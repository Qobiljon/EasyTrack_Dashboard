using System;
using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    public partial class ParticipantProfile : UserControl
    {
        public ParticipantProfile()
        {
            InitializeComponent();
        }
        
        public bool ParticipantIsActive
        {
            set
            {
                labelParticipantStatus.Image = value ? Properties.Resources.green_dot : Properties.Resources.red_dot;
                labelParticipantStatus.Image.Tag = value;
            }
            get
            {
                return (bool)labelParticipantStatus.Image.Tag;
            }
        }
        public string ParticipantUsername { set { labelParticipantUsername.Text = value; } get { return labelParticipantUsername.Text; } }
        public string ParticipantLastSyncTime { set { labelParticipantLastSyncTime.Text = value; } get { return labelParticipantUsername.Text; } }
        public string ParticipantAmountOfData
        {
            set
            {
                if (value[0] == '+')
                    labelParticipantAmountOfData.Image = Properties.Resources.arrow_up;
                else if (value[0] == '=')
                    labelParticipantAmountOfData.Image = Properties.Resources.arrow_right;
                else if (value[0] == '=')
                    labelParticipantAmountOfData.Image = Properties.Resources.arrow_down;
                else
                    labelParticipantAmountOfData.Image = null;

                labelParticipantAmountOfData.Text = value.Substring(1);
                labelParticipantAmountOfData.Tag = value;
            }
            get
            {
                return (string)labelParticipantAmountOfData.Tag;
            }
        }
    }
}
