using PhoneLog.Controllers;
using PhoneLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneLog
{
    public partial class phoneLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Load the Call Types and the Employee Email addresses
            this.callType.Items.Clear();
            foreach(CallType call in CallTypeController.getAllCallTypes())
            {
                this.callType.Items.Add(call.CallType1);
            }
            this.employeeId.Items.Clear();
            foreach (Employee empl in EmployeeController.getAllEmployees())
            {
                this.employeeId.Items.Add(new ListItem(empl.EmployeeName, empl.EmployeeEmail));
            }


        }
    }
}