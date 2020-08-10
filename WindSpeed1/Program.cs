using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindSpeed1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Wind speed: { WindSpeed2Beaufort1(windSpeed: 5.4) } "); 

			Console.Write("\nPress any key...");
			Console.ReadKey();
		}

		/// <summary>
		/// Determine the speed in Beaufort from [m/s].
		/// </summary>
		/// <param name="windSpeed">in [m/s]</param>
		private static int WindSpeed2Beaufort(double windSpeed)
		{
			if (windSpeed <= 0.2) { return 0; }
			if (windSpeed <= 1.5) { return 1; }
			if (windSpeed <= 3.3) { return 2; }
			if (windSpeed <= 5.4) { return 3; }
			if (windSpeed <= 7.9) { return 4; }
			if (windSpeed <= 10.7) { return 5; }
			if (windSpeed <= 13.8) { return 6; }
			if (windSpeed <= 17.1) { return 7; }
			if (windSpeed <= 20.7) { return 8; }
			if (windSpeed <= 24.4) { return 9; }
			if (windSpeed <= 28.4) { return 10; }
			if (windSpeed <= 32.6) { return 11; }
			return 12;
		}

		/// <summary>
		/// Determine the speed in Beaufort from [m/s].
		/// Refactoried with switch pattern matching in C# version 8.
		/// </summary>
		/// <param name="windSpeed">in [m/s]</param>
		private static int WindSpeed2Beaufort1(double windSpeed)
		{
			switch (windSpeed)
			{
				case double w when w <= 0.2: return 0;
				case double w when w <= 1.5: return 1;
				case double w when w <= 3.3: return 2;
				case double w when w <= 5.4: return 3;
				case double w when w <= 7.9: return 4;
				case double w when w <= 10.7: return 5;
				case double w when w <= 13.8: return 6;
				case double w when w <= 17.1: return 7;
				case double w when w <= 20.7: return 8;
				case double w when w <= 24.4: return 9;
				case double w when w <= 28.4: return 10;
				case double w when w <= 32.6: return 11;
				default: return 12;
			}
		}
	}
}
