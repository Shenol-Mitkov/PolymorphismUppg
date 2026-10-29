using PolymorphismUppg.Entities;

namespace PolymorphismUppg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar objekten 
            GeometryAbst circle = new Circle();
            GeometryAbst rectangle = new Rectangle();
            GeometryAbst square = new Square();

            // Använder polymorfism för att beräkna arean för varje objekt
            foreach (var shape in new GeometryAbst[] { circle, rectangle, square })
            {
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area()}");
            }

            Console.ReadLine();
        }
    }
}
