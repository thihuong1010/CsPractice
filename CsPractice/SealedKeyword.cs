using System;
namespace CsPractice
{
    public class First
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Base class First method");
        }
        public virtual void Test()
        {
            Console.WriteLine("Base class First Test Method");
        }
    }

    public class Second : First
    {
        public sealed override void GetInfo()
        {
            Console.WriteLine("Derived class Second method");
        }
        public override void Test()
        {
            Console.WriteLine("Derived class Second Test Method");
        }
    }

    public class Third : Second
    {
        // Compile time error
        public override void GetInfo()
        {
            Console.WriteLine("");
        }

        public override void Test()
        {
            Console.WriteLine("Derived Class C Test Method");
        }
    }
}

