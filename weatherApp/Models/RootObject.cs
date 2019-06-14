using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using weatherApp.Models;
using System.Net;
using System.Net.Mail;

namespace weatherApp.Models
{
	public class RootObject
	{
		public City city { get; set; }
		public string cod { get; set; }
		public double message { get; set; }
		public int cnt { get; set; }
		public List<List> list { get; set; }

		//Method 
		public RootObject getWeatherInfo(String cityName)
		{
			DateTime weatherTime;
			RootObject root = new RootObject();
			List<List> tempList = new List<List>();
			int hourOfDay = 9;
		 
			//api.openweathermap.org/data/2.5/forecast?q={city name},{country code}cnt=6
			//This calls the weather API and assign it to an object
		    string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0},jm&APPID={1}&units=metric", cityName,  System.Configuration.ConfigurationManager.AppSettings["OWAKey"]);
			using (WebClient client = new WebClient())
			{
				//Get the root object and place it in jsnon file
				var json = client.DownloadString(url);
				root = (new JavaScriptSerializer()).Deserialize<RootObject>(json);
			}

			int j = root.list.Count;
			int i = 1;
			tempList = root.list.ToList();
			//While loop to filter out the objects i wanted based on the time predefined
			while(i < j || i==j )
			{
				if (i == j)
				{
					weatherTime = DateTime.Parse(tempList[i - 1].dt_txt);
				}
				else
				{
					weatherTime = DateTime.Parse(tempList[i].dt_txt);

				}

				if (weatherTime.Hour != hourOfDay)
				{
					tempList.Remove(tempList[i]);
					j = j - 1;
					i = i-1;
				}
				i++;
			}
			root.list = tempList.ToList();
			return root;

		}
	}

	public class Main
	{
		public double temp { get; set; }
		public double temp_min { get; set; }
		public double temp_max { get; set; }
		public double pressure { get; set; }
		public double sea_level { get; set; }
		public double grnd_level { get; set; }
		public int humidity { get; set; }
		public double temp_kf { get; set; }
	}

	public class Weather
	{
		public int id { get; set; }
		public string main { get; set; }
		public string description { get; set; }
		public string icon { get; set; }
	}

	public class Clouds
	{
		public int all { get; set; }
	}

	public class Wind
	{
		public double speed { get; set; }
		public double deg { get; set; }
	}

	public class Sys
	{
		public string pod { get; set; }
	}

	public class List
	{
		public int dt { get; set; }
		public Main main { get; set; }
		public List<Weather> weather { get; set; }
		public Clouds clouds { get; set; }
		public Wind wind { get; set; }
		public Sys sys { get; set; }
		public string dt_txt { get; set; }
	}

	public class Coord
	{
		public double lat { get; set; }
		public double lon { get; set; }
	}

	public class City
	{
		public int id { get; set; }
		public string name { get; set; }
		public Coord coord { get; set; }
		public string country { get; set; }
		public int population { get; set; }
		public int timezone { get; set; }
	}
}