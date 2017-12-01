using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    public class PlayerBullet : Bullet
    {

        public override void Initialize(Texture2D texture, Vector2 position, Quaternion trajectory, int speed)
        {
            Texture = texture;

            Position = position;

            Trajectory = trajectory;

            BulletSpeed = speed;

            Active = true;
        }

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
