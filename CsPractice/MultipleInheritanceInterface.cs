using System;
namespace CsPractice
{
	interface IName
	{
		void GetName(string x);
	}
	interface ILocation
	{
		void GetLocation(string x);
	}
	interface IAge
	{
		void GetAge(int x);
	}

	class UserMultipleInheritance : IName, ILocation, IAge
	{
        public void GetName(string a)
        {
            Console.WriteLine("Name: {0}", a);
        }
        public void GetLocation(string a)
        {
            Console.WriteLine("Location: {0}", a);
        }
        public void GetAge(int a)
        {
            Console.WriteLine("Age: {0}", a);
        }
    }
}

