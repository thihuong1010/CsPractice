using System;
namespace CsPractice
{
	public class UserInfo
	{
		public string? Name;
		private string? Location;
		public UserInfo()
		{
			Console.WriteLine("Base class contructor");
		}
		public void GetUserInfo(string location)
		{
			Location = location;
			Console.WriteLine("Name: {0}", Name);
			Console.WriteLine("Location: {0}", Location);
		}
	}
	public class Detail: UserInfo
	{
		public int Age;
		public Detail()
		{
			Console.WriteLine("Child class constructor");
		}
		public void GetAge()
		{
			Console.WriteLine("Age: {0}", Age);
		}
	}
}

