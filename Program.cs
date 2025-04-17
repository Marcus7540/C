using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Title = "My Sticky Notes App";
        List<string> stickyNotes = new List<string>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Sticky notes (type 'list' to view all, 'exit' to quit):");
            string sticky = Console.ReadLine();

            if (sticky.ToLower() == "exit")
            {
                break;
            }
            else if (sticky.ToLower() == "list")
            {
                Console.Clear();
                Console.WriteLine("All Sticky Notes:\n");
                if (stickyNotes.Count == 0)
                {
                    Console.WriteLine("No notes yet.");
                }
                else
                {
                    foreach (string note in stickyNotes)
                    {
                        Console.WriteLine("- " + note);
                    }
                }
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
            else
            {
                stickyNotes.Add(sticky);
            }
        }
    }
}
