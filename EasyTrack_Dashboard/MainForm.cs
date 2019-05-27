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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            moveBackToLoginForm = false;
            experimenterProfile.Username = Properties.Settings.Default.Username;
            experimenterProfile.ProfileType = Properties.Settings.Default.Type;
            logoutToolStripMenuItem.Text = $"Logout from [{experimenterProfile.Username}]";
        }

        #region Variables
        private bool moveBackToLoginForm;
        #endregion

        private void toggleFeaturesButton_Click(object sender, EventArgs e)
        {
            rootSplitContaner.Panel1Collapsed = !rootSplitContaner.Panel1Collapsed;
        }

        private void campaignsButton_Click(object sender, EventArgs e)
        {
            rootTabControl.SelectTab(campaignsTabPage.Name);
        }

        private void userStatsButton_Click(object sender, EventArgs e)
        {
            rootTabControl.SelectTab(userStatsTabPage.Name);
        }

        private void logsButton_Click(object sender, EventArgs e)
        {
            rootTabControl.SelectTab(logsTabPage.Name);
        }

        private void feedbacksButton_Click(object sender, EventArgs e)
        {
            rootTabControl.SelectTab(feedbacksTabPage.Name);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LoggedIn = false;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
            moveBackToLoginForm = true;
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!moveBackToLoginForm)
                DialogResult = DialogResult.Cancel;
        }
    }
}
