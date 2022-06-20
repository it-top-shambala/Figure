namespace Figure.App;

public class Rectangle : Figure
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    
    public override double GetSquare()
    {
        return SideA * SideB;
    }

    public override double GetPerimeter()
    {
        return 2 * (SideA + SideB);
    }
}