using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tm.ToDo;

namespace tm
{
  public partial class EditTask : Form
  {
    public EditTask() {
      InitializeComponent();
    }

    TaskTodo activeTask;

    public void LoadTask(TaskTodo task) {
      activeTask = task;
      if (task == null) return;
      eTitle.Text = task.Text;
      eActivity.SelectedItem = task.ActivityName;
      useDueDate.Checked = task.HasDueDate;
      if (task.HasDueDate) eDueDate.Value = task.DueDate; else eDueDate.Text = "";
      eScope.SelectedItem = task.ScopeName;
      useStartDate.Checked = task.HasStartDate;
      if (task.HasStartDate) eStartDate.Value = task.StartDate; else eStartDate.Text = "";
      eHours.Text = task.Duration.ToString();
      eCritical.Checked = task.IsCritical;
      groupRecurring.Enabled = false;
      if (task.Period == TodoPeriod.None) eRecur.Checked = false;
      else {
        eRecur.Checked = true;
        groupRecurring.Enabled = true;
        eDays.Value = task.RepeatCount;
        eFloating.Checked = task.IsFloating;
        ePeriod.SelectedItem = task.PeriodName;
      }
      eDescription.Text = task.Description;
      updateControls();
    }

    public void SaveTask(TaskTodo task) {
      if (task == null) return;
      task.Text = eTitle.Text;
      task.ScopeName = eScope.SelectedItem.ToString();
      task.ActivityName = eActivity.SelectedItem.ToString();
      if (useDueDate.Checked) task.DueDate = eDueDate.Value; else task.HasDueDate = false;
      if (useStartDate.Checked) task.StartDate = eStartDate.Value; else task.HasStartDate = false;
      task.Duration = Convert.ToDouble(eHours.Text);
      task.IsCritical = eCritical.Checked;
      if (eRecur.Checked) {
        task.RepeatCount = Convert.ToInt32(eDays.Value);
        task.IsFloating = eFloating.Checked;
        task.PeriodName = ePeriod.SelectedItem.ToString();
      } else task.Period = TodoPeriod.None;
      task.Description = eDescription.Text;
    }

    private void updateControls() {
      groupRecurring.Enabled = eRecur.Checked;
      eDueDate.Enabled = useDueDate.Checked;
      eStartDate.Enabled = useStartDate.Checked;
      if (eRecur.Checked) {
        useDueDate.Checked = true;
        useDueDate.Enabled = false;
        eDueDate.Enabled = true;
      } else {
        useDueDate.Enabled = true;
      }
      Application.DoEvents();
    }

    private void btnOK_Click(object sender, EventArgs e) {
      SaveTask(activeTask);
    }

    private void eRecur_CheckedChanged(object sender, EventArgs e) {
      updateControls();
    }
  }
}