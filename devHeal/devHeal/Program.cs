using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace devHeal
{
    static class Program
    {
        public static String connectn;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            connectn = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=G:\\DevHeal\\databaseDh.mdf;Integrated Security=True;Connect Timeout=30";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
