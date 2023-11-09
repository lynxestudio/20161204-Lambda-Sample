using System;

namespace Samples.Delegates
{
	class MainClass
	{
		//definimos al objeto que guardara las referencias a los metódos
		delegate double GetTemp(double d);
		public static void Main(string[] args)
		{
			int x = 44;
			Console.WriteLine("{0} Fahrenheit = {1:0.00} Celsius", x, ApplyF(x, Temp.GetCelsius));
			Console.WriteLine("{0} Fahrenheit = {1:0.00} Kelvin", x, ApplyF(x, Temp.GetKelvin));
			Console.Read();
		}

		//el metódo que aplicará el metódo que es su segundo argumento
		static double ApplyF(double d, GetTemp f)
		{
			return f(d);
		}
	}
}
