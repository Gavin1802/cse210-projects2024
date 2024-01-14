using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {   //First Name Question and Response
        string question1 = "What is your first name?";
        Console.Write(question1 + " ");
        var firstName = Console.ReadLine();

        //Last Names Question and Response
        string question2 = "What is your last name?";
        Console.Write(question2 + " ");
        var lastName = Console.ReadLine();

        Console.WriteLine("Your name is " + lastName + ", " + firstName + " " + lastName);
       
        }
    }