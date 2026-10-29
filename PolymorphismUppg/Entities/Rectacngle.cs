using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismUppg.Entities
{
    internal class Rectangle : GeometryAbst
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 3.2;
            Height = 8.0;
        }
        // Implementerar den abstrakta metoden Area() från GeometryAbst-klassen
        public override double Area()
        {
            return Width * Height;
        }   
    }
}
