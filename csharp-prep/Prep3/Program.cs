using System;

class Program
{
    static void Main(string[] args)
    {
        /* 
        1. Start by asking the user for the magic number. (In future steps, 
        we will change this to have the computer generate a random number, 
        but to get started, we'll just let the user decide what it is.)
        Ask the user for a guess.
        Using an if statement, determine if the user needs to guess higher 
        or lower next time, or tell them if they guessed it. 
        At this point, you won't have any loops.
        */
        // Console.Write("What is the magic number? ");
        // string number1 = Console.ReadLine();
        // int magicNumber = Int16.Parse(number1);

        // Console.Write("What is your quess? ");
        // string number2 = Console.ReadLine();
        // int myNumber = Int16.Parse(number2);

        // if (myNumber < magicNumber)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else if (myNumber > magicNumber)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else
        // {
        //     Console.WriteLine("You guessed it!");
        // }

        /*
        2. Add a loop that keeps looping as long as the guess does not match 
        the magic number. At this point, the user should be able to keep playing 
        until they get the correct answer. 
        */
        // Console.Write("What is the magic number? ");
        // string number1 = Console.ReadLine();
        // int magicNumber = Int16.Parse(number1);

        // int myNumber = 0;

        // while (myNumber != magicNumber)
        // {
        //     Console.Write("What is your guess? ");
        //     string number2 = Console.ReadLine();
        //     myNumber = Int16.Parse(number2);

        //     if (myNumber < magicNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (myNumber > magicNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }
        // }

        /*
        3. Instead of having the user supply the magic number, generate a random 
        number from 1 to 100. Play the game and make sure it works!
        */
        // Random randomNumber = new Random();
        // int magicNumber = randomNumber.Next(1, 100);
        // int myNumber = 0;

        // while (myNumber != magicNumber)
        // {
        //     Console.Write("What is guess? ");
        //     string number = Console.ReadLine();
        //     myNumber = Int16.Parse(number);

        //     if (myNumber < magicNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (myNumber > magicNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }
        // }

        /*
        Stretch Challenge
        1. Keep track of how many guesses the user has made and inform them of it 
        at the end of the game.
        2. After the game is over, ask the user if they want to play again. Then, 
        loop back and play the whole game again and continue this loop as long as 
        they keep saying "yes".
        */
        string playingAgain = "yes";

        while (playingAgain == "yes")
        {   
            Random randomNumber = new Random();           
            int magicNumber = randomNumber.Next(1, 100);
            int myGuess = 0;
            int trackGuesses = 0;

            while (myGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string number = Console.ReadLine();
                myGuess = Int16.Parse(number);
                trackGuesses += 1;

                if (myGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (myGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"It took you {trackGuesses} guesses");
            Console.Write("Do you want to continue (yes/no)? ");
            playingAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing.");

    }

}