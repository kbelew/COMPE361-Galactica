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

                ((System.Windows.Forms.Form)FromHandle(game.Window.Handle)).Icon = new System.Drawing.Icon("Content\\Graphics\\PlayerShipIcon_002.ico");


                game.Run();
                


            }

            
            this.Show();
            this.Focus();

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
