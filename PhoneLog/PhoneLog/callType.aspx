<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="callType.aspx.cs" Inherits="PhoneLog.CallType" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="tokenField" runat="server" />
    <asp:Table ID="tblAllCalls" runat="server" GridLines="Both"></asp:Table>
    
    <asp:TextBox ID="callType" runat="server"></asp:TextBox>&nbsp;&nbsp;
    <asp:Button ID="btnAddType" runat="server" Text="Add Type" OnClick="btnAddType_Click"/>
            
    <p><asp:Label ID="lblErrorMsgs" runat="server"></asp:Label></p>
            
</asp:Content>
