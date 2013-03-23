using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneLog.Controllers;

namespace PhoneLogTest
{
    [TestClass]
    public class StorePhoneLogTest
    {
        string name = "";
        string message = "";
        DateTime date = new DateTime();
        string phoneNum = "";
        int callTypeId;
        int emplId;

        [TestMethod]
        public void storeLog()
        {


            PhoneLogController.storePhoneLog(
                "Test",
                new DateTime(),
                "543-3333",
                "Message",
                //0,
                //0,
                false);
        }
    }
}
    