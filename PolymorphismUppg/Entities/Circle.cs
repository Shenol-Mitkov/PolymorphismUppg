using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismUppg.Entities
{
    internal class Circle : GeometryAbst
    {
        public double Radius { get;  set; }
        
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
