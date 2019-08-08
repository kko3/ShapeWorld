namespace ShapeWorld.Domain.Models
{
    public class Circle : Shape
    {
        protected double Radius{get;set;}

        public override double Parimeter(){
          return 2 * 3.14 * Radius;
        }

        public override double Area(){
          return 3.14 * (Radius * Radius);
        }

        public override double Volume(){
          return 0;
        }

        public Circle() : base(1){

        }
    }
}