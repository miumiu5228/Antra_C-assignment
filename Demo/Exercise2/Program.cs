using System;

namespace Exercise2
{
    public class Arithmetic
    {
        int a;
        int b;

        public void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Subtraction(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void Division(int a, int b)
        {
            Console.WriteLine(a / b);
        }


    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();

            Console.WriteLine("Please enter the number of any caculation type 1.Addition 2.Subtraction 3.Multiplication 4.Division");
            int type = Convert.ToInt32(Console.ReadLine());
            int a = 5, b = 10;
            switch (type)
            {

                case 1:
                    arithmetic.Addition(a, b);
                    break;
                case 2:                  
                    arithmetic.Subtraction(a, b);
                    break;
                case 3:
                    arithmetic.Multiplication(a, b);
                    break;
                case 4:
                    arithmetic.Division(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;

            }
        }
    }
}
