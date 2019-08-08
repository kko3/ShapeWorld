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
            PlayWithCollections();
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
    }
}
