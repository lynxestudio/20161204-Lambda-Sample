using System;

namespace Samples.AnonymousMethods
{
	class MainClass
	{
		delegate double GetTemp(double d);		
		public static void Main(string[] args)
		{
			int x = 44;
			Console.WriteLine("{0} Fahrenheit = {1:0.00} Celsius", x, ApplyF(x, delegate (double fahrenheit)
			{
				return (fahrenheit - 32) * (5 / 9D);
			}));
			Console.WriteLine("{0} Fahrenheit = {1:0.00} Kelvin", x, ApplyF(x, delegate (double fahrenheit)
			{
				return fahrenheit + 460;
			}));
			Console.Read();
		}

		static double ApplyF(double d, GetTemp f)
		{
			return f(d);
		}

	}
}
