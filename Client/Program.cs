using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                await Coordinator.Instance.OpenLoginForm();
                Application.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne moze da se konektuje na server." + ex.Message);
            }
        }
    }
}
