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
    /// <summary>
    /// Most Base class of all Objects that Show up in Game
    /// </summary>
    public abstract class GameObject
    {
        // Is GameObject active?

        public bool Active;

        // 2D position of GameObject

        public Vector2 Position;

        // Texture assigned to GameObject

        public Texture2D Texture;

        // GalagaGame Class Parent

        public GalagaGame Parent; //http://xboxforums.create.msdn.com/forums/t/54423.aspx

        // Width of GameObject in pixels

        public int Width => Texture.Width;

        // Height of GameObject in pixels

        public int Height => Texture.Height;
    }
}
