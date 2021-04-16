<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ContactUs.aspx.vb" Inherits="ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Contact Us<br />
            Email: <a href="mailto:spathak01@student.ysu.edu">spathak01@student.ysu.edu</a><br />
            <br />
            <asp:HyperLink ID="ReturnHyperLink" runat="server" NavigateUrl="~/Default.aspx">Return to Home</asp:HyperLink>
        </div>
    </form>
</body>
</html>
