using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HelloWorld
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      MessageBox.Show("Hello, World!"); // it's a message for everyone
    }
  }
}
