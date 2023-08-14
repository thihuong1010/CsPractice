using System;
namespace CsPractice
{
    public class BaseClass
    {
        public virtual string Name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine("Learn C# Tutorial");
        }
    }
    public class DeridedClass : BaseClass
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    name = "No Value";
                }
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine("Welcome to Tutlane");
        }
    }
}

