using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Galactica
{
    public class LevelUp : PowerUp
    {
        public override void Initialize(Texture2D texture, Vector2 position)
        {
            Active = true;
            Texture = texture;
            Position = position;
            MoveSpeed = 3;
        }

        public override void Update()
        {
            Position.Y += MoveSpeed;
        }
    }
}
