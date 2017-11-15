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
    public abstract class Bullet
    {
        public Quaternion Trajectory;

        public int Damage;

        public Texture2D BulletTexture;

        public Vector2 Position;

        public int BulletSpeed;

        public bool Active;

        public int Width => BulletTexture.Width;

        public int Height => BulletTexture.Height;

        public void Draw(SpriteBatch spriteBatch)

        {
            spriteBatch.Draw(BulletTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

        public abstract void Initialize(Texture2D texture, Vector2 position, Quaternion trajectory, int speed);

        public abstract void Update();


    }
}
