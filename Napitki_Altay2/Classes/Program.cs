using System;
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
            //if (Classes.InternetCheck.CheckConnection())
            //{
            //    Application.Run(new AuthForm());
            //}
            //else
            //    Application.Run(new NoInternetForm());
        }
    }
}
