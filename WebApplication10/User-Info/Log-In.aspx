<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log-In.aspx.cs" Inherits="WebApplication10.User_Info.Log_In" %>

<%@ Register Assembly="Materialize" Namespace="Materialize.Web.UI.WebControls" TagPrefix="mrz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title>Log-In</title>
</head>
<body>
    <nav>
        <div class="nav-wrapper black">
            <a href="#!" class="brand-logo"><img src="../images/logo.jpg" width="64"  /></a>
            <ul class="right hide-on-med-and-down">
                <li><a href="Registration.aspx">Registration</a></li>
                <li><a href="http://localhost:58305/Home/Login">Admin Login</a></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <table class="pagination">
            <tr>
                <td>
                   <%-- <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Sign-Up with Facebook</asp:LinkButton>--%>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" DestinationPageUrl="~/default.aspx">
        </asp:Login>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Forget Password?</asp:LinkButton>
                </td>
            </tr>
        </table>
    </form>
    <footer class="page-footer black">
        <div class="container">
            <div class="row">
                <div class="col l6 s12">
                    <h5 class="white-text">Let's Book</h5>
                    <p class="grey-text text-lighten-4">Book Your Favorite Show & Watch with Your Loved One.</p>
                </div>
                <div class="col l4 offset-l2 s12">
                    <h5 class="white-text">Links</h5>
                    <ul>
                        <li><a class="grey-text text-lighten-3" href="FirstPage.aspx">First Page</a></li>
                        <li><a href="Log-In.aspx">Log-In</a></li>
                        <li><a class="grey-text text-lighten-3" href="Registration.aspx">Sign Up</a></li>
                        <li><a class="grey-text text-lighten-3" href="http://localhost:58305/Home/Login">Admin Login</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="footer-copyright">
            <div class="container">
                © 2017 Copyright Text
            <a class="grey-text text-lighten-4 right" href="#!">More Links</a>
            </div>
        </div>
    </footer>
    <script src="~/Scripts/materialize/materialize.js" type="text/javascript"></script>

</body>
</html>
