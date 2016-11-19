using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.Render
{
    public class DrawObject
    {
        public bool visible; //onely used by other classes
        protected readonly CoreClasses.StaticObject parent; //needed to figure out position etc.

        public DrawObject(CoreClasses.StaticObject parent)
        {
            //CoreClasses.GameWorld.Add(this);
        }

        public void Remove()
        {
            //GameWorld.RemoveMe(this);
        }

        public virtual void UpdateP(GameTime GT) { }
        public virtual bool Draw(GameTime GT, SpriteBatch SB)
        {
            return visible;
        }
    }
}
