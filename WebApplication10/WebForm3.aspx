<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication10.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }   
    </style>
</head>
<body>
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
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1 no-pad-bot centered">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" CssClass="select-label" runat="server" Text="Theater"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label6" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label2" CssClass="select-label" runat="server" Text="Movie"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label7" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label3" CssClass="select-label" runat="server" Text="Show Date"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label8" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label4" CssClass="select-label" runat="server" Text="Start Time"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label9" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label5" CssClass="select-label" runat="server" Text="Price"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label10" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label11" CssClass="select-label" runat="server" Text="No Of Tickets"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label12" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label13" CssClass="select-label" Font-Bold="true" runat="server" Text="Total Price"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label14" CssClass="select-label" Font-Bold="true" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                
                
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td><asp:ImageButton ID="PayPalBtn" runat="server" ImageUrl="https://www.paypalobjects.com/en_GB/i/btn/btn_paynow_LG.gif" OnClick="PayPalBtn_Click" /></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                
            </table>

            
        </div>
    </form>
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
