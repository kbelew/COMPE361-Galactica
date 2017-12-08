// Kevin Belew
// 818366010
// 12/8/17
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Keys = Microsoft.Xna.Framework.Input.Keys;


/// <summary>
/// To figure out Fonts I used this as a resource: http://rbwhitaker.wikidot.com/monogame-drawing-text-with-spritefonts
/// </summary>
namespace Galactica
{


    /// <summary>
    /// This is the main controller of the entire game
    /// </summary>
    public class GalagaGame : Game
    {
        public readonly bool DevMode;
        public int screenWidth;
        public int screenHeight;
        private bool gamePaused = false;
        private TimeSpan lastPause;
        private TimeSpan pauseDebounce;

        private TimeSpan gameOverTime;
        private TimeSpan gameOverDebounce;

        public Random globalRand;

        private bool gameOver = false;

        public KeyboardState prevState; //http://www.gamefromscratch.com/post/2015/06/28/MonoGame-Tutorial-Handling-Keyboard-Mouse-and-GamePad-Input.aspx
        public KeyboardState currState;


        private SpriteFont scoreFont;
        private SpriteFont teleMarineFont15;
        public int playerScore = 0;
        public int playerShotCounter = 0;
        public int enemyHitCounter = 0;
        public int enemyDeathCounter = 0;


        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public PlayerShip playerShip;


        private TimeSpan lastEnemySpawn;

        private TimeSpan enemySpawnFreq;

        // Starry Background

        TimeSpan lastStar;

        TimeSpan starSpawnFreq;

        public Texture2D starTexture;

        public List<Star> stars;


        // Enemy Textures

        public Texture2D enemyTexture01;

        public Texture2D enemyTexture02;

        public Texture2D enemyTexture03;

        public Texture2D enemyTexture04;

        public Texture2D enemyTexture05;

        private List<EnemyShip> enemyShips;


        // Bullets

        public Texture2D playerBulletTexture;

        public Texture2D enemyBulletTexture;

        public List<PlayerBullet> playerBulletVolley;

        public List<EnemyBullet> enemyBulletVolley;

        // PowerUps

        public Texture2D LevelUpTexture;

        public Texture2D ExtraLifeTexture;

        public List<PowerUp> powerUps;

        // Sound FX

        public SoundEffect playerBulletSound;
        public SoundEffect enemyBulletSound;


        public SoundEffect playerHitSound;




        public SoundEffect gameOverSound;



        public SoundEffect dropPowerUpSound;
        public SoundEffect pickUpPowerUpSound;



        internal float enemyRespawn = 50f;
        internal float starReload = 4000f;

        public GalagaGame(bool devMode = false)  // Optional Devmode, by default it is false
        {
            DevMode = devMode;

            screenWidth = 500;
            screenHeight = 600;

            graphics = new GraphicsDeviceManager(this)
            {
                // Change size of Application Window

                PreferredBackBufferWidth = screenWidth, // set this value to the desired width of your window
                PreferredBackBufferHeight = screenHeight // set this value to the desired height of your window
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
            globalRand = new Random();

            prevState = Keyboard.GetState();
            currState = Keyboard.GetState();

            const float pauseDebounceLength = 200f;
            pauseDebounce = TimeSpan.FromMilliseconds(pauseDebounceLength);
            lastPause = TimeSpan.Zero;

            const float gameOverDebounceLength = 3f;
            gameOverDebounce = TimeSpan.FromSeconds(gameOverDebounceLength);
            gameOverTime = TimeSpan.Zero;


            playerScore = 0;


            // Starry Background

            stars = new List<Star>();


            starSpawnFreq = TimeSpan.FromSeconds(60f / starReload);
            lastStar = TimeSpan.Zero;

            // Ships

            playerShip = new PlayerShip();

            enemyShips = new List<EnemyShip>();


            enemySpawnFreq = TimeSpan.FromSeconds(60f / enemyRespawn);
            lastEnemySpawn = TimeSpan.Zero;

            // Bullets

            playerBulletVolley = new List<PlayerBullet>();

            enemyBulletVolley = new List<EnemyBullet>();

            // PowerUps

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

            teleMarineFont15 = Content.Load<SpriteFont>("Fonts\\TeleMarine_15");

            starTexture = Content.Load<Texture2D>("Graphics\\Star_003");

            playerBulletTexture = Content.Load<Texture2D>("Graphics\\playerBullet_001");

            enemyBulletTexture = Content.Load<Texture2D>("Graphics\\enemyBullet_002");
            // Load the player resources

            Vector2 playerShipPosition =
                new Vector2(
                    GraphicsDevice.Viewport.TitleSafeArea.X + GraphicsDevice.Viewport.TitleSafeArea.Width / 2 - 32,
                    GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height -
                    100); // 32 is half of ship width | // 100 is to keep on screen

            playerShip.Initialize(Content.Load<Texture2D>("Graphics\\playerShip_001"), playerShipPosition, this);


            // Load the enemyShips

            enemyTexture01 = Content.Load<Texture2D>("Graphics\\EnemyShip_002"); // Red
            enemyTexture02 = Content.Load<Texture2D>("Graphics\\EnemyShip_008"); // Yellow
            enemyTexture03 = Content.Load<Texture2D>("Graphics\\EnemyShip_009"); // Green
            enemyTexture04 = Content.Load<Texture2D>("Graphics\\EnemyShip_007"); // Blue
            enemyTexture05 = Content.Load<Texture2D>("Graphics\\EnemyShip_006"); // Purple

            // Load the powerUps

            

            LevelUpTexture = Content.Load<Texture2D>("Graphics\\LevelUp_001");
            ExtraLifeTexture = Content.Load<Texture2D>("Graphics\\ExtraLife_001");

            // LOAD SOUND FX


            playerBulletSound = Content.Load<SoundEffect>("Sound\\laserSound_003");
            enemyBulletSound = Content.Load<SoundEffect>("Sound\\laserSound_002");

            playerHitSound = Content.Load<SoundEffect>("Sound\\hitSound_001");

            gameOverSound = Content.Load<SoundEffect>("Sound\\gameOverSound");

            dropPowerUpSound = Content.Load<SoundEffect>("Sound\\dropPowerUp_001");
            pickUpPowerUpSound = Content.Load<SoundEffect>("Sound\\pickUpPowerUp_001");
        }


        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {            
            playerBulletSound.Dispose();
            enemyBulletSound.Dispose();

            playerHitSound.Dispose();
          
            gameOverSound.Dispose();

            dropPowerUpSound.Dispose();
            pickUpPowerUpSound.Dispose();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Gets current state of keyboard

            currState = Keyboard.GetState();




            if (DevMode)
            {
                DeveloperUpdates(gameTime);
            }

            if (gameOver)
            {
                GameOverUpdates(gameTime);
            }
            else if (gamePaused)
            {
                if (currState.IsKeyDown(Keys.Escape) && !prevState.IsKeyDown(Keys.Escape))
                {
                    Pause();
                }
            }
            else
            {
                if (currState.IsKeyDown(Keys.Escape) && !prevState.IsKeyDown(Keys.Escape))
                {

                    
                    Pause();
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

                if (playerShip.Active)
                {
                    playerShip.Update(gameTime);
                }
                else if (!playerShip.Active)
                {
                    gameOver = true;
                    Pause();
                }

                EnemySpawn(gameTime);

                // Update Enemies
                for (int i = 0; i < enemyShips.Count; ++i)
                {
                    if (enemyShips[i].Active == false)
                    {
                        SpawnPowerup(enemyShips[i].StartingEnemyLevel, enemyShips[i].Position);
                        enemyShips.Remove(enemyShips[i]);
                    }
                    else
                    {
                        enemyShips[i].Update(gameTime);
                    }
                }

                // Update Player Bullets
                for (int i = 0; i < playerBulletVolley.Count; ++i)
                {
                    playerBulletVolley[i].Update();
                    if (playerBulletVolley[i].Active == false)
                    {
                        playerBulletVolley.Remove(playerBulletVolley[i]);
                    }
                }

                
                // Update Enemy Bullets
                for (int i = 0; i < enemyBulletVolley.Count; ++i)
                {
                    enemyBulletVolley[i].Update();
                    if (enemyBulletVolley[i].Active == false)
                    {
                        enemyBulletVolley.Remove(enemyBulletVolley[i]);
                    }
                }

                // Update PowerUps
                for (int i = 0; i < powerUps.Count; ++i)
                {
                    powerUps[i].Update();
                    if (powerUps[i].Active == false)
                    {
                        powerUps.Remove(powerUps[i]);
                    }
                }

                base.Update(gameTime);
            }

            prevState = currState;
        }

        /// <summary>
        /// This Update Collisions is based off the one in the guide found at http://www.tarathegeekgirl.net/?p=281
        /// I learned how to do this from there and it is hard to fully deviate. I will do my best to expand on this.
        /// </summary>
        void UpdateCollisions()
        {
            var playerHitBox = new Rectangle((int) playerShip.Position.X, (int) playerShip.Position.Y, playerShip.Width,
                playerShip.Height);

            foreach (var currEnemyShip in enemyShips)
            {
                var enemyHitBox = new Rectangle((int) currEnemyShip.Position.X, (int) currEnemyShip.Position.Y,
                    currEnemyShip.Width, currEnemyShip.Height);

                if (playerHitBox.Intersects(enemyHitBox))
                {
                    playerShip.Health -= 1;
                    playerHitSound.Play();
                    currEnemyShip.Active = false;
                }


                foreach (var currPlayerBullet in playerBulletVolley)
                {
                    var playerBulletHitBox = new Rectangle((int) currPlayerBullet.Position.X,
                        (int) currPlayerBullet.Position.Y, currPlayerBullet.Width, currPlayerBullet.Height);

                    if (playerBulletHitBox.Intersects(enemyHitBox))
                    {
                        enemyHitCounter++;

                        playerScore += 10 * currEnemyShip.EnemyLevel;

                        if (currEnemyShip.EnemyLevel == 1)
                        {
                            enemyDeathCounter++;
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
                var enemyBulletHitBox = new Rectangle((int) currEnemyBullet.Position.X,
                    (int) currEnemyBullet.Position.Y, currEnemyBullet.Width, currEnemyBullet.Height);

                if (enemyBulletHitBox.Intersects(playerHitBox) && currEnemyBullet.Active)
                {
                    currEnemyBullet.Active = false;
                    playerShip.Health -= 1;
                    playerHitSound.Play();
                }
            }

            // Handle Collisons with PowerUps

            foreach (var currPowerUp in powerUps)
            {
                var powerUpHitBox = new Rectangle((int) currPowerUp.Position.X, (int) currPowerUp.Position.Y,
                    currPowerUp.Width, currPowerUp.Height);

                if (powerUpHitBox.Intersects(playerHitBox) && currPowerUp.Active)
                {
                    currPowerUp.Active = false;

                    pickUpPowerUpSound.Play(.3f, 0f, 0f);

                    if (currPowerUp is LevelUp)
                    {
                        playerShip.PlayerLevel++;
                        playerShip.LevelUp();
                    }
                    else if (currPowerUp is ExtraLife)
                    {
                        playerShip.Health++;
                    }
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


            // Start drawing

            spriteBatch.Begin();

            // Draw the Stars

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

            // Draw the Player Bullets

            foreach (PlayerBullet currentPlayerBullet in playerBulletVolley)
            {
                currentPlayerBullet.Draw(spriteBatch);
            }

            // Draw the Enemy Bullets

            foreach (EnemyBullet currentEnemyBullet in enemyBulletVolley)
            {
                currentEnemyBullet.Draw(spriteBatch);
            }

            // Draw the Powerups

            foreach (var currentPowerUp in powerUps)
            {
                currentPowerUp.Draw(spriteBatch);
            }

            // Draw the UI

            spriteBatch.DrawString(teleMarineFont15, $"Score: {playerScore}", new Vector2(5f, 5f), Color.White);

            spriteBatch.DrawString(teleMarineFont15, $"Lives: {playerShip.Health}", new Vector2(5f, 550f), Color.White);

            spriteBatch.DrawString(teleMarineFont15, $"Level: {playerShip.PlayerLevel}", new Vector2(325f, 550f),
                Color.White);

            
            // Draw the GameOver Screen

            if (gameOver)
            {
                spriteBatch.DrawString(scoreFont, $"GAME OVER", new Vector2(165f, 250f), Color.Red);
                spriteBatch.DrawString(scoreFont, $"Player Shots Fired: {playerShotCounter}", new Vector2(110f, 340f),
                    Color.White);
                spriteBatch.DrawString(scoreFont, $"Enemies Hit: {enemyHitCounter}", new Vector2(110f, 370f),
                    Color.Orange);
                spriteBatch.DrawString(scoreFont,
                    $"Fire Accuracy: {((float) enemyHitCounter / (float) playerShotCounter):P2}",
                    new Vector2(110f, 400f), Color.Green);

                if (gameOverTime != TimeSpan.Zero)
                {
                    if (gameTime.TotalGameTime - gameOverTime > gameOverDebounce)
                    {
                        spriteBatch.DrawString(scoreFont, $"Press Any Key To Main Menu", new Vector2(70f, 460f),
                            Color.White);
                    }
                }
            }
            else if (gamePaused)
            {
                spriteBatch.DrawString(scoreFont, $"PAUSED", new Vector2(175f, 250f), Color.White);
            }

            // Stop drawing
            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Handles the Pausing and Unpausing of the game, nothing updates while game is Paused
        /// </summary>
        private void Pause() => gamePaused = !gamePaused;

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

        /// <summary>
        /// Handles the spawning of the enemies, this is time based unless the method is called with forceSpawn -> true.
        /// 
        /// The enemy levels that they are spawned with is done by random rolls and is percentage based, compared to score.
        /// </summary>
        /// <param name="gameTime"></param>
        /// <param name="forceSpawn"></param>
        public void EnemySpawn(GameTime gameTime, bool forceSpawn = false)
        {
            enemySpawnFreq = TimeSpan.FromSeconds(60f / (enemyRespawn + (playerShip.PlayerLevel * 2)));

            if ((gameTime.TotalGameTime - lastEnemySpawn > enemySpawnFreq) || forceSpawn == true)
            {
                EnemyShip currEnemyShip = new EnemyShip();

                Random randPerc = new Random();
                int levelRoll = randPerc.Next(0, 100);
                

                Texture2D currEnemyTexture;

                // Figure out which level of enemy

                if (playerScore < 100)
                {
                    if (levelRoll < 5)
                    {
                        currEnemyTexture = enemyTexture02;
                        currEnemyShip.EnemyLevel = 2;
                        currEnemyShip.StartingEnemyLevel = 2;
                    }

                    else
                    {
                        currEnemyTexture = enemyTexture01;
                        currEnemyShip.EnemyLevel = 1;
                        currEnemyShip.StartingEnemyLevel = 1;
                    }
                }
                else if (playerScore < 500)
                {
                    if (levelRoll < 5)
                    {
                        currEnemyTexture = enemyTexture03;
                        currEnemyShip.EnemyLevel = 3;
                        currEnemyShip.StartingEnemyLevel = 3;
                    }
                    else if (levelRoll < 20)
                    {
                        currEnemyTexture = enemyTexture02;
                        currEnemyShip.EnemyLevel = 2;
                        currEnemyShip.StartingEnemyLevel = 2;
                    }
                    else
                    {
                        currEnemyTexture = enemyTexture01;
                        currEnemyShip.EnemyLevel = 1;
                        currEnemyShip.StartingEnemyLevel = 1;
                    }
                }
                else if (playerScore < 1250)
                {
                    if (levelRoll < 5)
                    {
                        currEnemyTexture = enemyTexture04;
                        currEnemyShip.EnemyLevel = 4;
                        currEnemyShip.StartingEnemyLevel = 4;
                    }
                    else if (levelRoll < 20)
                    {
                        currEnemyTexture = enemyTexture03;
                        currEnemyShip.EnemyLevel = 3;
                        currEnemyShip.StartingEnemyLevel = 3;
                    }
                    else if (levelRoll < 40)
                    {
                        currEnemyTexture = enemyTexture02;
                        currEnemyShip.EnemyLevel = 2;
                        currEnemyShip.StartingEnemyLevel = 2;
                    }
                    else
                    {
                        currEnemyTexture = enemyTexture01;
                        currEnemyShip.EnemyLevel = 1;
                        currEnemyShip.StartingEnemyLevel = 1;
                    }
                }
                else if (playerScore < 2500)
                {
                    if (levelRoll < 5)
                    {
                        currEnemyTexture = enemyTexture05;
                        currEnemyShip.EnemyLevel = 5;
                        currEnemyShip.StartingEnemyLevel = 5;
                    }
                    else if (levelRoll < 20)
                    {
                        currEnemyTexture = enemyTexture04;
                        currEnemyShip.EnemyLevel = 4;
                        currEnemyShip.StartingEnemyLevel = 4;
                    }
                    else if (levelRoll < 40)
                    {
                        currEnemyTexture = enemyTexture03;
                        currEnemyShip.EnemyLevel = 3;
                        currEnemyShip.StartingEnemyLevel = 3;
                    }
                    else if (levelRoll < 65)
                    {
                        currEnemyTexture = enemyTexture02;
                        currEnemyShip.EnemyLevel = 2;
                        currEnemyShip.StartingEnemyLevel = 2;
                    }
                    else
                    {
                        currEnemyTexture = enemyTexture01;
                        currEnemyShip.EnemyLevel = 1;
                        currEnemyShip.StartingEnemyLevel = 1;
                    }
                }
                else
                {
                    currEnemyTexture = enemyTexture05;
                    currEnemyShip.EnemyLevel = 5;
                    currEnemyShip.StartingEnemyLevel = 5;
                }

                // Reset Spawn Timer
                lastEnemySpawn = gameTime.TotalGameTime;


                // Figure out Enemy Starting Position

                var randEnemyPosition = new Vector2(randPerc.Next(0, 400), -50f);


                currEnemyShip.Initialize(currEnemyTexture, randEnemyPosition, this, gameTime);
                enemyShips.Add(currEnemyShip);
            }
        }

        /// <summary>
        /// This Method is responsible for tracking the colors of the enemies as they lose health
        /// </summary>
        public void EnemyLevelUpdate()
        {
            foreach (var currEnemyShip in enemyShips)
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

        /// <summary>
        /// This method handles the spawning of PowerUps. More specifically if they will get 
        /// created based off of percentages and the destroyed enemy's level.
        /// </summary>
        /// <param name="enemyStartingLevel"></param>
        /// <param name="startingPos"></param>
        public void SpawnPowerup(int enemyStartingLevel, Vector2 startingPos)
        {
            //Random rand = new Random();

            int rollPerc = globalRand.Next(0, 100);

            if (enemyStartingLevel == 1)
            {
                if (rollPerc < 20)
                {
                    CreatePowerUp(startingPos);
                }
            }
            else if (enemyStartingLevel == 2)
            {
                if (rollPerc < 22)
                {
                    CreatePowerUp(startingPos);
                }
            }
            else if (enemyStartingLevel == 3)
            {
                if (rollPerc < 25)
                {
                    CreatePowerUp(startingPos);
                }
            }
            else if (enemyStartingLevel == 4)
            {
                if (rollPerc < 28)
                {
                    CreatePowerUp(startingPos);
                }
            }
            else if (enemyStartingLevel == 5)
            {
                if (rollPerc < 32)
                {
                    CreatePowerUp(startingPos);
                }
            }
        }

        /// <summary>
        /// This Method actually creates the Powerups, using a roll with certain weight to each powerup.
        /// </summary>
        /// <param name="startingPos"></param>
        public void CreatePowerUp(Vector2 startingPos)
        {
            //Random rand = new Random();
            int powerUpTypeRoll = globalRand.Next(0, 3);

            dropPowerUpSound.Play(.3f, 0f, 0f);

            if (powerUpTypeRoll == 0)
            {
                var currPowerUp = new ExtraLife();
                currPowerUp.Initialize(ExtraLifeTexture, startingPos);
                powerUps.Add(currPowerUp);
            }
            else
            {
                var currPowerUp = new LevelUp();
                currPowerUp.Initialize(LevelUpTexture, startingPos);
                powerUps.Add(currPowerUp);
            }
        }

        /// <summary>
        /// This is the update method handling all of the Developer Mode capabilities.
        /// </summary>
        /// <param name="gameTime"></param>
        public void DeveloperUpdates(GameTime gameTime)
        {
            if (currState.IsKeyDown(Keys.D1) && !prevState.IsKeyDown(Keys.D1))
            {
                playerShip.PlayerLevel++;
                playerShip.LevelUp();
            }
            if (currState.IsKeyDown(Keys.D2) && !prevState.IsKeyDown(Keys.D2))
            {
                EnemySpawn(gameTime, true);
            }
        }

        /// <summary>
        /// This is the update method handling the GameOver scenario and screen.
        /// </summary>
        /// <param name="gameTime"></param>
        public void GameOverUpdates(GameTime gameTime)
        {
            if (gameOverTime.Equals(TimeSpan.Zero))
            {
                gameOverTime = gameTime.TotalGameTime;
            }
            else
            {
                enemyBulletVolley.Clear();
                playerBulletVolley.Clear();
                enemyShips.Clear();
                powerUps.Clear();

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

                if (Keyboard.GetState().GetPressedKeys().Length > 0 &&
                    gameTime.TotalGameTime - gameOverTime > gameOverDebounce)
                {
                    Cursor.Show(); // To use Mouse in Main Menu
                    Exit();
                }
            }
        }
    }
}