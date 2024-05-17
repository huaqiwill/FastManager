using ProgramBox.UI;
using System;
using System.Windows.Forms;
using ProgramBox.Utils;
using System.Collections.Generic;

namespace ProgramBox
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            App.ProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMain());
        }
    }
}
