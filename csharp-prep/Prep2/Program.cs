using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   //Say Hi and ask for their grade percentage
        Console.WriteLine("Hello! Welcome to my grade checker :)");
        Console.Write("Please type your grade percentage here: ");
        string gdPerc = Console.ReadLine();
        int number = int.Parse(gdPerc);
        var grd = "Your letter grade is a(n) ";
        string letter;
        var congrats = "You passed! Great job!";
        var encourage = "You didn't pass but you'll do better next time!";

        //If/Else for their letter grade
        if (number >= 90)
        {
            letter = "A";
            // Console.WriteLine(grd + "A");
            // Console.WriteLine(congrats);
        } 
        else if (number >= 80 && number < 90)
        {
            letter = "B";
            // Console.WriteLine(grd + "B");
            // Console.WriteLine(congrats);
        }
        else if (number >= 70 && number < 80)
        {
            letter = "C";
            // Console.WriteLine(grd + "C");
            // Console.WriteLine(congrats);
        }
        else if (number >= 60 && number < 70)
        {
            letter = "D";
            // Console.WriteLine(grd + "D");
            // Console.WriteLine(encourage);
        }
        else
        {
            letter = "F";
            // Console.WriteLine(grd + "F");
            // Console.WriteLine(encourage);
        }

            Console.WriteLine(grd + letter);

        if (number >= 70)
        {
            Console.WriteLine(congrats);
        }
        else
        {
            Console.WriteLine(encourage);
        }


    }
}