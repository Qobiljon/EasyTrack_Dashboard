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
        }

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
    }
}
