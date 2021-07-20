using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
