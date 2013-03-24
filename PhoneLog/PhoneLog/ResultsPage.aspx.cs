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
            foreach(string key in this.Page.Request.Params.AllKeys)
            {
                Label lblKey = new Label();
                lblKey.Text = "Key: " + key + " | Value: " + this.Page.Request.Params.GetValues(key);

                this.confirmPanel.Controls.Add(lblKey);
            }
        }
    }
}