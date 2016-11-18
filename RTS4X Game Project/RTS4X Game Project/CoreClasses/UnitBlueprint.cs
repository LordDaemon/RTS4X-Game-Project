using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RTS4X_Game_Project.CoreClasses
{
    public class UnitBlueprint //class that contains things that are the same for a given unit type. Is generated from file.
    {
        //spawn animation
        public int maxHealth; //...
        public Vector4 maxSpeed; //how fast may we move? W is reverse! (thus negative).
        public Vector3 maxAngularSpeed; //how fast may we turn?
        public float maxTerrainAngle; //tha maximum terrain angle the pathfinder will path on
        public Vector3 terrainAngleVelocityPenalty; //the penalty modifier for moving on sloped terrain. X for climbing up a slope, Y for going down slope, Z for moving but not climbing.
        //death animation (May contain multiple options and chose deterministacally.)
        //death wreckage (contains particles etc.)
        
    }
}
