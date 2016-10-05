using System;

namespace NullObjectDesignPattern.Cars
{
	public class MazdaCar : Car
	{
		public override void GetCarName()
		{
			Console.WriteLine("Mazda RX-8");
		}
	}
}
