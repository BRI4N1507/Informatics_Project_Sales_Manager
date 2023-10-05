using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DH52005810.ChucNangLogin;


namespace DH52005810
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

            ChucNangLogin a = new ChucNangLogin();
            a.ReadFileUser();
            Application.Run(new formlogin());
        }
    }
}
