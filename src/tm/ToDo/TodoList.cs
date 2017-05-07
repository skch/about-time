using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml;
using System.IO;

namespace tm.ToDo
{


  public class TodoList : IListSource, ITaskTodoLoader
  {
    private List<TaskTodo> tasks = new List<TaskTodo>();

    public TodoList() {
    }

    public void Add(TaskTodo task) {
      tasks.Add(task);
    }

    public void Delete(TaskTodo task) {
      tasks.Remove(task);
    }

    #region IListSource Members

    public bool ContainsListCollection {
      get { return true; }
    }

    public System.Collections.IList GetList() {
      return tasks;
    }

    #endregion

    #region File operations

    private string getFileName() {
      return string.Format("{0}{1}Todo.xml", Config.DataPath, Path.DirectorySeparatorChar);
    }

    public void LoadTasks() {
      tasks.Add(new TaskTodo("Do something"));
      tasks.Add(new TaskTodo("Do something else"));
      tasks.Add(new TaskTodo("Hi there"));

      string fileName = getFileName();
      LoadFromFile(fileName);
      //tasks.Clear();
      //LoadFromRtm();
    }

    public void SaveTasks() {
      try {
        SaveToFile(getFileName());
      } catch { }
    }

    internal void LoadFromFile(string fileName) {
      if (!File.Exists(fileName)) return;
      XmlDocument doc = new XmlDocument();
      doc.Load(fileName);
      XmlElement xmlTasks = doc.DocumentElement["Tasks"];
      tasks.Clear();
      foreach (XmlElement xmlTask in xmlTasks.ChildNodes) {
        try
        {
          TaskTodo task = new TaskTodo(xmlTask);
          tasks.Add(task);
        }
        catch { 
        }
      }
    }

    internal void SaveToFile(string fileName) {
      using (XmlTextWriter wr = new XmlTextWriter(fileName, Encoding.UTF8)) {
        wr.WriteStartDocument();
        wr.WriteStartElement("TODO");
        wr.WriteStartElement("Tasks");
        foreach (TaskTodo task in tasks) {
          task.WriteToXml(wr);
        }
        wr.WriteEndElement();
        wr.WriteEndElement();
        wr.WriteEndDocument();
        wr.Flush();
      }
    }
    #endregion

    #region ITaskTodoLoader Members

    public void AddNewTask(TaskTodo task)
    {
      tasks.Add(task);
    }

    #endregion
  }
}
