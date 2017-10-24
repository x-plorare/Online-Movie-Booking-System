<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="WebApplication10.User_Info.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.css" rel="stylesheet" media="screen,projection" />
    <link type="text/css" href="~/content/materialize/css/footer.css" rel="stylesheet" media="screen,projection" />
    <title></title>

</head>
<body>
    <header>
        <nav>
            <div class="nav-wrapper black">
                <a href="#!" class="brand-logo">Logo</a>
                <ul class="right hide-on-med-and-down">
                    <li><a href="sass.html">Sass</a></li>
                    <li><a href="badges.html">Components</a></li>
                    <li><a href="collapsible.html">JavaScript</a></li>
                </ul>
            </div>
        </nav>
    </header>
    <main>
    <form id="form1" runat="server">
        <div>
<%--            <asp:LoginView ID="LoginView1" runat="server">
                <AnonymousTemplate>
                    Please Register Yourself 
                <a href="Registration.aspx">Click Here</a>
                    Or <a href="Log-In.aspx">Login Here</a>--%>
                    <table class="pagination">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td><div class="row">
        <div class="col s12 m7">
          <div class="card">
            <div class="card-image">
              <img src="https://cdn1.freshdesignweb.com/wp-content/uploads/2017/01/calm-breeze-login-screen.jpg" />
              <span class="card-title">Log In</span>
            </div>
            <div class="card-content">
              <p>If you have account already then choose this option.</p>
            </div>
            <div class="card-action black">
              <a href="Log-In.aspx">Sign In</a>
            </div>
          </div>
        </div>
      </div></td>
                            <td>
                                <%--<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>--%>&nbsp
                            </td>
                            <td><div class="row">
        <div class="col s12 m7">
          <div class="card">
            <div class="card-image">
              <img src="https://cdn1.freshdesignweb.com/wp-content/uploads/2013/03/Simple-Registration-Dark-Form.jpg" />
              <span class="card-title">Registration</span>
            </div>
            <div class="card-content">
              <p>If you are new to this website please register your self as a member.</p>
            </div>
            <div class="card-action black">
              <a href="Registration.aspx">Sign Up</a>
            </div>
          </div>
        </div>
      </div></td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
<%--                </AnonymousTemplate>

                <LoggedInTemplate>
                    <asp:LoginName ID="LoginName1" runat="server" />
                    <asp:LoginStatus ID="LoginStatus1" runat="server" />
                </LoggedInTemplate>
            </asp:LoginView>--%>
        </div>
    </form>
     </main>
    <footer class="page-footer black">
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
                © 2017 Copyright Text
            <a class="grey-text text-lighten-4 right" href="#!">More Links</a>
            </div>
        </div>
    </footer>
    <script src="~/Scripts/materialize/materialize.js" type="text/javascript"></script>
</body>
</html>
