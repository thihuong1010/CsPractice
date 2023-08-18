using System;
namespace CsPractice
{
	public class Base
	{
		public string name = "Huong Nguyen";
		public string location = "Finland";
		public int age = 23;
		public virtual void GetInfoMethod()
		{
			Console.WriteLine("Name: {0}", name);
			Console.WriteLine("Location: {0}", location);
		}
	}

	public class Derived : Base
	{
        public override void GetInfoMethod()
        {
            base.GetInfoMethod();
			Console.WriteLine("Age: {0}", age);
		}
    }
}

