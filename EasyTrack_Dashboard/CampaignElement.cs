using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    public partial class CampaignElement : UserControl
    {
        public CampaignElement()
        {
            InitializeComponent();

            campaignDataSources = new List<DataSource>();
            startTicks = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds * 1000);
            endTicks = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds * 1000);
        }

        #region Variables
        private List<DataSource> campaignDataSources;
        private long startTicks;
        private long endTicks;
        #endregion

        public int CampaignId { get; set; }
        public string CampaignOwner { get; set; }
        public string CampaignName { get { return campaignNameLabel.Text; } set { campaignNameLabel.Text = value; } }
        public long CampaignStartDate
        {
            get
            {
                return startTicks;
            }
            set
            {
                startTicks = value;
                DateTime startDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(((long)value) / 1000).ToLocalTime();
                campaignStartDateLabel.Text = $"{startDateTime.ToShortDateString()}\n{startDateTime.ToShortTimeString()}";
            }
        }
        public long CampaignEndDate
        {
            get
            {
                return endTicks;
            }
            set
            {
                endTicks = value;
                DateTime endDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(((long)value) / 1000).ToLocalTime();
                campaignEndDateLabel.Text = $"{endDateTime.ToShortDateString()}\n{endDateTime.ToShortTimeString()}";
            }
        }
        public string CampaignDescription { get; set; }
        public int CampaignParticipantsCount { get { return int.Parse(campaignParticipantsCountLabel.Text); } set { campaignParticipantsCountLabel.Text = value.ToString(); } }
        public DataSource[] CampaignDataSources { get { return campaignDataSources.ToArray(); } }

        public void addDataSource(int id, string name, string device, int dataRate)
        {
            DataSource dataSource = new DataSource();
            dataSource.SourceId = id;
            dataSource.SourceName = name;
            dataSource.Device = device;
            dataSource.DataRate = dataRate;
            campaignDataSources.Add(dataSource);
        }
        public void checkUpdateStatus()
        {
            long nowTicks = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds * 1000);
            if (startTicks <= nowTicks && nowTicks <= endTicks)
                campaignStatusLabel.Image = Properties.Resources.green_dot;
            else
                campaignStatusLabel.Image = Properties.Resources.red_dot;
        }
    }

    public class DataSource
    {
        public int SourceId { set; get; }
        public string SourceName { set; get; }
        public string Device { set; get; }
        public int DataRate { set; get; }
    }
}
