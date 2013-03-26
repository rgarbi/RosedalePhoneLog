<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeUpdateResultsPage.aspx.cs" Inherits="PhoneLog.EmployeeUpdateResultsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HyperLink ID="addNewEmployee" runat="server" NavigateUrl="~/employeeUpdate.aspx">Add New Employee</asp:HyperLink>


    <asp:Table ID="tblAllEmployees" runat="server" GridLines="Both" BorderStyle="Solid" BorderColor="Black" BorderWidth="1px"></asp:Table>

</asp:Content>
