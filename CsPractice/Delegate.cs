using System;
namespace CsPractice
{
	public delegate void SampleDelegate(int a, int b);
	class MathOperations
	{
		public void Add(int a, int b)
		{
			Console.WriteLine("Add result: {0}", a + b);
		}
		public void Subtract(int x, int y)
		{
			Console.WriteLine("Subtract result: {0}", x - y);
		}
	}
}

