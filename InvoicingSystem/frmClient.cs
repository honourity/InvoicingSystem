using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicingSystem
{
  public partial class frmClient : Form
  {
    private client client;
    private InvoiceSystemEntities entities;

    public frmClient()
    {
      InitializeComponent();
      FillClientData();
    }
    public frmClient(InvoiceSystemEntities entities)
    {
      InitializeComponent();
      this.entities = entities;
      FillClientData();
    }
    public frmClient(InvoiceSystemEntities entities, client client)
    {
      InitializeComponent();
      this.entities = entities;
      this.client = client;
      FillClientData();
    }
    private void frmClient_Load(object sender, EventArgs e)
    {

    }

    private void FillClientData()
    {
      if (client == null)
      {
        client = new client();
        client.id = Guid.NewGuid();
        client.isme = false;
        client.currentInvoiceNumber = 0;
      }

      txtABN.Text = client.abn;
      txtAddress.Text = client.address;
      txtClientName.Text = client.clientname;
      txtEmail.Text = client.email;
      txtID.Text = client.id.ToString();
      txtPhoneNumber.Text = client.phonenumber;
      txtTaxRate.Text = client.taxrate.ToString();

      if (entities.clients.Find(client.id) == null)
      {
        entities.clients.Add(client);
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      client.abn = (String.IsNullOrEmpty(txtABN.Text)) ? null : txtABN.Text;
      client.address = (String.IsNullOrEmpty(txtAddress.Text)) ? null : txtAddress.Text;
      client.clientname = (String.IsNullOrEmpty(txtClientName.Text)) ? null : txtClientName.Text;
      client.email = (String.IsNullOrEmpty(txtEmail.Text)) ? null : txtEmail.Text;
      client.phonenumber = (String.IsNullOrEmpty(txtPhoneNumber.Text)) ? null : txtPhoneNumber.Text;
      client.taxrate = (String.IsNullOrEmpty(txtTaxRate.Text)) ? 0 : Convert.ToDouble(txtTaxRate.Text);

      entities.SaveChanges();
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      entities.ChangeTracker.Entries().First().State = System.Data.Entity.EntityState.Unchanged;
      this.Close();
    }
  }
}
