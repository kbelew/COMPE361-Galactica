// Kevin Belew
// 818366010
// 12/8/17
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    /// <summary>
    /// Abstract Bullet class for both PlayerShip and EnemyShips
    /// </summary>
    public abstract class Bullet : GameObject
    {
        // Unused but could dictate the trajectory of bullets flying at angles.
        public Quaternion Trajectory;

        
        
        
        // How fast the bullet moves forward
        public int BulletSpeed;

        
        /// <summary>
        /// Standard Draw method across GameObjects
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)

        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            
        }

        /// <summary>
        /// Assign a Texture, Position, Trajectory, and Bullet Speed to the created Bullet.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="position"></param>
        /// <param name="trajectory"></param>
        /// <param name="speed"></param>
        public abstract void Initialize(Texture2D texture, Vector2 position, Quaternion trajectory, int speed);

        /// <summary>
        /// The abstract Update method of Bullets.
        /// </summary>
        public abstract void Update();


    }
}
