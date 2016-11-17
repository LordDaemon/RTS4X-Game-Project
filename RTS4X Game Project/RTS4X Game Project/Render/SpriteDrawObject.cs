using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.Render
{
    class SpriteDrawObject : DrawObject
    {
        private Texture2D sprite; //TODO Add support for sprithsheet stuff --> multiple sprites frommsingle file...
        public SpriteDrawObject(string assetName) : base(assetName)
        {
            //load sprite
            
        }

        public override void Draw(GameTime GT)
        {
            
        }
    }
}
