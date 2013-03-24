<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="employeeUpdate.aspx.cs" Inherits="PhoneLog.WebForm2" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="tokenField" runat="server" />
    <asp:Table ID="tblAllEmployees" runat="server" GridLines="Both"></asp:Table>
    
    <asp:TextBox ID="txtEmplName" runat="server"></asp:TextBox>&nbsp;&nbsp;
    <asp:TextBox ID="txtEmplEmailAddress" runat="server"></asp:TextBox>&nbsp;&nbsp;
    <asp:Button ID="btnAddEmployee" runat="server" Text="Add Employee" OnClick="btnAddEmployee_Click"/>
            
    <p><asp:Label ID="lblErrorMsgs" runat="server"></asp:Label></p>
            
</asp:Content>
