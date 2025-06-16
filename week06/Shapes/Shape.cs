using System.Formats.Asn1;
using System.Runtime.InteropServices;

public class Shape
{
    private string _color;


    public Shape(string color)
    {
        _color = color;
    }

    public void setColor(string color)
    {
        _color = color;
    }

    public string getColor()
    {
        Console.WriteLine(_color);
        return _color;
    }

    public virtual double getArea(int side)
    {
        double area;
        area = side * side;
        return area;
    }
}