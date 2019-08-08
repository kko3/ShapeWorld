namespace ShapeWorld.Domain.Models
{
  class Sphere : Circle
  {
     public override double SurfaceArea(){
       return 4 * (Radius*Radius) * 3.14;
     }
     public override double Volume(){
       return (4/3)*3.14*(Radius*Radius*Radius);
     }
  }
  
}