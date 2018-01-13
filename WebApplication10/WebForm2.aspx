<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication10.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title>Select Seats</title>
    
</head>
<body>
    <nav>
        <div class="nav-wrapper black">
            <a href="#!" class="brand-logo"><img src="../images/logo.jpg" width="64"  /></a>
            <ul class="right hide-on-med-and-down">
                <li><a href="default.aspx">Dashboard</a></li>
                <li><input type="button" runat="server" onserverclick="Signout_Click" value="Sign Out" /></li>
            </ul>
        </div>
    </nav>
    <nav>
    <div class="nav-wrapper black">
      <div class="col s12">
        <a href="Webform1.aspx" class="breadcrumb">Select Show</a>
        <a href="Webform2.aspx" class="breadcrumb">Select Seats</a>
      </div>
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
                    <h5 class="white-text">Let's Book</h5>
                    <p class="grey-text text-lighten-4">Book Your Favorite Show & Watch with Your Loved One.</p>
                </div>
                <div class="col l4 offset-l2 s12">
                    <h5 class="white-text">Links</h5>
                    <ul>
                        <li><a class="grey-text text-lighten-3" href="default.aspx">Dashboard</a></li>
                        <li><a class="grey-text text-lighten-3" href="Profile.aspx">Profile</a></li>
                        <li><a class="grey-text text-lighten-3" href="Booked_Tickets.aspx">Tickets</a></li>
                        <li><a href="WebForm1.aspx">Book Ticket</a></li>
                        <li><a class="grey-text text-lighten-3" href="Ticket_Cancellation.aspx">Cancel Ticket</a></li>
                        
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
