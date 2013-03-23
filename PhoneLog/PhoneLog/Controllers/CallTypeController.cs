using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace PhoneLog.Controllers
{
    public class CallTypeController
    {

        public static void storeCallType(string callType)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var call = new PhoneLog.Models.CallType
                {
                    CallType1 = callType
                };
                db.CallTypes.Add(call);
                try
                { 
                    int result = db.SaveChanges();
                    Console.WriteLine(result);
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
        }

        public static List<PhoneLog.Models.CallType> getAllCallTypes()
        {
            List<Models.CallType> allCallTypes = new List<Models.CallType>();

            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var query = from l in db.CallTypes
                            orderby l.CallType1
                            select l;

                Console.WriteLine("All calltypes in the database:");
                foreach (var item in query)
                {
                    allCallTypes.Add(new Models.CallType
                    {
                        Id = item.Id,
                        CallType1 = item.CallType1
                    });
                }
            }

            return allCallTypes;
        }

        public static void deleteCallType(int id)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            { 
                var callType = db.CallTypes.Where(item => item.Id == id).Single();
                db.CallTypes.Remove(callType);
                db.SaveChanges();
            }
        }

        public static Models.CallType getCallTypeById(int id)
        {
            using (var db = new PhoneLog.Models.PhoneLogContext())
            {
                var callType = db.CallTypes.Where(item => item.Id == id).Single();
                return new Models.CallType
                {
                    Id = callType.Id,
                    CallType1 = callType.CallType1
                };
            }
        }
    }
}