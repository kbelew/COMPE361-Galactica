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
        }

        public override void Update()
        {
            //TODO: Everything
            
            
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

        public override void Fire()
        {
            throw new NotImplementedException();
        }

        public override void Reload()
        {
            throw new NotImplementedException();
        }
    }
}
