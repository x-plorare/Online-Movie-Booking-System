<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Booked_Tickets.aspx.cs" Inherits="WebApplication10.Booked_Tickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <link type="text/css" href="content/materialize/css/footer.css" rel="stylesheet" media="screen,projection" />
    <title>Tickets</title>
</head>
<body>
    <nav>
        <div class="nav-wrapper black">
            <a href="#!" class="brand-logo"><img src="../images/logo.jpg" width="64"  /></a>
            <ul class="right hide-on-med-and-down">
                <li><a href="default.aspx">Dashboard</a></li>
                <li><a href="Profile.aspx">Profile</a></li>
                <li><a href="Webform1.aspx">Book Ticket</a></li>
                <li><a href="Ticket_Cancellation.aspx">Cancel Ticket</a></li>
                <li>
                    <input type="button" runat="server" onserverclick="Signout_Click" value="Sign Out" /></li>
            </ul>
        </div>
    </nav>
    <form id="form1" class="main" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

        </div>
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
                        <li><a href="Booked_Tickets.aspx">Tickets</a></li>
                        <li><a class="grey-text text-lighten-3" href="WebForm1.aspx">Book Ticket</a></li>
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
