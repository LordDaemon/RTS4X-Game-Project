using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RTS4X_Game_Project.CoreClasses
{
    public class Simulation : Interfaces.ISimObject
    //Responsible for threading 'n stuff.
    {
        protected GameWorld gameWorld;

        public Simulation()
        {
            gameWorld = new GameWorld();
            //UI = new UI();
        }

        public void UpdateP(GameTime GT)
        {
            //TODO: Threading...
            foreach (StaticObject obj in gameWorld.AllSimulationObjects)
            {
                obj.UpdateP(GT);
            }
        }

        public void UpdateS(GameTime GT)
        {
            for (int i = gameWorld.AllSimulationObjects.Count; i >= 0; i--)
            {
                gameWorld.AllSimulationObjects[i].UpdateS(GT);
            }
        }

        public void Draw(GameTime GT/*, SpriteBatch SB*/)
        { 
            for (int i = gameWorld.AllDrawObjects.Count; i >= 0; i--)
            {
                gameWorld.AllDrawObjects[i].Draw(GT/*, SB*/);
            }
        }
    }
}
