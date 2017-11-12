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
    public class Background
    {
        Texture2D StarTexture;

        Vector2 Position;

        int StarSpeed = 8;

        public bool Active;
        public void Initialize(Texture2D texture)
        {
            Random rand1 = new Random();
            int randSeed = rand1.Next(0, 1000000);

            Random rand2 = new Random(randSeed); // Using: https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp
            int randInt = 10 * rand2.Next(0, 49);

            Active = true;

            StarTexture = texture;

            Position = new Vector2(randInt, 5);
        }

        public void Update()
        {
            this.Position.Y += StarSpeed;
            if (this.Position.Y > 600)
            {
                this.Active = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(StarTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

       
    }
}
