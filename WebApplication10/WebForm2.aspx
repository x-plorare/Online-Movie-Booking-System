<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication10.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title></title>
    
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
            &nbsp;&nbsp;&nbsp;
    
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource1" DataTextField="Name" DataValueField="Value" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal">
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:Button ID="Button2" CssClass="waves-effect waves-light btn black" runat="server" OnClick="Button2_Click" Text="Show Seats" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Xmls/XMLFile1.xml"></asp:XmlDataSource>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource2" DataTextField="Name" DataValueField="Value" OnSelectedIndexChanged="CheckBoxList_SelectedIndexChanged" RepeatDirection="Horizontal" Visible="False">
                    </asp:CheckBoxList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList2" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource3" DataTextField="Name" DataValueField="Value" OnSelectedIndexChanged="CheckBoxList_SelectedIndexChanged" RepeatDirection="Horizontal" Visible="False">
                    </asp:CheckBoxList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList3" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource4" DataTextField="Name" DataValueField="Value" OnSelectedIndexChanged="CheckBoxList_SelectedIndexChanged" RepeatDirection="Horizontal" Visible="False">
                    </asp:CheckBoxList>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/Xmls/Seats1.xml"></asp:XmlDataSource>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList4" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource5" DataTextField="Name" DataValueField="Value" OnSelectedIndexChanged="CheckBoxList_SelectedIndexChanged" RepeatDirection="Horizontal" Visible="False">
                    </asp:CheckBoxList>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:XmlDataSource ID="XmlDataSource3" runat="server" DataFile="~/Xmls/Seats2.xml"></asp:XmlDataSource>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList5" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource6" DataTextField="Name" DataValueField="Value" OnSelectedIndexChanged="CheckBoxList_SelectedIndexChanged" RepeatDirection="Horizontal" Visible="False">
                    </asp:CheckBoxList>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:XmlDataSource ID="XmlDataSource4" runat="server" DataFile="~/Xmls/Seats3.xml"></asp:XmlDataSource>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" CssClass="waves-effect waves-light btn black" runat="server" Enabled="False" OnClick="Button1_Click" Text="Lock" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:XmlDataSource ID="XmlDataSource5" runat="server" DataFile="~/Xmls/Seats4.xml"></asp:XmlDataSource>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Book" CssClass="waves-effect waves-light btn black" runat="server" Text="Book" OnClick="Book_Click" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:XmlDataSource ID="XmlDataSource6" runat="server" DataFile="~/Xmls/Seats5.xml"></asp:XmlDataSource>
                </td>
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
