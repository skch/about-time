using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace tm
{
  public static class AppLog
  {

    public static string LogFileName = null;

    public static void SetLogFile(string fileName) {
      //System.Environment.CurrentDirectory
      LogFileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + fileName;
      WriteString("");
      WriteString("------------------------------------------");
      WriteEvent("Application Started");
    }

    public static void WriteEvent(string Msg) {
      WriteString(string.Format("{0}: {1}", DateTime.Now, Msg));
    }

    public static void WriteError(string routine, Exception ex)
    {
      WriteString(string.Format("{0}: ERROR in {1}\n{2}\n{3}", DateTime.Now, routine, ex.Message, ex.Source, ex.StackTrace));
    }

    private static void WriteString(string Msg)
    {
      if (LogFileName == null) return;
      using (StreamWriter sw = new StreamWriter(LogFileName, true))
      {
        sw.WriteLine(Msg);
        sw.Flush();
        sw.Close();
      }

    }
  }
}
