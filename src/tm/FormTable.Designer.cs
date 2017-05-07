namespace tm
{
  partial class FormTable
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
      System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Critical", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Overdue", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Active", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Future", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Completed", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Demo item here", 10);
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
      this.tabsHolder = new System.Windows.Forms.TabControl();
      this.pageToday = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.timeTable = new System.Windows.Forms.DataGridView();
      this.pageTasks = new System.Windows.Forms.TabPage();
      this.tasksListBox = new System.Windows.Forms.ListView();
      this.c1 = new System.Windows.Forms.ColumnHeader();
      this.menuForTask = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.menuComplete = new System.Windows.Forms.ToolStripMenuItem();
      this.menuCritical = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.iconsNotes = new System.Windows.Forms.ImageList(this.components);
      this.iconsState = new System.Windows.Forms.ImageList(this.components);
      this.p = new System.Windows.Forms.ColumnHeader();
      this.taskTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tabsHolder.SuspendLayout();
      this.pageToday.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.timeTable)).BeginInit();
      this.pageTasks.SuspendLayout();
      this.menuForTask.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.taskTableBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // tabsHolder
      // 
      this.tabsHolder.Controls.Add(this.pageToday);
      this.tabsHolder.Controls.Add(this.pageTasks);
      this.tabsHolder.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabsHolder.Location = new System.Drawing.Point(0, 0);
      this.tabsHolder.Name = "tabsHolder";
      this.tabsHolder.SelectedIndex = 0;
      this.tabsHolder.Size = new System.Drawing.Size(466, 676);
      this.tabsHolder.TabIndex = 0;
      // 
      // pageToday
      // 
      this.pageToday.Controls.Add(this.panel1);
      this.pageToday.Controls.Add(this.timeTable);
      this.pageToday.Location = new System.Drawing.Point(4, 22);
      this.pageToday.Name = "pageToday";
      this.pageToday.Padding = new System.Windows.Forms.Padding(3);
      this.pageToday.Size = new System.Drawing.Size(458, 650);
      this.pageToday.TabIndex = 0;
      this.pageToday.Text = "Today";
      this.pageToday.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnClear);
      this.panel1.Controls.Add(this.btnCancel);
      this.panel1.Controls.Add(this.btnOK);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(354, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(101, 644);
      this.panel1.TabIndex = 1;
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(12, 88);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 2;
      this.btnClear.Text = "Clear &All";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(12, 32);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(12, 3);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "O&K";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // timeTable
      // 
      this.timeTable.AllowUserToAddRows = false;
      this.timeTable.AllowUserToDeleteRows = false;
      this.timeTable.AllowUserToResizeColumns = false;
      this.timeTable.AllowUserToResizeRows = false;
      this.timeTable.BackgroundColor = System.Drawing.Color.Beige;
      this.timeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.timeTable.Dock = System.Windows.Forms.DockStyle.Left;
      this.timeTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
      this.timeTable.GridColor = System.Drawing.SystemColors.ScrollBar;
      this.timeTable.Location = new System.Drawing.Point(3, 3);
      this.timeTable.MultiSelect = false;
      this.timeTable.Name = "timeTable";
      this.timeTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.timeTable.RowHeadersVisible = false;
      this.timeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
      this.timeTable.Size = new System.Drawing.Size(345, 644);
      this.timeTable.TabIndex = 0;
      // 
      // pageTasks
      // 
      this.pageTasks.Controls.Add(this.tasksListBox);
      this.pageTasks.Location = new System.Drawing.Point(4, 22);
      this.pageTasks.Name = "pageTasks";
      this.pageTasks.Padding = new System.Windows.Forms.Padding(3);
      this.pageTasks.Size = new System.Drawing.Size(458, 650);
      this.pageTasks.TabIndex = 1;
      this.pageTasks.Text = "Tasks";
      this.pageTasks.UseVisualStyleBackColor = true;
      // 
      // tasksListBox
      // 
      this.tasksListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tasksListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.p});
      this.tasksListBox.ContextMenuStrip = this.menuForTask;
      this.tasksListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tasksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tasksListBox.GridLines = true;
      listViewGroup1.Header = "Critical";
      listViewGroup1.Name = "gCritical";
      listViewGroup2.Header = "Overdue";
      listViewGroup2.Name = "gOverdue";
      listViewGroup3.Header = "Active";
      listViewGroup3.Name = "gActive";
      listViewGroup4.Header = "Future";
      listViewGroup4.Name = "gFuture";
      listViewGroup5.Header = "Completed";
      listViewGroup5.Name = "gCompleted";
      this.tasksListBox.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
      this.tasksListBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
      listViewItem1.Group = listViewGroup1;
      listViewItem1.StateImageIndex = 0;
      this.tasksListBox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
      this.tasksListBox.Location = new System.Drawing.Point(3, 3);
      this.tasksListBox.Name = "tasksListBox";
      this.tasksListBox.OwnerDraw = true;
      this.tasksListBox.ShowItemToolTips = true;
      this.tasksListBox.Size = new System.Drawing.Size(452, 644);
      this.tasksListBox.SmallImageList = this.iconsNotes;
      this.tasksListBox.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.tasksListBox.StateImageList = this.iconsState;
      this.tasksListBox.TabIndex = 0;
      this.tasksListBox.UseCompatibleStateImageBehavior = false;
      this.tasksListBox.View = System.Windows.Forms.View.Details;
      this.tasksListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tasksListBox_MouseClick);
      this.tasksListBox.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.tasksListBox_DrawItem);
      this.tasksListBox.DoubleClick += new System.EventHandler(this.tasksListBox_DoubleClick);
      this.tasksListBox.Click += new System.EventHandler(this.tasksListBox_Click);
      // 
      // c1
      // 
      this.c1.Text = "To Do Tasks";
      this.c1.Width = 379;
      // 
      // menuForTask
      // 
      this.menuForTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuComplete,
            this.menuCritical,
            this.toolStripSeparator1,
            this.menuEdit,
            this.menuAdd,
            this.menuDelete});
      this.menuForTask.Name = "menuForTask";
      this.menuForTask.Size = new System.Drawing.Size(163, 120);
      // 
      // menuComplete
      // 
      this.menuComplete.Name = "menuComplete";
      this.menuComplete.Size = new System.Drawing.Size(162, 22);
      this.menuComplete.Text = "Mark &Completed";
      this.menuComplete.Click += new System.EventHandler(this.menuComplete_Click);
      // 
      // menuCritical
      // 
      this.menuCritical.Name = "menuCritical";
      this.menuCritical.Size = new System.Drawing.Size(162, 22);
      this.menuCritical.Text = "Mark Cri&tical";
      this.menuCritical.Click += new System.EventHandler(this.menuCritical_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
      // 
      // menuEdit
      // 
      this.menuEdit.Name = "menuEdit";
      this.menuEdit.Size = new System.Drawing.Size(162, 22);
      this.menuEdit.Text = "&Edit task...";
      this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
      // 
      // menuAdd
      // 
      this.menuAdd.Name = "menuAdd";
      this.menuAdd.Size = new System.Drawing.Size(162, 22);
      this.menuAdd.Text = "&Add new task...";
      this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
      // 
      // menuDelete
      // 
      this.menuDelete.Name = "menuDelete";
      this.menuDelete.Size = new System.Drawing.Size(162, 22);
      this.menuDelete.Text = "&Delete task";
      this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
      // 
      // iconsNotes
      // 
      this.iconsNotes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsNotes.ImageStream")));
      this.iconsNotes.TransparentColor = System.Drawing.Color.Transparent;
      this.iconsNotes.Images.SetKeyName(0, "vwicn999.bmp");
      this.iconsNotes.Images.SetKeyName(1, "vwicn001.bmp");
      this.iconsNotes.Images.SetKeyName(2, "vwicn002.bmp");
      this.iconsNotes.Images.SetKeyName(3, "vwicn003.bmp");
      this.iconsNotes.Images.SetKeyName(4, "vwicn004.bmp");
      this.iconsNotes.Images.SetKeyName(5, "vwicn005.bmp");
      this.iconsNotes.Images.SetKeyName(6, "vwicn006.bmp");
      this.iconsNotes.Images.SetKeyName(7, "vwicn007.bmp");
      this.iconsNotes.Images.SetKeyName(8, "vwicn008.bmp");
      this.iconsNotes.Images.SetKeyName(9, "vwicn009.bmp");
      this.iconsNotes.Images.SetKeyName(10, "vwicn010.bmp");
      this.iconsNotes.Images.SetKeyName(11, "vwicn011.bmp");
      this.iconsNotes.Images.SetKeyName(12, "vwicn012.bmp");
      this.iconsNotes.Images.SetKeyName(13, "vwicn013.bmp");
      this.iconsNotes.Images.SetKeyName(14, "vwicn014.bmp");
      this.iconsNotes.Images.SetKeyName(15, "vwicn015.bmp");
      this.iconsNotes.Images.SetKeyName(16, "vwicn016.bmp");
      this.iconsNotes.Images.SetKeyName(17, "vwicn017.bmp");
      this.iconsNotes.Images.SetKeyName(18, "vwicn018.bmp");
      this.iconsNotes.Images.SetKeyName(19, "vwicn019.bmp");
      this.iconsNotes.Images.SetKeyName(20, "vwicn020.bmp");
      this.iconsNotes.Images.SetKeyName(21, "vwicn021.bmp");
      this.iconsNotes.Images.SetKeyName(22, "vwicn022.bmp");
      this.iconsNotes.Images.SetKeyName(23, "vwicn023.bmp");
      this.iconsNotes.Images.SetKeyName(24, "vwicn024.bmp");
      this.iconsNotes.Images.SetKeyName(25, "vwicn025.bmp");
      this.iconsNotes.Images.SetKeyName(26, "vwicn026.bmp");
      this.iconsNotes.Images.SetKeyName(27, "vwicn027.bmp");
      this.iconsNotes.Images.SetKeyName(28, "vwicn028.bmp");
      this.iconsNotes.Images.SetKeyName(29, "vwicn029.bmp");
      this.iconsNotes.Images.SetKeyName(30, "vwicn030.bmp");
      this.iconsNotes.Images.SetKeyName(31, "vwicn031.bmp");
      this.iconsNotes.Images.SetKeyName(32, "vwicn032.bmp");
      this.iconsNotes.Images.SetKeyName(33, "vwicn033.bmp");
      this.iconsNotes.Images.SetKeyName(34, "vwicn034.bmp");
      this.iconsNotes.Images.SetKeyName(35, "vwicn035.bmp");
      this.iconsNotes.Images.SetKeyName(36, "vwicn036.bmp");
      this.iconsNotes.Images.SetKeyName(37, "vwicn037.bmp");
      this.iconsNotes.Images.SetKeyName(38, "vwicn038.bmp");
      this.iconsNotes.Images.SetKeyName(39, "vwicn039.bmp");
      this.iconsNotes.Images.SetKeyName(40, "vwicn040.bmp");
      this.iconsNotes.Images.SetKeyName(41, "vwicn041.bmp");
      this.iconsNotes.Images.SetKeyName(42, "vwicn042.bmp");
      this.iconsNotes.Images.SetKeyName(43, "vwicn043.bmp");
      this.iconsNotes.Images.SetKeyName(44, "vwicn044.bmp");
      this.iconsNotes.Images.SetKeyName(45, "vwicn045.bmp");
      this.iconsNotes.Images.SetKeyName(46, "vwicn046.bmp");
      this.iconsNotes.Images.SetKeyName(47, "vwicn047.bmp");
      this.iconsNotes.Images.SetKeyName(48, "vwicn048.bmp");
      this.iconsNotes.Images.SetKeyName(49, "vwicn049.bmp");
      this.iconsNotes.Images.SetKeyName(50, "vwicn050.bmp");
      this.iconsNotes.Images.SetKeyName(51, "vwicn051.bmp");
      this.iconsNotes.Images.SetKeyName(52, "vwicn052.bmp");
      this.iconsNotes.Images.SetKeyName(53, "vwicn053.bmp");
      this.iconsNotes.Images.SetKeyName(54, "vwicn054.bmp");
      this.iconsNotes.Images.SetKeyName(55, "vwicn055.bmp");
      this.iconsNotes.Images.SetKeyName(56, "vwicn056.bmp");
      this.iconsNotes.Images.SetKeyName(57, "vwicn057.bmp");
      this.iconsNotes.Images.SetKeyName(58, "vwicn058.bmp");
      this.iconsNotes.Images.SetKeyName(59, "vwicn059.bmp");
      this.iconsNotes.Images.SetKeyName(60, "vwicn060.bmp");
      this.iconsNotes.Images.SetKeyName(61, "vwicn061.bmp");
      this.iconsNotes.Images.SetKeyName(62, "vwicn062.bmp");
      this.iconsNotes.Images.SetKeyName(63, "vwicn063.bmp");
      this.iconsNotes.Images.SetKeyName(64, "vwicn064.bmp");
      this.iconsNotes.Images.SetKeyName(65, "vwicn065.bmp");
      this.iconsNotes.Images.SetKeyName(66, "vwicn066.bmp");
      this.iconsNotes.Images.SetKeyName(67, "vwicn067.bmp");
      this.iconsNotes.Images.SetKeyName(68, "vwicn068.bmp");
      this.iconsNotes.Images.SetKeyName(69, "vwicn069.bmp");
      this.iconsNotes.Images.SetKeyName(70, "vwicn070.bmp");
      this.iconsNotes.Images.SetKeyName(71, "vwicn071.bmp");
      this.iconsNotes.Images.SetKeyName(72, "vwicn072.bmp");
      this.iconsNotes.Images.SetKeyName(73, "vwicn073.bmp");
      this.iconsNotes.Images.SetKeyName(74, "vwicn074.bmp");
      this.iconsNotes.Images.SetKeyName(75, "vwicn075.bmp");
      this.iconsNotes.Images.SetKeyName(76, "vwicn076.bmp");
      this.iconsNotes.Images.SetKeyName(77, "vwicn077.bmp");
      this.iconsNotes.Images.SetKeyName(78, "vwicn078.bmp");
      this.iconsNotes.Images.SetKeyName(79, "vwicn079.bmp");
      this.iconsNotes.Images.SetKeyName(80, "vwicn080.bmp");
      this.iconsNotes.Images.SetKeyName(81, "vwicn081.bmp");
      this.iconsNotes.Images.SetKeyName(82, "vwicn082.bmp");
      this.iconsNotes.Images.SetKeyName(83, "vwicn083.bmp");
      this.iconsNotes.Images.SetKeyName(84, "vwicn084.bmp");
      this.iconsNotes.Images.SetKeyName(85, "vwicn085.bmp");
      this.iconsNotes.Images.SetKeyName(86, "vwicn086.bmp");
      this.iconsNotes.Images.SetKeyName(87, "vwicn087.bmp");
      this.iconsNotes.Images.SetKeyName(88, "vwicn088.bmp");
      this.iconsNotes.Images.SetKeyName(89, "vwicn089.bmp");
      this.iconsNotes.Images.SetKeyName(90, "vwicn090.bmp");
      this.iconsNotes.Images.SetKeyName(91, "vwicn091.bmp");
      this.iconsNotes.Images.SetKeyName(92, "vwicn092.bmp");
      this.iconsNotes.Images.SetKeyName(93, "vwicn093.bmp");
      this.iconsNotes.Images.SetKeyName(94, "vwicn094.bmp");
      this.iconsNotes.Images.SetKeyName(95, "vwicn095.bmp");
      this.iconsNotes.Images.SetKeyName(96, "vwicn096.bmp");
      this.iconsNotes.Images.SetKeyName(97, "vwicn097.bmp");
      this.iconsNotes.Images.SetKeyName(98, "vwicn098.bmp");
      this.iconsNotes.Images.SetKeyName(99, "vwicn099.bmp");
      this.iconsNotes.Images.SetKeyName(100, "vwicn100.bmp");
      this.iconsNotes.Images.SetKeyName(101, "vwicn101.bmp");
      this.iconsNotes.Images.SetKeyName(102, "vwicn102.bmp");
      this.iconsNotes.Images.SetKeyName(103, "vwicn103.bmp");
      this.iconsNotes.Images.SetKeyName(104, "vwicn104.bmp");
      this.iconsNotes.Images.SetKeyName(105, "vwicn105.bmp");
      this.iconsNotes.Images.SetKeyName(106, "vwicn106.bmp");
      this.iconsNotes.Images.SetKeyName(107, "vwicn107.bmp");
      this.iconsNotes.Images.SetKeyName(108, "vwicn108.bmp");
      this.iconsNotes.Images.SetKeyName(109, "vwicn109.bmp");
      this.iconsNotes.Images.SetKeyName(110, "vwicn110.bmp");
      this.iconsNotes.Images.SetKeyName(111, "vwicn111.bmp");
      this.iconsNotes.Images.SetKeyName(112, "vwicn112.bmp");
      this.iconsNotes.Images.SetKeyName(113, "vwicn113.bmp");
      this.iconsNotes.Images.SetKeyName(114, "vwicn114.bmp");
      this.iconsNotes.Images.SetKeyName(115, "vwicn115.bmp");
      this.iconsNotes.Images.SetKeyName(116, "vwicn116.bmp");
      this.iconsNotes.Images.SetKeyName(117, "vwicn117.bmp");
      this.iconsNotes.Images.SetKeyName(118, "vwicn118.bmp");
      this.iconsNotes.Images.SetKeyName(119, "vwicn119.bmp");
      this.iconsNotes.Images.SetKeyName(120, "vwicn120.bmp");
      this.iconsNotes.Images.SetKeyName(121, "vwicn121.bmp");
      this.iconsNotes.Images.SetKeyName(122, "vwicn122.bmp");
      this.iconsNotes.Images.SetKeyName(123, "vwicn123.bmp");
      this.iconsNotes.Images.SetKeyName(124, "vwicn124.bmp");
      this.iconsNotes.Images.SetKeyName(125, "vwicn125.bmp");
      this.iconsNotes.Images.SetKeyName(126, "vwicn126.bmp");
      this.iconsNotes.Images.SetKeyName(127, "vwicn127.bmp");
      this.iconsNotes.Images.SetKeyName(128, "vwicn128.bmp");
      this.iconsNotes.Images.SetKeyName(129, "vwicn129.bmp");
      this.iconsNotes.Images.SetKeyName(130, "vwicn130.bmp");
      this.iconsNotes.Images.SetKeyName(131, "vwicn131.bmp");
      this.iconsNotes.Images.SetKeyName(132, "vwicn132.bmp");
      this.iconsNotes.Images.SetKeyName(133, "vwicn133.bmp");
      this.iconsNotes.Images.SetKeyName(134, "vwicn134.bmp");
      this.iconsNotes.Images.SetKeyName(135, "vwicn135.bmp");
      this.iconsNotes.Images.SetKeyName(136, "vwicn136.bmp");
      this.iconsNotes.Images.SetKeyName(137, "vwicn137.bmp");
      this.iconsNotes.Images.SetKeyName(138, "vwicn138.bmp");
      this.iconsNotes.Images.SetKeyName(139, "vwicn139.bmp");
      this.iconsNotes.Images.SetKeyName(140, "vwicn140.bmp");
      this.iconsNotes.Images.SetKeyName(141, "vwicn141.bmp");
      this.iconsNotes.Images.SetKeyName(142, "vwicn142.bmp");
      this.iconsNotes.Images.SetKeyName(143, "vwicn143.bmp");
      this.iconsNotes.Images.SetKeyName(144, "vwicn144.bmp");
      this.iconsNotes.Images.SetKeyName(145, "vwicn145.bmp");
      this.iconsNotes.Images.SetKeyName(146, "vwicn146.bmp");
      this.iconsNotes.Images.SetKeyName(147, "vwicn147.bmp");
      this.iconsNotes.Images.SetKeyName(148, "vwicn148.bmp");
      this.iconsNotes.Images.SetKeyName(149, "vwicn149.bmp");
      this.iconsNotes.Images.SetKeyName(150, "vwicn150.bmp");
      this.iconsNotes.Images.SetKeyName(151, "vwicn151.bmp");
      this.iconsNotes.Images.SetKeyName(152, "vwicn152.bmp");
      this.iconsNotes.Images.SetKeyName(153, "vwicn153.bmp");
      this.iconsNotes.Images.SetKeyName(154, "vwicn154.bmp");
      this.iconsNotes.Images.SetKeyName(155, "vwicn155.bmp");
      this.iconsNotes.Images.SetKeyName(156, "vwicn156.bmp");
      this.iconsNotes.Images.SetKeyName(157, "vwicn157.bmp");
      this.iconsNotes.Images.SetKeyName(158, "vwicn158.bmp");
      this.iconsNotes.Images.SetKeyName(159, "vwicn159.bmp");
      this.iconsNotes.Images.SetKeyName(160, "vwicn160.bmp");
      this.iconsNotes.Images.SetKeyName(161, "vwicn161.bmp");
      this.iconsNotes.Images.SetKeyName(162, "vwicn162.bmp");
      this.iconsNotes.Images.SetKeyName(163, "vwicn163.bmp");
      this.iconsNotes.Images.SetKeyName(164, "vwicn164.bmp");
      this.iconsNotes.Images.SetKeyName(165, "vwicn165.bmp");
      this.iconsNotes.Images.SetKeyName(166, "vwicn166.bmp");
      this.iconsNotes.Images.SetKeyName(167, "vwicn167.bmp");
      this.iconsNotes.Images.SetKeyName(168, "vwicn168.bmp");
      this.iconsNotes.Images.SetKeyName(169, "vwicn169.bmp");
      this.iconsNotes.Images.SetKeyName(170, "vwicn170.bmp");
      this.iconsNotes.Images.SetKeyName(171, "vwicn171.bmp");
      this.iconsNotes.Images.SetKeyName(172, "vwicn172.bmp");
      this.iconsNotes.Images.SetKeyName(173, "vwicn173.bmp");
      this.iconsNotes.Images.SetKeyName(174, "vwicn174.bmp");
      this.iconsNotes.Images.SetKeyName(175, "vwicn175.bmp");
      this.iconsNotes.Images.SetKeyName(176, "vwicn176.bmp");
      this.iconsNotes.Images.SetKeyName(177, "vwicn177.bmp");
      this.iconsNotes.Images.SetKeyName(178, "vwicn178.bmp");
      this.iconsNotes.Images.SetKeyName(179, "vwicn179.bmp");
      this.iconsNotes.Images.SetKeyName(180, "vwicn180.bmp");
      this.iconsNotes.Images.SetKeyName(181, "vwicn181.bmp");
      this.iconsNotes.Images.SetKeyName(182, "vwicn182.bmp");
      this.iconsNotes.Images.SetKeyName(183, "vwicn183.bmp");
      // 
      // iconsState
      // 
      this.iconsState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsState.ImageStream")));
      this.iconsState.TransparentColor = System.Drawing.Color.Transparent;
      this.iconsState.Images.SetKeyName(0, "vwicn999.bmp");
      this.iconsState.Images.SetKeyName(1, "vwicn037.bmp");
      this.iconsState.Images.SetKeyName(2, "vwicn038.bmp");
      // 
      // taskTableBindingSource
      // 
      this.taskTableBindingSource.DataSource = typeof(tm.ToDo.TodoList);
      // 
      // FormTable
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(466, 676);
      this.Controls.Add(this.tabsHolder);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormTable";
      this.Text = "Configuration";
      this.Load += new System.EventHandler(this.FormTable_Load);
      this.tabsHolder.ResumeLayout(false);
      this.pageToday.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.timeTable)).EndInit();
      this.pageTasks.ResumeLayout(false);
      this.menuForTask.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.taskTableBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabsHolder;
    private System.Windows.Forms.TabPage pageToday;
    private System.Windows.Forms.TabPage pageTasks;
    private System.Windows.Forms.DataGridView timeTable;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.BindingSource taskTableBindingSource;
    private System.Windows.Forms.ListView tasksListBox;
    private System.Windows.Forms.ImageList iconsNotes;
    private System.Windows.Forms.ColumnHeader c1;
    private System.Windows.Forms.ImageList iconsState;
    private System.Windows.Forms.ContextMenuStrip menuForTask;
    private System.Windows.Forms.ToolStripMenuItem menuComplete;
    private System.Windows.Forms.ToolStripMenuItem menuCritical;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem menuEdit;
    private System.Windows.Forms.ToolStripMenuItem menuAdd;
    private System.Windows.Forms.ToolStripMenuItem menuDelete;
    private System.Windows.Forms.ColumnHeader p;
  }
}