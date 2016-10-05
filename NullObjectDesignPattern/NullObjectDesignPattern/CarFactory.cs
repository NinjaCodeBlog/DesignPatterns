using NullObjectDesignPattern.Cars;

namespace NullObjectDesignPattern
{
	public static class CarFactory
	{
		public static Car GetCar(int number)
		{
			switch (number)
			{
				case 1:
					return new AudiCar();
				case 2:
					return new BmwCar();
				case 3:
					return new MazdaCar();
				default:
					return NullCar.GetInstance;
			}
		}
	}
}
