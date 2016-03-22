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
  public partial class frmSearchInvoices : Form
  {
    private frmInvoice invoiceForm;
    private InvoiceSystemEntities entities;
    public frmSearchInvoices()
    {
      InitializeComponent();
    }

    public frmSearchInvoices(InvoiceSystemEntities entities)
    {
      this.entities = entities;
      InitializeComponent();
    }

    private void frmSearchInvoice_Load(object sender, EventArgs e)
    {
      var invoiceheaders = entities.invoiceheaders;
      listViewInvoices.Clear();
      foreach (invoiceheader invoiceheader in invoiceheaders.OrderBy(item => item.datecreated))
      {
        ListViewItem newItem;
        if (invoiceheader.invoicelines.Count > 0)
        {
          newItem = new ListViewItem(invoiceheader.client.clientname + " - " + invoiceheader.invoicelines.Last().datecompleted.ToString("MMMM"));
        }
        else
        {
          newItem = new ListViewItem(invoiceheader.client.clientname);
        }

        newItem.Tag = invoiceheader;
        listViewInvoices.Items.Add(newItem);
      }
    }
    private void btnAddInvoice_Click(object sender, EventArgs e)
    {
      //todo - open an invoice edit form (fill hidden data with default values)
      if ((invoiceForm == null) || invoiceForm.IsDisposed) invoiceForm = new frmInvoice(entities);
      invoiceForm.Show();
      invoiceForm.Focus();
    }

    private void lstInvoices_DoubleClick(object sender, EventArgs e)
    {
      if (listViewInvoices.SelectedItems.Count > 0)
      {
        invoiceForm = new frmInvoice(entities, (invoiceheader)listViewInvoices.SelectedItems[0].Tag);
        invoiceForm.Show();
        invoiceForm.Focus();
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      frmSearchInvoice_Load(null, null);
    }
  }
}
