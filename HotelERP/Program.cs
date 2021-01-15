using System;
using System.Windows.Forms;

namespace HotelERP
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
            Framework.StartUp();
            var form = (Form)Framework.provider.GetService(typeof(Login));
            Application.Run(form);
        }
    }
}
