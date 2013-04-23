<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="PhoneLog.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <fieldset>
            <legend>Reports</legend>
            <ul>
                <li><asp:HyperLink ID="AllPhoneLogs" runat="server">View All Phone Logs</asp:HyperLink></li>
                <li><asp:HyperLink ID="ThityDayLogs" runat="server">View Phone Logs from the past 30 days.</asp:HyperLink></li>
                <li><asp:HyperLink ID="NotFollowedUp" runat="server">View Phone Logs that have not been followed up.</asp:HyperLink></li>
            </ul>

            <div>
                <p>Get Phone Logs By Date:</p>
                <p>
                    <asp:Calendar ID="calBeginDate" runat="server" Caption="Begin Date"></asp:Calendar>
                    <asp:Calendar ID="calEndDate" runat="server" Caption="End Date"></asp:Calendar>
                </p>
                <asp:Button ID="btnRunReport" runat="server" Text="Generate Report" OnClick="btnRunReport_Click" /><br/>
                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            </div>
         </fieldset>
    </div>

    
</asp:Content>
