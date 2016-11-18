using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS4X_Game_Project.Render.RenderExceptions
{
    public class InvalidAssetNameExeption : System.Exception //Assetname could not be understood.
    {
        public InvalidAssetNameExeption() : base() { }
        public InvalidAssetNameExeption(string message) : base(message) { }
        public InvalidAssetNameExeption(string message, System.Exception inner) : base(message, inner) { }

        protected InvalidAssetNameExeption(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext contect) { }
    }

    public class AssetNotFoundExeption : System.Exception //The asset could not be found.
    {
        public AssetNotFoundExeption() : base() { }
        public AssetNotFoundExeption(string message) : base(message) { }
        public AssetNotFoundExeption(string message, System.Exception inner) : base(message, inner) { }

        protected AssetNotFoundExeption(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext contect) { }
    }
}
