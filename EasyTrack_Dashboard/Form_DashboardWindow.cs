using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Json;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EasyTrack_Dashboard
{
    public partial class Form_DashboardWindow : Form
    {
        public Form_DashboardWindow(UC_Campaign campaignElem)
        {
            InitializeComponent();

            summaryLabel_Click(null, null);
            this.campaignElem = campaignElem;
        }

        #region Variables
        private UC_Campaign campaignElem;
        private Thread summaryUpdateThread;
        #endregion


        private void summaryLabel_Click(object sender, EventArgs e)
        {
            summaryLabel.ForeColor = Color.Black;
            usersLabel.ForeColor = Color.White;
            surveysLabel.ForeColor = Color.White;
            exportLabel.ForeColor = Color.White;
            rootTabControl.SelectedTab = summaryTabPage;

            startLiveSummaryUpdateThread();
        }

        private void usersLabel_Click(object sender, EventArgs e)
        {
            summaryLabel.ForeColor = Color.White;
            usersLabel.ForeColor = Color.Black;
            surveysLabel.ForeColor = Color.White;
            exportLabel.ForeColor = Color.White;
            rootTabControl.SelectedTab = usersTabPage;

            stopLiveSummaryUpdateThread();
        }

        private void surveysLabel_Click(object sender, EventArgs e)
        {
            summaryLabel.ForeColor = Color.White;
            usersLabel.ForeColor = Color.White;
            surveysLabel.ForeColor = Color.Black;
            exportLabel.ForeColor = Color.White;
            rootTabControl.SelectedTab = surveysTabPage;

            stopLiveSummaryUpdateThread();
        }

        private void exportLabel_Click(object sender, EventArgs e)
        {
            summaryLabel.ForeColor = Color.White;
            usersLabel.ForeColor = Color.White;
            surveysLabel.ForeColor = Color.White;
            exportLabel.ForeColor = Color.Black;
            rootTabControl.SelectedTab = exportTabPage;

            stopLiveSummaryUpdateThread();
        }


        private void startLiveSummaryUpdateThread()
        {
            if (summaryUpdateThread != null && summaryUpdateThread.IsAlive)
                summaryUpdateThread.Abort();

            summaryUpdateThread = new Thread(async () =>
            {
                while (true)
                {
                    try
                    {
                        HttpResponseMessage result = await Tools.post(Tools.API_GET_CAMPAIGN_DQ_VALUES, new Dictionary<string, string>
                        {
                            { "username", Properties.Settings.Default.Username },
                            { "password", Properties.Settings.Default.Password },
                            { "campaign_id", campaignElem.CampaignId.ToString() }
                        });
                        if (result.IsSuccessStatusCode)
                        {
                            JsonObject resJson = (JsonObject)JsonValue.Parse(await result.Content.ReadAsStringAsync());
                            if (resJson.ContainsKey("result") && (ServerResult)int.Parse(resJson["result"].ToString()) == ServerResult.OK)
                            {
                                Dictionary<long, float> series = new Dictionary<long, float>();

                                long time = -360;
                                foreach (dynamic obj in resJson["last_6h_completeness"])
                                {
                                    series.Add(time, (float)obj.Value);
                                    time += 10;
                                    //series.Add(long.Parse(obj.Key), (float)obj.Value);
                                }

                                Tools.runOnUiThread(this, () =>
                                {
                                    DataTable dt = new DataTable();
                                    dt.Columns.Add("Time (mins ago)", typeof(double));
                                    dt.Columns.Add("Completeness", typeof(double));

                                    foreach (long key in series.Keys)
                                        dt.Rows.Add(key, series[key]);
                                    chart1.DataSource = dt;
                                    chart1.Series["Completeness"].XValueMember = "Time (mins ago)";
                                    chart1.Series["Completeness"].YValueMembers = "Completeness";
                                    chart1.Series["Completeness"].ChartType = SeriesChartType.Line;
                                    chart1.ChartAreas[0].AxisY.LabelStyle.Format = "";
                                });
                            }
                            else
                            {
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

            summaryUpdateThread.Start();
        }

        private void stopLiveSummaryUpdateThread()
        {
            if (summaryUpdateThread != null && summaryUpdateThread.IsAlive)
                summaryUpdateThread.Abort();
        }
    }
}
