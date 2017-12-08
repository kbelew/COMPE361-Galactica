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
    /// The Poweup type GameObject that when picked up provides an Extra Life
    /// </summary>
    public class ExtraLife : PowerUp
    {
        /// <summary>
        /// Assign the Texture and Position of the PowerUp.
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
        /// Move the PowerUp
        /// </summary>
        public override void Update()
        {
            if (Position.Y > 600)
            {
                this.Active = false;
            }
            else
            {
                Position.Y += MoveSpeed;
            }
        }
    }
}
