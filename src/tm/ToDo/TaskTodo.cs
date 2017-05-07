using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace tm.ToDo
{

  public enum TodoActivity
  {
    Information = 11,
    Birthday = 10,
    Writing = 58,
    Reading = 34,
    Phone = 44,
    Finance = 59,
    Home = 69,
    Medical = 71,
    Travel = 66,
    Driving = 174
  }

  public enum TodoScope
  {
    Personal, Home, Work, Business
  }

  public enum TodoPeriod
  {
    None, Days, Weeks, Months, Years
  }

  public class TaskTodo
  {

    private DateTime BlankDate = new DateTime(1100, 1, 1);

    public TaskTodo(string atext)
    {
      text = atext;
      startDate = DateTime.Today;
      dueDate = startDate.AddDays(1);
    }

    public TaskTodo(XmlElement task)
    {
      if (task == null) return;
      isCritical = task.GetAttribute("critical") == "True";
      isCompleted = task.GetAttribute("completed") == "True";
      scope = (TodoScope)Enum.Parse(typeof(TodoScope), task.GetAttribute("scope"));
      string sact = task.GetAttribute("activity");
      if (string.IsNullOrEmpty(sact)) sact = "Information";
      activity = (TodoActivity)Enum.Parse(typeof(TodoActivity), sact);
      Duration = Convert.ToDouble(task.GetAttribute("duration"));
      startDate = textToDate(task.GetAttribute("start"));
      dueDate = textToDate(task.GetAttribute("due"));
      XmlElement rep = task["Repeat"];
      if (rep != null)
      {
        recPeriod = (TodoPeriod)Enum.Parse(typeof(TodoPeriod), rep.GetAttribute("period"));
        repCount = Convert.ToInt32(rep.GetAttribute("times"));
        isFloat = rep.GetAttribute("float") == "True";

      }
      else recPeriod = TodoPeriod.None;

      XmlElement txt = task["title"];
      text = (txt != null) ? txt.InnerText : "";
      txt = task["text"];
      desc = (txt != null) ? txt.InnerText : "";
    }

    private DateTime textToDate(string text)
    {
      DateTime result = (string.IsNullOrEmpty(text)) ? BlankDate : DateTime.Parse(text);
      return result;
    }

    private string dateToText(DateTime dt)
    {
      string result = (dt.CompareTo(BlankDate) == 0) ? "" : dt.ToShortDateString();
      return result;
    }

    public bool HasDueDate
    {
      get { return (dueDate.Year > 1200); }
      set { if (!value) dueDate = BlankDate; else dueDate = DateTime.Today; }
    }

    private DateTime dueDate = DateTime.Today;
    public DateTime DueDate
    {
      get { return dueDate; }
      set
      {
        dueDate = value;
        if (!HasDueDate) recPeriod = TodoPeriod.None;
      }
    }

    public bool HasStartDate
    {
      get { return (startDate.Year > 1200); }
      set { if (!value) startDate = BlankDate; else startDate = DateTime.Today; }
    }

    private DateTime startDate;
    public DateTime StartDate
    {
      get { return startDate; }
      set { startDate = value; }
    }


    private string text;
    public string Text
    {
      get { return text; }
      set { text = value; }
    }

    private bool isCompleted = false;
    public bool IsCompleted
    {
      get { return isCompleted; }
      set { isCompleted = value; }
    }

    private DateTime shiftDays(DateTime date, int count)
    {
      if (date.Year < 1200) return date;
      return (isFloat) ? DateTime.Today.AddDays(count) : date.AddDays(count);
    }

    private DateTime shiftMonths(DateTime date)
    {
      if (date.Year < 1200) return date;
      return (isFloat) ? DateTime.Today.AddMonths(repCount) : date.AddMonths(repCount);
    }

    private DateTime shiftYears(DateTime date)
    {
      if (date.Year < 1200) return date;
      return (isFloat) ? DateTime.Today.AddYears(repCount) : date.AddYears(repCount);
    }

    public void MarkCompleted()
    {
      switch (recPeriod)
      {
        case TodoPeriod.None:
          isCompleted = true;
          break;
        case TodoPeriod.Days:
          dueDate = shiftDays(dueDate, repCount);
          startDate = shiftDays(startDate, repCount);
          break;
        case TodoPeriod.Weeks:
          dueDate = shiftDays(dueDate, repCount * 7);
          startDate = shiftDays(startDate, repCount * 7);
          break;
        case TodoPeriod.Months:
          dueDate = shiftMonths(dueDate);
          startDate = shiftMonths(startDate);
          break;
        case TodoPeriod.Years:
          dueDate = shiftYears(dueDate);
          startDate = shiftYears(startDate);
          break;
      }
    }

    public bool IsRecurring
    {
      get { return (recPeriod != TodoPeriod.None); }
    }

    private bool isFloat;
    public bool IsFloating
    {
      get { return isFloat; }
      set { isFloat = value; }
    }

    private bool isCritical;
    public bool IsCritical
    {
      get { return isCritical; }
      set { isCritical = value; }
    }

    private double duration = 1;
    public double Duration
    {
      get { return duration; }
      set { if (value <= 0) duration = 0.1; else duration = value; }
    }

    private TodoActivity activity = TodoActivity.Information;
    public TodoActivity Activity
    {
      get { return activity; }
      set { activity = value; }
    }

    public string ActivityName
    {
      get { return activity.ToString(); }
      set { activity = (TodoActivity)Enum.Parse(typeof(TodoActivity), value, true); }
    }

    private TodoScope scope = TodoScope.Personal;
    public TodoScope Scope
    {
      get { return scope; }
      set { scope = value; }
    }

    public string ScopeName
    {
      get { return scope.ToString(); }
      set { scope = (TodoScope)Enum.Parse(typeof(TodoScope), value, true); }
    }

    private string desc;
    public string Description
    {
      get { return desc; }
      set { desc = value; }
    }

    private int repCount;
    public int RepeatCount
    {
      get { return repCount; }
      set { repCount = value; }
    }

    private TodoPeriod recPeriod = TodoPeriod.None;
    public TodoPeriod Period
    {
      get { return recPeriod; }
      set { recPeriod = value; }
    }

    public string PeriodName
    {
      get { return recPeriod.ToString(); }
      set
      {
        switch (value.ToLower())
        {
          case "years": recPeriod = TodoPeriod.Years; break;
          case "months": recPeriod = TodoPeriod.Months; break;
          case "weeks": recPeriod = TodoPeriod.Weeks; break;
          case "days": recPeriod = TodoPeriod.Days; break;
          default: recPeriod = TodoPeriod.None; break;
        }
      }
    }

    public double Pressure
    {
      get
      {
        DateTime due = DateTime.Today.AddMonths(1);
        if (HasDueDate)
        {
          if (dueDate > DateTime.Today) due = dueDate; else return 0;
        }
        TimeSpan remain = due - DateTime.Today;
        return remain.TotalHours / duration;

      }
    }

    public bool IsOverdue
    {
      get { return (HasDueDate && (dueDate < DateTime.Today) && (!isCompleted)); }
    }

    public bool InFuture
    {
      get { return ((startDate > DateTime.Today) && (!isCompleted)); }
    }

    public string RemainsUntil
    {
      get
      {
        if (IsCompleted) return "";
        if (!HasDueDate && !HasStartDate) return "";
        DateTime f = (HasStartDate && startDate > DateTime.Today) ? startDate : dueDate;
        if (f < DateTime.Today) return "";
        TimeSpan diff = f - DateTime.Today;
        if (diff.TotalDays >= 365) return string.Format("{0:F1} year(s)", diff.TotalDays / 365);
        if (diff.TotalDays >= 30) return string.Format("{0:F1} month(s)", diff.TotalDays / 30);
        if (diff.TotalDays >= 7) return string.Format("{0:F1} week(s)", diff.TotalDays / 7);
        if (diff.TotalDays >= 1) return string.Format("{0:F1} day(s)", diff.TotalDays);
        return "Today";
      }
    }



    public override string ToString()
    {
      return text;
    }

    internal void WriteToXml(XmlWriter wr)
    {
      wr.WriteStartElement("Task");
      wr.WriteAttributeString("critical", isCritical.ToString());
      wr.WriteAttributeString("completed", isCompleted.ToString());
      wr.WriteAttributeString("activity", activity.ToString());
      wr.WriteAttributeString("scope", scope.ToString());
      wr.WriteAttributeString("duration", duration.ToString());
      wr.WriteAttributeString("start", dateToText(startDate));
      wr.WriteAttributeString("due", dateToText(dueDate));
      if (recPeriod != TodoPeriod.None)
      {
        wr.WriteStartElement("Repeat");
        wr.WriteAttributeString("period", recPeriod.ToString());
        wr.WriteAttributeString("times", repCount.ToString());
        wr.WriteAttributeString("float", isFloat.ToString());
        wr.WriteEndElement();
      }
      wr.WriteElementString("title", text);
      wr.WriteElementString("text", desc);
      wr.WriteEndElement();
    }
  }


}
