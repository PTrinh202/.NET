using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKHO.Utils;

namespace QLKHO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.DbName = ".Net_QLKho";
            DatabaseHelper.Severver = "localhost";
            DatabaseHelper.UserId = "sa";
            DatabaseHelper.password = "Abcdef@123";
            //
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI());
        }
    }
}
