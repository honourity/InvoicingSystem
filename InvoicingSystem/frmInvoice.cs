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
  public partial class frmInvoice : Form
  {
    private invoiceheader invoiceheader;
    private InvoiceSystemEntities entities;

    public frmInvoice()
    {
      InitializeComponent();
    }

    public frmInvoice(InvoiceSystemEntities entities)
    {
      InitializeComponent();
      this.entities = entities;
      FillInvoiceData();
    }
    public frmInvoice(InvoiceSystemEntities entities, invoiceheader invoiceheader)
    {
      InitializeComponent();
      this.entities = entities;
      this.invoiceheader = invoiceheader;
      FillInvoiceData();
    }

    private void frmInvoice_Load(object sender, EventArgs e)
    {

    }

    private void FillInvoiceData()
    {
      if (invoiceheader == null)
      {
        invoiceheader = new invoiceheader();
        invoiceheader.id = Guid.NewGuid();
        invoiceheader.datecreated = System.DateTime.Now;
      }
      txtID.Text = invoiceheader.id.ToString();

      IEnumerable<client> clientList = entities.clients.ToList();
      cmbClient.DataSource = clientList;
      cmbClient.DisplayMember = "clientname";
      cmbClient.SelectedItem = invoiceheader.client;

      txtNumLines.Text = invoiceheader.invoicelines.Count.ToString();
      dtpDateCreated.Value = invoiceheader.datecreated;
      txtHourlyRate.Text = invoiceheader.hourlyrate.ToString();
      txtTaxRate.Text = invoiceheader.taxrate.ToString();

      if (entities.invoiceheaders.Find(invoiceheader.id) == null)
      {
        invoiceheader.number = -1;
        entities.invoiceheaders.Add(invoiceheader);
      }
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
      var generator = new InvoiceFileGenerator();

      //todo - make this generator throw various errors, then use try/catch here to present status messages, confirmation of overwrite existing etc...
      generator.GeneratePDF(invoiceheader);
      btnPrint.Enabled = false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      invoiceheader.fk_client = ((client)cmbClient.SelectedItem).id;
      if (invoiceheader.number == -1)
      {
        ((client)cmbClient.SelectedItem).currentInvoiceNumber++;
        invoiceheader.number = ((client)cmbClient.SelectedItem).currentInvoiceNumber;
      }

      if (String.IsNullOrEmpty(txtHourlyRate.Text))
      {
        invoiceheader.hourlyrate = null;
      }
      else
      {
        invoiceheader.hourlyrate = Convert.ToDouble(txtHourlyRate.Text);
      }

      if (String.IsNullOrEmpty(txtTaxRate.Text))
      {
        invoiceheader.taxrate = null;
      }
      else
      {
        invoiceheader.taxrate = Convert.ToDouble(txtTaxRate.Text);
      }

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
