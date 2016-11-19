using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.GameStates
{
    class SimGo : GameState // Sim running
    {
        public SimGo(string name) : base(name)
        {

        }

        public override void Update(GameTime GT)
        {
            gameStateManager.simulation.Update(GT);
            //UI.Update(GT); ???
        }

        public override void Draw(GameTime GT, SpriteBatch SB)
        {
            gameStateManager.simulation.Draw(GT, SB);
            //UI.Draw(GT); ???
        }

    }
}
