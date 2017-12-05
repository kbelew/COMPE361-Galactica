using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    class EnemyShip : Ship
    {

        public bool MovingRight;
        public bool MovingForward;
        public int ForwardCounter;


        public static Random EnemyRand = new Random();


        public int ChanceToFire;
        public int EnemyLevel;
        public int StartingEnemyLevel;
        public override void Initialize(Texture2D texture, Vector2 position, Game1 game, GameTime gameTime = null)
        {
            Parent = game;
            Texture = texture;

            MovingRight = (EnemyRand.Next(0, 2) == 0) ? true : false;   // 50/50 of starting moving right or left

            //MovingRight = true;
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

            ReloadTime = TimeSpan.FromSeconds(60f / ReloadSpeed * StartingEnemyLevel);

            try
            {
                LastFire = gameTime.TotalGameTime;
            }
            catch (NullReferenceException ex)
            {
                Console.Error.WriteLine($"An instance of EnemyShip was not passed the gameTime: {ex}");
                LastFire = TimeSpan.Zero;
            }

            ChanceToFire = StartingEnemyLevel * 20; // Level 1 has 20 perc, level 5 always shoots


        }

        public override void Update(GameTime gameTime)
        {
            //TODO: Everything




            if (Position.Y < 0) Position.Y += LateralSpeed;
            else
            {
                if (Reloading == false)
                {
                    Fire();
                    Reloading = true;
                    LastFire = gameTime.TotalGameTime;
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
                        Position.Y += LateralSpeed;
                    }
                   
                }
                else if (Position.X > 431)
                {

                    MovingForward = true;
                    //MovingRight = false;

                }
                else
                {
                   
                    Position.X += StrafeSpeed;
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
                        Position.Y += LateralSpeed;
                    }
                }
                else if (Position.X < 5)
                {
                    MovingForward = true;
                }
                else
                {
                    Position.X -= StrafeSpeed;
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
            int randPerc = firePerc.Next(0, 100);

            if (randPerc <= ChanceToFire)
            {

                Parent.enemyBulletSound.Play();

                var currentBullet1 = new EnemyBullet();

                currentBullet1.Initialize(Parent.enemyBulletTexture,
                    new Vector2(Position.X + 24, Position.Y + 64), new Quaternion(0, 0, 0, 0),
                    BulletSpeed);

                Parent.enemyBulletVolley.Add(currentBullet1);
            }
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
    }
}
