using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.CoreClasses
{    
    public class Simulation// : Interfaces.ISimObject must be public... !#**!??
    //Responsible for threading 'n stuff.
    {
        protected UInt64 simCycle; //the cycle of the simulation, one per Update() call (starts at 0, incremented to 1 before calling updateP() etc)
        protected GameWorld gameWorld;
        private UserInterface.SimDebugUI dUI;

        public Simulation()
        {
            simCycle = 0;
            gameWorld = new GameWorld();
            dUI = new UserInterface.SimDebugUI(this);
            //UI = new UI();
        }

        public void Update(GameTime GT)
        {
            simCycle++;
            //DoSimEvents()???
            UpdateP(GT);
            UpdateS(GT);
        }

        public void Reset()
        {
            gameWorld.Reset();
            simCycle = 0;
        }

        public UInt64 SimCycle
        {
            get { return simCycle; }
        }

        protected void UpdateP(GameTime GT)
        {
            //TODO: Threading...
            foreach (StaticObject obj in gameWorld.AllSimulationObjects)
            {
                obj.UpdateP(GT);
            }
        }

        protected void UpdateS(GameTime GT)
        {
            for (int i = gameWorld.AllSimulationObjects.Count -1; i >= 0; i--)
            {
                gameWorld.AllSimulationObjects[i].UpdateS(GT);
            }
        }

        public void Draw(GameTime GT, SpriteBatch SB)
        {
            dUI.Draw(GT, SB);
            for (int i = gameWorld.AllDrawObjects.Count -1; i >= 0; i--)
            {
                gameWorld.AllDrawObjects[i].Draw(GT, SB);
            }
        }
    }
}
