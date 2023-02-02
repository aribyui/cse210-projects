using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> promptsList = new List<string>();
        promptsList.Add("Who was the most interesting person I interacted with today?");
        promptsList.Add("What was the best part of my day?");
        promptsList.Add("How did I see the hand of the Lord in my life today?");
        promptsList.Add("What was the strongest emotion I felt today?");
        promptsList.Add("If I had one thing I could do over today, what would it be?");

        int numberOption = 0;

        Entry newEntry = new Entry();
        Journal j = new Journal();

        Console.WriteLine("\nWelcome to 'My Journal App'");

        while (numberOption != 5)
        {
            Console.WriteLine("\nPlease select on the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();
            numberOption = int.Parse(option);

            if (numberOption == 1)
            {
                // Write
                Random index = new Random();
                int randomIndex = index.Next(promptsList.Count());
                string randomPrompt = promptsList[randomIndex];
                Console.WriteLine(randomPrompt); // (e.g.) output: "What was the best part of my day?" or... "If I had one thing I could do over today, what would it be?"
                
                // retrieve user entry
                string userEntry = Console.ReadLine();
                // create a varible to store the current date
                string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
                newEntry._date = currentDate;
                newEntry._prompt = randomPrompt;
                newEntry._entry = userEntry;
                // newEntry.Display(); // (e.g.) output: Date: 29/01/2023 - Prompt: What was the best part of my day?\nstudy at my computer

                j._entries.Add(newEntry);                
            }
            else if (numberOption == 2)
            {
                j.DisplayRandomPrompt();
            }
        }

        // Test
        // Entry prompt1 = new Entry();
        // prompt1._entry = "Who was the most interesting person I interacted with today?";

        // Entry prompt2 = new Entry();
        // prompt2._entry = "What was the best part of my day?";

        // Journal prompt = new Journal();
        // prompt._entries.Add(prompt1);
        // prompt._entries.Add(prompt2);
        // prompt.DisplayRandomPrompt();

    }

}

// Resources:
// https://www.techiedelight.com/get-current-time-without-date-csharp/#:~:text=1.%20Using%20DateTime.ToString()%20method