namespace InvoicingSystem
{
  partial class frmInvoice
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
      this.txtTaxRate = new System.Windows.Forms.TextBox();
      this.lblTaxRate = new System.Windows.Forms.Label();
      this.txtHourlyRate = new System.Windows.Forms.TextBox();
      this.lblHourlyRate = new System.Windows.Forms.Label();
      this.lblDateCreated = new System.Windows.Forms.Label();
      this.txtNumLines = new System.Windows.Forms.TextBox();
      this.lblNumLines = new System.Windows.Forms.Label();
      this.txtID = new System.Windows.Forms.TextBox();
      this.lblClient = new System.Windows.Forms.Label();
      this.lblID = new System.Windows.Forms.Label();
      this.btnPrint = new System.Windows.Forms.Button();
      this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
      this.cmbClient = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(239, 166);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 32;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(158, 166);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 31;
      this.btnSave.Text = "Save All";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtTaxRate
      // 
      this.txtTaxRate.Location = new System.Drawing.Point(91, 140);
      this.txtTaxRate.Name = "txtTaxRate";
      this.txtTaxRate.Size = new System.Drawing.Size(223, 20);
      this.txtTaxRate.TabIndex = 30;
      // 
      // lblTaxRate
      // 
      this.lblTaxRate.AutoSize = true;
      this.lblTaxRate.Location = new System.Drawing.Point(31, 143);
      this.lblTaxRate.Name = "lblTaxRate";
      this.lblTaxRate.Size = new System.Drawing.Size(54, 13);
      this.lblTaxRate.TabIndex = 28;
      this.lblTaxRate.Text = "Tax Rate:";
      this.lblTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtHourlyRate
      // 
      this.txtHourlyRate.Location = new System.Drawing.Point(91, 114);
      this.txtHourlyRate.Name = "txtHourlyRate";
      this.txtHourlyRate.Size = new System.Drawing.Size(223, 20);
      this.txtHourlyRate.TabIndex = 27;
      // 
      // lblHourlyRate
      // 
      this.lblHourlyRate.AutoSize = true;
      this.lblHourlyRate.Location = new System.Drawing.Point(19, 117);
      this.lblHourlyRate.Name = "lblHourlyRate";
      this.lblHourlyRate.Size = new System.Drawing.Size(66, 13);
      this.lblHourlyRate.TabIndex = 26;
      this.lblHourlyRate.Text = "Hourly Rate:";
      this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblDateCreated
      // 
      this.lblDateCreated.AutoSize = true;
      this.lblDateCreated.Location = new System.Drawing.Point(12, 91);
      this.lblDateCreated.Name = "lblDateCreated";
      this.lblDateCreated.Size = new System.Drawing.Size(73, 13);
      this.lblDateCreated.TabIndex = 25;
      this.lblDateCreated.Text = "Date Created:";
      this.lblDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtNumLines
      // 
      this.txtNumLines.Enabled = false;
      this.txtNumLines.Location = new System.Drawing.Point(91, 62);
      this.txtNumLines.Name = "txtNumLines";
      this.txtNumLines.Size = new System.Drawing.Size(223, 20);
      this.txtNumLines.TabIndex = 24;
      // 
      // lblNumLines
      // 
      this.lblNumLines.AutoSize = true;
      this.lblNumLines.Location = new System.Drawing.Point(25, 65);
      this.lblNumLines.Name = "lblNumLines";
      this.lblNumLines.Size = new System.Drawing.Size(60, 13);
      this.lblNumLines.TabIndex = 23;
      this.lblNumLines.Text = "Num Lines:";
      this.lblNumLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtID
      // 
      this.txtID.Enabled = false;
      this.txtID.Location = new System.Drawing.Point(91, 9);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(223, 20);
      this.txtID.TabIndex = 21;
      // 
      // lblClient
      // 
      this.lblClient.AutoSize = true;
      this.lblClient.Location = new System.Drawing.Point(49, 38);
      this.lblClient.Name = "lblClient";
      this.lblClient.Size = new System.Drawing.Size(36, 13);
      this.lblClient.TabIndex = 18;
      this.lblClient.Text = "Client:";
      this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
      // btnPrint
      // 
      this.btnPrint.Location = new System.Drawing.Point(77, 166);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(75, 23);
      this.btnPrint.TabIndex = 33;
      this.btnPrint.Text = "Print";
      this.btnPrint.UseVisualStyleBackColor = true;
      this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
      // 
      // dtpDateCreated
      // 
      this.dtpDateCreated.Enabled = false;
      this.dtpDateCreated.Location = new System.Drawing.Point(91, 88);
      this.dtpDateCreated.Name = "dtpDateCreated";
      this.dtpDateCreated.Size = new System.Drawing.Size(223, 20);
      this.dtpDateCreated.TabIndex = 34;
      // 
      // cmbClient
      // 
      this.cmbClient.FormattingEnabled = true;
      this.cmbClient.Location = new System.Drawing.Point(91, 35);
      this.cmbClient.Name = "cmbClient";
      this.cmbClient.Size = new System.Drawing.Size(222, 21);
      this.cmbClient.TabIndex = 35;
      // 
      // frmInvoice
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(319, 196);
      this.Controls.Add(this.cmbClient);
      this.Controls.Add(this.dtpDateCreated);
      this.Controls.Add(this.btnPrint);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtTaxRate);
      this.Controls.Add(this.lblTaxRate);
      this.Controls.Add(this.txtHourlyRate);
      this.Controls.Add(this.lblHourlyRate);
      this.Controls.Add(this.lblDateCreated);
      this.Controls.Add(this.txtNumLines);
      this.Controls.Add(this.lblNumLines);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.lblClient);
      this.Controls.Add(this.lblID);
      this.Name = "frmInvoice";
      this.Text = "frmInvoice";
      this.Load += new System.EventHandler(this.frmInvoice_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtTaxRate;
    private System.Windows.Forms.Label lblTaxRate;
    private System.Windows.Forms.TextBox txtHourlyRate;
    private System.Windows.Forms.Label lblHourlyRate;
    private System.Windows.Forms.Label lblDateCreated;
    private System.Windows.Forms.TextBox txtNumLines;
    private System.Windows.Forms.Label lblNumLines;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.Label lblClient;
    private System.Windows.Forms.Label lblID;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.DateTimePicker dtpDateCreated;
    private System.Windows.Forms.ComboBox cmbClient;
  }
}