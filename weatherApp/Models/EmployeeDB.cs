using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;

namespace weatherApp.Models
{
	public class EmployeeDB
	{
		EmployeeDBEntities db;
		public EmployeeDB()
		{
			db = new EmployeeDBEntities();
		}

		//Select Methods
		public IEnumerable<Employee> getEmployeesByRole(string role, string city)
		{ //Address type signifies if its work address or not
			return ( from emp in db.Employee
				   where emp.empRole == role
					join adr in db.Address on emp.Id equals adr.EmployeeID
				    where adr.AddressType == true
				   where adr.City == city
					select emp);
		}

		public IEnumerable<Employee> getEmployees(string city)
		{
			return (from emp in db.Employee
					join adr in db.Address on emp.Id equals adr.EmployeeID
					where adr.AddressType == true
					where adr.City == city
					select emp);

		}
		public IEnumerable<Employee> GetEmployees()
		{
			return (from c in db.Employee
				   orderby c.Id
				   select c);
				   
		}
		public void emailEmployees(string City )
		{
			RootObject root = new RootObject();
			string messageSubjectRegNoRain = "You're scheduled for 8 hours tomorrow";
			string messageSubjectItNoRain = "Work tomorrow";
			string messageSubjectReg = "You're only working 4 hours tomorrow and not the usual 8 hours";
			string messageSubjectIt = "No work tomorrow due to rain";

			List<Employee> emp = getEmployees(City).ToList();
			root = root.getWeatherInfo(City.ToLower());

			Boolean check = rainCheck(root);
			for(int i=0;i< (emp.Count); i++)
			{
				if (check && emp[i].empRole == "IT")
				{
					sendMail(messageSubjectIt, emp[i].email);
				}
				else if (check && emp[i].empRole != "IT")
				{
					sendMail(messageSubjectReg, emp[i].email);
				}
				else if (emp[i].empRole == "IT")
				{
					sendMail(messageSubjectItNoRain, emp[i].email);
				}
				else
				{
					sendMail(messageSubjectRegNoRain, emp[i].email);
				}
			}
		}
		public Boolean rainCheck(RootObject root )
		{
			string[] words = root.list[1].weather[0].description.Split();
			foreach(string i in words)
			{
				if(i == "rain")
				{
					return true;
				}
			}
			return false;
		}

		public void sendMail(String message,String email)
		{
			string emailSender = "thisbeatestmyg@outlook.com";
			string password = "ThisIsAtestpassword1000";
			//
			SmtpClient client = new SmtpClient();
			client.Port = 587;
			client.Host = "smtp-mail.outlook.com";
			client.EnableSsl = true;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			client.UseDefaultCredentials = false;
			System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(emailSender, password);
			
			client.Credentials = credentials;

			MailMessage msg = new MailMessage(emailSender, email);
			msg.Subject = "Status For Work Tomorrow";
			msg.Body = message;
			msg.BodyEncoding = UTF8Encoding.UTF8;
			msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
			client.Send(msg);
			msg.Dispose();
		}
	}
}