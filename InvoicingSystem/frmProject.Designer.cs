namespace InvoicingSystem
{
  partial class frmProject
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.lblABN = new System.Windows.Forms.Label();
      this.txtHourlyRate = new System.Windows.Forms.TextBox();
      this.txtID = new System.Windows.Forms.TextBox();
      this.lblAddress = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblName = new System.Windows.Forms.Label();
      this.lblID = new System.Windows.Forms.Label();
      this.cmbClient = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(239, 114);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 32;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(158, 114);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 31;
      this.btnSave.Text = "Save All";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // lblABN
      // 
      this.lblABN.AutoSize = true;
      this.lblABN.Location = new System.Drawing.Point(49, 90);
      this.lblABN.Name = "lblABN";
      this.lblABN.Size = new System.Drawing.Size(36, 13);
      this.lblABN.TabIndex = 23;
      this.lblABN.Text = "Client:";
      this.lblABN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtHourlyRate
      // 
      this.txtHourlyRate.Location = new System.Drawing.Point(91, 61);
      this.txtHourlyRate.Name = "txtHourlyRate";
      this.txtHourlyRate.Size = new System.Drawing.Size(223, 20);
      this.txtHourlyRate.TabIndex = 22;
      // 
      // txtID
      // 
      this.txtID.Enabled = false;
      this.txtID.Location = new System.Drawing.Point(91, 9);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(223, 20);
      this.txtID.TabIndex = 21;
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.Location = new System.Drawing.Point(19, 64);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(66, 13);
      this.lblAddress.TabIndex = 20;
      this.lblAddress.Text = "Hourly Rate:";
      this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(91, 35);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(223, 20);
      this.txtName.TabIndex = 19;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(47, 38);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(38, 13);
      this.lblName.TabIndex = 18;
      this.lblName.Text = "Name:";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblID
      // 
      this.lblID.AutoSize = true;
      this.lblID.Location = new System.Drawing.Point(64, 12);
      this.lblID.Name = "lblID";
      this.lblID.Size = new System.Drawing.Size(21, 13);
      this.lblID.TabIndex = 17;
      this.lblID.Text = "ID:";
      this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // cmbClient
      // 
      this.cmbClient.FormattingEnabled = true;
      this.cmbClient.Location = new System.Drawing.Point(92, 87);
      this.cmbClient.Name = "cmbClient";
      this.cmbClient.Size = new System.Drawing.Size(222, 21);
      this.cmbClient.TabIndex = 33;
      // 
      // frmProject
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(319, 144);
      this.Controls.Add(this.cmbClient);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.lblABN);
      this.Controls.Add(this.txtHourlyRate);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.lblAddress);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.lblID);
      this.Name = "frmProject";
      this.Text = "frmProject";
      this.Load += new System.EventHandler(this.frmProject_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblABN;
    private System.Windows.Forms.TextBox txtHourlyRate;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.Label lblAddress;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblID;
    private System.Windows.Forms.ComboBox cmbClient;
  }
}