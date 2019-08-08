namespace ShapeWorld.Domain.Models
{
  public class Square : Rectangle
  {
    protected double edgeLength;
    public override double Width {
      get
      {
        return edgeLength;
      }
      set
      {
        edgeLength = value;
      }
    }
    public override double Length {
      get
      {
        return edgeLength;
      }
      set
      {
        edgeLength = value;
      }
    }
    public override double Parimeter()
    {
      return 4 * Length;
    }   
  }
}