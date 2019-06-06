using System;
using System.Collections.Generic;
using System.Json;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            moveBackToLoginForm = false;
            experimenterProfile.ExperimenterUsername = Properties.Settings.Default.Username;
            experimenterProfile.ExperimenterProfileType = Properties.Settings.Default.Type;
            logoutToolStripMenuItem.Text = $"Logout from [{experimenterProfile.ExperimenterUsername}]";
            participantProfileElems = new Dictionary<string, ParticipantProfile>();
            startLiveUserTrackingToolStripMenuItem.PerformClick();
            loadCampaignsList();
            rootTabControl.SelectedTab = campaignsTabPage;
        }

        #region Variables
        private bool moveBackToLoginForm;
        private Thread participateStatsUpdateThread;
        private Dictionary<string, ParticipantProfile> participantProfileElems;
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
            stopLiveUserTrackingToolStripMenuItem.PerformClick();
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

        private void startLiveUserTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (participateStatsUpdateThread != null && participateStatsUpdateThread.IsAlive)
                participateStatsUpdateThread.Abort();

            participateStatsUpdateThread = new Thread(async () =>
            {
                while (true)
                {
                    try
                    {
                        HttpResponseMessage result = await Tools.post(Tools.API_GET_PARTICIPANT_LIST, new Dictionary<string, string>
                        {
                            { "username", Properties.Settings.Default.Username },
                            { "password", Properties.Settings.Default.Password }
                        });
                        if (result.IsSuccessStatusCode)
                        {
                            JsonObject resJson = (JsonObject)JsonValue.Parse(await result.Content.ReadAsStringAsync());
                            if (resJson.ContainsKey("result") && (ServerResult)int.Parse(resJson["result"].ToString()) == ServerResult.OK)
                                foreach (JsonValue data in resJson["participants"])
                                {
                                    string username = data["username"].ToString();
                                    username = username.Substring(1, username.Length - 2);
                                    uint lastSyncMinsAgo = uint.Parse(data["last_synced_timestamp"].ToString());
                                    Tools.runOnUiThread(this, () =>
                                    {
                                        if (!participantProfileElems.ContainsKey(username))
                                        {
                                            ParticipantProfile profile = new ParticipantProfile();
                                            profile.Dock = DockStyle.Top;
                                            Control topBar = userStatsPanel.Controls[0];
                                            userStatsPanel.Controls.RemoveAt(0);
                                            userStatsPanel.Controls.Add(profile);
                                            userStatsPanel.Controls.Add(topBar);

                                            participantProfileElems[username] = profile;
                                        }

                                        participantProfileElems[username].ParticipantUsername = username;
                                        participantProfileElems[username].ParticipantIsActive = lastSyncMinsAgo < 360;
                                        participantProfileElems[username].ParticipantLastSyncTime = lastSyncMinsAgo < 2 ? "syncing now" : $"{lastSyncMinsAgo} mins ago";
                                        participantProfileElems[username].ParticipantAmountOfData = $"{(lastSyncMinsAgo > 360 ? '=' : '+')}{data["amount_of_data"].ToString()} samples";
                                    });
                                }
                            else
                            {
                                logoutToolStripMenuItem.PerformClick();
                                throw new Exception($"Bad result from server. Content: {resJson.ToString()}");
                            }
                        }
                        else
                        {
                            Application.Exit();
                            throw new Exception($"Bad http result, status code {result.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            Tools.runOnUiThread(this, () => { MessageBox.Show(this, $"Error occurred while loading user's list.\nReason: {ex.Message}", "Failed to load the user list", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                        }
                        catch
                        {

                        }
                    }
                    Thread.Sleep(3000);
                }
            });

            participateStatsUpdateThread.Start();
        }

        private void stopLiveUserTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (participateStatsUpdateThread != null && participateStatsUpdateThread.IsAlive)
                participateStatsUpdateThread.Abort();
        }

        private void createNewCampaignButton_Click(object sender, EventArgs e)
        {
            CampaignCreatorForm form = new CampaignCreatorForm();
            if (form.ShowDialog() == DialogResult.OK) { }
        }

        private void createNewCampaignButton_Click_1(object sender, EventArgs e)
        {
            CampaignCreatorForm form = new CampaignCreatorForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void loadCampaignsList()
        {
            new Thread(async () =>
            {
                try
                {
                    HttpResponseMessage response = await Tools.post(Tools.API_GET_CAMPAIGNS, new Dictionary<string, string>
                    {
                        { "username", Properties.Settings.Default.Username },
                        { "password", Properties.Settings.Default.Password },
                    });

                    if (response.IsSuccessStatusCode)
                    {
                        JsonObject resJson = (JsonObject)JsonValue.Parse(await response.Content.ReadAsStringAsync());
                        if (resJson.ContainsKey("result") && (ServerResult)int.Parse(resJson["result"].ToString()) == ServerResult.OK)
                        {
                            foreach (JsonObject dataSrc in resJson["campaigns"])
                            {
                                Tools.runOnUiThread(this, () =>
                                {
                                    DataSourceElement elem = new DataSourceElement();
                                    elem.DeviceName = dataSrc["device"];
                                    elem.SourceName = dataSrc["source_name"];
                                    elem.Tag = dataSrc["source_id"];
                                    elem.Dock = DockStyle.Top;
                                    campaignsPanel.Controls.Add(elem);
                                });
                            }
                        }
                        else
                            throw new Exception($"Bad result from server. Content: {resJson.ToString()}");
                    }
                    else
                        throw new Exception($"Bad http result, status code {response.StatusCode}");
                }
                catch (Exception ex)
                {
                    try
                    {
                        Tools.runOnUiThread(this, () => { MessageBox.Show(this, $"Error occurred while loading campaigns list.\nReason: {ex.Message}", "Failed to load the user list", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                    }
                    catch
                    {

                    }
                }
            }).Start();
        }
    }
}
