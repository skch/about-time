namespace tm
{
  partial class EditTask
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.useStartDate = new System.Windows.Forms.CheckBox();
      this.useDueDate = new System.Windows.Forms.CheckBox();
      this.eCritical = new System.Windows.Forms.CheckBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.eActivity = new System.Windows.Forms.ComboBox();
      this.eHours = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.eScope = new System.Windows.Forms.ComboBox();
      this.eStartDate = new System.Windows.Forms.DateTimePicker();
      this.eDueDate = new System.Windows.Forms.DateTimePicker();
      this.eRecur = new System.Windows.Forms.CheckBox();
      this.eTitle = new System.Windows.Forms.TextBox();
      this.groupRecurring = new System.Windows.Forms.GroupBox();
      this.eDays = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.ePeriod = new System.Windows.Forms.ComboBox();
      this.eFloating = new System.Windows.Forms.CheckBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.eDescription = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupRecurring.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.eDays)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.useStartDate);
      this.groupBox1.Controls.Add(this.useDueDate);
      this.groupBox1.Controls.Add(this.eCritical);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.eActivity);
      this.groupBox1.Controls.Add(this.eHours);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.eScope);
      this.groupBox1.Controls.Add(this.eStartDate);
      this.groupBox1.Controls.Add(this.eDueDate);
      this.groupBox1.Controls.Add(this.eRecur);
      this.groupBox1.Controls.Add(this.eTitle);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(421, 126);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Task information";
      // 
      // useStartDate
      // 
      this.useStartDate.AutoSize = true;
      this.useStartDate.Location = new System.Drawing.Point(227, 45);
      this.useStartDate.Name = "useStartDate";
      this.useStartDate.Size = new System.Drawing.Size(75, 17);
      this.useStartDate.TabIndex = 15;
      this.useStartDate.Text = "Start date:";
      this.useStartDate.UseVisualStyleBackColor = true;
      this.useStartDate.CheckedChanged += new System.EventHandler(this.eRecur_CheckedChanged);
      // 
      // useDueDate
      // 
      this.useDueDate.AutoSize = true;
      this.useDueDate.Location = new System.Drawing.Point(6, 45);
      this.useDueDate.Name = "useDueDate";
      this.useDueDate.Size = new System.Drawing.Size(73, 17);
      this.useDueDate.TabIndex = 14;
      this.useDueDate.Text = "Due date:";
      this.useDueDate.UseVisualStyleBackColor = true;
      this.useDueDate.CheckedChanged += new System.EventHandler(this.eRecur_CheckedChanged);
      // 
      // eCritical
      // 
      this.eCritical.AutoSize = true;
      this.eCritical.Location = new System.Drawing.Point(85, 100);
      this.eCritical.Name = "eCritical";
      this.eCritical.Size = new System.Drawing.Size(57, 17);
      this.eCritical.TabIndex = 13;
      this.eCritical.Text = "Critical";
      this.eCritical.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(361, 101);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(33, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "hours";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(245, 71);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(44, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Activity:";
      // 
      // eActivity
      // 
      this.eActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.eActivity.FormattingEnabled = true;
      this.eActivity.Items.AddRange(new object[] {
            "No category",
            "Information",
            "Birthday",
            "Write",
            "Read",
            "Phone",
            "Finance",
            "Home",
            "Medical",
            "Travel",
            "Driving"});
      this.eActivity.Location = new System.Drawing.Point(308, 68);
      this.eActivity.Name = "eActivity";
      this.eActivity.Size = new System.Drawing.Size(105, 21);
      this.eActivity.TabIndex = 10;
      // 
      // eHours
      // 
      this.eHours.Location = new System.Drawing.Point(308, 98);
      this.eHours.Name = "eHours";
      this.eHours.Size = new System.Drawing.Size(47, 20);
      this.eHours.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(25, 71);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Scope:";
      // 
      // eScope
      // 
      this.eScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.eScope.FormattingEnabled = true;
      this.eScope.Items.AddRange(new object[] {
            "Personal",
            "Home",
            "Work",
            "Business"});
      this.eScope.Location = new System.Drawing.Point(85, 68);
      this.eScope.Name = "eScope";
      this.eScope.Size = new System.Drawing.Size(105, 21);
      this.eScope.TabIndex = 6;
      // 
      // eStartDate
      // 
      this.eStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.eStartDate.Location = new System.Drawing.Point(308, 42);
      this.eStartDate.Name = "eStartDate";
      this.eStartDate.Size = new System.Drawing.Size(105, 20);
      this.eStartDate.TabIndex = 4;
      this.eStartDate.Value = new System.DateTime(2007, 1, 18, 0, 0, 0, 0);
      // 
      // eDueDate
      // 
      this.eDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.eDueDate.Location = new System.Drawing.Point(85, 42);
      this.eDueDate.Name = "eDueDate";
      this.eDueDate.Size = new System.Drawing.Size(105, 20);
      this.eDueDate.TabIndex = 2;
      this.eDueDate.Value = new System.DateTime(2007, 1, 18, 0, 0, 0, 0);
      // 
      // eRecur
      // 
      this.eRecur.AutoSize = true;
      this.eRecur.Location = new System.Drawing.Point(148, 100);
      this.eRecur.Name = "eRecur";
      this.eRecur.Size = new System.Drawing.Size(72, 17);
      this.eRecur.TabIndex = 1;
      this.eRecur.Text = "Recurring";
      this.eRecur.UseVisualStyleBackColor = true;
      this.eRecur.CheckedChanged += new System.EventHandler(this.eRecur_CheckedChanged);
      // 
      // eTitle
      // 
      this.eTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.eTitle.Location = new System.Drawing.Point(6, 19);
      this.eTitle.Name = "eTitle";
      this.eTitle.Size = new System.Drawing.Size(407, 20);
      this.eTitle.TabIndex = 0;
      // 
      // groupRecurring
      // 
      this.groupRecurring.Controls.Add(this.eDays);
      this.groupRecurring.Controls.Add(this.label7);
      this.groupRecurring.Controls.Add(this.ePeriod);
      this.groupRecurring.Controls.Add(this.eFloating);
      this.groupRecurring.Location = new System.Drawing.Point(12, 144);
      this.groupRecurring.Name = "groupRecurring";
      this.groupRecurring.Size = new System.Drawing.Size(421, 52);
      this.groupRecurring.TabIndex = 1;
      this.groupRecurring.TabStop = false;
      this.groupRecurring.Text = "Recurring";
      // 
      // eDays
      // 
      this.eDays.Location = new System.Drawing.Point(46, 19);
      this.eDays.Name = "eDays";
      this.eDays.Size = new System.Drawing.Size(47, 20);
      this.eDays.TabIndex = 10;
      this.eDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 22);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(34, 13);
      this.label7.TabIndex = 9;
      this.label7.Text = "Every";
      // 
      // ePeriod
      // 
      this.ePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ePeriod.FormattingEnabled = true;
      this.ePeriod.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
      this.ePeriod.Location = new System.Drawing.Point(99, 19);
      this.ePeriod.Name = "ePeriod";
      this.ePeriod.Size = new System.Drawing.Size(144, 21);
      this.ePeriod.TabIndex = 8;
      // 
      // eFloating
      // 
      this.eFloating.AutoSize = true;
      this.eFloating.Location = new System.Drawing.Point(308, 20);
      this.eFloating.Name = "eFloating";
      this.eFloating.Size = new System.Drawing.Size(74, 17);
      this.eFloating.TabIndex = 7;
      this.eFloating.Text = "Is Floating";
      this.eFloating.UseVisualStyleBackColor = true;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(12, 294);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 2;
      this.btnOK.Text = "O&K";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(93, 294);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.eDescription);
      this.groupBox3.Location = new System.Drawing.Point(12, 202);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(421, 86);
      this.groupBox3.TabIndex = 5;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Description";
      // 
      // eDescription
      // 
      this.eDescription.Location = new System.Drawing.Point(6, 19);
      this.eDescription.Multiline = true;
      this.eDescription.Name = "eDescription";
      this.eDescription.Size = new System.Drawing.Size(407, 61);
      this.eDescription.TabIndex = 5;
      // 
      // EditTask
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(439, 322);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.groupRecurring);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "EditTask";
      this.Text = "Edit Task";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupRecurring.ResumeLayout(false);
      this.groupRecurring.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.eDays)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupRecurring;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.DateTimePicker eDueDate;
    private System.Windows.Forms.CheckBox eRecur;
    private System.Windows.Forms.TextBox eTitle;
    private System.Windows.Forms.DateTimePicker eStartDate;
    private System.Windows.Forms.CheckBox eFloating;
    private System.Windows.Forms.ComboBox eScope;
    private System.Windows.Forms.TextBox eHours;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox eActivity;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox eDescription;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox ePeriod;
    private System.Windows.Forms.NumericUpDown eDays;
    private System.Windows.Forms.CheckBox eCritical;
    private System.Windows.Forms.CheckBox useDueDate;
    private System.Windows.Forms.CheckBox useStartDate;
  }
}