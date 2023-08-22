using System;
namespace CsPractice
{
	class User
	{
		// Initialize read only field
		public readonly string name = "Huong Nguyen";
		public readonly string location;
		public readonly int age;
		public User()
		{
			location = "Finland";
			age = 23;
		}
	}
}

