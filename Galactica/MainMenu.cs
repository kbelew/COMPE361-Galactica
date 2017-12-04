using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Telerik.WinControls.UI;
using System.Linq;
using System.Windows.Forms;

namespace Galactica
{
    public partial class MainMenu : RadForm
    {
        public HighScore currHighScore;
        public List<HighScore> HighScores;
        public BindingSource CurrBindingSource = new BindingSource();

        public MainMenu()
        {
            InitializeComponent();

            HighScores = new List<HighScore>();
            
            string[] lines;

            try
            {
                lines = File.ReadAllLines("Content\\Assets\\HighScores.csv");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            foreach (var line in lines)
            {
                if (line.Equals("Player,Score,LevelReached"))
                {
                    continue;
                }
                var columns = line.Split(',');
                var currHighScore = new HighScore(columns[0],int.Parse(columns[1]),int.Parse(columns[2]));
                HighScores.Add(currHighScore);
            }

            //HighScores = HighScores.OrderByDescending((HighScore score1,HighScore score2) => score1.CompareTo(score2)).ToList();
            HighScores.Sort((score1, score2) => -1 * score1.CompareTo(score2)); //https://stackoverflow.com/questions/3062513/how-can-i-sort-generic-list-desc-and-asc

            foreach (var highScore in HighScores)
            {

                //ListViewItem item = new ListViewItem(new string[]{highScore.Name, highScore.Score.ToString(), highScore.LevelReached.ToString()});
                CurrBindingSource.Add(highScore);
                //Console.WriteLine(CurrBindingSource.);
            }

            
            HighScoreTable.DataSource = CurrBindingSource;

            
            //foreach (DataGridViewRow row in HighScoreTable.Rows)   //https://stackoverflow.com/questions/9581626/show-row-number-in-row-header-of-a-datagridview
            
            //{
            //    row.HeaderCell.Value = string.Format($"{row.Index + 1}");
            //}
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            
            this.Hide();

            using (var game = new Game1())
            {

                ((System.Windows.Forms.Form)FromHandle(game.Window.Handle)).Icon = new System.Drawing.Icon("Content\\Graphics\\PlayerShipIcon_002.ico");


                game.Run();
                NewHighScorePanel.Show();
                currHighScore = new HighScore("NA",Game1.playerScore,Game1.playerShip.PlayerLevel);

            }


            
            this.Show();
            //this.Focus();
            //ResetCursor();

        }

        private void Title_Click(object sender, System.EventArgs e)
        {

        }

        private void OptionsButton_Click(object sender, System.EventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void HighScoreTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewHighScoreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewHighScoreSubmitButton_Click(object sender, EventArgs e)
        {
            currHighScore.Name = NewHighScoreTextBox.Text;
            currHighScore.WriteToCsv("..\\..\\..\\..\\Content\\Assets\\HighScores.csv");
            NewHighScorePanel.Hide();
            HighScores.Add(currHighScore);
            CurrBindingSource.Add(currHighScore);
            HighScores.Sort((score1, score2) => -1 * score1.CompareTo(score2));
            CurrBindingSource.Clear();
            foreach (var highScore in HighScores)
            {

                
                CurrBindingSource.Add(highScore);
                
            }

        }
    }
}
