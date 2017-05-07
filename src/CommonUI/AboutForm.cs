using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace CommonUI
{
  public partial class AboutForm : Form
  {

    protected string linkUrl = null;

    public AboutForm() {
      InitializeComponent();
    }

    public static void ShowAboutForm(ApplicationInfo info) {
      Assembly asm = Assembly.GetEntryAssembly();
      //asm.GetCustomAttributes(true);
      //FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo("%systemroot%\\Notepad.exe");
      AboutForm dlg = new AboutForm();


      foreach (Attribute attr in Attribute.GetCustomAttributes(asm)) {
        AssemblyTitleAttribute atrTitle = attr as AssemblyTitleAttribute;
        if (atrTitle != null) dlg.labelTitle.Text = atrTitle.Title;

        AssemblyDescriptionAttribute atrDesc = attr as AssemblyDescriptionAttribute;
        if (atrDesc != null) dlg.labelDesc.Text = atrDesc.Description;

        //AssemblyCompanyAttribute atrComp = attr as AssemblyCompanyAttribute;
        //if (atrComp != null) dlg.labelCopyright.Text = atrComp.Company;

        AssemblyFileVersionAttribute atrVer = attr as AssemblyFileVersionAttribute;
        if (atrVer != null) {
          Version ver = new Version(atrVer.Version);
          dlg.labelVersion.Text = string.Format("Version {0}.{1}.{2} ({3})", ver.Major, ver.Minor, ver.Build, ver.Revision); 
        }

        //AssemblyVersionAttribute atrVer = attr as AssemblyVersionAttribute;
        //if (atrVer != null) dlg.labelVersion.Text = atrVer.Version;

        AssemblyCopyrightAttribute atrCopy = attr as AssemblyCopyrightAttribute;
        if (atrCopy != null) dlg.labelCopyright.Text = atrCopy.Copyright;

      }

      dlg.BackColor = info.FormColor;
      dlg.Text = info.Title;
      dlg.picBox.Image = info.Logo;
      dlg.linkUrl = info.Url;
      dlg.labelWeb.Text = info.Url;
      dlg.ShowDialog();
    }

    private void labelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      if (!string.IsNullOrEmpty(linkUrl)) Process.Start(linkUrl);
    }
  }
}