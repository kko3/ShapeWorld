namespace ShapeWorld.Domain.Models
{
    class Cube : Square
    {
        public double Height { 
          get
          {
            return edgeLength;
          } 
          set
          {
            edgeLength = value;
          } 
        }
        public override double SurfaceArea(){
          return 6 * (edgeLength * edgeLength);
        }

        public override double Volume(){
          return (edgeLength * edgeLength * edgeLength);
        }

        public Cube(int edges){
          NumberOfEdges = edges;
        }
    }
}