using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RTS4X_Game_Project.CoreClasses
{
    public abstract class StaticObject
    {
        public readonly string UID; //Unique IDentifier.
        public StaticObject parent;
        public List<StaticObject> children;
        public Render.DrawObject drawObject; 
        //protected Render.DrawObject icon; //Strategic icon
        protected Vector3 position;
        protected Vector3 rotation; //RADIANS!

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

        public void Remove()
        {
            drawObject.Remove();
            for (int i = children.Count - 1; i >= 0; i--)
            {
                children[i].Remove();
            }
            //GameWorld.RemoveMe(this);
        }

        public virtual Vector3 Position
        {
            get { return position; }
            set { position = value; }
        }

        public virtual Vector3 GlobalPosition
        {
            get {
                if (parent != null) return position + parent.GlobalPosition;
                else return position;
            }
        }

        public virtual Vector3 Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public virtual Vector3 GlobalRotation
        {
            get {
                if (parent != null) return Rotation + parent.GlobalRotation;
                else return Rotation;
            }
        }

        public virtual void Draw(GameTime GT)
        {
            drawObject.Draw(GT);
        }
        
    }
}
