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
  public partial class frmSearchClients : Form
  {
    private frmClient clientForm;
    private InvoiceSystemEntities entities;
    public frmSearchClients()
    {
      InitializeComponent();
    }

    public frmSearchClients(InvoiceSystemEntities entities)
    {
      this.entities = entities;
      InitializeComponent();
    }

    private void frmSearchClient_Load(object sender, EventArgs e)
    {
      var clients = entities.clients;
      listViewClients.Clear();
      foreach (client client in clients)
      {
        ListViewItem newItem = new ListViewItem(client.clientname);
        newItem.Tag = client;
        listViewClients.Items.Add(newItem);
      }
    }
    private void btnAddClient_Click(object sender, EventArgs e)
    {
      if ((clientForm == null) || clientForm.IsDisposed) clientForm = new frmClient(entities);
      clientForm.Show();
      clientForm.Focus();
    }

    private void listViewClients_DoubleClick(object sender, EventArgs e)
    {
      if (listViewClients.SelectedItems.Count > 0)
      {
        clientForm = new frmClient(entities, (client)listViewClients.SelectedItems[0].Tag);
        clientForm.Show();
        clientForm.Focus();
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      frmSearchClient_Load(null, null);
    }
  }
}
