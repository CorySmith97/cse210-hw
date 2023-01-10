using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();
        
        int userInputInt = 1;
        int largest = 0;

        while (userInputInt != 0)
        {
            Console.Write("Enter number: ");
            string userInt = Console.ReadLine();
            userInputInt = Convert.ToInt32(userInt);
            if (userInputInt == 0)
            {
                break;
            }
            else
            {
                numbers.Add(userInputInt);
            }
            
        }
        float sum = numbers.Sum();
        Console.WriteLine($"The sum of the numbers is {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is {average}");
        
        foreach (int num in numbers)
        {
            
            if (num >= largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is {largest}");
    }
}