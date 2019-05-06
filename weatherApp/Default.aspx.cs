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
			string appId = "542ffd081e67f4512b705f89d2a611b2";
			string cityName = "Kingston";
			string cityName2 = "Montego Bay";

			string url = string.Format("https://api.openweathermap.org/data/2.5/forecast/daily?q={0},jm&APPID={1}&units=metric&cnt=6", cityName, appId);
			using (WebClient client = new WebClient())
			{
				var json = client.DownloadString(url);
				Forecast weatherInfo = (new JavaScriptSerializer()).Deserialize<Forecast>(json);

				//Tomorrows weather Forecast
				lblCity.Text = Convert.ToString(weatherInfo.City.name);
				lblDescription.Text = weatherInfo.list[1].weather[0].description;
				imgCountryFlag.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgWeatherIcon.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[1].weather[0].icon);
				lblHumidity.Text = string.Format("Humidity: {0}", weatherInfo.list[1].humidity);
				lblTempMin.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[1].Temp.temp_min, 1));
				lblTempMax.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[1].Temp.temp_max, 1));
				lblTempDay.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[1].Temp.day, 1));

				//2nd Day weather Forecast
				lblCityDay2.Text = Convert.ToString(weatherInfo.City.name);
				lblDescriptionDay2.Text = weatherInfo.list[2].weather[0].description;
				imgCountryFlagDay2.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgWeatherIconDay2.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[2].weather[0].icon);
				lblHumidityDay2.Text = string.Format("Humidity: {0}", weatherInfo.list[2].humidity);
				lblTempMinDay2.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[2].Temp.temp_min, 1));
				lblTempMaxDay2.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[2].Temp.temp_max, 1));
				lblTempDayDay2.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[2].Temp.day, 1));
				lblDate2.Text = string.Format("Date: {0} ", weatherInfo.list[1].dt_txt);

				//3rd Day Weather Forecast
				lblCityDay3.Text = Convert.ToString(weatherInfo.City.name);
				lblDescriptionDay3.Text = weatherInfo.list[3].weather[0].description;
				imgCountryFlagDay3.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgWeatherIconDay3.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[3].weather[0].icon);
				lblHumidityDay3.Text = string.Format("Humidity: {0}", weatherInfo.list[3].humidity);
				lblTempMinDay3.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[3].Temp.temp_min, 1));
				lblTempMaxDay3.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[3].Temp.temp_max, 1));
				lblTempDayDay3.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[3].Temp.day, 1));


				//4th Day Weather Forecast
				lblCityDay4.Text = Convert.ToString(weatherInfo.City.name);
				lblDescriptionDay4.Text = weatherInfo.list[4].weather[0].description;
				imgCountryFlagDay4.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgWeatherIconDay4.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[4].weather[0].icon);
				lblHumidityDay4.Text = string.Format("Humidity: {0}", weatherInfo.list[4].humidity);
				lblTempMinDay4.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[4].Temp.temp_min, 1));
				lblTempMaxDay4.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[4].Temp.temp_max, 1));
				lblTempDayDay4.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[4].Temp.day, 1));


				//5th Day Weather Forecast
				lblCityDay5.Text = Convert.ToString(weatherInfo.City.name);
				lblDescriptionDay5.Text = weatherInfo.list[5].weather[0].description;
				imgCountryFlagDay5.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgWeatherIconDay5.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[5].weather[0].icon);
				lblHumidityDay5.Text = string.Format("Humidity: {0}", weatherInfo.list[4].humidity);
				lblTempMinDay5.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[5].Temp.temp_min, 1));
				lblTempMaxDay5.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[5].Temp.temp_max, 1));
				lblTempDayDay5.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[5].Temp.day, 1));

			}
			string url2 = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0},jm&APPID={1}&units=metric&cnt=6", cityName2, appId);
			using (WebClient client = new WebClient())
			{
				var json = client.DownloadString(url2);
				Forecast weatherInfo = (new JavaScriptSerializer()).Deserialize<Forecast>(json);

				//Tomorrows weather Forecast
				lblMBayCityDay.Text = Convert.ToString(weatherInfo.City.name);
				lblMBayDescriptionDay.Text = weatherInfo.list[1].weather[0].description;
				imgMBayCountryFlagDay.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgMBayWeatherIconDay.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[1].weather[0].icon);
				lblMBayHumidityDay.Text = string.Format("Humidity: {0}", weatherInfo.list[1].humidity);
				lblMBayTempMinDay.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[1].Temp.temp_min, 1));
				lblMBayTempMaxDay.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[1].Temp.temp_max, 1));
				lblMBayTempDayDay.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[1].Temp.day, 1));


				//2nd Day2 weather forecast
				lblMBayCityDay2.Text = Convert.ToString(weatherInfo.City.name);
				lblMBayDescriptionDay2.Text = weatherInfo.list[2].weather[0].description;
				imgMBayCountryFlagDay2.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgMBayWeatherIconDay2.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[2].weather[0].icon);
				lblMBayHumidityDay2.Text = string.Format("Humidity: {0}", weatherInfo.list[2].humidity);
				lblMBayTempMinDay2.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[2].Temp.temp_min, 1));
				lblMBayTempMaxDay2.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[2].Temp.temp_max, 1));
				lblMBayTempDayDay2.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[2].Temp.day, 1));

				//3rd Day Forecast
				lblMBayCityDay3.Text = Convert.ToString(weatherInfo.City.name);
				lblMBayDescriptionDay3.Text = weatherInfo.list[3].weather[0].description;
				imgMBayCountryFlagDay3.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgMBayWeatherIconDay3.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[3].weather[0].icon);
				lblMBayHumidityDay3.Text = string.Format("Humidity: {0}", weatherInfo.list[3].humidity);
				lblMBayTempMinDay3.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[3].Temp.temp_min, 1));
				lblMBayTempMaxDay3.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[3].Temp.temp_max, 1));
				lblMBayTempDayDay3.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[3].Temp.day, 1));

				//4th day forecast
				lblMBayCityDay4.Text = Convert.ToString(weatherInfo.City.name);
				lblMBayDescriptionDay4.Text = weatherInfo.list[4].weather[0].description;
				imgMBayCountryFlagDay4.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgMBayWeatherIconDay4.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[4].weather[0].icon);
				lblMBayHumidityDay4.Text = string.Format("Humidity: {0}", weatherInfo.list[4].humidity);
				lblMBayTempMinDay4.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[4].Temp.temp_min, 1));
				lblMBayTempMaxDay4.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[4].Temp.temp_max, 1));
				lblMBayTempDayDay4.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[4].Temp.day, 1));

				//5th day forecast
				lblMBayCityDay5.Text = Convert.ToString(weatherInfo.City.name);
				lblMBayDescriptionDay5.Text = weatherInfo.list[5].weather[0].description;
				imgMBayCountryFlagDay5.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.City.country.ToLower());
				imgMBayWeatherIconDay5.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[5].weather[0].icon);
				lblMBayHumidityDay5.Text = string.Format("Humidity: {0}", weatherInfo.list[5].humidity);
				lblMBayTempMinDay5.Text = string.Format("Minimum Temp :{0} c", Math.Round(weatherInfo.list[5].Temp.temp_min, 1));
				lblMBayTempMaxDay5.Text = string.Format("Maximum Temp :{0} c", Math.Round(weatherInfo.list[5].Temp.temp_max, 1));
				lblMBayTempDayDay5.Text = string.Format("Average Temp :{0} c", Math.Round(weatherInfo.list[5].Temp.day, 1));
			}
		}

		protected void btnNotifAll_Click(object sender, EventArgs e)
		{
			EmployeeDB empDB = new EmployeeDB();
			Employee employee = new Employee();
			string messageSubjectReg;
			string messageSubjectIt;
			string messageSubjectRegKIN;
			string messageSubjectItKIN;

			//Setting the messages based on the weather for Kingston
			if ((lblDescription.Text == "light rain" ) || (lblDescription.Text == "moderate rain") || (lblDescription.Text == "heavy rain"))
			{
				messageSubjectRegKIN = "You're only working 4 hours tomorrow and not the usual 8 hours";
				messageSubjectItKIN = "No work tomorrow due to rain";
			}
			else
			{
				messageSubjectRegKIN = "You're scheduled for 8 hours tomorrow";
				messageSubjectItKIN = "Work tomorrow";
			}
			//Setting the messages based on the weather for Montego Bay
			if ((lblMBayDescriptionDay.Text == "light rain") || (lblMBayDescriptionDay.Text == "moderate rain") || (lblMBayDescriptionDay.Text == "heavy rain"))
			{
				messageSubjectReg = "You're only working 4 hours tomorrow and not the usual 8 hours";
				messageSubjectIt = "No work tomorrow due to rain";
			}
			else
			{
				messageSubjectReg = "You're scheduled for 8 hours tomorrow";
				messageSubjectIt = "Work tomorrow";
			}


			//Getting the Roles and location of the employees to send Emails
			List<Employee> empList = empDB.GetEmployees().ToList();
			for (int i = 0; i < empList.Count; i++)
			{
				if (empList[i].addressLocation == "Kingston")//Sending Emails
				{
					try
					{
						string emailSender = "thisbeatestmyg@outlook.com";
						string password = "ThisIsAtestpassword1000";
						string reciever = empList[i].email;

						SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

						client.Port = 587;
						client.DeliveryMethod = SmtpDeliveryMethod.Network;
						client.UseDefaultCredentials = false;
						System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(emailSender, password);
						client.EnableSsl = true;
						client.Credentials = credentials;


						MailMessage message = new MailMessage(emailSender, reciever);
						message.Subject = "Status for Work Tomorrow";
						if (empList[i].empRole == "IT")
						{
							message.Body = messageSubjectItKIN;
						}
						else
						{
							message.Body = messageSubjectRegKIN;
						}

						client.Send(message);

					}catch (Exception ex)
					{
						Response.Write(ex.Message);
					}
				}
				else if(empList[i].addressLocation == "Montego Bay")
					{
					try
					{
						string emailSender = "thisbeatestmyg@outlook.com";
						string password = "ThisIsAtestpassword1000";
						string reciever = empList[i].email;

						SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

						client.Port = 587;
						client.DeliveryMethod = SmtpDeliveryMethod.Network;
						client.UseDefaultCredentials = false;
						System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(emailSender, password);
						client.EnableSsl = true;
						client.Credentials = credentials;


						MailMessage message = new MailMessage(emailSender, reciever);
						message.Subject = "Status for Work Tomorrow";
						if (empList[i].empRole != "IT")
						{
							message.Body = messageSubjectIt;
						}
						else
						{
							message.Body = messageSubjectReg;
						}

						client.Send(message);

					}
					catch (Exception ex)
					{
						Response.Write(ex.Message);
					}
				}
			}
		}

		//protected void btnNotifIT_Click(object sender, EventArgs e)
		//{
		//	try
		//	{

		//		string emailSender = "thisbeatestmyg@outlook.com";
		//		string password = "ThisIsAtestpassword1000";
		//		string reciever = "javaughnboothe14@gmail.com";

		//		SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

		//		client.Port = 587;
		//		client.DeliveryMethod = SmtpDeliveryMethod.Network;
		//		client.UseDefaultCredentials = false;
		//		System.Net.NetworkCredential credentials =
		//		new System.Net.NetworkCredential(emailSender, password);
		//		client.EnableSsl = true;
		//		client.Credentials = credentials;

		//		MailMessage message = new MailMessage(emailSender, reciever);
		//		message.Subject = "test one";
		//		message.Body = "This is a test";
		//		client.Send(message);

		//	}
		//	catch (Exception ex)
		//	{
		//		Response.Write(ex.Message);
		//	}


		//}

		//protected void btnNotifRegEmp_Click(object sender, EventArgs e)
		//{

		//}
	}
}