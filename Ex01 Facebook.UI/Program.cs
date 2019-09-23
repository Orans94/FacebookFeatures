using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ex01_Facebook.UI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UIManager ui = new UIManager();
            ui.Run();
        }
    }
}
