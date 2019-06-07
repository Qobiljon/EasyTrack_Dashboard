using System;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
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
            if (Properties.Settings.Default.LoggedIn)
            {
                Form form = null;
                do
                {
                    form = form == null || form is Form_AuthenticationWindow ? (Form)new Form_MainWindow() : new Form_AuthenticationWindow();
                    Application.Run(form);
                } while (form.DialogResult == DialogResult.OK);
            }
            else
            {
                Form form = null;
                do
                {
                    form = form == null || form is Form_MainWindow ? (Form)new Form_AuthenticationWindow() : new Form_MainWindow();
                    Application.Run(form);
                } while (form.DialogResult == DialogResult.OK);
            }
        }
    }
}
