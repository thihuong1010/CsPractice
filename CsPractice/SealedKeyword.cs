using System;
namespace CsPractice
{
	// Base class
	sealed class Users
	{
        public string name = "Huong nguyen";
        public string location = "Finland";
        public void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }

    // Derived class
    public class Details : Users
    {
        public int age = 23;
        public void GetAge()
        {
            Console.WriteLine("Age: {0}", age);
        }
    }
}

