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

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            
        }

        protected void Page_Load()
        {
            
        }

        
        public static List<Employee> allEmployees;

        protected void Page_Load(object sender, EventArgs e)
        {
            refreshTable();
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

                   
                    refreshTable();
                    

                }
                else
                {
                    this.lblErrorMsgs.Text = "Name and Email are required.";
                }
        }

        

        protected void refreshTable()
        {
            this.tblAllEmployees.Rows.Clear();
            allEmployees = EmployeeController.getAllEmployees();

            if (allEmployees.Count == 0)
            {
                this.tblAllEmployees.Rows.Clear();
                this.tblAllEmployees.Visible = false;
            }
            else
            {
                this.tblAllEmployees.Visible = true;
                TableRowCollection rows = this.tblAllEmployees.Rows;

                foreach (Employee empl in allEmployees)
                {
                    TableRow row = new TableRow();
                    TableCell cell = new TableCell();
                    cell.Text = empl.EmployeeName;

                    TableCell cell1 = new TableCell();
                    cell1.Text = empl.EmployeeEmail;
                    row.Cells.Add(cell);
                    row.Cells.Add(cell1);

                    rows.Add(row);
                }
            }
        }


    }
}