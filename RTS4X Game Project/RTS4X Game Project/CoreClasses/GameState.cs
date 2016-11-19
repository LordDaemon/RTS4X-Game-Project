using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RTS4X_Game_Project.CoreClasses
{
    public class GameState
    {
        public string name;

        public GameState(string name)
        {
            this.name = name;
        }

        public virtual void Update(GameTime GT)
        {

        }

        public virtual void Draw(GameTime GT/*, SpriteBatch SB*/)
        {

        }

        //public virtual Reset() {} //Do we need this ????
    }
}
