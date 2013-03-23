using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneLog.Controllers;
using System.Collections.Generic;
using PhoneLog.Models;

namespace PhoneLogTest
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestCleanup]
        public void cleanUpDB()
        {
            List<Employee> allEmployees = EmployeeController.getAllEmployees();
            foreach (Employee e in allEmployees)
            {
                EmployeeController.deleteEmployee(e.Id);
            }
        }
        
        [TestMethod]
        public void storeEmployee()
        {
            EmployeeController.storeEmployee("EmployeeName", "EmployeeEmail");

            List<Employee> allEmployees = EmployeeController.getAllEmployees();

            Assert.AreEqual(allEmployees.Count, 1);
            foreach(Employee e in allEmployees)
            {
                Console.WriteLine(e.Id);
                Console.WriteLine(e.EmployeeName);
                Console.WriteLine(e.EmployeeEmail);

                EmployeeController.deleteEmployee(e.Id);
            }

        }


        [TestMethod]
        public void getEmployeeTest()
        {
            EmployeeController.storeEmployee("EmployeeName", "EmployeeEmail");

            List<Employee> allEmployees = EmployeeController.getAllEmployees();

            Assert.AreEqual(allEmployees.Count, 1);
            foreach (Employee e in allEmployees)
            {
                Console.WriteLine(e.Id);
                Console.WriteLine(e.EmployeeName);
                Console.WriteLine(e.EmployeeEmail);

                Employee returnedEmp = EmployeeController.getEmployeeById(e.Id);
                Assert.AreEqual(returnedEmp.EmployeeEmail, e.EmployeeEmail);
                Assert.AreEqual(returnedEmp.EmployeeName, e.EmployeeName);

                EmployeeController.deleteEmployee(e.Id);
            }

        }

    }
}
    