<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log-In.aspx.cs" Inherits="WebApplication10.User_Info.Log_In" %>

<%@ Register Assembly="Materialize" Namespace="Materialize.Web.UI.WebControls" TagPrefix="mrz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title></title>
</head>
<body>
    <nav>
        <div class="nav-wrapper">
            <a href="#!" class="brand-logo center">Logo</a>
            <ul class="left hide-on-med-and-down">
                <li><a href="sass.html">Sass</a></li>
                <li><a href="badges.html">Components</a></li>
                <li class="active"><a href="collapsible.html">JavaScript</a></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div>
            LOGIN DETAILS
        </div>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
        </asp:Login>
    </form>
    <footer class="page-footer">
          <div class="container">
            <div class="row">
              <div class="col l6 s12">
                <h5 class="white-text">Footer Content</h5>
                <p class="grey-text text-lighten-4">You can use rows and columns here to organize your footer content.</p>
              </div>
              <div class="col l4 offset-l2 s12">
                <h5 class="white-text">Links</h5>
                <ul>
                  <li><a class="grey-text text-lighten-3" href="#!">Link 1</a></li>
                  <li><a class="grey-text text-lighten-3" href="#!">Link 2</a></li>
                  <li><a class="grey-text text-lighten-3" href="#!">Link 3</a></li>
                  <li><a class="grey-text text-lighten-3" href="#!">Link 4</a></li>
                </ul>
              </div>
            </div>
          </div>
          <div class="footer-copyright">
            <div class="container">
            © 2014 Copyright Text
            <a class="grey-text text-lighten-4 right" href="#!">More Links</a>
            </div>
          </div>
        </footer>
    <script src="~/Scripts/materialize/materialize.js" type="text/javascript"></script>

</body>
</html>
