using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWeatherWithInterfals
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Weather with interfals";
			ConsoleKeyInfo Key = new ConsoleKeyInfo();

			Console.WriteLine("{0} Start process", DateTime.Now);
			do
			{
				Key = Console.ReadKey(true);

			} while (Key.Key != ConsoleKey.Q);
		}
	}
}
