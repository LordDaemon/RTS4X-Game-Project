using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS4X_Game_Project.Render
{
    public class DrawObjectCreator //This choses the correct DrawObject given an assetname and game settings.
    {
        public DrawObjectCreator(/*Parameters nececary to determine stuff! */)
        {

        }

        public DrawObject CreateDrawObject(CoreClasses.StaticObject parent, string assetName)
        {
            // Check: assetName valid foramt.
            // Check: Static / animated.
            // Check: assetName exists.
            // Check settings: sprite /3d.

            //everything else 
            DrawObject obj = new DrawObject(parent); //Temporary!
            return obj;
        }
    }
}
