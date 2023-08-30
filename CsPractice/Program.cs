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
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        User u = new User();
    //        // set accessor will invoke
    //        u.Name = "Huong Nguyen";
    //        u.Location = "Finland";
    //        // get accessor will invoke
    //        Console.WriteLine("Name: " + u.Name);
    //        Console.WriteLine("Location: " + u.Location);

    //        Console.WriteLine("\nPress Enter Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}

    // C# inheritance
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Detail d = new Detail();
    //        d.Name = "Huong Nguyen";
    //        // Compile time error because Location is private
    //        // d.Location = "Finland";
    //        d.Age = 23;
    //        d.GetUserInfo("Finland");
    //        d.GetAge();

    //        Console.WriteLine("\nPress Any Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}

    // C# multi-level inheritance
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        C c = new C();
    //        c.Name = "Huong Nguyen";
    //        c.Location = "Finland";
    //        c.Age = 23;
    //        c.GetName();
    //        c.GetLocation();
    //        c.GetAge();

    //        Console.WriteLine("\nPress Any Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}

    // C# compile time polymorphism example
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Calculate c = new Calculate();
    //        c.AddNumbers(1, 2);
    //        c.AddNumbers(1, 2, 3);

    //        Console.WriteLine("\nPress Enter Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}

    // C# rum time polymorphism
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DClass d = new DClass();
    //        d.GetInfo();
    //        BClass b = new BClass();
    //        b.GetInfo();

    //        Console.WriteLine("\nPress Enter Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Events Example****");
            Operations op = new Operations(10, 20);
            op.AddOperation();
            op.SubOperation();
            Console.ReadLine();
        }
    }
}