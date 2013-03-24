using PhoneLog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneLog
{
    public partial class ResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string phoneLogId = HttpUtility.ParseQueryString(Request.Url.Query).Get("PhoneLogId");
            
            Models.PhoneLog log = PhoneLogController.getPhoneLogById(int.Parse(phoneLogId));

            TableRow row = new TableRow();
            TableCell cellTxt = new TableCell();
            TableCell cellValue = new TableCell();

            cellTxt.Text = "Name:";
            cellValue.Text = log.CallerName;
            row.Cells.Add(cellTxt);
            row.Cells.Add(cellValue);
            this.confirmTable.Rows.Add(row);

            row = new TableRow();
            cellTxt = new TableCell();
            cellValue = new TableCell();

            cellTxt.Text = "Call Date:";
            cellValue.Text = log.CallDate.ToString();
            row.Cells.Add(cellTxt);
            row.Cells.Add(cellValue);
            this.confirmTable.Rows.Add(row);

            row = new TableRow();
            cellTxt = new TableCell();
            cellValue = new TableCell();

            cellTxt.Text = "Phone Number:";
            cellValue.Text = log.PhoneNumber;
            row.Cells.Add(cellTxt);
            row.Cells.Add(cellValue);
            this.confirmTable.Rows.Add(row);

            row = new TableRow();
            cellTxt = new TableCell();
            cellValue = new TableCell();

            cellTxt.Text = "Call Type:";
            cellValue.Text = log.CallType;
            row.Cells.Add(cellTxt);
            row.Cells.Add(cellValue);
            this.confirmTable.Rows.Add(row);

            row = new TableRow();
            cellTxt = new TableCell();
            cellValue = new TableCell();

            cellTxt.Text = "Message:";
            cellValue.Text = log.Message;
            row.Cells.Add(cellTxt);
            row.Cells.Add(cellValue);
            this.confirmTable.Rows.Add(row);

        }
    }
}