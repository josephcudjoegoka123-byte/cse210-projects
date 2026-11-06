using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();
        
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = prompts.GetRandomPrompt();
                Console.WriteLine(prompt);
                
                string response = Console.ReadLine();

                Entry entry = new Entry()
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = prompt,
                    _entryText = response
                };
                journal.AddEntry(entry);
            }
            else if (choice == 2) journal.DisplayAll();
            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                journal.LoadFromFile(Console.ReadLine());
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                journal.SaveToFile(Console.ReadLine());
            }
        }
    }
}