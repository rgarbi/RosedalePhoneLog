using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;

namespace PhoneLog.Controllers
{
    public class EmployeeController
    {

        public static void storeEmployee(string employeeName, String employeeEmail)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var employee = new PhoneLog.Models.Employee
                {
                    EmployeeName = employeeName,
                    EmployeeEmail = employeeEmail
                    
                };
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }

        public static List<PhoneLog.Models.Employee> getAllEmployees()
        {
            List<Models.Employee> allEmployees = new List<Models.Employee>();

            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var query = from l in db.Employees
                            orderby l.EmployeeName
                            select l;

                Console.WriteLine("All employees in the database:");
                foreach (var item in query)
                {
                    allEmployees.Add(new Models.Employee
                    {
                        Id = item.Id,
                        EmployeeName = item.EmployeeName,
                        EmployeeEmail = item.EmployeeEmail
                    });
                }
            }

            return allEmployees;
        }

        public static void deleteEmployee(int id)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            { 
                var employee = db.Employees.Where(item => item.Id == id).Single();
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
        }

        public static Models.Employee getEmployeeById(int id)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var employee = db.Employees.Where(item => item.Id == id).Single();
                return new Models.Employee
                {
                    Id = employee.Id,
                    EmployeeName = employee.EmployeeName,
                    EmployeeEmail = employee.EmployeeEmail
                };
            }
        }
    }
}