using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for user input and parsing it into an int variable
            Console.WriteLine("Please insert an int");
            string userInput = Console.ReadLine();
            int userInt = int.Parse(userInput);

            //Asking for user input and parsing it into an int variable
            Console.WriteLine("Please insert a float");
            string userInput2 = Console.ReadLine();
            float userFloat = float.Parse(userInput2);

            Console.WriteLine(userInt+userFloat);
        }
    }
}
