// Kevin Belew
// 818366010
// 12/8/17
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactica
{
    public partial class OptionsMenu : UserControl
    {
        public MainMenu MainMenuParent;

        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void OptionsMenu_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void DevModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DevModeCheckBox.Checked)
            {
                MainMenuParent.DeveloperModeEnabled = true;
            }
            else
            {
                MainMenuParent.DeveloperModeEnabled = false;
            }
        }

        private void OptionsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
