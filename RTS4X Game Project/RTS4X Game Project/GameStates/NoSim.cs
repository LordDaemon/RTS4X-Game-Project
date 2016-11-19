using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.GameStates
{
    public class NoSim : GameState
    {
        // The base GameState for states that do not have a Simulation.
        public NoSim(string name) : base(name)
        {

        }

        public override void Update(GameTime GT)
        {

        }

        public override void Draw(GameTime GT, SpriteBatch SB)
        {

        }
    }
}
