using System;
using System.Windows.Forms;

namespace SimpleBudgeting
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
            Application.Run(new StartupPage());
            //syntax of sql server connection string
            //for windows auth.
            //@"Data Source=(machineName)\(instanceName);Initial Catalog=(DBname);Integrated Security = true;"





        }
    }
}
