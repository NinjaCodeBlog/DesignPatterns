namespace NullObjectDesignPattern.Cars
{
	public class NullCar : Car
	{
		public override void GetCarName()
		{
			// do nothing
		}

		private static Car instance = new NullCar();

		public static Car GetInstance
		{
			get
			{
				if (instance == null)
					instance = new NullCar();
				return instance;
			}
		}
	}
}
