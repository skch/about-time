using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml;
using System.IO;

namespace tm
{
  /// <summary>
  /// One row is the task for these 30 minutes
  /// </summary>
  public class TimeRow {
    internal DateTime time;
    public string Time {
      get { return time.ToShortTimeString(); }
    }

    private string task;
    public string Task {
      get { return (task == null) ? "" : task; }
      set { task = value; }
    }

    private int id;
    public int Id {
      get { return id; }
    }
	
    public TimeRow(int anId, int hour, int min) {
      id = anId;
      time = DateTime.Now;
      time = new DateTime(time.Year, time.Month, time.Day, hour, min, 0);
    }

    public TimeRow(int anId, DateTime atime) {
      id = anId;
      time = new DateTime(atime.Year, atime.Month, atime.Day, atime.Hour, atime.Minute, 0);
    }

  }


  /// <summary>
  /// The list of 30 minute rows of the day
  /// </summary>
  public class TimeTable : IListSource
  {
    List<TimeRow> rows = new List<TimeRow>();

    public TimeTable() {
      DateTime t = DateTime.Now;
      t = Config.StartTime;
      int id = 1;
      while (t <= Config.EndTime) {
        rows.Add(new TimeRow(id++, t));
        t = t.AddMinutes(30);
      }
    }

    private string getFileName() {
      DateTime t = DateTime.Today;
      return string.Format("{0}{1}{2}.xml", Config.DataPath, Path.DirectorySeparatorChar, DateTime.Today.ToString("yyyyMMdd"));
    }

    public void Load() {
      try {
        string fname = getFileName();
        if (!File.Exists(fname)) return;
        LoadFromFile(fname);
      } catch (Exception ex) {
        AppLog.WriteError("Load", ex);
      }
    }

    public void Save() {
      SaveToFile(getFileName());
    }

    public void LoadFromFile(string fileName) {
      AppLog.WriteEvent("Loading from " + fileName);
      XmlDocument doc = new XmlDocument();
      doc.Load(fileName);
      XmlElement schedule = doc.DocumentElement;
      foreach (XmlElement sec in schedule.ChildNodes) {
        DateTime time = DateTime.Parse(sec.GetAttribute("Time"));
        TimeRow row = GetRowByTime(time);
        if (row != null) row.Task = sec.InnerText;
      }
    }

    public void SaveToFile(string fileName) {
      using (XmlTextWriter wr = new XmlTextWriter(fileName, Encoding.UTF8)) {
        wr.WriteStartDocument();
        wr.WriteStartElement("schedule");
        int id = 1;
        foreach (TimeRow row in rows) {
          if (!string.IsNullOrEmpty(row.Task)) {
            wr.WriteStartElement("section");
            wr.WriteAttributeString("Id", row.Id.ToString());
            wr.WriteAttributeString("Time", row.Time);
            wr.WriteString(row.Task);
            wr.WriteEndElement();
          }
          id++;
        }
        wr.WriteEndElement();
        wr.WriteEndDocument();
        wr.Flush();
      }
    }

    public TimeRow FindRowForTime(DateTime atime) {
      int m = (atime.Minute >= 30) ? 30 : 0;
      return GetRowByTime(atime.Hour, m);
    }

    private TimeRow GetRowByTime(DateTime time) {
      return GetRowByTime(time.Hour, time.Minute);
    }

    private TimeRow GetRowByTime(int h, int m) {
      foreach (TimeRow row in rows) {
        if (row.time.Hour == h && row.time.Minute == m) return row;
      }
      return null;
    }

    public void Clear() {
      foreach (TimeRow row in rows) {
        row.Task = "";
      }
    }

    internal int GetBackCount(DateTime atime)
    {
      int res = 0;
      bool future = false;
      int m = (atime.Minute >= 30) ? 30 : 0;
      foreach (TimeRow row in rows)
      {
        if (future)
        {
          if (!string.IsNullOrEmpty(row.Task)) return res+1;
          res++;
        }
        if (row.time.Hour == atime.Hour && row.time.Minute == m) future = true;
      }
      return res+1;
    }

    #region IListSource Members

    public bool ContainsListCollection {
      get { return true; }
    }

    public System.Collections.IList GetList() {
      return rows;
    }

    #endregion


  }
}
