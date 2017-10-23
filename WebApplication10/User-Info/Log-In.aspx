<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log-In.aspx.cs" Inherits="WebApplication10.User_Info.Log_In" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        LOGIN DETAILS
    </div>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
        </asp:Login>
    </form>
</body>
</html>