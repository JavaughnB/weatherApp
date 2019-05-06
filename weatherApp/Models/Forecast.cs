using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace weatherApp.Models
{
	public class Forecast
	{
		public List <list> list { get; set; }	
		public city City { get; set; }
		
	}
	public class temp
	{
		public double day { get; set; }
		public float temp_min { get; set; }
		public float temp_max { get; set; }
		public double dt { get; set; }
		
	}
	public class city {
		public string name { get; set; }
		public string country { get; set; }
	}
	public class weather
	{
		public string main { get; set; }
		public string description { get; set; }
		public string icon { get; set; }
	}
	public class list
	{
		public temp Temp  { get; set; }
		public List<weather> weather { get; set; }
		public double pressure { get; set; }
		public double humidity { get; set; }
		public double speed { get; set; }
		public string dt_txt { get; set; }
	}
}