using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherFormat
{
	class Program
	{
		static void Main(string[] args)
		{
			WeatherModel model = new WeatherModel();
			model.Temperature = 10;

			Console.Write("Press any key... ");
			Console.ReadKey();
		}
	}
}
