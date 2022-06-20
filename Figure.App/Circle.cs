namespace Figure.App;

public class Circle : Figure
{
    public const double PI = 3.14;
    public double Radius { get; set; }
    
    public override double GetSquare()
    {
        return PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * PI * Radius;
    }
}