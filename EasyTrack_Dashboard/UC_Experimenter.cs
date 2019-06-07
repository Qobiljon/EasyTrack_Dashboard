using System.Windows.Forms;

namespace EasyTrack_Dashboard
{
    public partial class UC_Experimenter : UserControl
    {
        public UC_Experimenter()
        {
            InitializeComponent();
        }

        public string ExperimenterUsername { set { usernameLabel.Text = value; } get { return usernameLabel.Text; } }
        public string ExperimenterProfileType { set { typeLabel.Text = value; } get { return typeLabel.Text; } }
    }
}
