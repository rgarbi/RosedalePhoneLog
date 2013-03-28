using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneLog.Models;
using System.Data;

namespace PhoneLog.Controllers
{
    public class PhoneLogController
    {
        public static int storePhoneLog(string name, DateTime date, string phoneNumber, string message, string employeeEmail, string callType,  Boolean followedUp)
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

                var savedLog = db.PhoneLogs.Where(item => 
                    item.CallerName == name && 
                    item.CallDate == date && 
                    item.PhoneNumber == phoneNumber &&
                    item.Message == message &&
                    item.CallType == callType &&
                    item.FollowedUp == followedUp).Single();

                EmailController.sendAnEmail(savedLog);
                return savedLog.Id;
            }
        }

        public static void updatePhoneLog(int id, string name, DateTime date, string phoneNumber, string message, string employeeEmail, string callType, Boolean followedUp)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            {

                Models.PhoneLog log = (from x in db.PhoneLogs 
                                        where x.Id == id
                                        select x).First();
                log.Id = id;
                log.CallerName = name;
                log.CallDate = date;
                log.CallType = callType;
                log.Message = message;
                log.PhoneNumber = phoneNumber;
                log.FollowedUp = followedUp;
                log.EmployeeEmail = employeeEmail;
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


        public static Models.PhoneLog getPhoneLogById(int id)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var log = db.PhoneLogs.Where(item => item.Id == id).Single();
                return new Models.PhoneLog
                {
                    Id = log.Id,
                    CallDate = log.CallDate,
                    EmployeeEmail = log.EmployeeEmail,
                    CallerName = log.CallerName,
                    CallType = log.CallType,
                    FollowedUp = log.FollowedUp,
                    Message = log.Message,
                    PhoneNumber = log.PhoneNumber
                };
            }
        }



    }
}