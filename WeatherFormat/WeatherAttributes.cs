using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherFormat
{
	public enum TempuratureFormat
	{
		Kelvin = 1,
		Celsius,
		Fahrenheit
	}

	public class TemperatureTypeAttribute : Attribute
	{
		public TemperatureTypeAttribute(TempuratureFormat tempuratureFormat)
		{
			format = tempuratureFormat;
		}

		protected TempuratureFormat format;

		public TempuratureFormat Format
		{
			get => format;
			set => format = value;
		}
	}

	class WeatherAttributes
	{
		[TemperatureType(TempuratureFormat.Kelvin)]
		public double Temperature { get; set; }
		public double WindSpeed { get; set; }
	}
}
