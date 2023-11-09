using System;
namespace Samples.Delegates
{
	public class Temp
	{
		//la implementación de cada metódo
		public static double GetCelsius(double fahrenheit)
		{
			return (fahrenheit - 32) * (5 / 9D);
		}

		public static double GetKelvin(double fahrenheit)
		{
			return fahrenheit + 460;
		}
	}
}
