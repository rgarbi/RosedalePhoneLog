using PhoneLog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneLog
{
    public partial class CallTypeResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Models.CallType> allCallTypes = CallTypeController.getAllCallTypes();
            TableRow headerRow = new TableRow();
          
            TableHeaderCell header = new TableHeaderCell();
            header.Text = "ID";
            headerRow.Cells.Add(header);

            header = new TableHeaderCell();
            header.Text = "Call Type";
            headerRow.Cells.Add(header);

            this.callTypeResultsTable.Rows.Add(headerRow);

            foreach (Models.CallType aType in allCallTypes)
            {
                TableRow row = new TableRow();
                TableCell cellId = new TableCell();
                TableCell cellText = new TableCell();

                cellId.Text = aType.Id.ToString();
                cellText.Text = aType.CallType1;
                row.Cells.Add(cellId);
                row.Cells.Add(cellText);
                this.callTypeResultsTable.Rows.Add(row);
            }

        }
    }
}