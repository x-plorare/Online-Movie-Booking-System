<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Booked_Ticket_Details.aspx.cs" Inherits="WebApplication10.Booked_Ticket_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title>Ticket Details</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
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
        <a href="Webform3.aspx" class="breadcrumb">Payment Details</a> 
        <a href="Booked_Ticket_Details.aspx" class="breadcrumb">Ticket</a>        
      </div>
    </div>
  </nav>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" CssClass="select-label" runat="server" Text="Theater Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label9" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label2" CssClass="select-label" runat="server" Text="Movie Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label10" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label3" CssClass="select-label" runat="server" Text="Show Date"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label11" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label4" CssClass="select-label" runat="server" Text="Show Time"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label12" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label5" CssClass="select-label" runat="server" Text="No of Seats"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label13" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label6" CssClass="select-label" runat="server" Text="Seat No"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label14" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label7" CssClass="select-label" runat="server" Text="Total Price"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label15" CssClass="select-label" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label8" CssClass="select-label" runat="server" Text="Payment"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label16" CssClass="select-label" runat="server" Text="Label"></asp:Label>
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
                <td>
                    <asp:Button ID="Button1" CssClass="btn waves-effect waves-light" runat="server" OnClick="Button1_Click" Text="Confirm" />
                </td>
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
