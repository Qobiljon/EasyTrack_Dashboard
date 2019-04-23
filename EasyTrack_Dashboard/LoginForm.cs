using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Task<string> res = Tools.post(
                Tools.AUTHENTICATE_API,
                new Dictionary<string, string>
                {
                    { "username", usernameTextBox.Text },
                    { "password", passwordTextBox.Text }
                }
            );
            res.Start();
        }
    }
}
