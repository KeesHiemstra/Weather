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
	[DataContract]
	public class Coord
	{
		[DataMember(Name = "lon")]
		public int Lon { get; set; }

		[DataMember(Name = "lat")]
		public double Lat { get; set; }
	}


	[DataContract]
	public class WeatherI
	{
		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "main")]
		public string Main { get; set; }

		[DataMember(Name = "description")]
		public string Description { get; set; }

		[DataMember(Name = "icon")]
		public string Icon { get; set; }
	}


	[DataContract]
	public class Main
	{
		/// <summary>
		/// Current temperature (K)
		/// </summary>
		[DataMember(Name = "temp")]
		public double Temperature { get; set; }

		/// <summary>
		/// Calculate temperature Kalvin to Celcius in 1 decimal
		/// </summary>
		public double TemperatureCelsius
		{
			get { return Temperature.KelvinToCelsius(); }
		}

		/// <summary>
		/// Display temperature in Celsius include trail
		/// </summary>
		public string TemperatureCelsiusString
		{
			get { return $"{Temperature.KelvinToCelsiusString()}"; }
		}

		[DataMember(Name = "pressure")]
		public int Pressure { get; set; }

		[DataMember(Name = "humidity")]
		public int Humidity { get; set; }

		[DataMember(Name = "temp_min")]
		public double Temp_min { get; set; }

		[DataMember(Name = "temp_max")]
		public double Temp_max { get; set; }
	}


	[DataContract]
	public class Wind
	{
		[DataMember(Name = "speed")]
		public double Speed { get; set; }

		[DataMember(Name = "deg")]
		public int Deg { get; set; }
	}


	[DataContract]
	public class Clouds
	{
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
		public double Message { get; set; }

		[DataMember(Name = "country")]
		public string Country { get; set; }

		[DataMember(Name = "sunrise")]
		public int Sunrise { get; set; }

		[DataMember(Name = "sunset")]
		public int Sunset { get; set; }
	}


	[DataContract]
	public class OpenWeatherMap
	{
		[DataMember(Name = "coord")]
		public Coord Coord { get; set; }

		[DataMember(Name = "weather")]
		public List<WeatherI> Weather { get; set; }

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
}
