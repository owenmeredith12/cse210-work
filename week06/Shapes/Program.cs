using System;

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape("green");
        Square square = new Square(12, "green");

        square.getColor();
        square.getArea(square.getSide());
    }
}