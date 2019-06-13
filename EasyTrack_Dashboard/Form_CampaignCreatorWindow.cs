using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Json;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    public partial class Form_CampaignCreatorWindow : Form
    {
        public Form_CampaignCreatorWindow()
        {
            InitializeComponent();

            dataSrcIcons = new Dictionary<string, Image>();
            rootTabControl.SelectedTab = campaignDetailsTabPage;
            loadCampaignManagersList();
            loadDataSources();
        }

        #region Variables
        private Dictionary<string, Image> dataSrcIcons;
        #endregion

        private void loadCampaignManagersList()
        {
            // Apply the current experimenter's details
            currentExperimenterProfile.ExperimenterUsername = Properties.Settings.Default.Username;
            currentExperimenterProfile.ExperimenterProfileType = Properties.Settings.Default.Type;
            campaignManagersPanel.Controls.Add(currentExperimenterProfile);
        }

        private void loadDataSources()
        {
            new Thread(async () =>
            {
                try
                {
                    HttpResponseMessage response = await Tools.post(Tools.API_GET_UNIQUE_DATA_SOURCES, new Dictionary<string, string>
                    {
                        { "username", Properties.Settings.Default.Username },
                        { "password", Properties.Settings.Default.Password },
                    });

                    if (response.IsSuccessStatusCode)
                    {
                        JsonObject resJson = (JsonObject)JsonValue.Parse(await response.Content.ReadAsStringAsync());
                        if (resJson.ContainsKey("result") && (ServerResult)int.Parse(resJson["result"].ToString()) == ServerResult.OK)
                        {
                            foreach (string key in resJson.Keys)
                                if (!key.Equals("result") && !dataSrcIcons.ContainsKey(key))
                                    using (var memStr = new MemoryStream(new WebClient().DownloadData($"{Tools.SERVER_URL}/{Tools.API_DOWNLOAD_DEVICE_ICON}/{key}")))
                                        dataSrcIcons[key] = Image.FromStream(memStr);
                            foreach (string key in resJson.Keys)
                                if (!key.Equals("result"))
                                    foreach (JsonObject dataSrc in resJson[key])
                                        Tools.runOnUiThread(this, () =>
                                        {
                                            UC_DataSource elem = new UC_DataSource()
                                            {
                                                DeviceName = dataSrc["device"],
                                                SourceName = dataSrc["source_name"],
                                                DataRate = dataSrc["data_rate"],
                                                SourceId = dataSrc["source_id"],
                                                DataSourceIcon = dataSrcIcons[key],
                                                Size = new Size(400, 72)
                                            };
                                            dataSourcesFlowLayoutPanel.Controls.Add(elem);
                                        });
                        }
                        else
                            throw new Exception($"Bad result from server. Content: {resJson.ToString()}");
                    }
                    else
                        throw new Exception($"Bad http result, status code {response.StatusCode}");
                }
                catch (IOException ex)
                {
                    Tools.runOnUiThread(this, () => { MessageBox.Show(this, $"Error occurred while loading unique data sources.\nReason: {ex.Message}", "Failed to load the data sources", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                }
            }).Start();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (rootTabControl.SelectedTab == campaignDetailsTabPage)
                checkCampaignDetailsAndMoveNext();
            else if (rootTabControl.SelectedTab == dataSourcesTabPage)
                checkDataSourcesAndMoveNext();
            else if (rootTabControl.SelectedTab == recruitingTabPage)
                checkRecruitmentAndMoveNext();
            else if (rootTabControl.SelectedTab == confirmDetailsTabPage)
                saveCampaign();
        }

        private void addParticipantButton_Click(object sender, EventArgs e)
        {
            Enabled = false;

            new Thread(async (participant_username) =>
            {
                HttpResponseMessage response = await Tools.post(Tools.API_CHECK_PARTICIPANT_AVAILABILITY, new Dictionary<string, string>
                {
                    { "username", Properties.Settings.Default.Username },
                    { "password", Properties.Settings.Default.Password },
                    { "participant_username", (string)participant_username }
                });

                if (response.IsSuccessStatusCode)
                {
                    JsonObject resJson = (JsonObject)JsonValue.Parse(await response.Content.ReadAsStringAsync());
                    if (resJson.ContainsKey("result") && (ServerResult)int.Parse(resJson["result"].ToString()) == ServerResult.OK && resJson["available"])
                        Tools.runOnUiThread(this, () =>
                        {
                            participantsListBox.Items.Add(newParticipantUsernameTextBox.Text);
                            newParticipantUsernameTextBox.Text = "";
                            Enabled = true;
                        });
                    else
                        Tools.runOnUiThread(this, () =>
                        {
                            MessageBox.Show(this, "User is either unavailable for recruitment, or doesn't exist!", "User is unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Enabled = true;
                        });
                }
                else
                    Tools.runOnUiThread(this, () =>
                    {
                        MessageBox.Show(this, "User is either unavailable for recruitment, or doesn't exist!", "User is unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enabled = true;
                    });
            }).Start(newParticipantUsernameTextBox.Text);
        }

        private void checkRecruitmentAndMoveNext()
        {
            if (participantsListBox.Items.Count == 0)
                MessageBox.Show(this, "At least one participant needed for the campaign to be created!", "No participant added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                rootTabControl.SelectTab(rootTabControl.SelectedIndex + 1);
                proceedButton.Text = "Save";
            }
        }

        private void checkDataSourcesAndMoveNext()
        {
            confirmNameLabel.Text = campaignNameTextBox.Text;
            confirmDescriptionLabel.Text = campaignDescriptionTextBox.Text;
            confirmPeriodLabel.Text = $"{campaignStartDatePicker.Value.ToShortDateString()} ~ {campaignEndDatePicker.Value.ToShortDateString()}";
            confirmDataSourcesLabel.Text = "";
            for (int n = 0, count = 0; n < dataSourcesFlowLayoutPanel.Controls.Count; n++)
            {
                UC_DataSource elem = (UC_DataSource)dataSourcesFlowLayoutPanel.Controls[n];
                if (!elem.IsSelected)
                    continue;
                if (count == 4)
                {
                    confirmDataSourcesLabel.Text += "...";
                    break;
                }
                confirmDataSourcesLabel.Text += $"{(count == 0 ? "" : ",")}{elem.SourceName}";
                count++;
            }

            rootTabControl.SelectTab(rootTabControl.SelectedIndex + 1);
        }

        private void checkCampaignDetailsAndMoveNext()
        {
            rootTabControl.SelectTab(rootTabControl.SelectedIndex + 1);
        }

        private void saveCampaign()
        {
            long startDateSecs = (long)(campaignStartDatePicker.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds * 1000);
            long endDateSecs = (long)(campaignEndDatePicker.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds * 1000);
            JsonArray dataSrcsJson = new JsonArray();
            for (int n = 0; n < dataSourcesFlowLayoutPanel.Controls.Count; n++)
            {
                UC_DataSource elem = (UC_DataSource)dataSourcesFlowLayoutPanel.Controls[n];
                if (!elem.IsSelected)
                    continue;
                JsonObject json = new JsonObject();
                json.Add("device", elem.DeviceName);
                json.Add("source_name", elem.SourceName);
                json.Add("source_id", elem.SourceId);
                json.Add("data_rate", elem.DataRate);
                dataSrcsJson.Add(json);
            }
            string[] participants = new string[participantsListBox.Items.Count];
            for (int n = 0; n < participants.Length; n++)
                participants[n] = participantsListBox.GetItemText(participantsListBox.Items[n]);

            Enabled = false;
            new Thread(async (param) =>
            {
                string[] @params = (string[])param;
                try
                {
                    Dictionary<string, string> args = new Dictionary<string, string>()
                        {
                            { "username", Properties.Settings.Default.Username },
                            { "password", Properties.Settings.Default.Password },
                            { "campaign_name", @params[0] },
                            { "campaign_start_date", @params[1] },
                            { "campaign_end_date", @params[2] },
                            { "campaign_description", @params[3] },
                            { "campaign_data_sources_json", @params[4] },
                            { "participants", @params[5] }
                        };

                    HttpResponseMessage response = await Tools.post(Tools.API_CREATE_CAMPAIGN, args, null);
                    if (response.IsSuccessStatusCode)
                    {
                        JsonValue resJson = JsonValue.Parse(await response.Content.ReadAsStringAsync());
                        if (resJson.ContainsKey("result"))
                        {
                            ServerResult resCode = (ServerResult)int.Parse(resJson["result"].ToString());
                            if (resCode == ServerResult.OK)
                                Tools.runOnUiThread(this, () =>
                                {
                                    MessageBox.Show(this, $"Campaign \"{campaignNameTextBox.Text}\" has been successfully created under your ({Properties.Settings.Default.Username}) profile!", "Campaign created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Enabled = true;
                                });
                            else
                            {
                                Thread.Sleep(2000);

                                Tools.runOnUiThread(this, () =>
                                {
                                    MessageBox.Show(this, "Failed to create the campaign!", "Failed to create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    MessageBox.Show(resJson.ToString());
                                    Enabled = true;
                                });
                            }
                        }
                        else
                            Tools.runOnUiThread(this, () =>
                            {
                                MessageBox.Show(this, "Unknown error occurred, please refer to the developer of this application!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Enabled = true;
                            });
                    }
                    else
                        throw new Exception($"Post request response: {response.StatusCode.ToString()}");
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.ToString());
                    Tools.runOnUiThread(this, () =>
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show(this, "Failed to connect to server, plase check your internet connection!", "Connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enabled = true;
                    });
                }
            }).Start(new string[] {
                campaignNameTextBox.Text,
                startDateSecs.ToString(),
                endDateSecs.ToString(),
                campaignDescriptionTextBox.Text,
                dataSrcsJson.ToString(),
                string.Join(",", participants)
            });
        }
    }
}
