using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    public partial class DataSourceElement : UserControl
    {
        public DataSourceElement()
        {
            InitializeComponent();
        }

        public string SourceName { set { labelSourceName.Text = value; } get { return labelSourceName.Text; } }
        public string DeviceName { set { labelDeviceName.Text = value; } get { return labelDeviceName.Text; } }
        public bool IsSelected { get { return dataSrcCheckBox.Checked; } }
        public int DataRate
        {
            get
            {
                return dataRateTextBox.TextLength == 0 ? 0 : int.Parse(dataRateTextBox.Text);
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
