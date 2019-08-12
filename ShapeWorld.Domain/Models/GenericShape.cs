using ShapeWorld.Domain.Interfaces;

namespace ShapeWorld.Domain.Models
{
    public class GenericShape<S> where S : IThreeD
    {
        public void SayHello<T>(S shape)  where T : Shape
        {
          System.Console.WriteLine($"S is called {shape}");
        }
        public void SayHello(Shape shape)
        {
          System.Console.WriteLine($"Shape is called {shape}");
        }
    }
}