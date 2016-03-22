namespace InvoicingSystem
{
  partial class frmSearchInvoices
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
      this.btnRefresh = new System.Windows.Forms.Button();
      this.listViewInvoices = new System.Windows.Forms.ListView();
      this.btnAddInvoice = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(197, 12);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(75, 23);
      this.btnRefresh.TabIndex = 5;
      this.btnRefresh.Text = "Refresh";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // listViewInvoices
      // 
      this.listViewInvoices.Location = new System.Drawing.Point(12, 12);
      this.listViewInvoices.Name = "listViewInvoices";
      this.listViewInvoices.Size = new System.Drawing.Size(179, 237);
      this.listViewInvoices.TabIndex = 4;
      this.listViewInvoices.UseCompatibleStateImageBehavior = false;
      this.listViewInvoices.View = System.Windows.Forms.View.List;
      this.listViewInvoices.DoubleClick += new System.EventHandler(this.lstInvoices_DoubleClick);
      // 
      // btnAddInvoice
      // 
      this.btnAddInvoice.Location = new System.Drawing.Point(197, 41);
      this.btnAddInvoice.Name = "btnAddInvoice";
      this.btnAddInvoice.Size = new System.Drawing.Size(75, 23);
      this.btnAddInvoice.TabIndex = 3;
      this.btnAddInvoice.Text = "New Invoice";
      this.btnAddInvoice.UseVisualStyleBackColor = true;
      this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
      // 
      // frmSearchInvoices
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.listViewInvoices);
      this.Controls.Add(this.btnAddInvoice);
      this.Name = "frmSearchInvoices";
      this.Text = "frmSearchInvoice";
      this.Load += new System.EventHandler(this.frmSearchInvoice_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.ListView listViewInvoices;
    private System.Windows.Forms.Button btnAddInvoice;

  }
}