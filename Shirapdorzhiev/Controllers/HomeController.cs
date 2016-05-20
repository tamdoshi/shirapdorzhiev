using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using Shirapdorzhiev.Models;
using System.Text;

namespace Shirapdorzhiev.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModels c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    SmtpClient client = new SmtpClient();
                    MailAddress from = new MailAddress(c.Email.ToString());
                    StringBuilder sb = new StringBuilder();
                    msg.To.Add("shirapdorzho@gmail.com");
                    msg.Subject = "Свяжитесь с нами";
                    msg.IsBodyHtml = false;
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new System.Net.NetworkCredential("shirapdorzho@gmail.com", "12901290");
                    sb.Append(from.DisplayName);
                    sb.Append("Имя: " + c.FirstName);
                    sb.Append(c.LastName);
                    sb.Append(Environment.NewLine);
                    sb.Append("Email: " + c.Email);
                    sb.Append(Environment.NewLine);
                    sb.Append("Текст сообщения: " + c.Comment);
                    msg.Body = sb.ToString();
                    client.Send(msg);
                    msg.Dispose();
                    return View("Success");
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        //public ActionResult Gallery()
        //{
        //    return View();
        //}
    }
}