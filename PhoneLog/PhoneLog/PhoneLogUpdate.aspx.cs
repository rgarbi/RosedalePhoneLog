using PhoneLog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneLog
{
    public partial class PhoneLogUpdate : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            string phoneLogId = HttpUtility.ParseQueryString(Request.Url.Query).Get("PhoneLogId");

            Models.PhoneLog log = PhoneLogController.getPhoneLogById(int.Parse(phoneLogId));

            txtPhoneLogId.Text = log.Id.ToString();
            txtCallerName.Text = log.CallerName;
            txtPhoneNumber.Text = log.PhoneNumber;
            txtCallDate.Text = log.CallDate.Value.ToString();
            txtCallType.Text = log.CallType;
            txtMessage.Text = log.Message;
            txtRecipient.Text = log.EmployeeEmail;
            chkFollowedUp.Checked = log.FollowedUp.Value;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            bool isChecked = chkFollowedUp.Checked;

            PhoneLogController.updatePhoneLog(
                int.Parse(txtPhoneLogId.Text),
                txtCallerName.Text,
                DateTime.Parse(txtCallDate.Text),
                txtPhoneNumber.Text,
                txtMessage.Text,
                txtRecipient.Text,
                txtCallType.Text,
                chkFollowedUp.Checked);
        }
    }
}