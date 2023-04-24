using DocumentFormat.OpenXml.Drawing.Charts;
using Napitki_Altay2.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napitki_Altay2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
            if (Classes.InternetCheck.CheckConnection())
            {
                Application.Run(new AuthForm());
            }
            else
                Application.Run(new NoInternetForm());
        }
    }
}
