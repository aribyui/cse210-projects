using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        Console.Write("\nWhat is your first name? ");
        string name = Console.ReadLine();
        name = char.ToUpper(name[0]) + name.Substring(1); // https://www.delftstack.com/howto/csharp/csharp-capitalize-first-letter/

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        last = char.ToUpper(last[0]) + last.Substring(1); // https://www.delftstack.com/howto/csharp/csharp-capitalize-first-letter/

        Console.WriteLine($"\nYour name is: {last}, {name} {last}.\n");
    
    }
}