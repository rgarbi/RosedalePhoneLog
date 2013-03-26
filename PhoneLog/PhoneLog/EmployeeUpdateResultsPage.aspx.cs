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
    public partial class EmployeeUpdateResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var allEmployees = EmployeeController.getAllEmployees();
            this.tblAllEmployees.Visible = true;

            TableRow headerRow = new TableRow();

            TableHeaderCell header = new TableHeaderCell();
            header.Text = "ID";
            headerRow.Cells.Add(header);

            header = new TableHeaderCell();
            header.Text = "Name";
            headerRow.Cells.Add(header);

            header = new TableHeaderCell();
            header.Text = "Email";
            headerRow.Cells.Add(header);

            this.tblAllEmployees.Rows.Add(headerRow);

            foreach (Employee empl in allEmployees)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();

                cell = new TableCell();
                cell.Text = empl.Id.ToString();
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = empl.EmployeeName;
                row.Cells.Add(cell);

                cell = new TableCell();
                cell.Text = empl.EmployeeEmail;
                row.Cells.Add(cell);

                this.tblAllEmployees.Rows.Add(row);
            }
        }
    }
}