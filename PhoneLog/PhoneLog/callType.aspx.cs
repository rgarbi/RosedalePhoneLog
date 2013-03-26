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
    public partial class CallType : System.Web.UI.Page
    {

        
        public static List<Models.CallType> allCallTypes;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAddType_Click(object sender, EventArgs e)
        {
            
                string type = this.callType.Text;
                if (type != "")
                {
                    this.lblErrorMsgs.Text = String.Empty;
                    CallTypeController.storeCallType(type);
                    this.callType.Text = String.Empty;
                    type = String.Empty;
                    Response.Redirect("~/CallTypeResultsPage.aspx", true);

                }
                else
                {
                    this.lblErrorMsgs.Text = "Call Type is required.";
                }
        }

        

        
    }
}