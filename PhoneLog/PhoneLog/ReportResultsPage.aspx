<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportResultsPage.aspx.cs" Inherits="PhoneLog.ReportResultsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="btnExcel" runat="server" Text="Generate Excel" OnClick="btnExcel_Click" />
    <asp:Table ID="allPhoneLogsTable" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" GridLines="Both">
        <asp:TableRow runat="server" BorderStyle="Solid" BorderWidth="1px" TableSection="TableHeader">
            <asp:TableCell runat="server">ID</asp:TableCell>
            <asp:TableCell runat="server">Name</asp:TableCell>
            <asp:TableCell runat="server">Phone Number</asp:TableCell>
            <asp:TableCell runat="server">Call Type</asp:TableCell>
            <asp:TableCell runat="server">Message</asp:TableCell>
            <asp:TableCell runat="server">Intended Recipient</asp:TableCell>
            <asp:TableCell runat="server">Date</asp:TableCell>
            <asp:TableCell runat="server">Followed Up</asp:TableCell>
            <asp:TableCell runat="server">Update</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
   
</asp:Content>
