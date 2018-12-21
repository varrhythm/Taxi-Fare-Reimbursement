<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<html>

<head runat="server">
    <marquee > <b>TAXI FARE REIMBURSEMENT </b></marquee>
	<br/>
    <table><tr>
    <td>
    <img src="images/Gail.png" height="200" width="250"/>
    </td>
    <td>
    <img src="images/taxi.jpg" height="250" width="1100"/>
    </td>
    </tr>
    </table><br/>
    <table width="100%" height="8%" border="3" bgcolor="black">
    <font size="6">
    <tr align="center" font="7" >
	<%--<td><a href="login.aspx" ><b style="color:white">LOGIN PAGE</b></a></td>--%>
    <td><a href="register.aspx" ><b style="color:white">REGISTRATION</b></a></td>
	<td><a href="train.aspx" ><b style="color:white">TRAIN MASTER PAGE</b></a></td>
	<td><a href="Manage.aspx" ><b style="color:white">ADMINISTRATION</b></a></td>

    </tr>
    </font>
    </table>
    <title>Login</title>
</head>
<body>
    <table>
        <tr>
        <td>
    <form id="form1" runat="server">
    <div style="height: 260px; width: 508px">
        
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Employee ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPASS" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="67px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" Width="72px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Forget Password" Width="142px" />
        
    </div>
    </form>
            </td>
        <td>
        <img src="images/pic.jpg"  height="350" width="350">
        </td>
        <td><FONT size="3.5" color="blue" face="verdana"> <p align="justify">Enter your EMPLOYEE ID which is your user id and enter the password, if you do not have an account then please go to registration and create a new account.</p></FONT></td>
        </p></FONT>
        </td>
        </tr>
        </table>
</body>
</html>
