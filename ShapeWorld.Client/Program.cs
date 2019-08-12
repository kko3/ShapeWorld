using System;
using ShapeWorld.Domain.Collections;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
    public static object ShapeArray { get; private set; }

    private static void Main(string[] args)
        {
            //PlayWithShapes();
            //PlayWithCollections();
            PlayWithGeneric();
        }

        private static void PlayWithShapes(){
          Shape someShape = new Rectangle();
          Square someSquare = new Square();
          Shape someCube = new Cube();
          
          Console.WriteLine(someShape.Volume());
          Console.WriteLine(someSquare.NumberOfEdges);
        }

        private static void PlayWithCollections(){
          ShapeArray sa = new ShapeArray();
          sa.DimensionalArray();
          sa.MyList();
          sa.MyDictionary();
        }

        private static void PlayWithGeneric()
        {
          var gs = new GenericShape<string>();

          gs.SayHello("shape");
          gs.SayHello(new Triangle());

          var gs2 = new GenericShape<Shape>();

          gs2.SayHello(new Rectangle());

          var gs3 = new GenericShape<Square>();
          gs3.SayHello(new Square());
        }
    }
}
