using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneLog.Controllers;
using PhoneLog.Models;
using System.Collections.Generic;

namespace PhoneLogTest
{
    [TestClass]
    public class StorePhoneLogTest
    {

        [TestCleanup]
        public void cleanUpAllData()
        {
            List<Employee> allEmployees = EmployeeController.getAllEmployees();
            List<CallType> allCalls = CallTypeController.getAllCallTypes();
            List<PhoneLog.Models.PhoneLog> allPhoneLog = PhoneLogController.getAllPhoneLogs();

            foreach (Employee emp in allEmployees)
            {
                EmployeeController.deleteEmployee(emp.Id);
            }

            foreach (CallType call in allCalls)
            {
                CallTypeController.deleteCallType(call.Id);
            }

            foreach (PhoneLog.Models.PhoneLog phoneLog in allPhoneLog)
            {
                PhoneLogController.deletePhoneLog(phoneLog.Id);
            }
        }

        [TestMethod]
        public void storeLog()
        {


            PhoneLogController.storePhoneLog(
                "Test",
                System.DateTime.Now,
                "543-3333",
                "Message",
                "me",
                "me@me.me",
                false);
        }


        [TestMethod]
        public void getLogsDateRange()
        {
            System.DateTime start = DateTime.Now;
            System.DateTime end = DateTime.Now;
            int numLogs = 100;

            end = end.AddDays(100.00);

            System.DateTime middle = DateTime.Now;
            middle = middle.AddDays(50.00);

            for (int i = 0; i < numLogs; ++i)
            {
                PhoneLogController.storePhoneLog(
                "Test",
                middle,
                "543-3333",
                "Message",
                "me",
                "me@me.me",
                false);
            }


            List<PhoneLog.Models.PhoneLog> allLogs = PhoneLogController.getAllPhoneLogsInRange(start, end);

            Assert.AreEqual(numLogs, allLogs.Count);

        }
    }
}
    