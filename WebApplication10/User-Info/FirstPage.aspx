<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="WebApplication10.User_Info.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.css" rel="stylesheet" media="screen,projection" />
    <link type="text/css" href="~/content/materialize/css/footer.css" rel="stylesheet" media="screen,projection" />
    <title>First Page</title>
    <style>
        #card1, #card2 {
            padding-left: 350px;
            width: 1550px;
        }
    </style>
</head>
<body>
    <header>
        <nav>
            <div class="nav-wrapper black">
                <a href="#!" class="brand-logo left">
                    <img src="../images/logo.jpg" width="64" />
                </a>
                
                <ul class="right hide-on-med-and-down">
                    
                    <li><a href="Registration.aspx">Registration</a></li>
                    <li><a href="http://localhost:58305/Home/Login">Admin Login</a></li>
                </ul>
            </div>
        </nav>
    </header>
    <main>
        <form id="form1" runat="server">
            <div>
                <table class="pagination">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td id="card1">
                            <div class="row">
                                <div class="col s12 m7">
                                    <div class="card">
                                        <div class="card-image">
                                            <img src="https://i.pinimg.com/originals/5a/7f/b4/5a7fb4167a23d2b5de2a61fdb1a01425.jpg" width="350px" height="350px" />
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
                            </div>
                        </td>
                        <td id="card2">
                            <div class="row">
                                <div class="col s12 m7">
                                    <div class="card">
                                        <div class="card-image">
                                            <img src="https://i.pinimg.com/736x/7a/c3/16/7ac316e8d6224ccf78930dd5775c9698--app-ui-ui-ux.jpg" width="350px" height="350px" />
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
                            </div>
                        </td>
                    </tr>
                    <tr>
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
                    <h5 class="white-text">Let's Book</h5>
                    <p class="grey-text text-lighten-4">Book Your Favorite Show & Watch with Your Loved One.</p>
                </div>
                <div class="col l4 offset-l2 s12">
                    <h5 class="white-text">Links</h5>
                    <ul>
                        <li><a href="FirstPage.aspx">First Page</a></li>
                        <li><a class="grey-text text-lighten-3" href="Log-In.aspx">Log-In</a></li>
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
