using System;
using System.Collections.Generic;
using System.Json;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    public partial class Form_MainWindow : Form
    {
        public Form_MainWindow()
        {
            InitializeComponent();

            moveBackToLoginForm = false;

            experimenterProfile.ExperimenterUsername = Properties.Settings.Default.Username;
            experimenterProfile.ExperimenterProfileType = Properties.Settings.Default.Type;

            logoutToolStripMenuItem.Text = $"Logout from [{experimenterProfile.ExperimenterUsername}]";

            participantProfileElems = new Dictionary<string, UC_Participant>();
            startLiveUserTrackingToolStripMenuItem.PerformClick();

            campaignElems = new Dictionary<int, UC_Campaign>();
            startLiveCampaignTrackingToolStripMenuItem.PerformClick();

            rootTabControl.SelectedTab = campaignsTabPage;
        }

        #region Variables
        private bool moveBackToLoginForm;
        private Thread participantStatsUpdateThread;
        private Dictionary<string, UC_Participant> participantProfileElems;
        private Thread campaignsListUpdateThread;
        private Dictionary<int, UC_Campaign> campaignElems;
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
            if (participantStatsUpdateThread != null && participantStatsUpdateThread.IsAlive)
                participantStatsUpdateThread.Abort();

            participantStatsUpdateThread = new Thread(async () =>
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
                            {
                                foreach (JsonValue data in resJson["participants"])
                                {
                                    string username = data["username"].ToString();
                                    username = username.Substring(1, username.Length - 2);
                                    uint lastSyncMinsAgo = uint.Parse(data["last_synced_timestamp"].ToString());
                                    Tools.runOnUiThread(this, () =>
                                    {
                                        if (!participantProfileElems.ContainsKey(username))
                                        {
                                            UC_Participant profile = new UC_Participant();
                                            profile.Dock = DockStyle.Top;
                                            userStatsPanel.Controls.Add(profile);

                                            participantProfileElems[username] = profile;
                                        }

                                        participantProfileElems[username].ParticipantUsername = username;
                                        participantProfileElems[username].ParticipantIsActive = lastSyncMinsAgo < 360;
                                        participantProfileElems[username].CampaignName = data["campaign_name"];
                                        participantProfileElems[username].ParticipantLastSyncTime = lastSyncMinsAgo < 2 ? "syncing now" : $"{lastSyncMinsAgo} mins ago";
                                        participantProfileElems[username].ParticipantAmountOfData = $"{(lastSyncMinsAgo > 360 ? '=' : '+')}{data["amount_of_data"].ToString()} samples";
                                    });
                                }
                                Tools.runOnUiThread(this, () => { userStatsPanel.Controls.Remove(topUsersDescrPanel); userStatsPanel.Controls.Add(topUsersDescrPanel); });
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

            participantStatsUpdateThread.Start();
        }

        private void stopLiveUserTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (participantStatsUpdateThread != null && participantStatsUpdateThread.IsAlive)
                participantStatsUpdateThread.Abort();
        }

        private void startLiveCampaignTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (campaignsListUpdateThread != null && campaignsListUpdateThread.IsAlive)
                campaignsListUpdateThread.Abort();

            campaignsListUpdateThread = new Thread(async () =>
            {
                while (true)
                {
                    try
                    {
                        HttpResponseMessage result = await Tools.post(Tools.API_GET_CAMPAIGNS, new Dictionary<string, string>
                        {
                            { "username", Properties.Settings.Default.Username },
                            { "password", Properties.Settings.Default.Password }
                        });
                        if (result.IsSuccessStatusCode)
                        {
                            JsonObject resJson = (JsonObject)JsonValue.Parse(await result.Content.ReadAsStringAsync());
                            if (resJson.ContainsKey("result") && (ServerResult)int.Parse(resJson["result"].ToString()) == ServerResult.OK)
                            {
                                foreach (JsonValue data in resJson["campaigns"])
                                {
                                    int campaign_id = data["campaign_id"];
                                    Tools.runOnUiThread(this, () =>
                                    {
                                        if (!campaignElems.ContainsKey(campaign_id))
                                        {
                                            UC_Campaign campaign = new UC_Campaign();
                                            campaign.Dock = DockStyle.Top;
                                            campaignsPanel.Controls.Add(campaign);

                                            campaignElems[campaign_id] = campaign;
                                            campaignElems[campaign_id].addDetailsClickHandler((snd, evt) =>
                                            {
                                                Form_DashboardWindow form = new Form_DashboardWindow((UC_Campaign)((Button)snd).Parent);
                                                form.ShowDialog(this);
                                            });
                                        }

                                        campaignElems[campaign_id].CampaignId = campaign_id;
                                        campaignElems[campaign_id].CampaignOwner = data["campaign_owner"];
                                        campaignElems[campaign_id].CampaignName = data["campaign_name"];
                                        campaignElems[campaign_id].CampaignStartDate = data["campaign_start_date"];
                                        campaignElems[campaign_id].CampaignEndDate = data["campaign_end_date"];
                                        campaignElems[campaign_id].checkUpdateStatus();
                                        campaignElems[campaign_id].CampaignDescription = data["campaign_description"];
                                        campaignElems[campaign_id].CampaignParticipantsCount = data["campaign_participants"];
                                        foreach (JsonObject obj in JsonValue.Parse(data["campaign_data_sources"].ToString()))
                                            campaignElems[campaign_id].addDataSource(obj["source_id"], obj["source_name"], obj["device"], obj["data_rate"]);
                                    });
                                }
                                Tools.runOnUiThread(this, () => { campaignsPanel.Controls.Remove(topCampaignDescrPanel); campaignsPanel.Controls.Add(topCampaignDescrPanel); });
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
                            Tools.runOnUiThread(this, () => { MessageBox.Show(this, $"Error occurred while loading the list of your campaigns.\nReason: {ex.Message}", "Failed to load the user list", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                        }
                        catch
                        {

                        }
                    }
                    Thread.Sleep(60000);
                }
            });

            campaignsListUpdateThread.Start();
        }

        private void stopLiveCampaignTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (campaignsListUpdateThread != null && campaignsListUpdateThread.IsAlive)
                campaignsListUpdateThread.Abort();
        }

        private void createNewCampaignButton_Click(object sender, EventArgs e)
        {
            Form_CampaignCreatorWindow form = new Form_CampaignCreatorWindow();
            if (form.ShowDialog() == DialogResult.OK) { }
        }

        private void createNewCampaignButton_Click_1(object sender, EventArgs e)
        {
            Form_CampaignCreatorWindow form = new Form_CampaignCreatorWindow();
            if (form.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void feedbackLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:easytracl_support@googlegroups.com");
        }
    }
}
