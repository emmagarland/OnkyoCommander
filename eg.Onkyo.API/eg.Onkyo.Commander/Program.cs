using System;
using System.Windows.Forms;
using eg.Onkyo.Commander.Properties;

namespace eg.Onkyo.Commander
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the Onkyo Commander application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OnkyoCommander());
        }
    }
}
