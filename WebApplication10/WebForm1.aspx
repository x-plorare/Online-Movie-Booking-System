<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication10.WebForm1" %>

<%@ Register Assembly="Materialize" Namespace="Materialize.Web.UI.WebControls" TagPrefix="mrz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 35px;
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
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList1" CssClass="dropdown-button btn black white-text" runat="server" DataSourceID="SqlDataSource2" DataTextField="Location" DataValueField="Location" Style="margin-bottom: 0px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:online-ticket-databaseConnectionString %>" SelectCommand="SELECT * FROM [Theater_Info]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="margin-left: 40px">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="centered" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" ForeColor="Black" Font-Names="Roboto" RepeatDirection="Horizontal">
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
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
                    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
        </table>
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
            © 2014 Copyright Text
            <a class="grey-text text-lighten-4 right" href="#!">More Links</a>
            </div>
          </div>
        </footer>
    <script src="~/Scripts/materialize/materialize.js" type="text/javascript"></script>

</body>
</html>
