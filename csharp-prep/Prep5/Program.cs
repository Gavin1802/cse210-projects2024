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

        void PrintName(string name) {
            if (name.Length == 0){
                return;
            }
            System.Console.WriteLine($"Name is {name}");
        }

        PrintName("Bob");

        // functions should always start with capital letters!!

        //variabe scope
        var y = 0;
        { 
            var w = 10;
        }
    }
}