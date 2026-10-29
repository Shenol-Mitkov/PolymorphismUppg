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
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
