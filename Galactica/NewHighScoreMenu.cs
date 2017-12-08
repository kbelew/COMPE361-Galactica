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
    public partial class NewHighScoreMenu : UserControl
    {
        public MainMenu ParentMainMenu;
        public NewHighScoreMenu()
        {
            InitializeComponent();
        }

        private void NewHighScoreMenu_Load(object sender, EventArgs e)
        {

        }

        private void NewHighScoreSubmitButton_Click(object sender, EventArgs e)
        {
            
            ParentMainMenu.UpdateHighScore();

        }

        private void NewHighScoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
