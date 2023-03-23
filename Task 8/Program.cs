using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace Task_8
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string url = "https://restcountries.com/v3.1/all";
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			string jsonResponse = "";
			using (StreamReader sr = new StreamReader(response.GetResponseStream()))
			{
				jsonResponse = sr.ReadToEnd();
			}

			dynamic data = JsonConvert.DeserializeObject<dynamic>(jsonResponse);

			foreach (var country in data)
			{
				string filename = country.name.common + ".txt";
				string filePath = Path.Combine(@"C:\Users\I5 Gaming PC\Desktop\Countries API", filename);

				using (StreamWriter writer = new StreamWriter(filePath))
				{
					writer.WriteLine($"Region: {country.region}");
					writer.WriteLine($"Subregion: {country.subregion}");
					writer.WriteLine($"Latlng: {string.Join(",", country.latlng)}");
					writer.WriteLine($"Area: {country.area}");
					writer.WriteLine($"Population: {country.population}");
				}
			}
		}

	}
}
