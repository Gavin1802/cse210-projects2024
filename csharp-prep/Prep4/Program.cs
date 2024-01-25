using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // lists are of only one type, like all ints, or all floats

        List<int> myInts = new List<int>();
        int num = 1;
        System.Console.WriteLine("Enter a list of numbers to add to a list, type 0 when finished.");

        while(num != 0)
        {
            //prompt the user for numbers for myInts and add their number to the list
            System.Console.Write("Enter a Number: ");
            num = int.Parse(Console.ReadLine());
            myInts.Add(num);
        }

        if(num == 0){
            //Sum up and print the ints in the list
            int sum = myInts.Sum();
            Console.WriteLine($"The sum is {sum}.");

            //Calculate and print the average
            var average = myInts.Count > 0 ? myInts.Average() : 0;
            System.Console.WriteLine($"The average is {average}.");

            //Display the largest number
            int largest = myInts.Max();
            System.Console.WriteLine($"The largest number is: {largest}");
        }
    }
}