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
        

        [TestMethod]
        public void storeLog()
        {
            EmployeeController.storeEmployee("EmployeeName", "EmployeeEmail");

            List<Employee> allEmployees = EmployeeController.getAllEmployees();

            foreach(Employee e in allEmployees)
            {
                Console.WriteLine(e.Id);
                Console.WriteLine(e.EmployeeName);
                Console.WriteLine(e.EmployeeEmail);

                EmployeeController.deleteEmployee(e.Id);
            }

        }
    }
}
    