using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Telerik.WinControls.UI;

namespace Galactica
{
    public abstract class GameObject
    {
        public bool Active;
        public Vector2 Position;
        public Texture2D Texture;
        public Game1 Parent; //http://xboxforums.create.msdn.com/forums/t/54423.aspx
        public int Width => Texture.Width;

        public int Height => Texture.Height;
    }
}
