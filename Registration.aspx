<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
	<td><a href="login.aspx" ><b style="color:white">LOGIN PAGE</b></a></td>
    <td><a href="register.aspx" ><b style="color:white">REGISTRATION</b></a></td>
	<td><a href="train.aspx" ><b style="color:white">TRAIN MASTER PAGE</b></a></td>
	<td><a href="admin.aspx" ><b style="color:white">ADMINISTRATION</b></a></td>

    </tr>
    </font>
    </table>

    <title>REGISTRATION</title>
    <%--<title runat="server" id="MyTitle"> REGISTRATION</title>--%>
    <table>
    <tr>
    <td>
    <img src="images/pic.jpg"  height="350" width="350">
    </td>
    <td><style type="text/css">
        .auto-style1 {
            width: 90%;
            border-style: solid;
            border-width: 3px;
        }
        .auto-style2 {
            text-align: right;
            width: 300px;
        }
        .auto-style4 {
            width: 200px;
            text-align: justify;
        }
        .auto-style5 {
            width: 390px;
        }
        .auto-style6 {
            color: #FF0000;
        }
        #Reset1 {
            width: 77px;
        }
            .auto-style7 {
                text-align: right;
                width: 300px;
                height: 42px;
            }
            .auto-style8 {
                width: 200px;
                text-align: justify;
                height: 42px;
            }
            .auto-style9 {
                width: 390px;
                height: 42px;
            }
    </style>       
</head>

<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Employee ID"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBoxID" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxID" ErrorMessage="ID must be unique" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Employee Name</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBoxUN" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="Employee Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBoxEM" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEM" CssClass="auto-style6" ErrorMessage="Email is Required"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEM" ErrorMessage="Enter valid Email ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBoxP" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxP" CssClass="auto-style6" ErrorMessage="Password should not contain any spaces"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Mobile Number</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBoxMN" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxMN" CssClass="auto-style6" ErrorMessage="Mobile number should only contain 0-9 numbers"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="82px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <input id="Reset1" type="reset" value="reset" /></td>
                <td class="auto-style5">&nbsp;</td>
                </td>
                </tr>
            </table>
            </tr>
        </table>    
    </div>
    </form>
</body>
</html>
