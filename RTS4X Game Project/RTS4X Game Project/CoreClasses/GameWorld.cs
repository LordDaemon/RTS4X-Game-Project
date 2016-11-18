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
        List<StaticObject> allSimulationObjects; //TODO not portected - able???
        List<Render.DrawObject> allRenderObjects;
        //UI
        //Teams
            //Victory/Defeat conditions
        //etc.
        //etc.

        public GameWorld ()
        {
            Reset();
        }


        public virtual void Reset()
        {
            allSimulationObjects = new List<StaticObject>();
            allRenderObjects = new List<Render.DrawObject>();
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
            allRenderObjects.Add(obj);
        }

        public virtual void RemoveMe(StaticObject obj)
        {
            allSimulationObjects.Remove(obj);
        }
        public virtual void RemoveMe(Render.DrawObject obj)
        {
            allRenderObjects.Remove(obj);
        }


        public virtual void Draw(GameTime GT/*, SpriteBatch SB*/)
        {
            foreach (Render.DrawObject obj in allRenderObjects) obj.Draw(GT /*, SB*/);
        }
    }
}
