<%@ Page Title="" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="EmployeeAdd.aspx.cs" Inherits="PhoneLog.WebForm1" %>
<asp:Content ID="Userupdate" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    
    <p style="flex-item-align:center">
        <asp:CreateUserWizard ID="newUser" runat="server">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard>
    </p>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server"> </asp:Content>
