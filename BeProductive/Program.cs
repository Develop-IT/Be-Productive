using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeProductive
{
    static class Program
    {
        public static string mainPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(Path.Combine(mainPath,"configuration.beproductive")))
            {
                Application.Run(new frmIsLogged());
            }
            else
            {
                Application.Run(new frmLogin());
            }
            
        }
    }
}
