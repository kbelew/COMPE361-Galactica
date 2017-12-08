// Kevin Belew
// 818366010
// 12/8/17
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    /// <summary>
    /// The Bullet Type GameObject that the Player shoots
    /// </summary>
    public class PlayerBullet : Bullet
    {
        /// <summary>
        /// Assign the Texture, Position, Trajectory, and Bullet Speed to the Bullet.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="position"></param>
        /// <param name="trajectory"></param>
        /// <param name="speed"></param>
        public override void Initialize(Texture2D texture, Vector2 position, Quaternion trajectory, int speed)
        {
            Texture = texture;

            Position = position;

            Trajectory = trajectory;

            BulletSpeed = speed;

            Active = true;
        }

        /// <summary>
        /// Move the bullet, if the bullet is off screen deactivate it.
        /// </summary>
        public override void Update()
        {
            Position.Y -= BulletSpeed;

            if (Position.Y < 0)
            {
                Active = false;
            }
        }
    }
}
