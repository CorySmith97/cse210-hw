using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string name = GetUserName();
        int number = GetUserNumber();
        int result = SquareNumber(number);

        DisplayResults(name, result);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program. ");
    }
    static string GetUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int GetUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int result = number * number;

        return result;
    }
    static void DisplayResults(string name, int result)
    {
        Console.WriteLine($"{name}, your number sqaured is {result}");
    }
}