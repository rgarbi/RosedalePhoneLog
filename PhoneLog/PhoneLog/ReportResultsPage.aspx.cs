using PhoneLog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneLog
{
    public partial class ReportResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Models.PhoneLog> allPhoneLogs = PhoneLogController.getAllPhoneLogs();
            
            foreach(Models.PhoneLog log in allPhoneLogs)
            {

                TableRow row = new TableRow();
                TableCell cell = new TableCell();

                cell.Text = log.Id.ToString();
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = log.CallerName;
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = log.PhoneNumber;
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = log.CallType;
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = log.Message;
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = log.EmployeeEmail;
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = log.CallDate.Value.ToShortDateString();
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = log.FollowedUp.Value.ToString();
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = "<a href='PhoneLogUpdate.aspx?PhoneLogId=" + log.Id.ToString() + "'>Update<a>";
                row.Cells.Add(cell);
                this.allPhoneLogsTable.Rows.Add(row);
            }

            

        }
    }
}