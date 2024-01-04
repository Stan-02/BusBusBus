using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }


    }

    class dbConnection
    {
        public string connectDB()
        {
            string connection = @"Data Source=jericho-garcia;Initial Catalog=SubUrbTicketingDB;Integrated Security=True";

            return connection;
         }
    }
}
