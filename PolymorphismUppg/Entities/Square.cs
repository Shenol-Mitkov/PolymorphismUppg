using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismUppg.Entities
{
    internal class Square : GeometryAbst
    {
        public double Length { get; set; }

        public Square()
        {
            Length = 5.5;
        }
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
}
