using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismUppg.Entities
{
    internal abstract class GeometryAbst 
    {
        //Abtrakt metod. Deklareras i child-klasserna.
        abstract public double Area();
    }
}
