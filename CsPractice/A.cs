using System;
namespace CsPractice
{
	public class A
	{
		public string? Name;
		public void GetName()
		{
			Console.WriteLine("Name: {0}", Name);
		}
	}

	public class B : A
	{
		public string? Location;
		public void GetLocation()
		{
			Console.WriteLine("Location: {0}", Location);
		}
	}

	public class C : B
	{
		public int? Age;
		public void GetAge()
		{
			Console.WriteLine("Age: {0}", Age);
		}
	}
}

