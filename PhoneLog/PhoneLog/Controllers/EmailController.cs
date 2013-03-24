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
            var fromAddress = new MailAddress("PhoneMessage@rosedale.com", "Phone Message");
            var toAddress = new MailAddress(phoneLog.EmployeeEmail, "To Name");
            const string fromPassword = "fromPassword";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.rosedale.org",
                Port = 587,
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