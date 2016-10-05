using System;

namespace NullObjectDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please select number a car (1-3): ");
			int number = Convert.ToInt32(Console.ReadLine());

			Car car = CarFactory.GetCar(number);
			car.GetCarName();

			Console.ReadKey(true);
		}
	}
}
