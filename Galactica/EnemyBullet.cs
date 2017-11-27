using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    public class EnemyBullet : Bullet
    {
        public override void Initialize(Texture2D texture, Vector2 position, Quaternion trajectory, int speed)
        {
            BulletTexture = texture;

            Position = position;

            Trajectory = trajectory;

            BulletSpeed = speed;

            Active = true;
        }

        public override void Update()
        {
            Position.Y += BulletSpeed;

            if (this.Position.Y > 600)
            {
                this.Active = false;
            }
        }
    }
}
