// Tutorials at: https://blogs.msdn.microsoft.com/tarawalker/2012/12/10/windows-8-game-development-using-c-xna-and-monogame-3-0-building-a-shooter-game-walkthrough-part-2-creating-the-shooterplayer-asset-of-the-game/
// Helped me get started

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Galactica
{
    class PlayerShip : Ship
    {
        

        public int PlayerLevel;

        public override void Initialize(Texture2D texture, Vector2 position)

        {
            ShipTexture = texture;



            // Set the starting position of the player around the middle of the screen and to the back

            Position = position;



            // Set the player to be active

            Active = true;



            // Set the player health

            Health = 3;

            

            // Speed in which the PlayerShip moves side to side

            StrafeSpeed = 4;


            // Speed in which PlayerShip moves up and down

            LateralSpeed = 3;

            

            ReloadSpeed = 200f;

            BulletSpeed = 30;

            PlayerLevel = 1;

            Reloading = false;

            CurrentFire = TimeSpan.FromSeconds(60f / ReloadSpeed);

            LastFire = TimeSpan.Zero;
        }



        public override void Update(GameTime gameTime)

        {

            if (Health == 0) Dead();

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Position.X += StrafeSpeed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                Position.X -= StrafeSpeed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Position.Y -= LateralSpeed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Position.Y += LateralSpeed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                if (Reloading == false)
                {
                    Fire();
                    Reloading = true;
                    LastFire = gameTime.TotalGameTime;
                }
            }
            Reload(gameTime);
        }

        public override void Reload(GameTime gameTime)
        {
            if (!Reloading)
            {
                return;
            }
            if (gameTime.TotalGameTime - LastFire > CurrentFire)
            {
                Reloading = false;
            }
                


        }

        public override void Fire()
        {
            switch (PlayerLevel)
            {
                case 1:
                    {
                        PlayerBullet currentBullet1 = new PlayerBullet();

                        currentBullet1.Initialize(Game1.playerBulletTexture, new Vector2(Position.X + 24, Position.Y + 20), new Quaternion(0, 0, 0, 0), BulletSpeed);

                        Game1.playerBulletVolley.Add(currentBullet1);
                        break;
                    }
                case 2:
                    {
                        PlayerBullet currentBullet1 = new PlayerBullet();

                        currentBullet1.Initialize(Game1.playerBulletTexture, new Vector2(Position.X + 4, Position.Y + 20), new Quaternion(0, 0, 0, 0), BulletSpeed);

                        Game1.playerBulletVolley.Add(currentBullet1);

                        PlayerBullet currentBullet2 = new PlayerBullet();

                        currentBullet2.Initialize(Game1.playerBulletTexture, new Vector2(Position.X + 46, Position.Y + 20), new Quaternion(0, 0, 0, 0), BulletSpeed);

                        Game1.playerBulletVolley.Add(currentBullet2);
                        break;
                    }

                default:
                    break;
            }
        }

        public void Dead()
        {
            Active = false;
            
        }
    }
}
