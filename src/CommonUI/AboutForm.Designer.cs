namespace CommonUI
{
  partial class AboutForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.labelTitle = new System.Windows.Forms.Label();
      this.labelVersion = new System.Windows.Forms.Label();
      this.labelCopyright = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.picBox = new System.Windows.Forms.PictureBox();
      this.labelWeb = new System.Windows.Forms.LinkLabel();
      this.labelDesc = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
      this.SuspendLayout();
      // 
      // labelTitle
      // 
      this.labelTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTitle.Location = new System.Drawing.Point(118, 12);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(275, 35);
      this.labelTitle.TabIndex = 0;
      this.labelTitle.Text = "About Form";
      // 
      // labelVersion
      // 
      this.labelVersion.Location = new System.Drawing.Point(121, 47);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new System.Drawing.Size(272, 17);
      this.labelVersion.TabIndex = 1;
      this.labelVersion.Text = "Version 1.0 (2274)";
      // 
      // labelCopyright
      // 
      this.labelCopyright.Location = new System.Drawing.Point(121, 64);
      this.labelCopyright.Name = "labelCopyright";
      this.labelCopyright.Size = new System.Drawing.Size(272, 18);
      this.labelCopyright.TabIndex = 2;
      this.labelCopyright.Text = "Copyright (c) 2007, Sergey Kucherov";
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(318, 146);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // picBox
      // 
      this.picBox.Location = new System.Drawing.Point(12, 12);
      this.picBox.Name = "picBox";
      this.picBox.Size = new System.Drawing.Size(100, 151);
      this.picBox.TabIndex = 3;
      this.picBox.TabStop = false;
      // 
      // labelWeb
      // 
      this.labelWeb.Location = new System.Drawing.Point(121, 82);
      this.labelWeb.Name = "labelWeb";
      this.labelWeb.Size = new System.Drawing.Size(272, 19);
      this.labelWeb.TabIndex = 6;
      this.labelWeb.TabStop = true;
      this.labelWeb.Text = "http://skch.net/columns/time.html";
      this.labelWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelWeb_LinkClicked);
      // 
      // labelDesc
      // 
      this.labelDesc.Location = new System.Drawing.Point(121, 101);
      this.labelDesc.Name = "labelDesc";
      this.labelDesc.Size = new System.Drawing.Size(272, 42);
      this.labelDesc.TabIndex = 7;
      this.labelDesc.Text = "Description";
      // 
      // AboutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(405, 175);
      this.ControlBox = false;
      this.Controls.Add(this.labelDesc);
      this.Controls.Add(this.labelWeb);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.picBox);
      this.Controls.Add(this.labelCopyright);
      this.Controls.Add(this.labelVersion);
      this.Controls.Add(this.labelTitle);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "AboutForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AboutForm";
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.PictureBox picBox;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.LinkLabel labelWeb;
    private System.Windows.Forms.Label labelDesc;
  }
}