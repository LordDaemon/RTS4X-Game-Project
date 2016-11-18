using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RTS4X_Game_Project.CoreClasses
{
    public class Unit : DynamicObject
    {
        private /*enum?*/ string team;
        public UnitBlueprint unitBlueprint; //refers to the type / blueprint this unit was made with.
        //public pathfinder thing
        //public AI thing
        

        public Unit(StaticObject gameWorld, UnitBlueprint unitBlueprint) : base(gameWorld)
        {
            this.unitBlueprint = unitBlueprint;
        }

        public override void UpdateP(GameTime GT)
        {
            base.UpdateP(GT);
            //do path stuff.
        }

        public override void UpdateS(GameTime GT)
        {
            base.UpdateS(GT);
            //do whatever else.
        }




        public override Vector3 Velocity 
        {
            get { return velocity; }
            set { velocity = new Vector3(MathHelper.Clamp(unitBlueprint.maxSpeed.W, unitBlueprint.maxSpeed.X, value.X),
                                        MathHelper.Clamp(unitBlueprint.maxSpeed.Y, unitBlueprint.maxSpeed.Y, value.Y),
                                        MathHelper.Clamp(unitBlueprint.maxSpeed.Z, unitBlueprint.maxSpeed.Z, value.Z)); } 
            //TODO This limit should be moved to the moving/path logic, the velocity could involuntairaly become higher than the unit is DESIGNED to move.
            //DynamicObject will have some sanity check later.
        }
    }
}
