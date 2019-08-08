namespace ShapeWorld.Domain.Models
{
    public abstract class Shape
    {
        //backing fields

        //properties
        public int NumberOfEdges {get; protected set;}
        //methods
        public virtual double Parimeter()
        {
          return 0;
        }

        public virtual double SurfaceArea()
        {
          return 0;
        }
        public abstract double Area();

        public abstract double Volume();        

        //controllers
        public Shape(int edges)
        {
          NumberOfEdges = edges;
        }
    }
}