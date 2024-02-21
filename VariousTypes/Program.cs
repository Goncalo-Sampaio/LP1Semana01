using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing multiple integral variables and printing them
            int int1 = 1;
            long long1 = 2L;
            ulong ulong1 = 3UL;
            Console.WriteLine(int1);
            Console.WriteLine(long1);
            Console.WriteLine(ulong1);

            //Initializing multiple char variables and printing them
            char char1 = '\u006F';
            char char2 = '\u006C';
            char char3 = '\u0061';
            Console.WriteLine(char1);
            Console.WriteLine(char2);
            Console.WriteLine(char3);

            //Initializing multiple floating point variables and printing them
            float float1 = 1.11f;
            double double1 = 2.22;
            decimal decimal1 = 3.33m;
            Console.WriteLine(float1);
            Console.WriteLine(double1);
            Console.WriteLine(decimal1);
        }
    }
}
