using System;

class Program
{
    static void Main(string[] args)
    {

        /* 
        1. Ask the user for their grade percentage, then write a series of 
        if-elif-else statements to print out the appropriate letter grade. 
        (At this point, you'll have a separate print statement for each grade 
        letter in the appropriate block.) 
        */

        Console.Write("\ngrade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        string letter;

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = gradePercentage % 10;
        string sign;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (gradePercentage >= 97 || gradePercentage <= 59)
        {
            sign = "";
        }

        Console.WriteLine($"letter grade: {letter}{sign}");

        /* 
        2. Assume that you must have at least a 70 to pass the class.
        After determining the letter grade and printing it out. Add a separate 
        if statement to determine if the user passed the course, and if so display 
        a message to congratulate them. If not, display a different message to 
        encourage them for next time. 
        */

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations! you have passed the course.\n");
        }
        else
        {
            Console.WriteLine("We sorry, you did not pass the couse.");
            Console.WriteLine("But you can try again, don't give up!\n");
        }

    }

}