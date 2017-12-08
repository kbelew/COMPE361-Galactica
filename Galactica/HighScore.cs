// Kevin Belew
// 818366010
// 12/8/17
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    /// <summary>
    /// This is the Highscore Object which holds the Name, score and level reached of the player.
    /// </summary>
    public class HighScore : IComparable<HighScore>
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int LevelReached { get; set; }

        public HighScore(string name, int score, int levelReached)
        {
            Name = name;
            Score = score;
            LevelReached = levelReached;
        }

        /// <summary>
        /// Compare two Highscores, first by Score then by level reached
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(HighScore other)
        {
            if (this.Score - other.Score == 0)
            {
                return this.LevelReached - other.LevelReached;
            }
            else
            {
                return this.Score - other.Score;
            }
        }

        /// <summary>
        /// This ToString is to help load these HighScores into a csv
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name},{Score},{LevelReached}";
        }

        /// <summary>
        /// Write Highscore to the end of a csv
        /// </summary>
        /// <param name="filePath"></param>
        public void WriteToCsv(string filePath)
        {
            //File.OpenWrite(filePath);
            File.AppendAllLines(filePath, new[] {this.ToString()});
        }
    }
}
