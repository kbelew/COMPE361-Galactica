// Kevin Belew
// 818366010
// 12/8/17
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    /// <summary>
    /// The Abstract Ship class that is base to EnemyShip and PlayerShip
    /// </summary>
    public abstract class Ship : GameObject
    {

        // Is the Ship Reloading?

        public bool Reloading;

        // How quickly does the ship Reload?

        public float ReloadSpeed;

        // The TimeSpan of actual Reloading Time

        public TimeSpan ReloadTime;

        // The last time the Ship fired

        public TimeSpan LastFire;




        // Lives of Ship

        private int _health;

        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                {

                    _health = 0;
                }
                else
                {
                    _health = value;
                }
            }
            
        }

        // Speed at which Ship moves side to side

        public int StrafeSpeed;

        // Speed at which Ship moves forward or backward

        public int LateralSpeed;

        // Speed at which bullets move when fired

        public int BulletSpeed;

        
        /// <summary>
        /// Default Draw Method
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)

        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

        /// <summary>
        /// Assign values of Texture, Position, Parent game class, and gameTime when applicable.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="position"></param>
        /// <param name="game"></param>
        /// <param name="gameTime"></param>
        public abstract void Initialize(Texture2D texture, Vector2 position, GalagaGame game, GameTime gameTime = null);

        /// <summary>
        /// Update the Ship
        /// </summary>
        /// <param name="gameTime"></param>
        public abstract void Update(GameTime gameTime);

        /// <summary>
        /// Reload the Ship
        /// </summary>
        /// <param name="gameTime"></param>
        public abstract void Reload(GameTime gameTime);

        /// <summary>
        /// Fire Bullet
        /// </summary>
        public abstract void Fire();

    }
}
