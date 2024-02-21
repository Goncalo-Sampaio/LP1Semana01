using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing multiple string variables and printing them
            string s1 = "A tab \t and a right arrow \u2192";
            string s2 = "A new line \n and a star \u2605";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
