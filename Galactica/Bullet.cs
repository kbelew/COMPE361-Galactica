using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    public abstract class Bullet : GameObject
    {
        public Quaternion Trajectory;

        public int Damage;

        //public Texture2D Texture;

        //public Vector2 Position;

        public int BulletSpeed;

        //public bool Active;

        //public int Width => Texture.Width;

        //public int Height => Texture.Height;

        public void Draw(SpriteBatch spriteBatch)

        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

        public abstract void Initialize(Texture2D texture, Vector2 position, Quaternion trajectory, int speed);

        public abstract void Update();


    }
}
