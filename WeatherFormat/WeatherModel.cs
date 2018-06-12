using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherFormat
{
	class WeatherModel
	{
		private double temperature;

		public double Temperature
		{
			get => temperature;
			set => temperature = value;
		}
	}
}
