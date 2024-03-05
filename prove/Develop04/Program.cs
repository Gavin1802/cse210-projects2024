using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            var time = "How long, in seconds, would you like for your session? ";

            if (choice == "1")
            {
                Console.Clear();
                Console.Write($"{time}");
                int duration = int.Parse(Console.ReadLine());
                Breathing activity = new Breathing();
                activity.Start(duration);
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.Write($"{time}");
                int duration = int.Parse(Console.ReadLine());
                Reflection activity = new Reflection();
                activity.Start(duration);
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.Write($"{time}");
                int duration = int.Parse(Console.ReadLine());
                Listing activity = new Listing();
                activity.Start(duration);
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Goodbye! Come back soon!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
    }
}





