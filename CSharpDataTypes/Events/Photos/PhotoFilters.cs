﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Events.Photos
{
    class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }
}
