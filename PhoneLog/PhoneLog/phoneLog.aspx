<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="phoneLog.aspx.cs" Inherits="PhoneLog.phoneLog" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="tblPhone" runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell>Date</asp:TableHeaderCell>
            <asp:TableHeaderCell>Name of Caller</asp:TableHeaderCell>
            <asp:TableHeaderCell>Phone</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Message</asp:TableCell>
            <asp:TableCell>Who For</asp:TableCell>
            <asp:TableCell>Call Type</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <!--<asp:TextBox ID="areaMessage" runat="server"></asp:TextBox>-->
                <textarea id="m" cols="20" rows="2"></textarea>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="employeeId" runat="server">
                </asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="callType" runat="server">
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Follow Up</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <!--<input id="radFollowYes" type="radio" name="update" value="Yes"/>
                <input id="radFollowNo" type="radio" name="update" value="No"/>-->
                <asp:CheckBox ID="chkFollowUp" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="phoneSubmit" runat="server" Text="Submit" OnClick="phoneSubmit_Click" />
    <!--<input id="phoneSubmit" type="button" value="     Submit     " />-->
</asp:Content>
