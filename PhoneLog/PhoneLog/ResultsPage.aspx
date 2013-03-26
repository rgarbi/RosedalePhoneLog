<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultsPage.aspx.cs" Inherits="PhoneLog.ResultsPage" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p><asp:HyperLink ID="newPhoneMessage" runat="server" NavigateUrl="~/Default.aspx">New Phone Message</asp:HyperLink></p>

    Phone Message Recorded:<br/>
    <asp:Table ID="confirmTable" runat="server" GridLines="Both" BorderWidth="1px" BorderStyle="Solid" BorderColor="Black"></asp:Table>
</asp:Content>
