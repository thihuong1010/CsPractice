using System;

namespace CsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop l = new Laptop();
            l.Brand = "Dell";
            l.Model = "Inspiron 14R";
            l.LaptopDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}