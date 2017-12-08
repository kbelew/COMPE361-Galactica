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
    /// The PowerUp Abstract Class
    /// </summary>
    public abstract class PowerUp : GameObject
    {
        // The speed at which the Powerup moves down

        public float MoveSpeed;

        /// <summary>
        /// The default Draw Method of this GameObject
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)

        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

        /// <summary>
        /// Assign at least Texture and Position
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="position"></param>
        public abstract void Initialize(Texture2D texture, Vector2 position);

        /// <summary>
        /// Update the PowerUp
        /// </summary>
        public abstract void Update();


    }
}
