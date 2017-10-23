<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication10.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
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
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show Seats" />
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
                    <asp:CheckBoxList ID="CheckBoxList4" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource5" DataTextField="Name" DataValueField="Value" OnSelectedIndexChanged="CheckBoxList_SelectedIndexChanged" RepeatDirection="Horizontal" Visible="False" >
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
                    <asp:Button ID="Button1" runat="server" Enabled="False" OnClick="Button1_Click" Text="Lock" Height="26px" Width="49px" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:XmlDataSource ID="XmlDataSource5" runat="server" DataFile="~/Xmls/Seats4.xml"></asp:XmlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Book" runat="server" Text="Book" OnClick="Book_Click" Width="47px" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:XmlDataSource ID="XmlDataSource6" runat="server" DataFile="~/Xmls/Seats5.xml"></asp:XmlDataSource>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
