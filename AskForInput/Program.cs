using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for user input and parsing it into an int variable
            string userInput = Console.ReadLine();
            int userInt = int.Parse(userInput);
        }
    }
}
