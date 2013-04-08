using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace PhoneLog.Controllers
{
    public class EmailController
    {
        public static void sendAnEmail(Models.PhoneLog phoneLog)
        {
            var fromAddress = new MailAddress("phonelog@rosedale.org", "Phone Message");
            var toAddress = new MailAddress(phoneLog.EmployeeEmail, "To Name");
            const string fromPassword = "Q3tn5EUfmrA3sEzc0h89";
            string subject = "Phone Message from: " + phoneLog.CallerName;
            string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                IsBodyHtml = true,
                Body = buildBody(phoneLog)
            })
            {
                smtp.Send(message);
            }
        }

        public static string buildBody(Models.PhoneLog phoneLog)
        {

            string host = HttpContext.Current.Request.Url.Host;
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.Append("<div>");
            messageBuilder.Append("<p>You have a message from: " + phoneLog.CallerName + "</p>");
            messageBuilder.Append("<p>They Called On: " + phoneLog.CallDate.Value.ToShortDateString() + "</p>");
            messageBuilder.Append("<p>Call Type: " + phoneLog.CallType + "</p>");
            messageBuilder.Append("<p>Message: " + phoneLog.Message + "</p>");
            messageBuilder.Append("<p>Their Phone Number: " + phoneLog.PhoneNumber + "</p>");
            messageBuilder.Append("<p><a href='http://"+HttpContext.Current.Request.Url.Host+"/phonelog/PhoneLogUpdate.aspx?PhoneLogId=" + phoneLog.Id + "'>Click Here to mark the call as followed up.</a></p>");
            messageBuilder.Append("</div>");

            return messageBuilder.ToString();
        }


    }
}