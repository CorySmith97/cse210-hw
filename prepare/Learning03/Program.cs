using System;

class Program
{
    static void Main(string[] args)
    {
        CSFraction f1 = new CSFraction(5,13);
        double csfactionDouble = f1.CSGetDecimalValue();
        string csfractionString = f1.CSGetFraction();

        Console.WriteLine(csfractionString);
        Console.WriteLine(csfactionDouble);
        
    }
}