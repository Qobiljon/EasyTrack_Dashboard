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

            campaignElems = new Dictionary<int, CampaignElement>(); ;
            startCampaignsListUpdateThread();

            rootTabControl.SelectedTab = campaignsTabPage;
        }

        #region Variables
        private bool moveBackToLoginForm;
        private Thread participantStatsUpdateThread;
        private Dictionary<string, ParticipantProfile> participantProfileElems;
        private Thread campaignsListUpdateThread;
        private Dictionary<int, CampaignElement> campaignElems;
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

            participantStatsUpdateThread.Start();
        }

        private void stopLiveUserTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (participantStatsUpdateThread != null && participantStatsUpdateThread.IsAlive)
                participantStatsUpdateThread.Abort();
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

        private void startCampaignsListUpdateThread()
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
                                foreach (JsonValue data in resJson["campaigns"])
                                {
                                    int campaign_id = data["campaign_id"];
                                    Tools.runOnUiThread(this, () =>
                                    {
                                        if (!campaignElems.ContainsKey(campaign_id))
                                        {
                                            CampaignElement campaign = new CampaignElement();
                                            campaign.Dock = DockStyle.Top;
                                            Control topBar = campaignsPanel.Controls[0];
                                            campaignsPanel.Controls.RemoveAt(0);
                                            campaignsPanel.Controls.Add(campaign);
                                            campaignsPanel.Controls.Add(topBar);

                                            campaignElems[campaign_id] = campaign;
                                            campaignElems[campaign_id].addDetailsClickHandler((snd, evt) =>
                                            {
                                                MessageBox.Show("Opening dashboard");
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
    }
}
