using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade this semeser? ");
        string strGrade = Console.ReadLine();
        int grade;
        grade = Convert.ToInt32(strGrade);

        if (grade >= 90)
        {
            Console.WriteLine("Your grade was an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade was a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade was a C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade was a D");
        }
        else if (grade <= 59)
        {
            Console.WriteLine("Your grade was a F");
        }
    }
}