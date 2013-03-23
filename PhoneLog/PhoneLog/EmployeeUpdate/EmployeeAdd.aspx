<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeAdd.aspx.cs" Inherits="PhoneLog.WebForm1" %>
<asp:Content ID="Userupdate" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
  <form action="" method="get">
    <p style="text-align:center">Name:<br />
      &nbsp;
      <asp:TextBox ID="name" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">Email:<br />
      &nbsp;
      <asp:TextBox ID="email" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">Password:<br />
      &nbsp;
      <asp:TextBox ID="password" runat="server"></asp:TextBox>
    </p>
    <p style="text-align:center">&nbsp;<input id="update" type="button" value="update" /></p>

  </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server"> </asp:Content>
