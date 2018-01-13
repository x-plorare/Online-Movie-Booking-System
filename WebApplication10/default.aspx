<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication10.User_Info.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="~/content/materialize/css/materialize.min.css" rel="stylesheet" media="screen,projection" />
    
    <title></title>
</head>
<body>
    <nav>
        <div class="nav-wrapper black">
            <a href="#!" class="brand-logo"><img src="../images/logo.jpg" width="64"  /></a>
            <ul class="right hide-on-med-and-down">
                <li><a href="default.aspx">Dashboard</a></li>
                <li><a href="Profile.aspx">Profile</a></li>
                <li><a href="Booked_Tickets.aspx">Tickets</a></li>
                <li><a href="Webform1.aspx">Book Ticket</a></li>
                <li><a href="Ticket_Cancellation.aspx">Cancel Ticket</a></li>
                <li>
                    <input type="button" runat="server" onserverclick="Signout_Click" value="Sign Out" /></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <%--<div>
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
            </tr>--%>
        <table>
            <tr>
                <td>
                    <div class="row">
                        <div class="col s12 m7">
                            <div class="card">
                                <div class="card-image">
                                    <img src="images/thor.jpg" width="50" height="600" />
                                    <span class="card-title">Thor: Ragnarok</span>
                                </div>
                                <div class="card-content">
                                    <p>
                                       Imprisoned on the other side of the universe, the mighty Thor finds himself in a deadly gladiatorial contest that pits him against the Hulk, his former ally and fellow Avenger. Thor's quest for survival leads him in a race against time to prevent the all-powerful Hela from destroying his home world and the Asgardian civilization. 
                                    </p>
                                </div>
                                <div class="card-action">
                                    <a href="WebForm1.aspx">Book Ticket</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </td>
                <td>
                    <div class="row">
                        <div class="col s12 m7">
                            <div class="card">
                                <div class="card-image">
                                    <img src="images/jl.jpg" width="50" height="600" />
                                    <span class="card-title">Justice Leauge</span>
                                </div>
                                <div class="card-content">
                                    <p>
                                        Fueled by his restored faith in humanity and inspired by Superman's selfless act, Bruce Wayne enlists newfound ally Diana Prince to face an even greater threat. Together, Batman and Wonder Woman work quickly to recruit a team to stand against this newly awakened enemy. Despite the formation of an unprecedented league of heroes -- Batman, Wonder Woman, Aquaman, Cyborg and the Flash -- it may be too late to save the planet from an assault of catastrophic proportions.
                                    </p>
                                </div>
                                <div class="card-action">
                                    <a href="WebForm1.aspx">Book Ticket</a>
                                </div>
                            </div>
                        </div>
                    </div>
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
                        <li><a href="default.aspx">Dashboard</a></li>
                        <li><a class="grey-text text-lighten-3" href="Profile.aspx">Profile</a></li>
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
    <script src="content/materialize/materialize.js" type="text/javascript"></script>
</body>
</html>
