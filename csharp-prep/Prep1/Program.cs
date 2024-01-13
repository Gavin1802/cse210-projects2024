using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string myName = "Peterson";

        Console.WriteLine("A Name: " + myName);


        //readLine
        System.Console.WriteLine("What's your age?");
        var ageString = Console.ReadLine();

        //Converting Variables
        var age = int.Parse(ageString);

        //Conditionals
        if (age < 18) { //curly braces creates blocks
            System.Console.WriteLine("You're a minor");
            System.Console.WriteLine("And you're cringe");
        }
        else{
            System.Console.WriteLine("You're Old");
        }
        
        }
    }
}