using System.Collections.Generic;
using ShapeWorld.Domain.Models;
using System.Linq;
using System;

namespace ShapeWorld.Domain.Collections
{
    public class ShapeArray
    {
        public void DimensionalArray()
        {
          //1-D
          Shape[] shaped = new Shape[10];
          Shape[] shaped2 = new Shape[]{ new Square()};

          //2-D
          Shape[,] shaped3 = new Shape[2,2];
          Shape[,] shaped4 = new Shape[,]
          {
            {new Square(),new Square()},
            {new Cube(),new Triangle()}
          };

          //3-D
          Shape[,,] shaped5 = new Shape[3,3,3];
          Shape[,,] shaped6 = new Shape[,,]
          {
            {{new Square(),new Square(),new Square()},{new Square(),new Square(),new Square()},{new Square(),new Square(),new Square()}},
            {{new Square(),new Square(),new Square()},{new Square(),new Square(),new Square()},{new Square(),new Square(),new Square()}},
            {{new Square(),new Square(),new Square()},{new Square(),new Square(),new Square()},{new Square(),new Square(),new Square()}},
          };

          //Read
          System.Console.WriteLine(shaped2[0]);
          System.Console.WriteLine(shaped4[1,0]);
          System.Console.WriteLine(shaped6[1,0,2]);

          //Write
          shaped2[0] = new Circle();
          shaped4[1,0] = new Cube();
          shaped6[1,0,2] = new Rectangle();

          //jagged array
          Shape[][] shaped7 = new Shape[10][];
          Shape[][] shaped8 = new Shape[][]
          {
            new Rectangle[10],
            new Circle[]{new Circle(),new Circle()}
          };
          System.Console.WriteLine(shaped8[1][1]);
        }

        public void MyList()
        {
          List<Shape> shaped = new List<Shape>();
          List<Shape> shaped2 = new List<Shape>{new Cube(),new Cube()};

          List<Shape[][,,]> shaped3 = new List<Shape[][,,]>();
          List<Shape[][,,]> shaped4 = new List<Shape[][,,]>{ new Shape[5][,,]};

          //Read
          System.Console.WriteLine(shaped2[1]);
          System.Console.WriteLine(shaped2.Find(e => e.NumberOfEdges == 4));
          System.Console.WriteLine(shaped2.FirstOrDefault(e => e.NumberOfEdges == 4));

          //Write
          shaped2[100] = new Rectangle();
          shaped2.Add(new Triangle());
          shaped2.AddRange(shaped2);

          //Remove
          shaped2.Remove(new Cube());
        }
        public void MyDictionary()
        {
          Dictionary<string,Shape> shaped = new Dictionary<string, Shape>();
          Dictionary<string,List<Shape>> shaped2 = new Dictionary<string, List<Shape>>
          {
            {"square",new List<Shape>()}
          };

          //Read
          System.Console.WriteLine(shaped2["square"]);
          shaped2.Select(d => d.Key == "square");

          //Write
          shaped2["square"] = new List<Shape>();
          shaped2.Add("square",new List<Shape>());
        }
    }
}