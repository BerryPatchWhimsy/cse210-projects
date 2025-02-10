
public class Circle : Shapes
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double pi = Math.PI;
        double r2 = _radius * _radius;
        return pi * r2;
    }
}