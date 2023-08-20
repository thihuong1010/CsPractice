using System;
namespace CsPractice
{
	interface IUser
	{
		void GetDetails(string x);
	}

	class UserClass1 : IUser
	{
		public void GetDetails(string a)
		{
			Console.WriteLine("Name: {0}", a);
		}
	}

	class UserClass2 : IUser
	{
		public void GetDetails(string a)
		{
			Console.WriteLine("Location: {0}", a);
		}
	}
}

