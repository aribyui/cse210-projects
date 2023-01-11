using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        For this assignment, write a C# program that has several simple functions:

        DisplayWelcome - Displays the message, "Welcome to the Program!"
        PromptUserName - Asks for and returns the user's name (as a string)
        PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        DisplayResult - Accepts the user's name and the squared number and displays them.
        */

        // Calling functions
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquareNumber = SquareNumber(userNumber);
        DisplayResult(userName, userSquareNumber);        

        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the Program");
        }

        static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            string nameWithFirstCapitalLetter = char.ToUpper(name[0]) + name.Substring(1);
            return nameWithFirstCapitalLetter;
        }

        static int PromptUserNumber()
        {          
            Console.Write("Please enter your favorite number: ");
            string value = Console.ReadLine(); // or: int number = int.Parse(Console.ReadLine());
            int number = int.Parse(value);
            return number;
        }

        static int SquareNumber (int userNumber)
        {
            int sqrtNum = userNumber * userNumber;
            return sqrtNum;
        }

        // static string DisplayResult(string userName, int userSquareNumber)
        // {
        //     Console.WriteLine($"{userName}, the square of your number is {userSquareNumber}");
        //     string result = Console.ReadLine();
        //     return result;
        // }

        // Sample Solution
        static void DisplayResult (string userName, int userSquareNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {userSquareNumber}");
        }

    }
}