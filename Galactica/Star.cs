// Kevin Belew
// 818366010
// 12/8/17
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    /// <summary>
    /// The GameObject that is each star in the background of the game.
    /// </summary>
    public class Star : GameObject
    {
       
        // How quickly the stars move past

        int StarSpeed = 8;

        /// <summary>
        /// Assign the Texture and Position to the star. This creates Stars very rapidly at random locations just above the screen, then they
        /// move down the screen and die at the end.
        /// </summary>
        /// <param name="texture"></param>
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

        /// <summary>
        /// Move Star down or deactivate if off screen.
        /// </summary>
        public void Update()
        {
            Position.Y += StarSpeed;
            if (Position.Y > 600)
            {
                Active = false;
            }
        }

        /// <summary>
        /// Default Draw method of this GameObject.
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

       
    }
}
