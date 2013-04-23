using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneLog
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.AllPhoneLogs.NavigateUrl = "~/ReportResultsPage.aspx?reportType=" + PhoneLog.Controllers.ReportTypes.types.allLogs.ToString();
            this.ThityDayLogs.NavigateUrl = "~/ReportResultsPage.aspx?reportType=" + PhoneLog.Controllers.ReportTypes.types.thirtyDays.ToString();
            this.NotFollowedUp.NavigateUrl = "~/ReportResultsPage.aspx?reportType=" + PhoneLog.Controllers.ReportTypes.types.notFollowedUp.ToString();

        }

        protected void btnRunReport_Click(object sender, EventArgs e)
        {
            DateTime beginDate = calBeginDate.SelectedDate;
            DateTime endDate = calEndDate.SelectedDate;

            if (endDate == null || beginDate == null)
            {
                lblMsg.Text = "Please select both an end date and a begin date.";
                return;
            }
            else
            {
                lblMsg.Text = "";

                long beginDateTicks = beginDate.Ticks;
                long endDateTicks = endDate.Ticks;

                Response.Redirect("~/ReportResultsPage.aspx?beginDate=" + beginDateTicks + "&endDate=" + endDateTicks, true);

            }
        }
    }
}