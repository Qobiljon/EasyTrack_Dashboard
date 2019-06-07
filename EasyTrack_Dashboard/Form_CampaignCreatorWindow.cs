using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Json;
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

            rootTabControl.SelectedTab = campaignDetailsTabPage;
            loadCampaignManagersList();
            loadDataSources();
        }

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
                            foreach (JsonObject dataSrc in resJson["sources"])
                            {
                                Tools.runOnUiThread(this, () =>
                                {
                                    UC_DataSource elem = new UC_DataSource();
                                    elem.DeviceName = dataSrc["device"];
                                    elem.SourceName = dataSrc["source_name"];
                                    elem.DataRate = dataSrc["data_rate"];
                                    elem.Tag = dataSrc["source_id"];
                                    dataSourcesFlowLayoutPanel.Controls.Add(elem);
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
                        Tools.runOnUiThread(this, () => { MessageBox.Show(this, $"Error occurred while loading unique data sources.\nReason: {ex.Message}", "Failed to load the user list", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                    }
                    catch
                    {

                    }
                }
            }).Start();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (rootTabControl.SelectedTab == campaignDetailsTabPage)
                rootTabControl.SelectTab(rootTabControl.SelectedIndex + 1);
            else if (rootTabControl.SelectedTab == dataSourcesTabPage)
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
                }

                rootTabControl.SelectTab(rootTabControl.SelectedIndex + 1);
            }
            else if (rootTabControl.SelectedTab == confirmDetailsTabPage)
            {
                Enabled = false;
                new Thread(async () =>
                {
                    try
                    {
                        JsonArray dataSrcsJson = new JsonArray();

                        for (int n = 0; n < dataSourcesFlowLayoutPanel.Controls.Count; n++)
                        {
                            UC_DataSource elem = (UC_DataSource)dataSourcesFlowLayoutPanel.Controls[n];
                            if (!elem.IsSelected)
                                continue;

                            JsonObject json = new JsonObject(new KeyValuePair<string, JsonValue>("source_id", (JsonValue)elem.Tag));
                            json.Add("device", elem.DeviceName);
                            json.Add("source_name", elem.SourceName);
                            json.Add("data_rate", elem.DataRate);
                            dataSrcsJson.Add(json);
                        }
                        long startDateSecs = (long)(campaignStartDatePicker.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds * 1000);
                        long endDateSecs = (long)(campaignEndDatePicker.Value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds * 1000);

                        Dictionary<string, string> args = new Dictionary<string, string>()
                        {
                            { "username", Properties.Settings.Default.Username },
                            { "password", Properties.Settings.Default.Password },
                            { "campaign_name", campaignNameTextBox.Text },
                            { "campaign_start_date", startDateSecs.ToString() },
                            { "campaign_end_date", endDateSecs.ToString() },
                            { "campaign_description", campaignDescriptionTextBox.Text },
                            { "campaign_data_sources_json", dataSrcsJson.ToString() }
                        };

                        HttpResponseMessage response = await Tools.post(Tools.API_CREATE_CAMPAIGN, args, null);
                        if (response.IsSuccessStatusCode)
                        {
                            JsonValue resJson = JsonValue.Parse(await response.Content.ReadAsStringAsync());
                            if (resJson.ContainsKey("result"))
                            {
                                ServerResult resCode = (ServerResult)int.Parse(resJson["result"].ToString());
                                if (resCode == ServerResult.OK)
                                {
                                    Tools.runOnUiThread(this, () =>
                                    {
                                        MessageBox.Show(this, $"Campaign \"{campaignNameTextBox.Text}\" has been successfully created under your ({Properties.Settings.Default.Username}) profile!", "Campaign created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Enabled = true;
                                    });
                                }
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
                            {
                                Tools.runOnUiThread(this, () =>
                                {
                                    MessageBox.Show(this, "Unknown error occurred, please refer to the developer of this application!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Enabled = true;
                                });
                            }
                        }
                        else
                            throw new Exception($"Post request response: {response.StatusCode.ToString()}");
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex.ToString());
                        Tools.runOnUiThread(this, () =>
                        {
                            MessageBox.Show(this, "Failed to connect to server, plase check your internet connection!", "Connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Enabled = true;
                        });
                    }
                }).Start();
            }
        }
    }
}
