<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CallTypeResultsPage.aspx.cs" Inherits="PhoneLog.CallTypeResultsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HyperLink ID="addNewCallType" runat="server" NavigateUrl="~/callType.aspx">Add New Call Type</asp:HyperLink>


    <asp:Table ID="callTypeResultsTable" runat="server" GridLines="Both" BorderWidth="1px" BorderStyle="Solid" BorderColor="Black"></asp:Table>

</asp:Content>


