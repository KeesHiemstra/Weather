using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	/// <summary>
	/// These classes got from Json data.
	/// </summary>
	/// 
	#region WeatherData
	/// <summary>
	/// Coordinates of the station.
	/// </summary>
	[DataContract]
	public class Coord
	{
		[DataMember(Name = "lon")]
		public float Lon { get; set; }

		[DataMember(Name = "lat")]
		public float Lat { get; set; }
	}


	[DataContract]
	public class Condition
	{
		[DataMember(Name = "id")]
		public int Id { get; set; }

		/// <summary>
		/// Weather condition in Enlish
		/// </summary>
		[DataMember(Name = "main")]
		public string Main { get; set; }

		/// <summary>
		/// Weather condition in Dutch
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }

		[DataMember(Name = "icon")]
		public string Icon { get; set; }
	}


	[DataContract]
	public class Main
	{
		/// <summary>
		/// Current temperature [K], direct converted to [°C].
		/// </summary>
		private float temperature;
		[DataMember(Name = "temp")]
		public float Temperature
		{
			get => temperature - 273.15f;
			set => temperature = value;
		}

		/// <summary>
		/// Pressure [mBar]
		/// </summary>
		[DataMember(Name = "pressure")]
		public int Pressure { get; set; }

		/// <summary>
		/// Humidity [%].
		/// </summary>
		[DataMember(Name = "humidity")]
		public int Humidity { get; set; }

		private float temperatureMinumum;
		[DataMember(Name = "temp_min")]
		public float TemperatureMinimum
		{
			get => temperatureMinumum - 273.15f;
			set => temperatureMinumum = value;
		}

		private float temperatureMaximum;
		[DataMember(Name = "temp_max")]
		public float TemperatureMaximum
		{
			get => temperatureMaximum - 273.15f;
			set => temperatureMaximum = value;
		}
	}


	[DataContract]
	public class Wind
	{
		/// <summary>
		/// Wind speed [m/s]
		/// </summary>
		[DataMember(Name = "speed")]
		public float Speed { get; set; }

		/// <summary>
		/// Wind direction [deg]
		/// </summary>
		[DataMember(Name = "deg")]
		public int Deg { get; set; }
	}


	[DataContract]
	public class Clouds
	{
		/// <summary>
		/// Clouds coverage [%]
		/// </summary>
		[DataMember(Name = "all")]
		public int All { get; set; }
	}


	[DataContract]
	public class Sys
	{
		[DataMember(Name = "type")]
		public int Type { get; set; }

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "message")]
		public float Message { get; set; }

		[DataMember(Name = "country")]
		public string Country { get; set; }

		/// <summary>
		/// Sunrise [date/time]
		/// </summary>
		[DataMember(Name = "sunrise")]
		public int Sunrise { get; set; }

		/// <summary>
		/// Sunset [date/time]
		/// </summary>
		[DataMember(Name = "sunset")]
		public int Sunset { get; set; }
	}


	[DataContract]
	public class OpenWeatherMap
	{
		[DataMember(Name = "coord")]
		public Coord Coord { get; set; }

		[DataMember(Name = "weather")]
		public List<Condition> Conditions { get; set; }

		[DataMember(Name = "@base")]
		public string Base { get; set; }

		[DataMember(Name = "main")]
		public Main Main { get; set; }

		[DataMember(Name = "visibility")]
		public int Visibility { get; set; }

		[DataMember(Name = "wind")]
		public Wind Wind { get; set; }

		[DataMember(Name = "clouds")]
		public Clouds Clouds { get; set; }

		[DataMember(Name = "dt")]
		public int Dt { get; set; }

		[DataMember(Name = "sys")]
		public Sys Sys { get; set; }

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "name")]
		public string Name { get; set; }

		[DataMember(Name = "cod")]
		public int Cod { get; set; }
	}
	#endregion

	class Conversion
	{
		#region Time conversion
		static System.DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);

		/// <summary>
		/// Convert Unix timestamp (number of seconds since epoch) to date/time (yyyy-MM-dd HH:mm:ss).
		/// </summary>
		/// <param name="unixTimeStamp"></param>
		/// <returns></returns>
		public static DateTime ConvertUnixTimeToDate(int unixTime)
		{
			// Unix timestamp is seconds past epoch
			return Epoch.AddSeconds(unixTime).ToUniversalTime();
		}

		/// <summary>
		/// Convert date/time (yyyy-MM-dd HH:mm:ss) to Unix timestamp (number of seconds since epoch).
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns></returns>
		public static int ConvertDateToUnixTime(DateTime dateTime)
		{
			return (int)(dateTime - Epoch).TotalSeconds;
		}
		#endregion
	}
}
