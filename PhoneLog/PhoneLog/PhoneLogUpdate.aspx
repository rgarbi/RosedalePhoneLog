<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PhoneLogUpdate.aspx.cs" Inherits="PhoneLog.PhoneLogUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>ID:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPhoneLogId" runat="server" Enabled="False"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Caller Name:</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtCallerName" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Phone Number:</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Call Date:</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtCallDate" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Call Type:</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtCallType" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Message:</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtMessage" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Recipient:</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtRecipient" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Followed Up:</asp:TableCell>
            <asp:TableCell><asp:CheckBox ID="chkFollowedUp" runat="server"></asp:CheckBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="btnUpdate" runat="server" Text="Button" OnClick="btnUpdate_Click" />
</asp:Content>
