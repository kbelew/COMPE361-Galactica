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
            Texture = texture;
            Position = position;
        }

        public override void Update()
        {
            Position.Y += MoveSpeed;
        }
    }
}
