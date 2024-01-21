using System;
namespace Hospital_Management
{
	public class Instrument
	{
		public string Title { get; set; }
		public double Price { get; set; }
		public Instrument(string title, double price)
		{
			Title = title;
			Price = price;
		}
	}
}

