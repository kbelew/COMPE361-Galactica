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
    class EnemyShip : Ship
    {

        public bool MovingRight;
        public bool MovingForward;
        public int ForwardCounter;

        public int ChanceToFire;
        public int EnemyLevel;
        public override void Initialize(Texture2D texture, Vector2 position)
        {
            ShipTexture = texture;

            MovingRight = true;
            MovingForward = false;
            ForwardCounter = 0;
            // Set the starting position of the player around the middle of the screen and to the back

            Position = position;

            

            // Set the player to be active

            Active = true;



            // Set the player health

            Health = 100;



            // Speed in which the PlayerShip moves side to side

            StrafeSpeed = 3;


            // Speed in which PlayerShip moves up and down

            LateralSpeed = 4;


            ReloadSpeed = 50f;

            BulletSpeed = 10;
            

            Reloading = false;

            CurrentFire = TimeSpan.FromSeconds(60f / ReloadSpeed);

            LastFire = TimeSpan.Zero;

            ChanceToFire = 25;


        }

        public override void Update(GameTime gameTime)
        {
            //TODO: Everything




            if (this.Position.Y < 0) this.Position.Y += LateralSpeed;
            else
            {
                if (this.Reloading == false)
                {
                    Fire();
                    this.Reloading = true;
                    this.LastFire = gameTime.TotalGameTime;
                }
            }

            Reload(gameTime);
            
            if (MovingRight)
            {
                if (MovingForward)
                {
                    if (ForwardCounter >= 16)
                    {
                        MovingRight = false;
                        MovingForward = false;
                        ForwardCounter = 0;

                    }
                    else
                    {
                        ForwardCounter++;
                        this.Position.Y += LateralSpeed;
                    }
                   
                }
                else if (this.Position.X > 431)
                {

                    MovingForward = true;
                    //MovingRight = false;

                }
                else
                {
                   
                    this.Position.X += StrafeSpeed;
                }
            }
            else
            {
                if (MovingForward)
                {
                    if (ForwardCounter >= 16)
                    {
                        MovingRight = true;
                        MovingForward = false;
                        ForwardCounter = 0;

                    }
                    else
                    {
                        ForwardCounter++;
                        this.Position.Y += LateralSpeed;
                    }
                }
                else if (this.Position.X < 5)
                {
                    MovingForward = true;
                }
                else
                {
                    this.Position.X -= StrafeSpeed;
                }
            }
        }

        //public Texture2D GetEnemyColor()
        //{
        //    switch (this.EnemyLevel)
        //    {
        //        case 1:
        //            return 
        //    }

                



        //}

        public override void Fire()
        {
            Random firePerc = new Random();
            int randPerc = firePerc.Next(1, 100);

            if (randPerc <= this.ChanceToFire)
            {
                var currentBullet1 = new EnemyBullet();

                currentBullet1.Initialize(Game1.enemyBulletTexture,
                    new Vector2(this.Position.X + 24, this.Position.Y + 64), new Quaternion(0, 0, 0, 0),
                    this.BulletSpeed);

                Game1.enemyBulletVolley.Add(currentBullet1);
            }
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
    }
}
