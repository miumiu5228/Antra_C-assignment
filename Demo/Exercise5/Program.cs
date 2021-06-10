using System;

namespace Exercise5
{
    class Program
    {
        public void BinaryTriangle()
        {
            Console.WriteLine("Please enter the number of the row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            bool isZero = false;
            for(int i = 0; i < row; i++)
            {
                
                string eachRow = "";
                for(int j = 0 ; j < i+1; j++)
                {
                    
                    if (isZero == true)
                    {
                        eachRow += "0";
                        isZero = false;
                    }
                    else
                    {
                        eachRow += "1";
                        isZero = true;
                    }
                }
                Console.WriteLine(eachRow);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.BinaryTriangle();
        }
    }
}
