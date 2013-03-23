using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneLog.Models;

namespace PhoneLog.Controllers
{
    public class PhoneLogController
    {
        public static void storePhoneLog(string name, DateTime date, string phoneNumber, string message, Boolean followedUp)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                
                var log = new PhoneLog.Models.PhoneLog{ 
                    CallerName = name, 
                    CallDate = date,
                    PhoneNumber = phoneNumber,
                    Message = message,
                    //EmployeeId = employeeId,
                    //CallTypeId = callTypeid,
                    FollowedUp = followedUp
                };
                db.PhoneLogs.Add(log);
                db.SaveChanges();

            }
        }

        public static List<PhoneLog.Models.PhoneLog> getAllPhoneLogs()
        {
            List<PhoneLog.Models.PhoneLog> allLogs = new List<Models.PhoneLog>();

            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var query = from l in db.PhoneLogs
                            orderby l.CallDate
                            select l;

                Console.WriteLine("All logs in the database:");
                foreach (var item in query)
                {
                    allLogs.Add(new Models.PhoneLog {
                        Id = item.Id,
                        CallerName = item.CallerName,
                        CallDate = item.CallDate,
                        PhoneNumber = item.PhoneNumber,
                        EmployeeId = item.EmployeeId,
                        CallTypeId = item.CallTypeId,
                        FollowedUp = item.FollowedUp,
                        Message = item.Message
                    });
                }
            }

            return allLogs;
        }

    }
}