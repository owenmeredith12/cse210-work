using System.Drawing;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

public class Square : Shape
{
    private int _side;
    public Square(int side, string color) : base(color)
    {
        _side = side;
    }

    public int getSide()
    {
        return _side;
    }


    public override double getArea(int side)
    {
        double area = side * side;
        Console.WriteLine(area);
        return area;
    }
}