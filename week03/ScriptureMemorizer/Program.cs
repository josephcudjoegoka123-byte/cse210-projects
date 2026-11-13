// Exceeded the program requirement by adding a library of 5 scriptures rather than a single one. Choose scriptures 
// at random to present to the user.


using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>();

        library.Add(new Scripture(new Reference ("John", 3, 16),
        "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"));

        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), 
        "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths"));

        library.Add(new Scripture(new Reference("Philippians", 4, 13), 
        "I can do all things through Christ which strengtheneth me"));

        library.Add(new Scripture(new Reference("Isaiah", 41, 10),
        "Fear thou not for I am with thee be not dismayed for I am thy God"));

         library.Add(new Scripture(new Reference("Psalm", 23, 1), 
        "The Lord is my shepherd I shall not want"));


        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(3);
    
        }
    }
}