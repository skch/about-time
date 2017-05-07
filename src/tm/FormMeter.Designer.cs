namespace tm
{
  partial class FormMeter
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
			this.components = new System.ComponentModel.Container();
			this.ltask1 = new System.Windows.Forms.TextBox();
			this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.ltask2 = new System.Windows.Forms.TextBox();
			this.timerShow = new System.Windows.Forms.Timer(this.components);
			this.timeProgress = new CommonUI.XpProgressBar();
			this.timerWin = new System.Windows.Forms.Timer(this.components);
			this.TextLabel = new System.Windows.Forms.Label();
			this.rcMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// ltask1
			// 
			this.ltask1.BackColor = System.Drawing.SystemColors.Control;
			this.ltask1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ltask1.ContextMenuStrip = this.rcMenu;
			this.ltask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ltask1.ForeColor = System.Drawing.Color.DarkRed;
			this.ltask1.Location = new System.Drawing.Point(5, 2);
			this.ltask1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ltask1.Multiline = true;
			this.ltask1.Name = "ltask1";
			this.ltask1.Size = new System.Drawing.Size(91, 32);
			this.ltask1.TabIndex = 3;
			this.ltask1.TabStop = false;
			this.ltask1.TextChanged += new System.EventHandler(this.OnChangeLeft);
			this.ltask1.DoubleClick += new System.EventHandler(this.callTodayDialog);
			this.ltask1.MouseEnter += new System.EventHandler(this.FormMeter_Enter);
			// 
			// rcMenu
			// 
			this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEdit,
            this.menuAbout,
            this.toolStripSeparator1,
            this.menuExit});
			this.rcMenu.Name = "rcMenu";
			this.rcMenu.Size = new System.Drawing.Size(118, 76);
			// 
			// menuEdit
			// 
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Size = new System.Drawing.Size(117, 22);
			this.menuEdit.Text = "&Edit Day";
			this.menuEdit.Click += new System.EventHandler(this.callTodayDialog);
			// 
			// menuAbout
			// 
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Size = new System.Drawing.Size(117, 22);
			this.menuAbout.Text = "&About";
			this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(117, 22);
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// ltask2
			// 
			this.ltask2.BackColor = System.Drawing.SystemColors.Control;
			this.ltask2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ltask2.ContextMenuStrip = this.rcMenu;
			this.ltask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ltask2.ForeColor = System.Drawing.Color.Navy;
			this.ltask2.Location = new System.Drawing.Point(99, 2);
			this.ltask2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ltask2.Multiline = true;
			this.ltask2.Name = "ltask2";
			this.ltask2.Size = new System.Drawing.Size(91, 32);
			this.ltask2.TabIndex = 4;
			this.ltask2.TabStop = false;
			this.ltask2.Text = "Right";
			this.ltask2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ltask2.TextChanged += new System.EventHandler(this.OnChangeRight);
			this.ltask2.DoubleClick += new System.EventHandler(this.callTodayDialog);
			this.ltask2.MouseEnter += new System.EventHandler(this.FormMeter_Enter);
			// 
			// timerShow
			// 
			this.timerShow.Enabled = true;
			this.timerShow.Interval = 30000;
			this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
			// 
			// timeProgress
			// 
			this.timeProgress.BackColor = System.Drawing.Color.Beige;
			this.timeProgress.ColorBackGround = System.Drawing.Color.Ivory;
			this.timeProgress.ColorBarBorder = System.Drawing.Color.LightSkyBlue;
			this.timeProgress.ColorBarCenter = System.Drawing.Color.RoyalBlue;
			this.timeProgress.ColorText = System.Drawing.Color.Black;
			this.timeProgress.ContextMenuStrip = this.rcMenu;
			this.timeProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeProgress.GradientStyle = CommonUI.GradientMode.Horizontal;
			this.timeProgress.Location = new System.Drawing.Point(4, 36);
			this.timeProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.timeProgress.Name = "timeProgress";
			this.timeProgress.Position = 15;
			this.timeProgress.PositionMax = 30;
			this.timeProgress.PositionMin = 0;
			this.timeProgress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.timeProgress.Size = new System.Drawing.Size(180, 25);
			this.timeProgress.SteepDistance = ((byte)(0));
			this.timeProgress.TabIndex = 0;
			this.timeProgress.Text = "12 min";
			this.timeProgress.TextShadow = false;
			this.timeProgress.DoubleClick += new System.EventHandler(this.callTodayDialog);
			this.timeProgress.MouseEnter += new System.EventHandler(this.FormMeter_Enter);
			// 
			// timerWin
			// 
			this.timerWin.Interval = 2000;
			this.timerWin.Tick += new System.EventHandler(this.timerWin_Tick);
			// 
			// TextLabel
			// 
			this.TextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TextLabel.ForeColor = System.Drawing.Color.Gray;
			this.TextLabel.Location = new System.Drawing.Point(4, 2);
			this.TextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TextLabel.Name = "TextLabel";
			this.TextLabel.Size = new System.Drawing.Size(185, 28);
			this.TextLabel.TabIndex = 5;
			this.TextLabel.Text = "label1";
			this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormMeter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(192, 64);
			this.ContextMenuStrip = this.rcMenu;
			this.Controls.Add(this.timeProgress);
			this.Controls.Add(this.ltask2);
			this.Controls.Add(this.ltask1);
			this.Controls.Add(this.TextLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "FormMeter";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "TIME";
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.FormMeter_Activated);
			this.Deactivate += new System.EventHandler(this.FormMeter_Deactivate);
			this.Load += new System.EventHandler(this.FormMeter_Load);
			this.MouseEnter += new System.EventHandler(this.FormMeter_Enter);
			this.MouseLeave += new System.EventHandler(this.FormMeter_MouseLeave);
			this.Resize += new System.EventHandler(this.FormMeter_Resize);
			this.rcMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox ltask1;
    private System.Windows.Forms.TextBox ltask2;
    private System.Windows.Forms.Timer timerShow;
    private CommonUI.XpProgressBar timeProgress;
    private System.Windows.Forms.ContextMenuStrip rcMenu;
    private System.Windows.Forms.ToolStripMenuItem menuExit;
    private System.Windows.Forms.Timer timerWin;
    private System.Windows.Forms.ToolStripMenuItem menuAbout;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem menuEdit;
    private System.Windows.Forms.Label TextLabel;
  }
}

