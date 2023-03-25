using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{
		public static IVehicle GetVehicle(int numberOfTires)
		{
			if (numberOfTires == 2)
			{
				return new Motorcycle();
			}
			else if (numberOfTires == 4)
			{
				return new Car();
			}
			else
			{
				return new Car();
			}
			//jeremy said If else statement was fine
		}

	}
}