using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.CoreClasses
{
    public class GameWorld
    {
        protected List<StaticObject> allSimulationObjects; //TODO not portected - able???
        protected List<Render.DrawObject> allDrawObjects;
        //UI
        //Teams
            //Victory/Defeat conditions
        //etc.
        //etc.

        public GameWorld ()
        {
            Reset();
        }

        public List<StaticObject> AllSimulationObjects { get { return allSimulationObjects; } }
        public List<Render.DrawObject> AllDrawObjects { get { return allDrawObjects; } }


        public virtual void Reset()
        {
            allSimulationObjects = new List<StaticObject>();
            allDrawObjects = new List<Render.DrawObject>();
            //UI = new UI();
        }

        public virtual void Add(StaticObject obj)
        {
            //checks?
            allSimulationObjects.Add(obj);
        }
        public virtual void Add(Render.DrawObject obj)
        {
            //checks?
            allDrawObjects.Add(obj);
        }

        public virtual void RemoveMe(StaticObject obj)
        {
            allSimulationObjects.Remove(obj);
        }
        public virtual void RemoveMe(Render.DrawObject obj)
        {
            allDrawObjects.Remove(obj);
        }
    }
}
