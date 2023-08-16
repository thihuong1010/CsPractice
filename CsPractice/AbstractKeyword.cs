using System;
namespace CsPractice
{
	abstract class Info
	{
		abstract public void GetDetails(string x, string y, int z);
	}

	class UserDClass : Info
	{
		public override void GetDetails(string a, string b, int c)
		{
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", c);
        }
	}
}

