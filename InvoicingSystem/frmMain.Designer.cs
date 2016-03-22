namespace InvoicingSystem
{
  partial class frmMain
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
      this.btnViewInvoices = new System.Windows.Forms.Button();
      this.btnViewProjects = new System.Windows.Forms.Button();
      this.btnViewClients = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnViewInvoices
      // 
      this.btnViewInvoices.Location = new System.Drawing.Point(13, 71);
      this.btnViewInvoices.Name = "btnViewInvoices";
      this.btnViewInvoices.Size = new System.Drawing.Size(75, 23);
      this.btnViewInvoices.TabIndex = 6;
      this.btnViewInvoices.Text = "Invoices";
      this.btnViewInvoices.UseVisualStyleBackColor = true;
      this.btnViewInvoices.Click += new System.EventHandler(this.btnViewInvoices_Click);
      // 
      // btnViewProjects
      // 
      this.btnViewProjects.Location = new System.Drawing.Point(13, 42);
      this.btnViewProjects.Name = "btnViewProjects";
      this.btnViewProjects.Size = new System.Drawing.Size(75, 23);
      this.btnViewProjects.TabIndex = 4;
      this.btnViewProjects.Text = "Projects";
      this.btnViewProjects.UseVisualStyleBackColor = true;
      this.btnViewProjects.Click += new System.EventHandler(this.btnViewProjects_Click);
      // 
      // btnViewClients
      // 
      this.btnViewClients.Location = new System.Drawing.Point(12, 12);
      this.btnViewClients.Name = "btnViewClients";
      this.btnViewClients.Size = new System.Drawing.Size(75, 23);
      this.btnViewClients.TabIndex = 2;
      this.btnViewClients.Text = "Clients";
      this.btnViewClients.UseVisualStyleBackColor = true;
      this.btnViewClients.Click += new System.EventHandler(this.btnViewClients_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(98, 107);
      this.Controls.Add(this.btnViewProjects);
      this.Controls.Add(this.btnViewClients);
      this.Controls.Add(this.btnViewInvoices);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = "frmMain";
      this.Text = "Invoicing";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnViewInvoices;
    private System.Windows.Forms.Button btnViewProjects;
    private System.Windows.Forms.Button btnViewClients;
  }
}

