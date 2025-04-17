using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Title = "Sticky Notes In C# :)";

        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "stickynotes.txt");
        List<string> stickyNotes = new List<string>();

        // Check if file exists and load notes
        if (File.Exists(filePath))
        {
            stickyNotes.AddRange(File.ReadAllLines(filePath));
        }

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
                File.AppendAllText(filePath, sticky + Environment.NewLine); // Save to file

                Console.WriteLine("\nPress Enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
