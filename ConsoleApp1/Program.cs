/* Console collect Weather information
 * 
 * The Json is case sensitive, use [Datemember(Name="xxx")] to it able to use Yyy
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static OpenWeatherMap Weather;

		[MTAThread]
		static void Main(string[] args)
		{
			int Count = 0;
			//Weather = new OpenWeatherMap();
			CollectWeatherAsync();

			DateTime Start = DateTime.Now;
			while (Weather == null) ;

			Console.WriteLine("Wait time: {0}", DateTime.Now - Start);

			Console.WriteLine($"Temperature: {Weather.Main.TemperatureCelsiusString}");

			Console.Write("Press any key... ");
			Console.ReadKey();
		}

		public static async void CollectWeatherAsync()
		{
			Weather = await OpenWeatherMapInterface.GetWeatherAsync();
		}
	}
}
