using System.Drawing;

public abstract class Shapes
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public Shapes(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

}