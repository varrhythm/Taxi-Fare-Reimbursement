<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
table, th, td {
    border: 1px solid black;
}
table {
    border-collapse: collapse;
    width: 100%;
}

th {
    background-color: #4CAF50;
    color: white;
    height: 50px;
    text-align: center;
}
    </style>
    <title>Manage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
