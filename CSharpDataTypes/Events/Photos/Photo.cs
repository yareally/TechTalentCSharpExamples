using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Events.Photos
{
    class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save() { }
    }
}
