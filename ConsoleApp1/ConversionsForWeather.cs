using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	//public class Temperature
	//{
	//	private double kelvin;
	//	public Temperature(double temperature)
	//	{
	//		kelvin = temperature;
	//	}

	//	public double Celsius
	//	{
	//		get { return Math.Floor((kelvin - 273.15) * 10) / 10; }
	//	}

	//	public override string ToString()
	//	{
	//		return this.ToString("C");
	//	}

	//	public string ToString(string format)
	//	{
	//		// Handle null or empty string. 
	//		if (string.IsNullOrEmpty(format)) format = "C";
	//		// Remove spaces and convert to uppercase.
	//		format = format.Trim().ToUpperInvariant();

	//		// Convert temperature to Fahrenheit and return string. 
	//		switch (format)
	//		{
	//			// Convert temperature to Fahrenheit and return string. 
	//			//case "F":
	//			//	return this.Fahrenheit.ToString("N2") + " °F";
	//			//// Convert temperature to Kelvin and return string. 
	//			//case "K":
	//			//	return this.Kelvin.ToString("N2") + " K";
	//			//// return temperature in Celsius. 
	//			case "G":
	//			case "C":
	//				return this.Celsius.ToString("N2") + " °C";
	//			default:
	//				throw new FormatException(String.Format("The '{0}' format string is not supported.", format));
	//		}
	//	}

	public static class ConversionsForWeather
	{
		#region Temperature
		/// <summary>
		/// Calculate Kelvin to Celsius in 1 decimal.
		/// </summary>
		/// <param name="kelvin"></param>
		/// <returns></returns>
		public static double KelvinToCelsius(this double kelvin)
		{
			return Math.Floor((kelvin - 273.15) * 10) / 10;
		}

		/// <summary>
		/// Calculate Kelvin to Celsius and display with °C.
		/// </summary>
		/// <param name="celsius"></param>
		/// <returns></returns>
		public static string KelvinToCelsiusString(this double kelvin)
		{
			return $"{Math.Floor((kelvin - 273.15) * 10) / 10}°C";
		}

		/// <summary>
		/// Display in Celsius with °C.
		/// </summary>
		/// <param name="celsius"></param>
		/// <returns></returns>
		public static string ToCelsiusString(this double celsius)
		{
			return $"{celsius}°C";
		}

		/// <summary>
		/// Calculate Kelvin to Fahrenheit in 1 decimal.
		/// </summary>
		/// <param name="kelvin"></param>
		/// <returns></returns>
		public static double KelvinToFahrenheit(this double kelvin)
		{
			return Math.Floor(((kelvin - 273.15) * 9 / 5 + 32) * 10) / 10;
		}

		/// <summary>
		/// Display in Fahrenheit with °F.
		/// </summary>
		/// <param name="celsius"></param>
		/// <returns></returns>
		public static string ToFahrenheitString(this double fahrenheit)
		{
			return $"{fahrenheit}°F";
		}
		#endregion

		#region Wind
		/// <summary>
		/// Convert wind speed to scale of Beaufort.
		/// </summary>
		/// <param name="WindSpeed"></param>
		/// <returns></returns>
		public static int ConvertWindSpeedToBeaufort(double WindSpeed)
		{
			if (WindSpeed <= 0.2) { return 0; }
			if (WindSpeed <= 1.5) { return 1; }
			if (WindSpeed <= 3.3) { return 2; }
			if (WindSpeed <= 5.4) { return 3; }
			if (WindSpeed <= 7.9) { return 4; }
			if (WindSpeed <= 10.7) { return 5; }
			if (WindSpeed <= 13.8) { return 6; }
			if (WindSpeed <= 17.1) { return 7; }
			if (WindSpeed <= 20.7) { return 8; }
			if (WindSpeed <= 24.4) { return 9; }
			if (WindSpeed <= 28.4) { return 10; }
			if (WindSpeed <= 32.6) { return 11; }
			return 12;
		}

		/// <summary>
		/// Convert Beaufort to short description of the wind.
		/// </summary>
		/// <param name="WindBeaufort"></param>
		/// <returns></returns>
		public static string ConvertWindBeaufortToName(int WindBeaufort)
		{
			string[] WindName = new string[13] {
				"Wind stil",
				"Flauw en stil",
				"Zwakke wind",
				"Lichte koelte",
				"Matige koelte",
				"Vrij krachtige wind",
				"Krachtige wind",
				"Harde wind",
				"Stormachtige wind",
				"Storm",
				"Zware storm",
				"Zeer zware storm",
				"Orkaan"};
			return WindName[WindBeaufort];
		}

		/// <summary>
		/// Convert Beaufort to short description of the wind.
		/// </summary>
		/// <param name="WindBeaufort"></param>
		/// <returns></returns>
		public static string ConvertWindBeaufortToName(double WindSpeed)
		{
			return ConvertWindBeaufortToName(ConvertWindSpeedToBeaufort(WindSpeed));
		}

		/// <summary>
		/// Convert Beaufort to description of the wind.
		/// </summary>
		/// <param name="WindBeaufort"></param>
		/// <returns></returns>
		public static string ConvertWindBeaufortToDescription(int WindBeaufort)
		{
			string[] WindDescription = new string[13] {
				"Rook stijgt recht of bijna recht omhoog.",
				"Windrichting goed herkenbaar aan rookpluimen.",
				"Bladeren beginnen te ritselen en windvanen kunnen gaan bewegen. Wind begint merkbaar te worden in het gelaat.",
				"Bladeren en twijgen zijn voortdurend in beweging.",
				"Kleine takken beginnen te bewegen. Stof en papier beginnen van de grond op te dwarrelen.",
				"Kleine bebladerde takken maken zwaaiende bewegingen. Er vormen zich gekuifde golven op meren en kanalen.",
				"Grote takken bewegen. Paraplu’s kunnen slechts met moeite worden vastgehouden.",
				"Gehele bomen bewegen. De wind is hinderlijk wanneer men er tegen in loopt.",
				"Twijgen breken af. Fietsen en lopen wordt bemoeilijkt.",
				"Lichte schade aan gebouwen. Schoorsteenkappen en dakpannen worden afgerukt.",
				"Ontwortelde bomen. Aanzienlijke schade aan gebouwen enz. Komt boven land zelden voor.",
				"Uitgebreide schade.",
				"Komt boven land zeer zelden voor."};
			return WindDescription[WindBeaufort];
		}

		/// <summary>
		/// Convert Beaufort to description of the wind.
		/// </summary>
		/// <param name="WindBeaufort"></param>
		/// <returns></returns>
		public static string ConvertWindBeaufortToDescription(double WindSpeed)
		{
			return ConvertWindBeaufortToDescription(ConvertWindSpeedToBeaufort(WindSpeed));
		}

		/// <summary>
		/// Convert direction to direction name.
		/// </summary>
		/// <param name="Direction"></param>
		/// <returns></returns>
		public static string ConvertDirectionToName(int Direction)
		{
			string[] DirectionName = new string[16]
			{
				"N", "NNO", "NO", "ONO",
				"O", "OZO", "ZO", "ZZO",
				"Z", "ZZW", "ZW", "WZW",
				"W", "WNW", "NW", "NNW"
			};
			int direction = (int)Math.Round(((float)Direction / 22.5));
			if (direction == 16) { direction = 0; }
			return DirectionName[direction];
		}
		#endregion

		#region Time
		/// <summary>
		/// Convert Unix timestamp (number of seconds since epoch to date/time.
		/// </summary>
		/// <param name="unixTimeStamp"></param>
		/// <returns></returns>
		public static DateTime ConvertUnixTimeToDate(int unixTime)
		{
			// Unix timestamp is seconds past epoch
			System.DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
			return dateTime.AddSeconds(unixTime).ToLocalTime();
		}
		#endregion
	}//Weather

}
