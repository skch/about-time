using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tm
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(params string[] args) {
      if (args.Length > 0 && args[0] == "/debug") AppLog.SetLogFile("TimeManagerLog.txt");
      try
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        AppLog.WriteEvent("Loading Configuration");
        Config.Load();
        Application.Run(new FormMeter());
      }
      catch (Exception ex) {
        AppLog.WriteError("Main", ex);
        MessageBox.Show("The program was terminated, please contact support team.", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}