using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    /// <summary>
    /// This class holds the Ship type GameObject of Enemy Ships.
    /// </summary>
    class EnemyShip : Ship
    {

        public bool MovingRight;
        public bool MovingForward;
        public int ForwardCounter;


        public static Random EnemyRand = new Random();


        public int ChanceToFire;
        public int EnemyLevel;
        public int StartingEnemyLevel;
        public override void Initialize(Texture2D texture, Vector2 position, GalagaGame game, GameTime gameTime = null)
        {
            Parent = game;
            Texture = texture;

            MovingRight = (EnemyRand.Next(0, 2) == 0) ? true : false;   // 50/50 of starting moving right or left

            //MovingRight = true;
            MovingForward = false;
            ForwardCounter = 0;
            // Set the starting position of the player around the middle of the screen and to the back

            Position = position;

            

            // Set the enemy to be active

            Active = true;


            // Speed in which the EnemyShip moves side to side

            StrafeSpeed = 3;


            // Speed in which EnemyShip moves up and down

            LateralSpeed = 4;

            // How often enemies can shoot

            ReloadSpeed = 50f;

            // How fast their bullets move forward

            BulletSpeed = 10;
            
            // Is the Enemy currently Reloading?

            Reloading = false;

            // The actual Timespan of how long it takes for the enemy to Reload

            ReloadTime = TimeSpan.FromSeconds(60f / ReloadSpeed * StartingEnemyLevel);

            try
            {
                LastFire = gameTime.TotalGameTime;  // Setting to the time of instance creation
            }
            catch (NullReferenceException ex)
            {
                Console.Error.WriteLine($"An instance of EnemyShip was not passed the gameTime: {ex}");
                LastFire = TimeSpan.Zero;
            }

            ChanceToFire = StartingEnemyLevel * 20; // Level 1 has 20 percent chance to shoot, level 5 always shoots


        }
        /// <summary>
        /// Handle various movements of EnemyShip.
        /// 
        /// Handle the firing of EnemyShip.
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {


            if (Position.Y > 700) this.Active = false;


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

        /// <summary>
        /// Dictates if they shoot, and spawning of the bullet that they do shoot
        /// </summary>
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

        /// <summary>
        /// Start reloading, only once the required ReloadTime has passed are they no longer reloading.
        /// </summary>
        /// <param name="gameTime"></param>
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
