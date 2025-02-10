using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> _shapes = new List<Shapes>();

        Square s1 = new Square("red", 2.4);
        Console.WriteLine(s1.GetArea());

        Rectangle r1 = new Rectangle("blue", 5, 3.5);
        Console.WriteLine(r1.GetArea());

        Circle c1 = new Circle("pink", 8);
        Console.WriteLine(c1.GetArea());

        _shapes.Add(s1);
        _shapes.Add(c1);
        _shapes.Add(r1);

        foreach (Shapes shape in _shapes)
        {
            DisplayShapeInformation(shape);
        }

    }

    public static void DisplayShapeInformation(Shapes shape)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            
            Console.WriteLine("");
            Console.WriteLine($"Shape: {shape}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine("");
        }
}