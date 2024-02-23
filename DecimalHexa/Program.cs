using System;

namespace DecimalHexa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for user input
            Console.WriteLine("Insere 4 números inteiros:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            //Parsing each of the inputs to ints
            int int1 = int.Parse(input1);
            int int2 = int.Parse(input2);
            int int3 = int.Parse(input3);
            int int4 = int.Parse(input4);
        }
    }
}
