using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Events.Photos
{
    class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }
}
