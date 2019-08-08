namespace ShapeWorld.Domain.Models
{
   public class Triangle : Shape
   {
     double Length{get;set;}
     double Width{get;set;}

     double Side{get;set;}

    double Height{get;set;}

     public override double Parimeter(){
       return Length + Width + Side;
     }
     public override double Area(){
       return Length * (Height * .5);
     }

     public override double Volume(){
       return 1;
     }

     public Triangle() : base(3)
     {}
   }
}