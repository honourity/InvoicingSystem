namespace InvoicingSystem
{
  partial class frmClient
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
      this.lblID = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.txtClientName = new System.Windows.Forms.TextBox();
      this.lblAddress = new System.Windows.Forms.Label();
      this.txtID = new System.Windows.Forms.TextBox();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.txtABN = new System.Windows.Forms.TextBox();
      this.lblABN = new System.Windows.Forms.Label();
      this.txtTaxRate = new System.Windows.Forms.TextBox();
      this.txtPhoneNumber = new System.Windows.Forms.TextBox();
      this.lblTaxRate = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.lblEmail = new System.Windows.Forms.Label();
      this.lblPhoneNumber = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblID
      // 
      this.lblID.AutoSize = true;
      this.lblID.Location = new System.Drawing.Point(60, 10);
      this.lblID.Name = "lblID";
      this.lblID.Size = new System.Drawing.Size(21, 13);
      this.lblID.TabIndex = 0;
      this.lblID.Text = "ID:";
      this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(14, 36);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(67, 13);
      this.lblName.TabIndex = 2;
      this.lblName.Text = "Client Name:";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtClientName
      // 
      this.txtClientName.Location = new System.Drawing.Point(87, 33);
      this.txtClientName.Name = "txtClientName";
      this.txtClientName.Size = new System.Drawing.Size(223, 20);
      this.txtClientName.TabIndex = 3;
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.Location = new System.Drawing.Point(33, 62);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(48, 13);
      this.lblAddress.TabIndex = 4;
      this.lblAddress.Text = "Address:";
      this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtID
      // 
      this.txtID.Enabled = false;
      this.txtID.Location = new System.Drawing.Point(87, 7);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(223, 20);
      this.txtID.TabIndex = 5;
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(87, 59);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(223, 20);
      this.txtAddress.TabIndex = 6;
      // 
      // txtABN
      // 
      this.txtABN.Location = new System.Drawing.Point(87, 85);
      this.txtABN.Name = "txtABN";
      this.txtABN.Size = new System.Drawing.Size(223, 20);
      this.txtABN.TabIndex = 8;
      // 
      // lblABN
      // 
      this.lblABN.AutoSize = true;
      this.lblABN.Location = new System.Drawing.Point(49, 88);
      this.lblABN.Name = "lblABN";
      this.lblABN.Size = new System.Drawing.Size(32, 13);
      this.lblABN.TabIndex = 7;
      this.lblABN.Text = "ABN:";
      this.lblABN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtTaxRate
      // 
      this.txtTaxRate.Location = new System.Drawing.Point(87, 163);
      this.txtTaxRate.Name = "txtTaxRate";
      this.txtTaxRate.Size = new System.Drawing.Size(223, 20);
      this.txtTaxRate.TabIndex = 14;
      // 
      // txtPhoneNumber
      // 
      this.txtPhoneNumber.Location = new System.Drawing.Point(87, 111);
      this.txtPhoneNumber.Name = "txtPhoneNumber";
      this.txtPhoneNumber.Size = new System.Drawing.Size(223, 20);
      this.txtPhoneNumber.TabIndex = 13;
      // 
      // lblTaxRate
      // 
      this.lblTaxRate.AutoSize = true;
      this.lblTaxRate.Location = new System.Drawing.Point(27, 166);
      this.lblTaxRate.Name = "lblTaxRate";
      this.lblTaxRate.Size = new System.Drawing.Size(54, 13);
      this.lblTaxRate.TabIndex = 12;
      this.lblTaxRate.Text = "Tax Rate:";
      this.lblTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(87, 137);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(223, 20);
      this.txtEmail.TabIndex = 11;
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Location = new System.Drawing.Point(46, 140);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(35, 13);
      this.lblEmail.TabIndex = 10;
      this.lblEmail.Text = "Email:";
      this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblPhoneNumber
      // 
      this.lblPhoneNumber.AutoSize = true;
      this.lblPhoneNumber.Location = new System.Drawing.Point(0, 114);
      this.lblPhoneNumber.Name = "lblPhoneNumber";
      this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
      this.lblPhoneNumber.TabIndex = 9;
      this.lblPhoneNumber.Text = "Phnoe Number:";
      this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(154, 189);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 15;
      this.btnSave.Text = "Save All";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(235, 189);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 16;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmClient
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(319, 222);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtTaxRate);
      this.Controls.Add(this.txtPhoneNumber);
      this.Controls.Add(this.lblTaxRate);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.lblEmail);
      this.Controls.Add(this.lblPhoneNumber);
      this.Controls.Add(this.txtABN);
      this.Controls.Add(this.lblABN);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.lblAddress);
      this.Controls.Add(this.txtClientName);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.lblID);
      this.Name = "frmClient";
      this.Text = "frmClient";
      this.Load += new System.EventHandler(this.frmClient_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblID;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtClientName;
    private System.Windows.Forms.Label lblAddress;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.TextBox txtABN;
    private System.Windows.Forms.Label lblABN;
    private System.Windows.Forms.TextBox txtTaxRate;
    private System.Windows.Forms.TextBox txtPhoneNumber;
    private System.Windows.Forms.Label lblTaxRate;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblPhoneNumber;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
  }
}