using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        // Functions
        // returnType FunctionName(ParameterTypeEncoder paramName1, ParameterTypeEncoder paramName2)
        // {
        //     Function body
        // }


        int Add2 (int number) {
            return number + 2;
        }

        int more = Add2(10);

        static void DisplayWelcome() {
            System.Console.WriteLine($"Welcome to the Program!");
        }

        static string PromptUserName() {
            System.Console.Write($"Please enter your name: ");
            string userName = System.Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber() {
            System.Console.Write($"Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int PromptUserNumber) {
            return PromptUserNumber * PromptUserNumber;
        }

        static void DisplayResult(string PromptUserName, int SquareNumber){
            System.Console.WriteLine($"{PromptUserName}, the square of your number is {SquareNumber}"); 
        }
       
       
        // void PrintName(string name) {
        //     if (name.Length == 0){
        //         return;
        //     }
        //     System.Console.WriteLine($"Name is {name}");
        // }

        // PrintName("Bob");

        // functions should always start with capital letters!!

        //variabe scope
        // var y = 0;
        // { 
        //     var w = 10;
        // }
    }
}