using System;

namespace Exercise6
{


    class Program
    {
        public void Diamond()
        {
            Console.WriteLine("Please enter the number of the row: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < rows; i++)
            {
                string eachRow = "";
                for (int j = rows; j > i + 1; j--)
                {
                    eachRow += " ";
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    eachRow += "*";
                }
                Console.WriteLine(eachRow);

            }


            for (int i = 1; i < rows; i++)
            {
                string eachRow = "";
                for (int j = 0; j < i; j++)
                {
                    eachRow += " ";
                }

                for (int j = 2 * rows - 1; j > 2 * i; j--)
                {
                    eachRow += "*";
                }

                Console.WriteLine(eachRow);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Diamond();
        }
    }
}
