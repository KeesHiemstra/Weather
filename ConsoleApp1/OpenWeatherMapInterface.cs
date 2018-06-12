using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class OpenWeatherMapInterface
	{
		public static async Task<OpenWeatherMap> GetWeatherAsync()
		{
			//Get JSon string from the web
			var http = new HttpClient();
			var httpRespond = await http.GetAsync("http://api.openweathermap.org/data/2.5/weather?lat=51.913580&lon=4.999771&appid=8b6fbc4fab942058a2e1967b913460a4&lang=nl");
			var httpResult = await httpRespond.Content.ReadAsStringAsync();

			using (StreamWriter sw = File.AppendText(@"C:\Temp\Weather.log"))
			{
				await sw.WriteLineAsync(String.Format("{0}\t{1}",
					DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
					httpResult));
			}

			//Translate data
			var serializer = new DataContractJsonSerializer(typeof(OpenWeatherMap));
			var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(httpResult));

			var openWeatherMap = (OpenWeatherMap)serializer.ReadObject(memoryStream);

			return openWeatherMap;
		}
	}
}
