using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using weatherApp.Models;
using System.Net;
using System.Net.Mail;

namespace weatherApp
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//605500dd99dc3209199e4f87053fe1e1
			//string appId = "542ffd081e67f4512b705f89d2a611b2";
		}

		protected void btnEnterCity_Click(object sender, EventArgs e)
		{
			string cityName;

			cityName = (Convert.ToString(txtCity.Text)).ToLower();

			RootObject root = new RootObject();
			try
			{
				root = root.getWeatherInfo(cityName);
			}
			catch (Exception ex)
			{
				lblError.Text = "Not a valid city";
			}

			if (root.city != null)
			{

				rptrWeather.DataSource = root.list;
				rptrWeather.DataBind();

			}
		}

		public void rptrWeather_ItemCommand(object source, RepeaterItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
			{
				List root = new List();
				root = (List)e.Item.DataItem;

				Image imgActive = (Image)e.Item.FindControl("imgActive");
				Label lblDescription = (Label)e.Item.FindControl("lblDescription");
				Label lblTemp = (Label)e.Item.FindControl("lblTemp");
				Label lblHumidity = (Label)e.Item.FindControl("lblHumidity");
				Label lblDate = (Label)e.Item.FindControl("lblDate");
				Label lblDay = (Label)e.Item.FindControl("lblDay");

				imgActive.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", root.weather[0].icon);
				lblDescription.Text = root.weather[0].description;
				lblTemp.Text = string.Format("Average Temp :{0} c", Math.Round(root.main.temp));
				lblHumidity.Text = string.Format("Humidity: {0}", root.main.humidity);
				lblDate.Text = root.dt_txt;
				lblDay.Text = (DateTime.Parse(root.dt_txt).DayOfWeek).ToString();
			}

		}

		protected void btnEmailSubmit_Click(object sender, EventArgs e)
		{
			try
			{
				EmployeeDB emp = new EmployeeDB();
				emp.emailEmployees("Kingston");
				emp.emailEmployees("Montego Bay");
			}
			catch (Exception ex)
			{
				lblError.Text =(ex.Message);
			}
		}
	}
}