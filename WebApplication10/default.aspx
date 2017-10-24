<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication10.User_Info.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title></title>
</head>
<body>
    <nav>
        <div class="nav-wrapper">
            <a href="#!" class="brand-logo">Logo</a>
            <ul class="right hide-on-med-and-down">
                <li><a href="sass.html">Sass</a></li>
                <li><a href="badges.html">Components</a></li>
                <li><a href="collapsible.html">JavaScript</a></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <a id="gcb-header-logo" href="./">

                            <b>Let's Book</b>

                        </a>
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="Button5" runat="server" Text="Profile" OnClick="Button5_Click" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="Button2" OnClick="Signout_Click"
                            Text="Sign Out" runat="server" />


                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>

                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>

                    <td class="auto-style3">&nbsp;</td>
                </tr>
            </table>


        </div>

        <table id="table2" runat="server">
            <tr>
                <td class="auto-style15">Name:</td>
                <td id="Table1" class="auto-style16">
                    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Email:</td>
                <td id="table3" class="auto-style12">
                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Password:</td>
                <td class="auto-style7" id="Table4">
                    <asp:TextBox ID="Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Phone_No:</td>
                <td id="Table5" class="auto-style12">
                    <asp:TextBox ID="Phone_No" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10" id="Table6">&nbsp;</td>
                <td id="Table7" class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11" id="Table8">
                    <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
                </td>
                <td class="auto-style7" id="Table9">
                    <asp:Button ID="Button4" runat="server" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10" id="Table10">&nbsp;</td>
                <td id="Table11" class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10" id="Table12">&nbsp;</td>
                <td id="Table13" class="auto-style12">
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Book Movie" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10" id="Table14">&nbsp;</td>
                <td id="Table15" class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10" id="Table16">&nbsp;</td>
                <td id="Table17" class="auto-style12">
                    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Cancel Ticket" />
                </td>
            </tr>
        </table>
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
