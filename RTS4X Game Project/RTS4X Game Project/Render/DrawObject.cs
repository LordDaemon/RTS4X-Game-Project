using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.Render
{
    class DrawObject
    {
        public readonly string assetName; //should not be REset @ runtime.

        public DrawObject(string assetName = "")
        {
            this.assetName = assetName;
        }

        public virtual void UpdateP(GameTime GT) { }
        public virtual void Draw(GameTime GT/*, SpriteBatch SB*/) { }
    }
}
