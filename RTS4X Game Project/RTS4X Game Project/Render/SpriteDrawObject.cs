using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.Render
{
    public class SpriteDrawObject : DrawObject
    {
        private Texture2D sprite; //TODO Add support for sprithsheet stuff --> multiple sprites from single file...
        //parameters

        public SpriteDrawObject(CoreClasses.StaticObject parent, Texture2D sprite /*parameters*/) : base(parent)
        {
            this.sprite = sprite;    
            //this.parameters = parameters;        
        }

        public override bool Draw(GameTime GT, SpriteBatch SB)
        {
            if (!base.Draw(GT, SB)) return false;
            
            
            //stuff

            
            return true;//if we decide not to draw return false!
        }
    }
}
