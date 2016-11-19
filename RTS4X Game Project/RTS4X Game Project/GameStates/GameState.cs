using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.GameStates
{
    public abstract class GameState //base for all gamestates.
    {
        public string name;
        protected CoreClasses.GameStateManager gameStateManager;

        public GameState(string name)
        {
            this.name = name;
        }

        public void Add(CoreClasses.GameStateManager GSManager)
        {
            this.gameStateManager = GSManager;
        }

        public abstract void Update(GameTime GT);
        public abstract void Draw(GameTime GT, SpriteBatch SB);

        //public virtual Reset() {} //Do we need this ????
    }
}
