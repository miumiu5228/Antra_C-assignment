using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Please enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            
            

            for (int i = number1; i <= number2; i++)
            {
                int length = Math.Abs(i).ToString().Length;
                int num = i;
                int armstrongNum = 0;
                while (num > 0)
                {
                    armstrongNum += Convert.ToInt32(Math.Pow((num % 10), length));
                    num /= 10;
                }
                if (armstrongNum == i)
                    Console.WriteLine(i);
            }
        }
    }
}
