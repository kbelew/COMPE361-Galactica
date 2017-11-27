using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    abstract class Ship
    {

        // Animation representing the player

        public Texture2D ShipTexture;



        // Position of the Player relative to the upper left side of the screen

        public Vector2 Position;

        public bool Reloading;

        public float ReloadSpeed;

        public TimeSpan CurrentFire;

        public TimeSpan LastFire;

        // State of the player

        public bool Active;



        // Amount of hit points that player has

        public int Health;



        // Get the width of the player ship

        public int Width => ShipTexture.Width;


        // Get the height of the player ship

        public int Height => ShipTexture.Height;

        public int StrafeSpeed;

        public int LateralSpeed;

        public int BulletSpeed;


        public void Draw(SpriteBatch spriteBatch)

        {
            spriteBatch.Draw(ShipTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

        public abstract void Initialize(Texture2D texture, Vector2 position);

        public abstract void Update(GameTime gameTime);

        public abstract void Reload(GameTime gameTime);

        public abstract void Fire();

    }
}
