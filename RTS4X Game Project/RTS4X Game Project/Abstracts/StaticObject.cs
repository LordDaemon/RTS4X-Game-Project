using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RTS4X_Game_Project.Abstracts
{
    abstract class StaticObject
    {
        public readonly string UID; //Unique IDentifier.
        protected StaticObject parent;
        protected IList<StaticObject> children;
        protected Render.DrawObject drawObject;
        protected Vector3 position;
        protected Vector3 rotation;

        public StaticObject(StaticObject gameWorld)
        {
            //UID = gameWorld.GetUID()

            // Register to SIM
        }

        public virtual void UpdateP(GameTime GT) //This is the paralel update sycle, should onely change this instance!
        {
            drawObject.UpdateP(GT);
        }     

        public virtual void UpdateS(GameTime GT) //This is the sequential update sycle, objects called in deterministic order.
        {

        }

        public virtual void Draw(GameTime GT)
        {
            drawObject.Draw(GT);
        }
        
    }
}
