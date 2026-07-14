using System;
using System.Collections.Generic; 

public class Program
{
    static Journal journal = new Journal();
    static void Main(string[] args)
    {
       while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal entries to a file");
            Console.WriteLine("4. Load journal entries from a file");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                journal.SaveToFile();
            }
            else if (choice == "4")
            {
                journal.LoadFromFile();
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        
    }

   
}