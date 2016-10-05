using System;

namespace NullObjectDesignPattern.Cars
{
	public class AudiCar : Car
	{
		public override void GetCarName()
		{
			Console.WriteLine("Audi Q7");
		}
	}
}
