<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="phoneLog.aspx.cs" Inherits="PhoneLog.phoneLog" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Table ID="Table1" runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>Date</asp:TableHeaderCell>
            <asp:TableHeaderCell>Name of Caller</asp:TableHeaderCell>
            <asp:TableHeaderCell>Phone</asp:TableHeaderCell>
            <asp:TableHeaderCell>Message</asp:TableHeaderCell>
            <asp:TableHeaderCell>Who For</asp:TableHeaderCell>
            <asp:TableHeaderCell>Call Type</asp:TableHeaderCell>
            <asp:TableHeaderCell>Follow Up</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="areaMessage" runat="server"></asp:TextBox></asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="dropId" runat="server" DataSourceID="SqlDataSource2" DataTextField="Id" DataValueField="Id">
        </asp:DropDownList></asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell><asp:DropDownList ID="dropType" runat="server" DataSourceID="SqlDataSource2"  DataTextField="" DataValueField="">
        </asp:DropDownList></asp:TableCell>
            <asp:TableCell><input id="Radio1" type="radio" /></asp:TableCell>
        </asp:TableRow>




    </asp:Table>

    <input  id="phoneSubmit" type="button" value="     Submit     " />

</asp:Content>
