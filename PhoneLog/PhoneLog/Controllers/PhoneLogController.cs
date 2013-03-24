using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneLog.Models;

namespace PhoneLog.Controllers
{
    public class PhoneLogController
    {
        public static void storePhoneLog(string name, DateTime date, string phoneNumber, string message, string employeeEmail, string callType,  Boolean followedUp)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                
                var log = new PhoneLog.Models.PhoneLog{ 
                    CallerName = name, 
                    CallDate = date,
                    PhoneNumber = phoneNumber,
                    Message = message,
                    EmployeeEmail = employeeEmail,
                    CallType = callType,
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
                        EmployeeEmail = item.EmployeeEmail,
                        CallType = item.CallType,
                        FollowedUp = item.FollowedUp,
                        Message = item.Message
                    });
                }
            }

            return allLogs;
        }

        public static void deletePhoneLog(int id)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var log = db.PhoneLogs.Where(item => item.Id == id).Single();
                db.PhoneLogs.Remove(log);
                db.SaveChanges();
            }
        }

        public static List<PhoneLog.Models.PhoneLog> getAllPhoneLogsInRange(DateTime start, DateTime end)
        {
            List<PhoneLog.Models.PhoneLog> allLogs = new List<Models.PhoneLog>();

            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var query = from l in db.PhoneLogs
                            where (l.CallDate.Value.CompareTo(start) >= 0) && (l.CallDate.Value.CompareTo(end) < 0)
                            orderby l.CallDate
                            select l;

                Console.WriteLine("All logs in the database:");
                foreach (var item in query)
                {
                    allLogs.Add(new Models.PhoneLog
                    {
                        Id = item.Id,
                        CallerName = item.CallerName,
                        CallDate = item.CallDate,
                        PhoneNumber = item.PhoneNumber,
                        EmployeeEmail = item.EmployeeEmail,
                        CallType = item.CallType,
                        FollowedUp = item.FollowedUp,
                        Message = item.Message
                    });
                }
            }

            return allLogs;
        }



    }
}