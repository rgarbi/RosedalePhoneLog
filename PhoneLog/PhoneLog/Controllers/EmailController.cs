using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                Port = 25,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

    }
}