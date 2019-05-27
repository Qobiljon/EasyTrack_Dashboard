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
                    form = form == null || form is AuthenticationForm ? (Form)new MainForm() : new AuthenticationForm();
                    Application.Run(form);
                } while (form.DialogResult == DialogResult.OK);
            }
            else
            {
                Form form = null;
                do
                {
                    form = form == null || form is MainForm ? (Form)new AuthenticationForm() : new MainForm();
                    Application.Run(form);
                } while (form.DialogResult == DialogResult.OK);
            }
        }
    }
}
