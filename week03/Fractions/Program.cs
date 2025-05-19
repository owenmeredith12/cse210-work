using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(4, 2);
        fraction.setBottom(3);
        fraction.setTop(3);
        fraction.getDecimalValue();
        fraction1.getDecimalValue();
        fraction.getFractionString();
        fraction1.getFractionString();

    }
}