using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    public class Star : GameObject
    {
        //Texture2D Texture;

        //Vector2 Position;

        int StarSpeed = 8;

        //public bool Active;
        public void Initialize(Texture2D texture)
        {
            Random rand1 = new Random();
            int randSeed = rand1.Next(0, 1000000);

            Random rand2 = new Random(randSeed); // Using: https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp
            int randInt = 10 * rand2.Next(0, 49);

            Active = true;

            Texture = texture;

            Position = new Vector2(randInt, 5);
        }

        public void Update()
        {
            Position.Y += StarSpeed;
            if (Position.Y > 600)
            {
                Active = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

       
    }
}
