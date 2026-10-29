using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismUppg.Entities
{
    internal class Circle : GeometryAbst
    {
        public double Radius { get;  set; }


        public Circle()
        {
            Radius = 4.0;
        }
        // Implementerar den abstrakta metoden Area() från GeometryAbst-klassen
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
