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
  public partial class frmMain : Form
  {
    private frmSearchClients searchClientsForm;
    private frmSearchProjects searchProjectsForm;
    private frmSearchInvoices searchInvoicesForm;

    private InvoiceSystemEntities entities;

    public frmMain()
    {
      InitializeComponent();
    }

    public frmMain(InvoiceSystemEntities entities)
    {
      InitializeComponent();
      this.entities = entities;
    }

    private void frmMain_Load(object sender, EventArgs e)
    {

    }

    private void btnViewClients_Click(object sender, EventArgs e)
    {
      //todo - open a client search form
      if ((searchClientsForm == null) || searchClientsForm.IsDisposed) searchClientsForm = new frmSearchClients(entities);
      searchClientsForm.Show();
      searchClientsForm.Focus();
    }
    private void btnViewProjects_Click(object sender, EventArgs e)
    {
      //todo - open a project edit form
      if ((searchProjectsForm == null) || searchProjectsForm.IsDisposed) searchProjectsForm = new frmSearchProjects(entities);
      searchProjectsForm.Show();
      searchProjectsForm.Focus();
    }
    private void btnViewInvoices_Click(object sender, EventArgs e)
    {
      //todo - open an invoice search form
      // this form will allow generating pdf files for selected invoices in search results
      if ((searchInvoicesForm == null) || searchInvoicesForm.IsDisposed) searchInvoicesForm = new frmSearchInvoices(entities);
      searchInvoicesForm.Show();
      searchInvoicesForm.Focus();
    }
  }
}
