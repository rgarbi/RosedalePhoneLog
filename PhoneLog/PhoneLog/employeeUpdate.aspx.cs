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
    public partial class employeeUpdate : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {

            string name = this.txtEmplName.Text;
            string email = this.txtEmplEmailAddress.Text;

                if (name != "" && email != "")
                {
                    this.lblErrorMsgs.Text = String.Empty;
                    EmployeeController.storeEmployee(name, email);
                    
                    this.txtEmplName.Text = String.Empty;
                    this.txtEmplEmailAddress.Text = String.Empty;

                    Response.Redirect("~/EmployeeUpdateResultsPage.aspx", true);
                    

                }
                else
                {
                    this.lblErrorMsgs.Text = "Name and Email are required.";
                }
        }

    }
}