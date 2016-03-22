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
  public partial class frmProject : Form
  {
    private project project;
    private InvoiceSystemEntities entities;

    public frmProject()
    {
      InitializeComponent();
      project = new project();
      FillProjectData();
    }
    public frmProject(InvoiceSystemEntities entities)
    {
      InitializeComponent();
      this.entities = entities;
      FillProjectData();
    }
    public frmProject(InvoiceSystemEntities entities, project project)
    {
      InitializeComponent();
      this.entities = entities;
      this.project = project;
      FillProjectData();
    }
    private void frmProject_Load(object sender, EventArgs e)
    {

    }

    private void FillProjectData()
    {
      if (project == null)
      {
        project = new project();
        project.id = Guid.NewGuid();
      }

      txtID.Text = project.id.ToString();
      txtName.Text = project.name;
      txtHourlyRate.Text = project.hourlyrate.ToString();

      IEnumerable<client> clientList = entities.clients.ToList();

      cmbClient.DataSource = clientList;
      cmbClient.DisplayMember = "clientname";
      cmbClient.SelectedItem = project.client;

      if (entities.projects.Find(project.id) == null)
      {
        entities.projects.Add(project);
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      project.name = (String.IsNullOrEmpty(txtName.Text)) ? null : txtName.Text;
      project.hourlyrate = (String.IsNullOrEmpty(txtHourlyRate.Text)) ? 0.0 : Convert.ToDouble(txtHourlyRate.Text);
      project.fk_client = ((client)cmbClient.SelectedItem).id;
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
