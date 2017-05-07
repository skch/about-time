using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommonUI;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Resources;

namespace tm
{
  public partial class FormMeter : Form
  {
    public FormMeter() {
      InitializeComponent();
    }

    private bool isActive = false;
    TimeRow rowNow = null;
    TimeRow rowNext = null;

    const int TITLE_HEIGHT = 22;
    const int BORDER_WIDTH = 2;
    const int SMALL_HEIGHT = 54;
    const int FULL_HEIGHT = 94;
    const int FULL_WIDTH = 155;
    const int SMALL_WIDTH = 146;


    const string IMG_LOGO = "tm.Resources.Logo.jpg";


		#region Initialize
		private void FormMeter_Load(object sender, EventArgs e)
		{
			try
			{
				Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width - 10, 26);
				Color bg = Config.BackgroundColor;
				timeProgress.BackColor = bg;
				timeProgress.ColorBackGround = bg;
				ltask1.BackColor = bg;
				ltask2.BackColor = bg;
				this.BackColor = bg;
				Config.TodayTime.Load();
				showSmall();
				showScreen();
			}
			catch (Exception ex)
			{
				AppLog.WriteError("FormMeter_Load", ex);
			}
		}

		#endregion

		#region Resize
		private void FormMeter_Enter(object sender, EventArgs e)
		{
			timerWin.Enabled = false;
			showFull();
		}

		private void FormMeter_MouseLeave(object sender, EventArgs e)
		{
			if (!isActive) timerWin.Enabled = true;
		}

		private void FormMeter_Activated(object sender, EventArgs e)
		{
			isActive = true;
		}

		private void FormMeter_Deactivate(object sender, EventArgs e)
		{
			showSmall();
			isActive = false;
		}


		private void showFull()
		{
			SuspendLayout();
			ltask1.Visible = true;
			ltask2.Visible = true;
			if (FormBorderStyle == FormBorderStyle.FixedToolWindow) return;
			int newY = Location.Y - TITLE_HEIGHT;
			if (newY > 0)
			{
				Location = new Point(Location.X - BORDER_WIDTH, newY);
			}
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Size = new Size(FULL_WIDTH, FULL_HEIGHT);
			ResumeLayout();
		}

		private void showSmall()
		{
			SuspendLayout();
			ltask1.Visible = (rowNow != null) && !string.IsNullOrEmpty(rowNow.Task);
			ltask2.Visible = (rowNext != null) && !string.IsNullOrEmpty(rowNext.Task);
			this.Size = new Size(SMALL_WIDTH, SMALL_HEIGHT);
			if (FormBorderStyle == FormBorderStyle.None) return;
			Location = new Point(Location.X + BORDER_WIDTH, Location.Y + TITLE_HEIGHT);
			FormBorderStyle = FormBorderStyle.None;
			ResumeLayout();
		}

		private void FormMeter_Resize(object sender, EventArgs e)
		{
			if (FormBorderStyle == FormBorderStyle.None)
			{
				this.Size = new Size(SMALL_WIDTH, SMALL_HEIGHT);
			}
			else
			{
				this.Size = new Size(FULL_WIDTH, FULL_HEIGHT);
			}

		}

		#endregion

		#region Dialogs
		private void callTodayDialog(object sender, EventArgs e)
		{
			FormTable ft = new FormTable();
			Hide();
			if (ft.ShowDialog() == DialogResult.OK) showScreen();
			Show();
		}

		private void menuAbout_Click(object sender, EventArgs e)
		{
			ApplicationInfo info = new ApplicationInfo();
			info.Title = "Application Credit and Version";
			info.Url = "http://skch.net/columns/time.html";
			Assembly a = Assembly.GetExecutingAssembly();

			Stream imgStream = System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream(IMG_LOGO);
			if (imgStream != null)
			{
				Bitmap bmp = Bitmap.FromStream(imgStream) as Bitmap;
				info.Logo = bmp;
			}
			AboutForm.ShowAboutForm(info);
		}



		#endregion

		#region Ticks

		private void showScreen()
		{
			DateTime tm = DateTime.Now;
			TimeSpan dif;
			int min = tm.Minute;
			DateTime fix = new DateTime(tm.Year, tm.Month, tm.Day, tm.Hour, 30, 0);
			if (min >= 30)
			{
				fix = fix.AddMinutes(30);
				dif = fix.Subtract(tm);
				timeProgress.Position = min - 30;
			}
			else
			{
				dif = fix.Subtract(tm);
				timeProgress.Position = min;
			}
			Text = " TIME " + tm.ToShortTimeString();
			timeProgress.Text = string.Format("{0} min", dif.Minutes + 1);
			rowNow = Config.TodayTime.FindRowForTime(tm);
			ltask1.Visible = (rowNow != null) && !string.IsNullOrEmpty(rowNow.Task);
			ltask2.Visible = (rowNext != null) && !string.IsNullOrEmpty(rowNext.Task);
			int remains = Config.TodayTime.GetBackCount(tm);
			TextLabel.Text = string.Format("{0}                               {1}", remains, remains - 1);
			ltask1.Text = (rowNow != null) ? rowNow.Task : "";

			rowNext = Config.TodayTime.FindRowForTime(tm.AddMinutes(30));
			ltask2.Text = (rowNext != null) ? rowNext.Task : "";
			this.ActiveControl = timeProgress;
			Application.DoEvents();
		}

		private void timerShow_Tick(object sender, EventArgs e)
		{
			showScreen();
		}

		private void timerWin_Tick(object sender, EventArgs e)
		{
			timerWin.Enabled = false;
			showSmall();
		}
		#endregion

		private void menuExit_Click(object sender, EventArgs e) {
      Close();
    }

    private void OnChangeLeft(object sender, EventArgs e) {
      if (rowNow == null) return;
      rowNow.Task = ltask1.Text;
    }

    private void OnChangeRight(object sender, EventArgs e) {
      if (rowNext == null) return;
      rowNext.Task = ltask2.Text;
    }



  }
}