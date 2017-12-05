// Tutorials at: https://blogs.msdn.microsoft.com/tarawalker/2012/12/10/windows-8-game-development-using-c-xna-and-monogame-3-0-building-a-shooter-game-walkthrough-part-2-creating-the-shooterplayer-asset-of-the-game/
// Helped me get started

using System;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Telerik.WinControls.UI;

namespace Galactica
{
    public class PlayerShip : Ship
    {
        

        public int PlayerLevel;

        public override void Initialize(Texture2D texture, Vector2 position, Game1 game, GameTime gameTime = null)

        {
            Parent = game;

            Texture = texture;

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

            

            ReloadSpeed = 3f;

            BulletSpeed = 30;

            PlayerLevel = 1;

            Reloading = false;

            ReloadTime = TimeSpan.FromSeconds(2f / ReloadSpeed);

            LastFire = TimeSpan.Zero;
        }

        public override void Update(GameTime gameTime)

        {

            if (Health <= 0) Dead();

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
            if (gameTime.TotalGameTime - LastFire > ReloadTime)
            {
                Reloading = false;
            }
                


        }

        public override void Fire()
        {
            if (PlayerLevel < 3)
                SingleShot();
            else if (PlayerLevel < 6)
                DoubleShot();
            else 
                TripleShot();


            
            

        }

        public void Dead()
        {
            Health = 0;
            Active = false;
            Parent.gameOverSound.Play();


        }

        public void SingleShot()
        {
            Parent.playerBulletSound.Play(.5f, 0f, 0f);


            PlayerBullet currentBullet1 = new PlayerBullet();

            currentBullet1.Initialize(Parent.playerBulletTexture, new Vector2(Position.X + 24, Position.Y + 20), new Quaternion(0, 0, 0, 0), BulletSpeed);

            Parent.playerBulletVolley.Add(currentBullet1);

            Parent.playerShotCounter++;
        }

        public void DoubleShot()
        {
            Parent.playerBulletSound.Play(.6f, 0f, 0f);

            PlayerBullet currentBullet1 = new PlayerBullet();

            currentBullet1.Initialize(Parent.playerBulletTexture, new Vector2(Position.X + 4, Position.Y + 20), new Quaternion(0, 0, 0, 0), BulletSpeed);

            Parent.playerBulletVolley.Add(currentBullet1);

            PlayerBullet currentBullet2 = new PlayerBullet();

            currentBullet2.Initialize(Parent.playerBulletTexture, new Vector2(Position.X + 46, Position.Y + 20), new Quaternion(0, 0, 0, 0), BulletSpeed);

            Parent.playerBulletVolley.Add(currentBullet2);

            Parent.playerShotCounter += 2;
        }

        public void TripleShot()
        {
            Parent.playerBulletSound.Play(.7f, 0f, 0f);

            PlayerBullet currentBullet1 = new PlayerBullet();

            currentBullet1.Initialize(Parent.playerBulletTexture, new Vector2(Position.X + 4, Position.Y + 20), new Quaternion(0, 0, 0, 0), BulletSpeed);

            Parent.playerBulletVolley.Add(currentBullet1);

            PlayerBullet currentBullet2 = new PlayerBullet();

            currentBullet2.Initialize(Parent.playerBulletTexture, new Vector2(Position.X + 25, Position.Y + 20), new Quaternion(0, 0, 0, 0), BulletSpeed);

            Parent.playerBulletVolley.Add(currentBullet2);

            PlayerBullet currentBullet3 = new PlayerBullet();

            currentBullet3.Initialize(Parent.playerBulletTexture, new Vector2(Position.X + 46, Position.Y + 20), new Quaternion(0, 0, 0, 0), BulletSpeed);

            Parent.playerBulletVolley.Add(currentBullet3);

            Parent.playerShotCounter += 3;
        }

        public void LevelUp()
        {
            ReloadTime = TimeSpan.FromSeconds(2f / (ReloadSpeed + PlayerLevel-1));
        }
    }
}
