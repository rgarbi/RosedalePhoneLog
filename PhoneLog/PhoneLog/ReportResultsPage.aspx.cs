using PhoneLog.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Xml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;

namespace PhoneLog
{
    public partial class ReportResultsPage : System.Web.UI.Page
    {
        List<Models.PhoneLog> allPhoneLogs;

        protected List<Models.PhoneLog> getAllLogsByType(ReportTypes.types typeVal)
        {
            List<Models.PhoneLog> logs;
            switch (typeVal)
            {
                case ReportTypes.types.allLogs:
                    logs = PhoneLogController.getAllPhoneLogs();
                    break;
                case ReportTypes.types.thirtyDays:
                    logs = PhoneLogController.getAllPhoneLogsInRange(DateTime.Now.Subtract(new TimeSpan(30, 0, 0, 0)), DateTime.Now);
                    break;
                case ReportTypes.types.notFollowedUp:
                    logs = PhoneLogController.getAllPhoneLogsNotFollowedUp();
                    break;
                default:
                    logs = PhoneLogController.getAllPhoneLogs();
                    break;
            }

            return logs;
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            allPhoneLogs = new List<Models.PhoneLog>();

            string type = HttpUtility.ParseQueryString(Request.Url.Query).Get("reportType");
            string beginDate = HttpUtility.ParseQueryString(Request.Url.Query).Get("beginDate");
            string endDate = HttpUtility.ParseQueryString(Request.Url.Query).Get("endDate");

            if (type != null)
            {
                ReportTypes.types typeVal = (ReportTypes.types)Enum.Parse(typeof(ReportTypes.types), type);
                allPhoneLogs = getAllLogsByType(typeVal);
            }
            else if (beginDate != null && endDate != null)
            {
                allPhoneLogs = PhoneLogController.getAllPhoneLogsInRange(new DateTime(long.Parse(beginDate)), new DateTime(long.Parse(endDate)));
            }

            

            foreach (Models.PhoneLog log in allPhoneLogs)
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
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            buildExcelDoc(allPhoneLogs);
        }


        public void buildExcelDoc(List<Models.PhoneLog> logs)
        {
            string tempPath = System.IO.Path.GetTempPath();

            string fullPath = tempPath + "PhoneLogReport.xlsx";
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            SpreadsheetDocument myDoc = SpreadsheetDocument.Create(fullPath, SpreadsheetDocumentType.Workbook, true);
           
            // Add a WorkbookPart to the document.
            WorkbookPart workbookpart = myDoc.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            // Add Sheets to the Workbook.
            Sheets sheets = myDoc.WorkbookPart.Workbook.
                AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            Sheet sheet = new Sheet()
            {
                Id = myDoc.WorkbookPart.
                    GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "mySheet"
            };
            sheets.Append(sheet);

            workbookpart.Workbook.Save();
            // Open the copied template workbook. 
            using (myDoc)
            {
                // Access the main Workbook part, which contains all references.
                WorkbookPart workbookPart = myDoc.WorkbookPart;

                // Get the first worksheet. 
                WorksheetPart wrksheetPart = workbookPart.WorksheetParts.ElementAt(0);

                // The SheetData object will contain all the data.
                SheetData sheetData = wrksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Begining Row pointer                       
                int index = 2;
                
                foreach (Models.PhoneLog log in logs)
                {
                   
                    Row row = buildRowFromPhoneLog(index, log);

                   
                    sheetData.AppendChild(row);

                    
                    index++;

                }

                // save
                worksheetPart.Worksheet.Save();

            }
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=PhoneLogReport.xlsx");
            Response.WriteFile(fullPath);
        }

        protected Row buildRowFromPhoneLog(int index, Models.PhoneLog log)
        {
            // New Row
            Row row = new Row();
            row.RowIndex = (UInt32)index;

            // New Cell
            Cell cell = new Cell();
            cell.DataType = CellValues.InlineString;
            // Column A1, 2, 3 ... and so on
            //cell.CellReference = "A" + index;

            Text t = new Text();
            t.Text = log.Id.ToString();
            InlineString inlineString = new InlineString();
            inlineString.AppendChild(t);
            cell.AppendChild(inlineString);
            row.AppendChild(cell);

            cell = new Cell();
            cell.DataType = CellValues.InlineString;
            t = new Text();
            t.Text = log.CallerName;
            // Append Text to InlineString object
            inlineString = new InlineString();
            inlineString.AppendChild(t);
            cell.AppendChild(inlineString);
            row.AppendChild(cell);

            cell = new Cell();
            cell.DataType = CellValues.InlineString;
            t = new Text();
            t.Text = log.PhoneNumber;
            // Append Text to InlineString object
            inlineString = new InlineString();
            inlineString.AppendChild(t);
            cell.AppendChild(inlineString);
            row.AppendChild(cell);

            cell = new Cell();
            cell.DataType = CellValues.InlineString;
            t = new Text();
            t.Text = log.CallType;
            // Append Text to InlineString object
            inlineString = new InlineString();
            inlineString.AppendChild(t);
            cell.AppendChild(inlineString);
            row.AppendChild(cell);

            cell = new Cell();
            cell.DataType = CellValues.InlineString;
            t = new Text();
            t.Text = log.Message;
            // Append Text to InlineString object
            inlineString = new InlineString();
            inlineString.AppendChild(t);
            cell.AppendChild(inlineString);
            row.AppendChild(cell);

            cell = new Cell();
            cell.DataType = CellValues.InlineString;
            t = new Text();
            t.Text = log.EmployeeEmail;
            // Append Text to InlineString object
            inlineString = new InlineString();
            inlineString.AppendChild(t);
            cell.AppendChild(inlineString);
            row.AppendChild(cell);

            cell = new Cell();
            cell.DataType = CellValues.InlineString;
            t = new Text();
            t.Text = log.CallDate.Value.ToShortDateString();
            // Append Text to InlineString object
            inlineString = new InlineString();
            inlineString.AppendChild(t);
            cell.AppendChild(inlineString);
            row.AppendChild(cell);

            cell = new Cell();
            cell.DataType = CellValues.InlineString;
            t = new Text();
            t.Text = log.FollowedUp.Value.ToString();
            // Append Text to InlineString object
            inlineString = new InlineString();
            inlineString.AppendChild(t);
            cell.AppendChild(inlineString);
            row.AppendChild(cell);

            return row;

        }
    }
}