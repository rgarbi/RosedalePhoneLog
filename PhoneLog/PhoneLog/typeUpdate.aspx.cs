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
    public partial class WebForm2 : System.Web.UI.Page
    {

        

        protected void Page_Load()
        {
            if (!IsPostBack)
                CreateToken();
        }

        // Call this method to establish a token in session and on the page.
        private void CreateToken()
        {
            string token = new Guid().ToString();
            Session["dupeToken"] = token;
            tokenField.Value = token;
        }

        // Call this method to validate the token before continuing workflow.
        private bool TokenIsValid()
        {
            string expectedToken = (string)Session["dupeToken"];
            if (expectedToken == null)
                return false;

            string actualToken = tokenField.Value;

            return expectedToken == actualToken;
        }

        // Call this method when the page submission is complete to prevent re-submission.
        private void ConsumeToken()
        {
            Session["dupeToken"] = null;
        }



        public static List<CallType> allCallTypes;

        protected void Page_Load(object sender, EventArgs e)
        {
            CreateToken();
            refreshTable();
        }

        protected void btnAddType_Click(object sender, EventArgs e)
        {
            if (TokenIsValid())
            {
                string type = this.callType.Text;
                if (type != "")
                {
                    this.lblErrorMsgs.Text = String.Empty;
                    CallTypeController.storeCallType(type);
                    this.callType.Text = String.Empty;
                    type = String.Empty;
                    refreshTable();
                    ConsumeToken();

                }
                else
                {
                    this.lblErrorMsgs.Text = "Call Type is required.";
                }
            }

        }

        protected void refreshTable()
        {
            this.tblAllCalls.Rows.Clear();
            allCallTypes = CallTypeController.getAllCallTypes();

            if (allCallTypes.Count == 0)
            {
                this.tblAllCalls.Rows.Clear();
                this.tblAllCalls.Visible = false;
            }
            else
            {
                this.tblAllCalls.Visible = true;
                TableRowCollection rows = this.tblAllCalls.Rows;

                foreach (CallType call in allCallTypes)
                {
                    TableRow row = new TableRow();
                    TableCell cell = new TableCell();
                    cell.Text = call.CallType1;
                    row.Cells.Add(cell);
                    rows.Add(row);
                }
            }
        }

    }
}