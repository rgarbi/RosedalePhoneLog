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
            this.callType.Items.Add(new ListItem(String.Empty, String.Empty));
            foreach(CallType call in CallTypeController.getAllCallTypes())
            {
                this.callType.Items.Add(new ListItem(call.CallType1, call.CallType1));
            }

            this.employeeId.Items.Clear();
            this.employeeId.Items.Add(new ListItem(String.Empty, String.Empty));
            foreach (Employee empl in EmployeeController.getAllEmployees())
            {
                this.employeeId.Items.Add(new ListItem(empl.EmployeeName, empl.EmployeeEmail));
            }

            //Default Date
            this.txtDate.Text = DateTime.Now.Date.ToShortDateString();

        }

        protected void phoneSubmit_Click(object sender, EventArgs e)
        {
            //Validation
            clearErrorMessages();
            if (saveValidation())
            {
                PhoneLogController.storePhoneLog(
                    txtName.Text,
                    DateTime.Parse(txtDate.Text),
                    txtPhone.Text,
                    txtMessage.Text,
                    employeeId.SelectedValue,
                    callType.SelectedValue,
                    chkFollowUp.Checked);

                clearAll();
            }
        }

        protected Boolean saveValidation()
        {
            bool valid = true;

            //Is the date a date.
            try
            {
                DateTime.Parse(txtDate.Text);
            }
            catch (Exception ex)
            {
                Trace.Write(ex.Message);
                valid = false;
                lblDateError.Text = "Please enter a valid date.";
            }
            
            //Must have entered Name, CallType, EmployeeEmail, Date
            if(txtName.Text.Equals(String.Empty))
            {
                valid = false;
                lblNameError.Text = "Please enter the name of the caller.";
            }

            if (callType.SelectedValue.Equals(String.Empty))
            {
                valid = false;
                lblCallTypeError.Text = "Please select the type of the call.";
            }

            if (employeeId.SelectedValue.Equals(String.Empty))
            {
                valid = false;
                lblEmployeeError.Text = "Please select the name of the person this call is for.";
            }

            return valid;
        }

        protected void clearAll()
        {
            clearAllFields();
            clearErrorMessages();
        }

        protected void clearErrorMessages()
        {
            lblDateError.Text = "";
            lblCallTypeError.Text = "";
            lblNameError.Text = "";
            lblEmployeeError.Text = "";
        }

        protected void clearAllFields()
        {
            txtName.Text = "";
            txtDate.Text = "";
            txtPhone.Text = "";
            txtMessage.Text = "";
            employeeId.SelectedIndex = 0;
            callType.SelectedIndex = 0;
            chkFollowUp.Checked = false;
        }
    }
}