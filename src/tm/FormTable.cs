using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tm.ToDo;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace tm
{
  public partial class FormTable : Form
  {
    public FormTable() {
      InitializeComponent();
    }

    const int GROUP_CRITICAL = 0;
    const int GROUP_OVERDUE = 1;
    const int GROUP_ACTIVE = 2;
    const int GROUP_FUTURE = 3;
    const int GROUP_COMPLETED = 4;


    private void setupTodayTable() {
      //this.Height = 700;
      TimeSpan td = Config.EndTime - Config.StartTime;
      this.Height = 105 + 22 * Convert.ToInt32(td.TotalMinutes / 30);
      AppLog.WriteEvent("Height: "+this.Height.ToString());

      TimeTable dt = Config.TodayTime;
      timeTable.RowTemplate.DefaultCellStyle.BackColor = Config.TableBackgroundColor;
      timeTable.DataSource = dt;
      timeTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      timeTable.Columns.Clear();
      timeTable.Columns.Add("Time", "Time");
      DataGridViewColumn col = timeTable.Columns[0];
      col.DataPropertyName = "Time";
      col.ReadOnly = true;
      col.Frozen = true;
      col.Width = 55;

      timeTable.Columns.Add("Task", "Task");
      DataGridViewColumn task = timeTable.Columns[1];
      task.DataPropertyName = "Task";
      task.Width = 270;
      //timeTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
      TimeRow crow = Config.TodayTime.FindRowForTime(DateTime.Now);
      if (crow != null && crow.Id > 0) {
        timeTable.Rows[crow.Id - 1].Cells[0].Selected = true;
      }
    }

    private void setupTaskTable() {
      Config.Tasks.LoadTasks();
      //taskTable.DataSource = Config.Tasks;
      tasksListBox.BackColor = Config.TableBackgroundColor;
      tasksListBox.Items.Clear();
      foreach (TaskTodo task in Config.Tasks.GetList()) {
        updateTaskStatus(null, task);
      }
      tasksListBox.Refresh();
    }

    private ListViewItem updateTaskStatus(ListViewItem item, TaskTodo task) {
      if (item != null) {
        tasksListBox.Items.Remove(item);
      }
      item = new ListViewItem(task.Pressure.ToString("0000000"));
      item.Tag = task;
      item.ToolTipText = task.Description;
      item.ImageIndex = (int) task.Activity;
      //tasksListBox.Items.Add(item);
      
      int idx = 0;
      foreach (ListViewItem zi in tasksListBox.Items) {
        TaskTodo zt = zi.Tag as TaskTodo;
        if (zt.Pressure > task.Pressure) { break; }
        idx++;
      }
      tasksListBox.Items.Insert(idx, item);
      

      if (task.IsCompleted) { item.Group = tasksListBox.Groups[GROUP_COMPLETED]; return item; }
      if (task.InFuture) { item.Group = tasksListBox.Groups[GROUP_FUTURE]; return item; }
      if (task.IsCritical) { item.Group = tasksListBox.Groups[GROUP_CRITICAL]; return item; }
      if (task.IsOverdue) { item.Group = tasksListBox.Groups[GROUP_OVERDUE]; return item; }
      item.Group = tasksListBox.Groups[GROUP_ACTIVE];
      return item;
    }


    private void FormTable_Load(object sender, EventArgs e) {
      Text = " Itinerary for " + DateTime.Today.ToLongDateString();
      setupTodayTable();
      setupTaskTable();

    }

    private void updateList(TaskTodo theTask) {
      ListViewItem toselect = null;
      tasksListBox.Items.Clear();
      foreach (TaskTodo task in Config.Tasks.GetList()) {
        if (task == theTask) toselect = updateTaskStatus(null, task); else  
        updateTaskStatus(null, task);
      }
      tasksListBox.Refresh();

    }

    private void EditSelectedTask() {
      EditTask dialog = new EditTask();
      if (tasksListBox.SelectedItems.Count < 1) return;
      ListViewItem item = tasksListBox.SelectedItems[0];
      if (item == null) return;
      TaskTodo task = item.Tag as TaskTodo;
      dialog.LoadTask(task);
      if (dialog.ShowDialog() == DialogResult.OK) {
        updateList(task);
        //updateTaskStatus(item, task);
        //tasksListBox.Refresh();
        Config.Tasks.SaveTasks();
      }
    }

    private void AddTask() {
      EditTask dialog = new EditTask();
      TaskTodo task = new TaskTodo("");
      dialog.LoadTask(task);
      if (dialog.ShowDialog() == DialogResult.OK) {
        Config.Tasks.Add(task);
        updateTaskStatus(null, task);
        tasksListBox.Refresh();
        Config.Tasks.SaveTasks();
      }
    }

    private void DeleteSelectedTask() {
      if (tasksListBox.SelectedItems.Count < 1) return;
      ListViewItem item = tasksListBox.SelectedItems[0];
      if (item == null) return;
      TaskTodo task = item.Tag as TaskTodo;
      if (!task.IsCompleted) return;
      Config.Tasks.Delete(task);
      tasksListBox.Items.Remove(item);
      Config.Tasks.SaveTasks();
    }


    private void MarkCompleted() {
      if (tasksListBox.SelectedItems.Count < 1) return;
      ListViewItem item = tasksListBox.SelectedItems[0];
      if (item == null) return;
      TaskTodo task = item.Tag as TaskTodo;
      if (task == null) return;
      task.MarkCompleted();
      updateTaskStatus(item, task);
      tasksListBox.Refresh();
      Config.Tasks.SaveTasks();

    }

    private void MarkCritical() {
      if (tasksListBox.SelectedItems.Count < 1) return;
      ListViewItem item = tasksListBox.SelectedItems[0];
      if (item == null) return;
      TaskTodo task = item.Tag as TaskTodo;
      if (task == null) return;
      task.IsCritical = true;
      updateTaskStatus(item, task);
      tasksListBox.Refresh();
      Config.Tasks.SaveTasks();
    }

    
    private void btnClear_Click(object sender, EventArgs e) {
      Config.TodayTime.Clear();
      timeTable.Refresh();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      Config.TodayTime.Save();
    }

    private void btnCancel_Click(object sender, EventArgs e) {
      Config.TodayTime.Load();
    }

    private void tasksListBox_ItemCheck(object sender, ItemCheckEventArgs e) {
      ListViewItem item = tasksListBox.Items[e.Index];
      if (item == null) return;
      TaskTodo task = item.Tag as TaskTodo;
      if (task == null) return;
      task.IsCompleted = (e.NewValue == CheckState.Checked);
      updateTaskStatus(item, task);
      Config.Tasks.SaveTasks();
    }

    private void tasksListBox_DoubleClick(object sender, EventArgs e) {
      EditSelectedTask();
    }

    private Color taskColor(TaskTodo task) {
      if (task.IsCompleted) return Color.Green;
      if (task.IsOverdue) return Color.Red;
      if (task.InFuture) return Color.Gray;
      return Color.Black;
    }


    int ICON_WIDTH = 13;
    int ICON_HEIGHT = 11;
    int ICON_SPACE = 2;
    int LEFT_MARGIN = 10;
    private void tasksListBox_DrawItem(object sender, DrawListViewItemEventArgs e) {
      TaskTodo task = e.Item.Tag as TaskTodo;
      if (task == null) {e.DrawDefault = true; return;}

      Rectangle rIcon = new Rectangle(e.Bounds.X + LEFT_MARGIN, e.Bounds.Y + 2, ICON_WIDTH, ICON_HEIGHT);
      int dx = LEFT_MARGIN + ICON_SPACE + ICON_WIDTH;
      Rectangle rIcon2 = new Rectangle(e.Bounds.X + dx, e.Bounds.Y + 2, ICON_WIDTH, ICON_HEIGHT);
      dx = LEFT_MARGIN + (ICON_WIDTH + ICON_SPACE) * 2;
      Rectangle rText = new Rectangle(e.Bounds.X + dx, e.Bounds.Y, e.Bounds.Width - dx, e.Bounds.Height);
      if ((e.State & ListViewItemStates.Selected) != 0) {
        e.Graphics.FillRectangle(Brushes.Coral, rText);
        //e.DrawFocusRectangle();
      }
      //else {
      //}

      int imageId = (int)task.Activity;
      if (task.IsCritical) imageId = 150;
      if (task.IsCompleted) imageId = 82;


      Image ic = iconsNotes.Images[imageId];
      e.Graphics.DrawImage(ic, rIcon);
      if (task.IsRecurring) e.Graphics.DrawImage(iconsNotes.Images[33], rIcon2);
#if DEBUG
      string dtext = string.Format("{0} {1} :({2})", task.Text, task.RemainsUntil, task.Pressure);
#else
      string dtext = string.Format("{0}  {1}", task.Text, task.RemainsUntil);
#endif
      e.Graphics.DrawString(dtext, tasksListBox.Font, new SolidBrush(taskColor(task)), rText);


      if (tasksListBox.View != View.Details) {
        e.DrawText();
      }

    }

    private void tasksListBox_MouseClick(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Right) { 
      }
      /*
      ListViewItem item = tasksListBox.Items[e.Index];
      if (item == null) return;
      TaskTodo task = item.Tag as TaskTodo;
      if (task == null) return;
      task.IsCompleted = (e.NewValue == CheckState.Checked);
      tasksListBox.Refresh();
      Config.Tasks.SaveTasks();
       */
    }

    private void tasksListBox_Click(object sender, EventArgs e) {
    }

    private void menuComplete_Click(object sender, EventArgs e) {
      MarkCompleted();
    }

    private void menuCritical_Click(object sender, EventArgs e) {
      MarkCritical();

    }

    private void menuEdit_Click(object sender, EventArgs e) {
      EditSelectedTask();
    }

    private void menuAdd_Click(object sender, EventArgs e) {
      AddTask();
    }

    private void menuDelete_Click(object sender, EventArgs e) {
      DeleteSelectedTask();
    }

  }
}