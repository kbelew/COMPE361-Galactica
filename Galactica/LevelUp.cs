// Kevin Belew
// 818366010
// 12/8/17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    /// <summary>
    /// The Poweup type GameObject that when picked up provides a Level Up
    /// </summary>
    public class LevelUp : PowerUp
    {
        /// <summary>
        /// Assign the Texture and Position to the PowerUp
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="position"></param>
        public override void Initialize(Texture2D texture, Vector2 position)
        {
            Active = true;
            Texture = texture;
            Position = position;
            MoveSpeed = 3;
        }

        /// <summary>
        /// Move the PowerUp Down
        /// </summary>
        public override void Update()
        {
            Position.Y += MoveSpeed;
        }
    }
}
