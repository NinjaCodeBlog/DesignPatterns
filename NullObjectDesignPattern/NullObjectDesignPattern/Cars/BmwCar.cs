using System;

namespace NullObjectDesignPattern.Cars
{
	public class BmwCar : Car
	{
		public override void GetCarName()
		{
			Console.WriteLine("BMW X5");
		}
	}
}
