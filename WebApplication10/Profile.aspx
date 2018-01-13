<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebApplication10.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    <title>User Info</title>
    <style>
        form1{
            box-sizing:content-box;
            box-decoration-break:initial;
        }
       
    </style>
</head>
<body>
     <nav>
        <div class="nav-wrapper black">
            <a href="#!" class="brand-logo"><img src="images/logo.jpg" width="64" /></a>
            <ul class="right hide-on-med-and-down">
                <li><a href="default.aspx">Dashboard</a></li>
                <li><a href="Profile.aspx">Profile</a></li>
                <li><a href="Webform1.aspx">Book Ticket</a></li>
                <li><a href="Ticket_Cancellation.aspx">Cancel Ticket</a></li>
                <li><input type="button" runat="server" onserverclick="Signout_Click" value="Sign Out" /></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" cssClass="" runat="server" Height="50px" Width="125px" OnItemCommand="DetailsViewParentsDetails_ItemCommand" OnItemUpdating="DetailsView1_ItemUpdating" OnItemUpdated="DetailsView1_ItemUpdated" OnModeChanging="DetailsView1_ModeChanging" EnableViewState="False" >
        </asp:DetailsView>
        <table id="table" runat="server">
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
        </table>
    </div>
        <p>
&nbsp;&nbsp;&nbsp;</p>
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
                        <li><a href="Profile.aspx">Profile</a></li>
                        <li><a class="grey-text text-lighten-3" href="Booked_Tickets.aspx">Tickets</a></li>
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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.100.2/js/materialize.min.js" type="text/javascript"></script>
</body>
</html>
