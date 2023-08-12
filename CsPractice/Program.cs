using System;

namespace CsPractice
{
    // C# abstraction
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Laptop l = new Laptop();
    //        l.Brand = "Dell";
    //        l.Model = "Inspiron 14R";
    //        l.LaptopDetails();
    //        Console.WriteLine("\nPress Enter Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}

    // C# encapsulation
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            // set accessor will invoke
            u.Name = "Huong Nguyen";
            u.Location = "Finland";
            // get accessor will invoke
            Console.WriteLine("Name: " + u.Name);
            Console.WriteLine("Location: " + u.Location);

            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}