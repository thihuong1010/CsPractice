﻿using System;
namespace CsPractice
{
	public class Laptop
	{
		private string? brand;
		private string? model;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public void LaptopDetails()
		{
			Console.WriteLine("Brand: " + Brand);
			Console.WriteLine("Model: " + Model);
		}

		public void LaptopKeyboard()
		{
			Console.WriteLine("Type using keyboard");
		}

        private void MotherBoardInfo()
        {
            Console.WriteLine("MotheBoard Information");
        }

        private void InternalProcessor()
        {
            Console.WriteLine("Processor Information");
        }
    }
}

