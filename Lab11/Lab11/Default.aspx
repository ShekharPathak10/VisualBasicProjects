<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 77%;
            height: 173px;
        }
        .auto-style3 {
            width: 669px;
        }
        .auto-style5 {
            font-size: xx-large;
            width: 577px;
            text-align: center;
        }
        .auto-style7 {
            width: 295px;
            text-align: right;
        }
        .auto-style8 {
            width: 295px;
        }
        .auto-style9 {
            width: 295px;
            height: 23px;
        }
        .auto-style10 {
            width: 669px;
            height: 23px;
        }
        .auto-style11 {
            width: 295px;
            text-align: right;
            height: 26px;
        }
        .auto-style12 {
            width: 669px;
            height: 26px;
        }
    </style>
</head>
<body style="width: 949px; height: 262px">
    <form id="form1" runat="server">
        <div class="auto-style5">
            Entry Form</div>
        <asp:Panel ID="FormPanel" runat="server" Height="355px" Width="932px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">Name:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NameTextBox" ErrorMessage="You must enter your name." ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Email Address:</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="You must enter an email." ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="You must enter a valid email." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">name@domain.com</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Phone Number:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="PhoneTextBox" ErrorMessage="You must enter a valid phone number." ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">123-456-7890</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Contact Method:</td>
                    <td class="auto-style3">
                        <asp:RadioButtonList ID="ContactMethodRadioButtonList" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Selected="True">Email</asp:ListItem>
                            <asp:ListItem>Phone</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Comments:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="CommentsTextBox" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="DuplicatePanel" runat="server" Height="16px" Visible="False" Width="923px">
            We&#39;re sorry, but only one submission is allowed.
        </asp:Panel>
    </form>
</body>
</html>
