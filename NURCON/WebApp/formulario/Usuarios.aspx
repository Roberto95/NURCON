﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="WebApp.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 52px;
            margin-left: 40px;
        }
        .auto-style2 {
            height: 78px;
        }
        .auto-style3 {
            margin-right: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <table class="auto-style2">
        <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>&nbsp; <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Entrar" CssClass="auto-style3" Width="77px" OnClick="Button1_Click" />
              
             </td>
            </tr>

    </table>
    
    </div>
    </form>
</body>
</html>
