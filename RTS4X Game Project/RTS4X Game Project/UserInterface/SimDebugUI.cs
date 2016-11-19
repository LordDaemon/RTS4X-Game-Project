using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.UserInterface
{
    class SimDebugUI
    {
        private CoreClasses.Simulation sim;
        public SimDebugUI (CoreClasses.Simulation sim)
        {
            this.sim = sim;
        }

        public void Update(GameTime GT)
        {

        }

        public void Draw(GameTime GT, SpriteBatch SB)
        {            
            SB.DrawString(CoreClasses.GameEnviornment.debugFont, "SimCycle: " + Convert.ToString(sim.SimCycle) + "\nIngameTime: " + GT.TotalGameTime.ToString(), new Vector2(0, 0), Color.White);
        }
    }
}
