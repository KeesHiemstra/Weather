/* Experiment with the Unix time and Windows time.
 * 
 * 2018-03-02
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			int Unix = 1519808100;
			DateTime Windows = ConvertUnixTimeToDate(Unix);

			Console.WriteLine(Unix);
			Console.WriteLine(ConvertUnixTimeToDate(Unix));
			Console.WriteLine(Windows.AddHours(1));
			Console.WriteLine(ConvertDateToUnixTime(Windows));

			Console.Write("Press any key... ");
			Console.ReadKey();

		}

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
