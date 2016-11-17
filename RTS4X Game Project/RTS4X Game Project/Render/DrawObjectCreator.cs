using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS4X_Game_Project.Render
{
    class DrawObjectCreator //This choses the correct DrawObject given an assetname and game settings
    {
        public DrawObjectCreator(/*Parameters nececary to determine stuff! */)
        {

        }

        public DrawObject CreateDrawObject(string assetName)
        {
            // Check assetName valid.
            // Check: Static / animated.
            // Check: assetName exists.
            // Check settings: sprite /3d.


            DrawObject obj = new DrawObject(assetName); //Temporary!
            return obj;
        }
    }
}
