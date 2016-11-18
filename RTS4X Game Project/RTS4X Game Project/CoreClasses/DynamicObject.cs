using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RTS4X_Game_Project.CoreClasses
{
    public class DynamicObject : StaticObject
    {
        protected Vector3 velocity;
        protected Vector3 angularVelocity; //RADIANS! //TODO shorter name.

        public DynamicObject(StaticObject gameWorld) : base(gameWorld)
        {

        }

        public override void UpdateP(GameTime GT)
        {
            base.UpdateP(GT);
            Position += Velocity * (float)GT.ElapsedGameTime.TotalSeconds;
            Rotation += AngularVelocity * (float)GT.ElapsedGameTime.TotalSeconds;
        }

        public virtual Vector3 Velocity
        {
            get { return velocity; }
            set { velocity = value; } //TODO: add some sanity check / limit? if ( NAN || INFINITY || etc. ) DoStuff();
        }

        public virtual Vector3 GlobalVelocity //Would be used for making projectiles, may be unnececary...
        {
            get
            {
                DynamicObject myDynamicParent = parent as DynamicObject; //StaticObject has no velocity. If parent is StaticObject the as should "return" null.
                if (parent != null && parent.GetType() != typeof(StaticObject)) return Velocity + myDynamicParent.GlobalVelocity;
                else return Velocity;
            }
        }

        public virtual Vector3 AngularVelocity
        {
            get { return angularVelocity; }
            set { angularVelocity = value; }
        }

        //TODO: Do we need global AngularVelocity??

    }
}
