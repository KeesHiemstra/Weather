﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrong_Caculations
{
	class Program
	{
		static void Main(string[] args)
		{
			float t = 278.43F; //5.28

			Console.WriteLine(t - 273.15);
			Console.WriteLine((float)((int)(t * 1000  - 273150))/1000);

			Console.WriteLine($"Attempt 3: {KelvinToCelsius(t)}");

			Console.Write("Press any key...");
			Console.ReadKey();
		}

		static float KelvinToCelsius(float Kelvin)
		{
			int kelvin = (int)(Kelvin * 100);
			kelvin -= 27315;

			return (float)kelvin / 100;
		}
	}
}
