using System;
namespace CsPractice
{
	abstract class Info
	{
		public void Welcome()
		{
			Console.WriteLine("Welcome to Tutlane");
		}

		public int age = 23;
		public abstract void GetDetails(string x, string y);
	}

	class UserDClass : Info
	{
		public override void GetDetails(string a, string b)
		{
			Welcome();
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", age);
        }
	}
}

