<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="PhoneLog.WebForm3" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <fieldset>
            <legend>Phone Logs By Date Range:</legend>
            Before: <asp:TextBox ID="beforeDate" runat="server"></asp:TextBox><br/>
            After: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </fieldset>
    </div>

    
</asp:Content>
