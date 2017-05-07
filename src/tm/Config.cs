using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using tm.ToDo;
using System.IO;
using System.Xml;

namespace tm
{
  public static class Config
  {

    public static TimeTable TodayTime;
    public static TodoList Tasks;

    private static Color backColor = Color.LemonChiffon;
    public static Color BackgroundColor {
      get { return backColor; }
    }

    private static Color tableBackColor = Color.LemonChiffon;
    public static Color TableBackgroundColor {
      get { return tableBackColor; }
    }

    private static string filesPath;
    public static string DataPath {
      get { return filesPath; }
    }
	

    private static DateTime startTime;
    public static DateTime StartTime {
      get { return startTime; }
    }

    private static DateTime endTime;
    public static DateTime EndTime {
      get { return endTime; }
    }

    public static void SetDefault() {
      backColor = Color.Lavender;
      tableBackColor = Color.LemonChiffon;
      startTime = DateTime.Now;
      startTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, 7, 30, 0);
      endTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, 21, 0, 0);
      filesPath = System.Environment.CurrentDirectory;
    }

    public static void SetDebug() {
      filesPath = @"D:\Code\C#\Shareware\Time Manager\tm\bin\Debug";
      endTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, 23, 0, 0);
    }

    public static void Load() {
      SetDefault();
#if DEBUG
      SetDebug();
#endif
      Tasks = new TodoList();
      string fName = System.Environment.CurrentDirectory + Path.DirectorySeparatorChar + "Settings.xml";
      if (!File.Exists(fName)) return;
      try
      {

        XmlDocument options = new XmlDocument();
        AppLog.WriteEvent("Loading config " + fName);
        options.Load(fName);
        XmlElement root = options.DocumentElement;
        XmlElement timetable = root["timetable"];
        if (!DateTime.TryParse(timetable.GetAttribute("start"), out startTime))
        {
          AppLog.WriteEvent("Cannot parse " + timetable.GetAttribute("start"));
          startTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, 7, 30, 0);
        }
        if (!DateTime.TryParse(timetable.GetAttribute("end"), out endTime))
        {
          AppLog.WriteEvent("Cannot parse " + timetable.GetAttribute("end"));
          endTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, 19, 0, 0);
        }
        AppLog.WriteEvent("End time " + endTime.ToShortTimeString());
      }
      catch (Exception ex)
      {
        AppLog.WriteError("Config.Load", ex);
      }
      finally {
        TodayTime = new TimeTable();
      }


    }
	
	
  }
}
