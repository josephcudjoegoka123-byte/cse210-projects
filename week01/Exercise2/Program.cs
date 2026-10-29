using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letterGrade = "";
        int lastDigit = percentage % 10;
        string sign = "";

        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        if (letterGrade == "A" && sign == "+")
        {
            sign = "";

        }
        if (letterGrade == "F")
        {
            sign = "";
        }


        Console.WriteLine($"Your grade is {letterGrade}{sign}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");

        }
        else
        {
            Console.WriteLine("Sorry, Better luck next time.");
        }
        
    }
}       

