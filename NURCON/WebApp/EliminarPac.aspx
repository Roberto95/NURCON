﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarPac.aspx.cs" Inherits="WebApp.EliminarPac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 119px;
            width: 580px;
        }
        .auto-style2 {
            height: 135px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="auto-style2">
        <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Introducir Matricula"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Buscar" Width="75px" />
&nbsp;<p>   <asp:Label ID="Label3" runat="server" Text="Nombre Completo"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <p>  <asp:Label ID="Label2" runat="server" Text="Edad"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                 <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
              
             &nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Eliminar" />
              
                    <asp:GridView ID="GridView1" runat="server" Height="100px" Width="602px">
                    </asp:GridView>
              
             </td>
            </tr>

    </table>
    </div>
    </form>
</body>
</html>
