using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");


        // int count = 5;

        //while loop:
        // while (count < 10) 
        // {
        //     Console.WriteLine($"Count = {count}");
        //     count++;
        // }


        //do-while loop:
        // while (count < 15)
        //     Console.WriteLine($"Count = {count++}");
            
        // int anotherCount = 0;
        // do {
        //     System.Console.WriteLine($"AnotherCount = {++anotherCount}");
        // } while (anotherCount < 10);

        // for (int i=0; i<5; ++i) {
        //     System.Console.WriteLine($"i = {i}");
        // }
        System.Console.WriteLine($"Let's guess the magic number!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess = -1;
        
        while (guess != number) {

            System.Console.Write($"Please guess the number: "); 
            guess = int.Parse(Console.ReadLine());

            if (guess < number){
                System.Console.WriteLine("Guess Higher!");
            }
            else if (guess > number){
                System.Console.WriteLine("Guess Lower!");
            }
            else {
                System.Console.WriteLine("That's the Magic Number!! Great Job");
            }
        }
    }
}