using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RTS4X_Game_Project.Interfaces
{
    public interface ISimObject
    {
        void UpdateP(GameTime GT);
        void UpdateS(GameTime GT);
    }
}
