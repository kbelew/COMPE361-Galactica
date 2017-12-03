using Telerik.WinControls.UI;

namespace Galactica
{
    public partial class MainMenu : RadForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            using (var game = new Game1())
            {
                game.Run();
                


            }

            
            this.Show();
            

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
