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
			Console.Title = "Weather information";
			ConsoleKeyInfo Key = new ConsoleKeyInfo();

			ShowWeather("Start");

			do
			{
				Key = Console.ReadKey(true);

				switch (Key.Key)
				{
					case ConsoleKey.R:
						ShowWeather("Refresh");
						break;
					default:
						Console.WriteLine("\nKey: {0}", Key.Key);
						break;
				}
			} while (Key.Key != ConsoleKey.Q);

			Console.Write("Press any key... ");
			Console.ReadKey();
		}

		public static void ShowWeather(string message)
		{
			Console.WriteLine("{0} {1}", DateTime.Now, message);
			Console.WriteLine();
			int Count = 0;
			CollectWeatherAsync();

			while (Weather == null) ;

			Console.WriteLine("Temperature        : {0}", Weather.Main.Temperature);
			Console.WriteLine("Maximum temperature: {0:F1}", Weather.Main.TemperatureMaximum);
			Console.WriteLine("Minumum temperature: {0:F1}", Weather.Main.TemperatureMinimum);
			Console.WriteLine("Humidity           : {0}", Weather.Main.Humidity);
			Console.WriteLine("Pressure           : {0}", Weather.Main.Pressure);
			Console.WriteLine("Wind speed         : {0}", Weather.Wind.Speed);
			Console.WriteLine("Wind direction     : {0}", Weather.Wind.Deg);
			Console.WriteLine("Clouds             : {0}", Weather.Clouds.All);
			Console.WriteLine("Visibility         : {0}", Weather.Visibility);
			Console.WriteLine("Count conditions   : {0}", Weather.Conditions.Count);
			foreach (var item in Weather.Conditions)
			{
				Console.WriteLine("  {1} - Id           : {0}", item.Id, Count);
				Console.WriteLine("  {1} - Main         : {0}", item.Main, Count);
				Console.WriteLine("  {1} - Description  : {0}", item.Description, Count);
				Count++;
			}
			Console.WriteLine("Sunrise            : {0}", Conversion.ConvertUnixTimeToDate(Weather.Sys.Sunrise).AddHours(1));
			Console.WriteLine("Sunset             : {0}", Conversion.ConvertUnixTimeToDate(Weather.Sys.Sunset).AddHours(1));
			Console.WriteLine();
			Console.WriteLine("Sys type           : {0}", Weather.Sys.Type);
			Console.WriteLine("Sys id             : {0}", Weather.Sys.Id);
			Console.WriteLine("Sys message        : {0}", Weather.Sys.Message);
			Console.WriteLine("Sys country        : {0}", Weather.Sys.Country);
			Console.WriteLine("Station ID         : {0}", Weather.Id);
			Console.WriteLine("Station            : {0}", Weather.Name);
			Console.WriteLine("Station time       : {0}", Conversion.ConvertUnixTimeToDate(Weather.Dt).AddHours(1));
			Console.WriteLine("Station parameter  : {0}", Weather.Cod);
			Console.WriteLine();
		}

		public static async void CollectWeatherAsync()
		{
			Weather = await OpenWeatherMapInterface.GetWeatherAsync();
		}
	}
}
