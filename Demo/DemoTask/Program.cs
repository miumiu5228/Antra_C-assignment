using System;

namespace DemoTask
{
    public class Student
    {
        String Name, Address;
        int Mobile;

        public void GetDate()
        {
            Console.WriteLine("Enter your Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number:");
            Mobile = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Address: " + Address);
            Console.WriteLine("Student Mobile: " + Mobile);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetDate();
            student.DisplayData();

        }
    }
}
