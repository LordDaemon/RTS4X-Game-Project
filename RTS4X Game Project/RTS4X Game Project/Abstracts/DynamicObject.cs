using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RTS4X_Game_Project.Abstracts
{
    class DynamicObject : StaticObject
    {
        protected Vector3 velocity;
        protected Vector3 angularVelocity; //TODO shorter name.

        public DynamicObject(StaticObject gameWorld) : base(gameWorld)
        {

        }

        public override void UpdateP(GameTime GT)
        {
            base.UpdateP(GT);
            position += velocity * (float)GT.ElapsedGameTime.TotalSeconds;
        }

    }
}
