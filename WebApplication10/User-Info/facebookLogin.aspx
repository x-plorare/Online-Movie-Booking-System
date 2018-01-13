<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="facebookLogin.aspx.cs" Inherits="WebApplication10.User_Info.facebookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.Net Facebook Integration</title>
    <script src="../scripts/jquery-1.8.0.min.js" type="text/javascript"></script>
    <script src="http://connect.facebook.net/en_US/all.js" type="text/javascript"></script>
    <script type="text/javascript">
        $("document").ready(function () {
            // Initialize the SDK upon load
            FB.init({
                appId: '938784612940252', // App ID
                channelUrl: 'localhost:4257/User-Info/facebookLogin.aspx', // Path to your Channel File
                scope: 'id,name,gender,user_birthday,email', // This to get the user details back from Facebook
                status: true, // check login status
                cookie: true, // enable cookies to allow the server to access the session
                xfbml: true  // parse XFBML
            });
            // listen for and handle auth.statusChange events
            FB.Event.subscribe('auth.statusChange', OnLogin);
        });

        // This method will be called after the user login into facebook.
        function OnLogin(response) {
            if (response.authResponse) {
                FB.api('/me?fields=id,name,gender,email,birthday', LoadValues);
            }
        }

        //This method will load the values to the labels
        function LoadValues(me) {
            if (me.name) {
                document.getElementById('displayname').innerHTML = me.name;
                document.getElementById('FBId').innerHTML = me.id;
                document.getElementById('DisplayEmail').innerHTML = me.email;
                document.getElementById('Gender').innerHTML = me.gender;
                document.getElementById('DOB').innerHTML = me.birthday;
                document.getElementById('auth-loggedin').style.display = 'block';
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div id="fb-root"></div>
            <!-- This initializes the FB controls-->
            <div class="fb-login-button" autologoutlink="true"
                scope="user_birthday,email">
                Login with Facebook
            </div>
            <!-- FB Login Button -->
            <!-- Details -->
            <div id="auth-status">
                <div id="auth-loggedin" style="display: none">
                    Hi, <span id="displayname" runat="server"></span>
                    <br />
                    Your Facebook ID : <span id="FBId" runat="server"></span>
                    <br />
                    Your Email : <span id="DisplayEmail" runat="server"></span>
                    <br />
                    Your Sex:, <span id="Gender" runat="server"></span>
                    <br />
                    Your Date of Birth :, <span id="DOB"></span>
                    <br />
                </div>
            </div>
            <%--<asp:HiddenField ID="displayname" runat="server" Value="" />
            <asp:HiddenField ID="FBId" runat="server" OnValueChanged="FBId_ValueChanged" />
            <asp:HiddenField ID="DisplayEmail" runat="server" OnValueChanged="DisplayEmail_ValueChanged" />--%>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log-In" />
        </div>
    </form>
</body>
</html>
