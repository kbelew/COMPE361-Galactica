// Tutorials at: https://blogs.msdn.microsoft.com/tarawalker/2012/12/10/windows-8-game-development-using-c-xna-and-monogame-3-0-building-a-shooter-game-walkthrough-part-2-creating-the-shooterplayer-asset-of-the-game/
// Helped me get started
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


            ReloadSpeed = 3;

            BulletSpeed = 30;

            PlayerLevel = 1;
    }



        public override void Update()

        {
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                this.Position.X += StrafeSpeed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                this.Position.X -= StrafeSpeed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                this.Position.Y -= LateralSpeed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                this.Position.Y += LateralSpeed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                Fire();
            }
        }

        public override void Fire()
        {
            PlayerBullet currentBullet1 = new PlayerBullet();

            currentBullet1.Initialize(Game1.playerBulletTexture, new Vector2(this.Position.X + 4, this.Position.Y + 20), new Quaternion(0, 0, 0, 0), this.BulletSpeed);

            Game1.playerBulletVolley.Add(currentBullet1);

            PlayerBullet currentBullet2 = new PlayerBullet();

            currentBullet2.Initialize(Game1.playerBulletTexture, new Vector2(this.Position.X + 46, this.Position.Y + 20), new Quaternion(0, 0, 0, 0), this.BulletSpeed);

            Game1.playerBulletVolley.Add(currentBullet2);
        }
    }
}
