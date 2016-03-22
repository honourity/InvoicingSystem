namespace InvoicingSystem
{
  partial class frmSearchProjects
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnAddProject = new System.Windows.Forms.Button();
      this.listViewProjects = new System.Windows.Forms.ListView();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnAddProject
      // 
      this.btnAddProject.Location = new System.Drawing.Point(197, 41);
      this.btnAddProject.Name = "btnAddProject";
      this.btnAddProject.Size = new System.Drawing.Size(75, 23);
      this.btnAddProject.TabIndex = 0;
      this.btnAddProject.Text = "New Project";
      this.btnAddProject.UseVisualStyleBackColor = true;
      this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
      // 
      // listViewProjects
      // 
      this.listViewProjects.Location = new System.Drawing.Point(12, 12);
      this.listViewProjects.Name = "listViewProjects";
      this.listViewProjects.Size = new System.Drawing.Size(179, 237);
      this.listViewProjects.TabIndex = 1;
      this.listViewProjects.UseCompatibleStateImageBehavior = false;
      this.listViewProjects.View = System.Windows.Forms.View.List;
      this.listViewProjects.DoubleClick += new System.EventHandler(this.listViewProjects_DoubleClick);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(197, 12);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(75, 23);
      this.btnRefresh.TabIndex = 2;
      this.btnRefresh.Text = "Refresh";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // frmSearchProjects
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.listViewProjects);
      this.Controls.Add(this.btnAddProject);
      this.Name = "frmSearchProjects";
      this.Text = "frmSearchProjects";
      this.Load += new System.EventHandler(this.frmSearchProjects_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAddProject;
    private System.Windows.Forms.ListView listViewProjects;
    private System.Windows.Forms.Button btnRefresh;
  }
}