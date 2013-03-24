<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeeUpdate/Master.Master" AutoEventWireup="true" CodeBehind="EmployeeDelete.aspx.cs" Inherits="PhoneLog.WebForm1" %>
<asp:Content ID="Userupdate" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <form action="post" method="get">
    <p style="text-align:center">Name:<br />
      &nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="Id" DataValueField="Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString='<%$ ConnectionStrings:name="PhoneLogContext" connectionString="Data Source=(localdb)\Projects;Initial Catalog=PhoneLog;Integrated Security=True;MultipleActiveResultSets=True" %>' SelectCommand="SELECT [Id] FROM [CallType]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </p>
    
    <p style="text-align:center">&nbsp;<input id="deleteEmployee" type="button" value="Delete Login" /></p>

  </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server"> </asp:Content>
