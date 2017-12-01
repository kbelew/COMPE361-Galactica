using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



/// <summary>
/// To figure out Fonts I used this as a resource: http://rbwhitaker.wikidot.com/monogame-drawing-text-with-spritefonts
/// </summary>
namespace Galactica
{


    // TODO: Make them start left or right randomly
    // TODO: Health bar, Score UI
    // TODO: When enemies overlap, make them spread out
    // TODO: Weapon Powerups
    // TODO: MISSLES EXTRA CREDIT




    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private bool gamePaused = false;
        private TimeSpan lastPause;
        private TimeSpan pauseDebounce;

        private bool gameOver = false;

        private SpriteFont scoreFont;
        public int playerScore = 0;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        PlayerShip playerShip;

        


        private TimeSpan lastEnemySpawn;

        private TimeSpan enemySpawnFreq;

        // Starry Background

        TimeSpan lastStar;

        TimeSpan starSpawnFreq;

        public static Texture2D starTexture;

        public static List<Star> stars;


        // Enemy Textures

        public static Texture2D enemyTexture01;

        public static Texture2D enemyTexture02;

        public static Texture2D enemyTexture03;

        public static Texture2D enemyTexture04;

        public static Texture2D enemyTexture05;

        private static List<EnemyShip> enemyShips;


        // Bullets

        public static Texture2D playerBulletTexture;
        
        public static Texture2D enemyBulletTexture;

        public static List<PlayerBullet> playerBulletVolley;

        public static List<EnemyBullet> enemyBulletVolley;

        // PowerUps

        public static Texture2D LevelUpTexture;

        public static Texture2D ExtraLifeTexture;

        public static List<PowerUp> powerUps;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this)
            {

                // Change size of Application Window

                PreferredBackBufferWidth = 500,  // set this value to the desired width of your window
                PreferredBackBufferHeight = 600   // set this value to the desired height of your window
            };
            graphics.ApplyChanges();


            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            const float pauseDebounceLength = 200f;
            pauseDebounce = TimeSpan.FromMilliseconds(pauseDebounceLength);
            lastPause = TimeSpan.Zero;


            playerScore = 0;


            // Starry Background

            stars = new List<Star>();

            const float starReload = 4000f;
            starSpawnFreq = TimeSpan.FromSeconds (60f / starReload);
            lastStar = TimeSpan.Zero;

            // Ships

            playerShip = new PlayerShip();

            enemyShips = new List<EnemyShip>();

            const float enemyRespawn = 50f;
            enemySpawnFreq = TimeSpan.FromSeconds(60f / enemyRespawn);
            lastEnemySpawn = TimeSpan.Zero;

           // enemyShip01 = new EnemyShip();

            // enemyShip02 = new EnemyShip();

            playerBulletVolley = new List<PlayerBullet>();

            enemyBulletVolley = new List<EnemyBullet>();

            powerUps = new List<PowerUp>();


            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            scoreFont = Content.Load<SpriteFont>("Fonts\\ScoreFont");

            // TODO: use this.Content to load your game content here

            starTexture = Content.Load<Texture2D>("Graphics\\Star_003");

            playerBulletTexture = Content.Load<Texture2D>("Graphics\\playerBullet_001");

            enemyBulletTexture = Content.Load<Texture2D>("Graphics\\enemyBullet_002");
            // Load the player resources

            Vector2 playerShipPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X + GraphicsDevice.Viewport.TitleSafeArea.Width / 2 - 32, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height - 100); // 32 is half of ship width | // 100 is to keep on screen

            playerShip.Initialize(Content.Load<Texture2D>("Graphics\\playerShip_001"), playerShipPosition);



            // Load the enemyShips

            enemyTexture01 = Content.Load<Texture2D>("Graphics\\EnemyShip_002");    // Red
            enemyTexture02 = Content.Load<Texture2D>("Graphics\\EnemyShip_008");    // Yellow
            enemyTexture03 = Content.Load<Texture2D>("Graphics\\EnemyShip_009");    // Green
            enemyTexture04 = Content.Load<Texture2D>("Graphics\\EnemyShip_007");    // Blue
            enemyTexture05 = Content.Load<Texture2D>("Graphics\\EnemyShip_006");    // Purple

            // Load the powerUps

            //TODO: POWEUP TEXTURES

            //Vector2 enemyShipPosition01 = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X + GraphicsDevice.Viewport.TitleSafeArea.Width / 2 + 96, GraphicsDevice.Viewport.TitleSafeArea.Y); // 32 is half of ship width | // 100 is to keep on screen

            //enemyShips.Add(new EnemyShip());

            //enemyShips.First().Initialize(Content.Load<Texture2D>("Graphics\\enemyShip_002"), enemyShipPosition01);

            //enemyShips.First().EnemyLevel = 1;

            //Vector2 enemyShipPosition02 = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X + GraphicsDevice.Viewport.TitleSafeArea.Width / 2 - 32, GraphicsDevice.Viewport.TitleSafeArea.Y); // 32 is half of ship width | // 100 is to keep on screen

            //enemyShip02.Initialize(Content.Load<Texture2D>("Graphics\\enemyShip_003"), enemyShipPosition02);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            
                
            
                //Exit();

            if (gameOver)
            {
                enemyBulletVolley.Clear();
                playerBulletVolley.Clear();
                enemyShips.Clear();

                CreateStars(gameTime);
                if (stars.Count > 0)
                {
                    for (int i = 0; i < stars.Count; ++i)
                    {
                        stars[i].Update();
                        if (stars[i].Active == false)
                        {
                            stars.Remove(stars[i]);

                        }

                    }

                }
            }
            else if (gamePaused)
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                {
                    Pause(gameTime);
                }
                
            }
            else
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                {
                    Pause(gameTime);
                }


                // Stars Updates
                CreateStars(gameTime);
                if (stars.Count > 0)
                {
                    for (int i = 0; i < stars.Count; ++i)
                    {
                        stars[i].Update();
                        if (stars[i].Active == false)
                        {
                            stars.Remove(stars[i]);

                        }

                    }

                }


                UpdateCollisions();

                EnemyLevelUpdate();

                if (playerShip.Active) playerShip.Update(gameTime);
                else if (!playerShip.Active)
                {
                    gameOver = true;
                    Pause(gameTime);
                }
                EnemySpawn(gameTime);


                for (int i = 0; i < enemyShips.Count; ++i)
                {
                    enemyShips[i].Update(gameTime);
                    if (enemyShips[i].Active == false)
                    {
                        enemyShips.Remove(enemyShips[i]);

                    }

                }
                //enemyShip01.Update(gameTime);

                //foreach(PlayerBullet currentPlayerBullet in playerBulletVolley)
                //{
                //    currentPlayerBullet.Update();
                //}

                for (int i = 0; i < playerBulletVolley.Count; ++i)
                {
                    playerBulletVolley[i].Update();
                    if (playerBulletVolley[i].Active == false)
                    {
                        playerBulletVolley.Remove(playerBulletVolley[i]);

                    }

                }

                //foreach (EnemyBullet currentEnemyBullet in enemyBulletVolley)
                //{
                //    currentEnemyBullet.Update();
                //}

                for (int i = 0; i < enemyBulletVolley.Count; ++i)
                {
                    enemyBulletVolley[i].Update();
                    if (enemyBulletVolley[i].Active == false)
                    {
                        enemyBulletVolley.Remove(enemyBulletVolley[i]);

                    }

                }


                base.Update(gameTime);


            }
        }
        /// <summary>
        /// This Update Collisions is similar to the one in the guid found at http://www.tarathegeekgirl.net/?p=281
        /// I learned how to do this from there and it is hard to fully deviate. I will do my best to expand on this.
        /// </summary>
        void UpdateCollisions()
        {
            


            var playerHitBox = new Rectangle((int)playerShip.Position.X, (int)playerShip.Position.Y, playerShip.Width, playerShip.Height);

            foreach (EnemyShip currEnemyShip in enemyShips)
            {
                var enemyHitBox = new Rectangle((int)currEnemyShip.Position.X, (int)currEnemyShip.Position.Y, currEnemyShip.Width, currEnemyShip.Height);

                if (playerHitBox.Intersects(enemyHitBox))
                {
                    playerShip.Health -= 1;
                    currEnemyShip.Active = false;
                }

                
               
                foreach (var currPlayerBullet in playerBulletVolley)
                {
                    var playerBulletHitBox = new Rectangle((int)currPlayerBullet.Position.X, (int)currPlayerBullet.Position.Y, currPlayerBullet.Width, currPlayerBullet.Height);

                    if (playerBulletHitBox.Intersects(enemyHitBox))
                    {

                        playerScore += 10 * currEnemyShip.EnemyLevel;

                        if (currEnemyShip.EnemyLevel == 1)
                        {
                            currEnemyShip.Active = false;
                        }
                        else
                        {
                            currEnemyShip.EnemyLevel -= 1;
                        }

                        
                        currPlayerBullet.Active = false;

                    }
                }

            }

            foreach (var currEnemyBullet in enemyBulletVolley)
            {
                var enemyBulletHitBox = new Rectangle((int)currEnemyBullet.Position.X, (int)currEnemyBullet.Position.Y, currEnemyBullet.Width, currEnemyBullet.Height);

                if (enemyBulletHitBox.Intersects(playerHitBox) && currEnemyBullet.Active)
                {
                    currEnemyBullet.Active = false;
                    playerShip.Health -= 1;
                }
            }

            
            

        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here


            // Start drawing

            spriteBatch.Begin();


            foreach (Star star in stars)
            {
                star.Draw(spriteBatch);
            }

            // Draw the Player

            if (playerShip.Active)
            {
                playerShip.Draw(spriteBatch);
            }
            




            // Draw the Enemies


            foreach (EnemyShip currentEnemyShip in enemyShips)
            {
                currentEnemyShip.Draw(spriteBatch);
            }
            

            foreach (PlayerBullet currentPlayerBullet in playerBulletVolley)
            {
                currentPlayerBullet.Draw(spriteBatch);
            }

            foreach (EnemyBullet currentEnemyBullet in enemyBulletVolley)
            {
                currentEnemyBullet.Draw(spriteBatch);
            }

            

            spriteBatch.DrawString(scoreFont, $"Score: {playerScore}", new Vector2(5f, 5f), Color.White);

            spriteBatch.DrawString(scoreFont, $"Lives: {playerShip.Health}", new Vector2(5f, 550f), Color.White );

            if (gameOver)
            {
                spriteBatch.DrawString(scoreFont, $"GAME OVER", new Vector2(175f, 250f), Color.Red);
            }
            else if (gamePaused)
            {
                spriteBatch.DrawString(scoreFont, $"PAUSED", new Vector2(175f, 250f), Color.White);

            }

            // Stop drawing
            spriteBatch.End();

            base.Draw(gameTime);
        }

        private void Pause(GameTime gameTime)
        {
            if (!gamePaused)
            {
                if (gameTime.TotalGameTime - lastPause > pauseDebounce)
                {
                    lastPause = gameTime.TotalGameTime;
                    gamePaused = true;
                }
            }
            else
            {
                if (gameTime.TotalGameTime - lastPause > pauseDebounce)
                {
                    lastPause = gameTime.TotalGameTime;
                    gamePaused = false;
                }
            }
        }

        public void CreateStars(GameTime gameTime)
        {
            if (gameTime.TotalGameTime - lastStar > starSpawnFreq)
            {
                lastStar = gameTime.TotalGameTime;

                Star star = new Star();
                star.Initialize(starTexture);
                stars.Add(star);
            }
        }

        public void EnemySpawn(GameTime gameTime)
        {
            if (gameTime.TotalGameTime - lastEnemySpawn > enemySpawnFreq)
            {
                EnemyShip currEnemyShip = new EnemyShip();

                Random randPerc = new Random();
                int levelRoll = randPerc.Next(1, 100);
                int textureRoll = randPerc.Next(1, 100);

                Vector2 randEnemyPosition;
                Texture2D currEnemyTexture;

                // Figure out which level of enemy
                if (playerScore < 100)
                {
                    if (levelRoll >= 99)
                    {
                        currEnemyTexture = enemyTexture02;
                        currEnemyShip.EnemyLevel = 2;
                    }

                    else
                    {
                        currEnemyTexture = enemyTexture01;
                        currEnemyShip.EnemyLevel = 1;
                    }

                } else if (playerScore < 500)
                {
                    if (levelRoll >= 99)
                    {
                        currEnemyTexture = enemyTexture03;
                        currEnemyShip.EnemyLevel = 3;

                    }
                    else if (levelRoll >= 80)
                    {
                        currEnemyTexture = enemyTexture02;
                        currEnemyShip.EnemyLevel = 2;
                    }
                    else
                    {
                        currEnemyTexture = enemyTexture01;
                        currEnemyShip.EnemyLevel = 1;
                    }
                }
                else
                {
                    currEnemyTexture = enemyTexture05;
                    currEnemyShip.EnemyLevel = 5;
                    
                }

                // Reset Spawn Timer
                lastEnemySpawn = gameTime.TotalGameTime;


                // Figure out Enemy Starting Position

                randEnemyPosition = new Vector2(randPerc.Next(0, 400), -50f);


                
                currEnemyShip.Initialize(currEnemyTexture, randEnemyPosition);
                enemyShips.Add(currEnemyShip);
            }
        }

        public void EnemyLevelUpdate()
        {
            foreach (EnemyShip currEnemyShip in enemyShips)
            {
                switch (currEnemyShip.EnemyLevel)
                {
                    case 1:
                        currEnemyShip.Texture = enemyTexture01;
                        break;
                    case 2:
                        currEnemyShip.Texture = enemyTexture02;
                        break;
                    case 3:
                        currEnemyShip.Texture = enemyTexture03;
                        break;
                    case 4:
                        currEnemyShip.Texture = enemyTexture04;
                        break;
                    case 5:
                        currEnemyShip.Texture = enemyTexture05;
                        break;
                }
            }
        }
        
        
    }
}
