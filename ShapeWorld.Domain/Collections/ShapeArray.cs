using ShapeWorld.Domain.Models;

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
        }
    }
}