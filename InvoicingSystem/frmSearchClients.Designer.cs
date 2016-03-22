namespace InvoicingSystem
{
  partial class frmSearchClients
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
      this.btnAddClient = new System.Windows.Forms.Button();
      this.listViewClients = new System.Windows.Forms.ListView();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnAddClient
      // 
      this.btnAddClient.Location = new System.Drawing.Point(197, 41);
      this.btnAddClient.Name = "btnAddClient";
      this.btnAddClient.Size = new System.Drawing.Size(75, 23);
      this.btnAddClient.TabIndex = 0;
      this.btnAddClient.Text = "New Client";
      this.btnAddClient.UseVisualStyleBackColor = true;
      this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
      // 
      // listViewClients
      // 
      this.listViewClients.Location = new System.Drawing.Point(12, 12);
      this.listViewClients.Name = "listViewClients";
      this.listViewClients.Size = new System.Drawing.Size(179, 237);
      this.listViewClients.TabIndex = 1;
      this.listViewClients.UseCompatibleStateImageBehavior = false;
      this.listViewClients.View = System.Windows.Forms.View.List;
      this.listViewClients.DoubleClick += new System.EventHandler(this.listViewClients_DoubleClick);
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
      // frmSearchClients
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.listViewClients);
      this.Controls.Add(this.btnAddClient);
      this.Name = "frmSearchClients";
      this.Text = "frmSearchClient";
      this.Load += new System.EventHandler(this.frmSearchClient_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAddClient;
    private System.Windows.Forms.ListView listViewClients;
    private System.Windows.Forms.Button btnRefresh;
  }
}