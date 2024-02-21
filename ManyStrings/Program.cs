using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing variables and printing them with different formatting
            double xx = 1.23456;
            int ii = 19;
            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");
            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");

            //Initializing multiple string variables and printing them
            string s1 = "A tab \t and a right arrow \u2192";
            string s2 = "A new line \n and a star \u2605";
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //Initializing multiple string variables using concatenation and
            //interpolation and printing them
            string s3 = "c" + 5;
            string s4 = "banana" + s3;

            string s5 = $"the value of s3 is {s3}";
            string s6 = $"{s3} plus {s4} equals {s3 + s4}";
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
        }
    }
}
