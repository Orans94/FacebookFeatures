using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;




// $G$ THE-001 (-11) your grade on diagrams document - 89. please see comments inside the document. (50% of your grade).


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
