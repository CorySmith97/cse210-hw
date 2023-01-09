using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int userNumberInt = 14;

        while (userNumberInt != number)
        {
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