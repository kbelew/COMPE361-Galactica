// Kevin Belew
// 818366010
// 12/8/17
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Galactica
{
    /// <inheritdoc />
    /// <summary>
    /// Derived of abstract class Bullet, this is specific to the EnemyShips
    /// </summary>
    public class EnemyBullet : Bullet
    {
        /// <inheritdoc />
        /// <summary>
        /// Assign a Texture, Position, Trajectory, and Bullet Speed to the created Bullet.
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
        /// Move the Bullet, or set to inactive if off screen
        /// </summary>
        public override void Update()
        {
            Position.Y += BulletSpeed;

            if (Position.Y > 600)
            {
                Active = false;
            }
        }
    }
}
