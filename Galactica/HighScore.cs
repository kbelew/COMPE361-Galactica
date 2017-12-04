using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
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
    }
}
