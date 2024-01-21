using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // lists are only one type of thing, like all ints, or all floats

        List<int> myInts = new List<int>();
        var moreInt = new List<int>();

        moreInt.Add(34);
        moreInt.Add(10);


        foreach(var n in moreInt) {
            System.Console.WriteLine($"n = {n}");
        }

        


    }
}