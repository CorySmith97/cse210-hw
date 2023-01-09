using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A random number has been generated. Take a guess!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int userNumberInt = 0;

        while (userNumberInt != number)
        {
            Console.WriteLine("What is your guess?");

            string userNumber = Console.ReadLine();
            userNumberInt = Convert.ToInt32(userNumber);
            if (userNumberInt == number)
            {
                Console.WriteLine("You got it!");
            }

            else if (userNumberInt >= number)
            {
                Console.WriteLine("Lower");
            }

            else if (userNumberInt <= number)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}