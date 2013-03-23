<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Log.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Style/style.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell>Date/Time
                    </asp:TableCell>
                    <asp:TableCell>Name of caller
                    </asp:TableCell>
                    <asp:TableCell>Phone Number (of the person who calls)
                    </asp:TableCell>
                    <asp:TableCell>Message
                    </asp:TableCell>
                    <asp:TableCell>Who message is for
                    </asp:TableCell>
                    <asp:TableCell>Send email to
                    </asp:TableCell>
                    <asp:TableCell>Call Type
                    </asp:TableCell>
                    <asp:TableCell>Follow up on calls
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></asp:TableCell>
                    <asp:TableCell><select name="select1">
                    <option value="">&nbsp;</option>
                    <option value=""></option>
                    <option value=""></option>
                    <option value=""></option>
                    <option value=""></option>
                    <option value=""></option>
                    <option value=""></option>
                    <option value=""></option>
                    </select>
                    </asp:TableCell>
                    <asp:TableCell>
        <select name="select2">
      <option value="Business">Business</option>
      <option value="Codes">Codes</option>
      <option value="Community">Community Events</option>
      <option value="Crime"></option>
      <option value="Emergency">Emergency Assistance</option>
      <option value="Feed">Feed a Family</option>
      <option value="Gardens">Gardens</option>
      <option value="Graffiti">Graffiti</option>
      <option value="Healthy">Healthy Kids Initiative</option>
      <option value="Housing">Housing</option>
      <option value="Meeting">Meeting space rental</option>
      <option value="Minor">Minor Home Repair</option>
      <option value="Neighborhood">Neighborhood groups</option>
      <option value="Public">Public Works</option>
      <option value="Summer">Summer Youth Employment</option>
      <option value="Volunteer">Volunteer opportunities</option>
      <option value="Youth">Youth programs</option>
      <option value="Other">Other</option>
    </select>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem Value="Yes">Yes</asp:ListItem>
                            <asp:ListItem Value="No">No</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </p>
    </div>
    </form>
</body>
</html>
