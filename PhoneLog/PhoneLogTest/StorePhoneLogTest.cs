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
                //0,
                //0,
                false);
        }
    }
}
    