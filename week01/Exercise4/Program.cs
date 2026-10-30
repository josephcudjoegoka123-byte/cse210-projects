using System;
using System.Globalization;

class Program


{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 to quit.");
            string answer = Console.ReadLine();
            userNumber = int.Parse(answer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float )sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest is: {largest}");

        int? smallestPositive = null;

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallestPositive == null || number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }

        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        numbers.Sort();

        Console.WriteLine("Sorted list:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        }   
}


