using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneLog.Controllers;

namespace PhoneLogTest
{
    [TestClass]
    public class EmailUnitTests
    {
        [TestMethod]
        public void sendMail()
        {
            PhoneLog.Models.PhoneLog phoneLog = new PhoneLog.Models.PhoneLog();
            phoneLog.CallerName = "Test";
            phoneLog.CallDate = System.DateTime.Now;
            phoneLog.PhoneNumber = "543-3333";
            phoneLog.Message = "Message";
            phoneLog.EmployeeEmail = "richard.garbi@gmail.com";


            EmailController.sendAnEmail(phoneLog);
        }
    }
}
