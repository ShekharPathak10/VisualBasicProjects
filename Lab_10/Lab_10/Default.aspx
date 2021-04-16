<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 390px;
        }
        .auto-style2 {
            width: 209px;
        }
        .auto-style3 {
            width: 209px;
            height: 24px;
            text-align: right;
        }
        .auto-style4 {
            height: 24px;
        }
        .auto-style5 {
            width: 425px;
        }
        .auto-style6 {
            height: 24px;
            width: 425px;
        }
        .auto-style7 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style8 {
            width: 209px;
            text-align: right;
        }
        .auto-style9 {
            width: 209px;
            height: 29px;
        }
        .auto-style10 {
            width: 425px;
            height: 29px;
        }
        .auto-style11 {
            height: 29px;
        }
        .auto-style12 {
            width: 209px;
            height: 66px;
        }
        .auto-style13 {
            width: 425px;
            height: 66px;
        }
        .auto-style14 {
            height: 66px;
        }
    </style>
</head>
<body style="width: 898px; height: 405px">
    <form id="form1" runat="server">
        <div>
        </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style7" colspan="3">R &#39;n R Book Sales</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Quantity:&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style5">
                <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvQuantityTextBox" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="You must enter a quantity." ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rvQuantityTextBox" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="Your quantity must be between 1 and 200" ForeColor="Red" MaximumValue="200" MinimumValue="1">Between 1 and 200</asp:RangeValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Title:&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style6">
                <asp:TextBox ID="TitleTextBox" runat="server" Width="251px"></asp:TextBox>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style8">Price:&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style5">
                <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPriceTextBox" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="You must enter a price" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rvPriceTextBox" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="You must enter a numeric price" ForeColor="Red" MaximumValue="9999999999999999" MinimumValue="0" Type="Currency">x.xx</asp:RangeValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Extended Price:&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style5">
                <asp:TextBox ID="ExtendedPriceTextBox" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">15% Discount:&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style5">
                <asp:TextBox ID="DiscountTextBox" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Total Discount:"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Discounted Price:&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style5">
                <asp:TextBox ID="DiscountedPriceTextBox" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="DiscountTotalTextBox" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10">
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
            </td>
            <td class="auto-style11">
                <asp:Button ID="SummaryButton" runat="server" Text="Discount Summary" CausesValidation="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="ClearButton" runat="server" CausesValidation="False" Text="Clear" />
            </td>
            <td>
                <asp:HiddenField ID="DiscountTotalHiddenField" runat="server" Value="0" />
            </td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style13">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
            <td class="auto-style14">
                <asp:HyperLink ID="ComtactHyperLink" runat="server" NavigateUrl="~/ContactUs.aspx">ContactUs</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
