<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="phoneLog.aspx.cs" Inherits="PhoneLog.phoneLog" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="tblPhone" runat="server">
        <asp:TableRow>
            <asp:TableCell>Date: </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox> <asp:Label ID="lblDateError" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Name of Caller: </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox> <asp:Label ID="lblNameError" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Phone #: </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Message: </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Message Recipient: </asp:TableCell>
            <asp:TableCell>
               <asp:DropDownList ID="employeeId" runat="server"></asp:DropDownList> <asp:Label ID="lblEmployeeError" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Call Type: </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="callType" runat="server"></asp:DropDownList> <asp:Label ID="lblCallTypeError" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Followed Up: </asp:TableCell>
            <asp:TableCell>
                <asp:CheckBox ID="chkFollowUp" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="phoneSubmit" runat="server" Text="Submit" OnClick="phoneSubmit_Click" />
    <!--<input id="phoneSubmit" type="button" value="     Submit     " />-->
</asp:Content>
