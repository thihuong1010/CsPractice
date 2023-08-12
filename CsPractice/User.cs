using System;
namespace CsPractice
{
	public class User
	{
		private string? location;
		private string? name;

		public string Location
		{
			get
			{
				return location;
			}
			set
			{
				location = value;
			}
		}
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
	}
}

