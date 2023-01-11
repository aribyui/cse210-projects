using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        1. Compute the sum, or total, of the numbers in the list.
        2. Compute the average of the numbers in the list.
        3. Find the maximum, or largest, number in the list.
        */
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        float average;

        // Console.WriteLine("Enter a list of numbers, type 0 when finished");

        // while (number != 0)
        // {
        //     Console.Write("Enter a number: ");
        //     string value = Console.ReadLine();
        //     number = int.Parse(value);

        //     if (number > 0)
        //     {
        //         numbers.Add(number);
        //         sum += number;
        //     }
        // }

        // foreach(int i in numbers)
        // {
        //     sum += i;
        // }

        // Part 2: Compute the average ...
        // https://github.com/byui-cse/cse210-student-sample-solutions/blob/main/csharp-prep/Prep4/Program.cs
        // average = ((float)sum) / numbers.Count; 

        // Console.WriteLine($"The sum is: {sum}");
        // Console.WriteLine($"The average is: {average}");
        // Console.WriteLine($"The largest number is: {numbers.Max()}");

        // --------------------------------------------------------------------------------------------------

        /*
        Stretch Challenge
        1. Have the user enter both positive and negative numbers, 
        then find the smallest positive number (the positive number 
        that is closest to zero).
        2. Sort the numbers in the list and display the new, sorted 
        list. Hint: There are C# libraries that can help you here, 
        try searching the internet for them.
        */
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string numberAsString = Console.ReadLine();
            number = int.Parse(numberAsString);

            if (number > 0 || number < 0) // if number (number != 0)
            {
                numbers.Add(number);
                // sum += number;
            }
        }

        foreach (int i in numbers)
        {
            sum += i;
        }

        average = ((float)sum) / numbers.Count;
        int largestNumber = numbers.Max();

        // I still have doubts in how to find the smallest positive number
        // int smallestPositiveNumber = numbers.Min();
        // foreach (int i in numbers)
        // {
        //     if (i < smallestPositiveNumber && i > 0)
        //     {
        //         smallestPositiveNumber = i;
        //     }
        // }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        // Console.WriteLine($"The smallest positive is: {smallestPositiveNumber}");

        numbers.Reverse();
        numbers.Sort();

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}

