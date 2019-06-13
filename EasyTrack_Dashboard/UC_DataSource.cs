using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    public partial class UC_DataSource : UserControl
    {
        public UC_DataSource()
        {
            InitializeComponent();
        }

        public string SourceName { set { labelSourceName.Text = value; } get { return labelSourceName.Text; } }
        public int SourceId { set; get; }
        public string DeviceName { set { labelDeviceName.Text = value; } get { return labelDeviceName.Text; } }
        public bool IsSelected { get { return dataSrcCheckBox.Checked; } }
        public Image DataSourceIcon { get { return dataSrcIconLabel.Image; } set { dataSrcIconLabel.Image = value; } }
        public int DataRate
        {
            get
            {
                return dataRateTextBox.TextLength == 0 || int.Parse(dataRateTextBox.Text) < 10 ? 10 : int.Parse(dataRateTextBox.Text);
            }
            set
            {
                dataRateTextBox.Text = value.ToString();
            }
        }

        private void dataSrcCheckToggle_Click(object sender, EventArgs e)
        {
            dataSrcCheckBox.Checked = !dataSrcCheckBox.Checked;
            BackColor = dataSrcCheckBox.Checked ? Color.FromName("Info") : Color.FromName("Control");
            dataRateTextBox.Enabled = IsSelected;
        }

        private void dataRateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(dataRateTextBox.Text, "[^0-9]"))
                dataRateTextBox.Text = "";
        }

        private void dataSrcCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataRateTextBox.Enabled = dataSrcCheckBox.Checked;
        }
    }
}
