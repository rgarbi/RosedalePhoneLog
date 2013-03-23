using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneLog.Controllers;
using System.Collections.Generic;
using PhoneLog.Models;

namespace PhoneLogTest
{
    [TestClass]
    public class CallTypeControllerTest
    {
        [TestCleanup]
        public void cleanUpDB()
        {
            List<CallType> allCalls = CallTypeController.getAllCallTypes();
            foreach (CallType e in allCalls)
            {
                CallTypeController.deleteCallType(e.Id);
            }
        }
        
        [TestMethod]
        public void storeCallType()
        {
            CallTypeController.storeCallType("SomeComplaint");

            List<CallType> allCalls = CallTypeController.getAllCallTypes();

            Assert.AreEqual(allCalls.Count, 1);
            foreach(CallType e in allCalls)
            {
                Console.WriteLine(e.Id);
                Console.WriteLine(e.CallType1);

                CallTypeController.deleteCallType(e.Id);
            }

        }


        [TestMethod]
        public void getCallTypeTest()
        {
            CallTypeController.storeCallType("SomeComplainTesting");

            List<CallType> allCallTypes = CallTypeController.getAllCallTypes();

            Assert.AreEqual(allCallTypes.Count, 1);
            foreach (CallType e in allCallTypes)
            {
                Console.WriteLine(e.Id);
                Console.WriteLine(e.CallType1);
                
                CallType returnedCallType = CallTypeController.getCallTypeById(e.Id);
                Assert.AreEqual(returnedCallType.CallType1, e.CallType1);
                
                CallTypeController.deleteCallType(e.Id);
            }

        }

    }
}
    