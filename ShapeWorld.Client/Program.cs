using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayWithShapes();
        }

        private static void PlayWithShapes(){
          Shape someShape = new Rectangle();
          Square someSquare = new Square();
          
          Console.WriteLine(someShape.Volume());
          Console.WriteLine(someSquare.NumberOfEdges);
        }
    }
}
