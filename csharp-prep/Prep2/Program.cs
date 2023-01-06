using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade this semeser? ");
        string strGrade = Console.ReadLine();
        int grade;
        grade = Convert.ToInt32(strGrade);

        string gradeLetter = "";

        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.Write($"Your Letter Grade was {gradeLetter}");
        

        if (gradeLetter == "A" || gradeLetter == "B" || gradeLetter == "C")
        {
            Console.WriteLine("Congratulations! You Pass!");
        }
        else
        {
            Console.WriteLine("Sorry, You Failed");
        }
    }
}