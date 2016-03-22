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
  public partial class frmSearchProjects : Form
  {
    private frmProject projectForm;
    private InvoiceSystemEntities entities;
    public frmSearchProjects()
    {
      InitializeComponent();
    }

    public frmSearchProjects(InvoiceSystemEntities entities)
    {
      this.entities = entities;
      InitializeComponent();
    }

    private void frmSearchProjects_Load(object sender, EventArgs e)
    {
      var projects = entities.projects;
      listViewProjects.Clear();
      foreach (project project in projects)
      {
        ListViewItem newItem = new ListViewItem(project.name);
        newItem.Tag = project;
        listViewProjects.Items.Add(newItem);
      }
    }
    private void btnAddProject_Click(object sender, EventArgs e)
    {
      if ((projectForm == null) || projectForm.IsDisposed) projectForm = new frmProject(entities);
      projectForm.Show();
      projectForm.Focus();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      frmSearchProjects_Load(null, null);
    }

    private void listViewProjects_DoubleClick(object sender, EventArgs e)
    {
      if (listViewProjects.SelectedItems.Count > 0)
      {
        projectForm = new frmProject(entities, (project)listViewProjects.SelectedItems[0].Tag);
        projectForm.Show();
        projectForm.Focus();
      }
    }
  }
}
