using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter something...");
            string userInput = Console.ReadLine();
            string output = "";

            for(int i = 0; i < userInput.Length; i ++)
            {
                output += userInput[userInput.Length - i-1];
            }

            Console.WriteLine($"Reversed string is {output}");
        }
    }
}
