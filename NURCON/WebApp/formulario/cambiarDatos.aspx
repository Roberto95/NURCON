<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cambiarDatos.aspx.cs" Inherits="WebApp.formulario.cambiarDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 128px;
        }
        .auto-style2 {
            width: 186px;
        }
        .auto-style3 {
            width: 409px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 86%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Font-Names="Berlin Sans FB Demi" ForeColor="#666666" Text="Se recomienda cambiar usuario y contraseña por motivos de seguridad"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/Doctor_Male_icon-icons.com_75051.png" />
                </td>
                <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Nuevo nombre de usuario" Font-Names="Berlin Sans FB"></asp:Label>
            &nbsp;<br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Nueva contraseña" Font-Names="Berlin Sans FB"></asp:Label>
            &nbsp;<br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Confirmar contraseña" Font-Names="Berlin Sans FB"></asp:Label>
            &nbsp;</td>
                <td class="auto-style3">&nbsp;<asp:TextBox ID="txtUser" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                    <br />
                    <br />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                    <br />
                    <br />
                <asp:TextBox ID="txtPassConf" runat="server" TextMode="Password" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" Font-Names="Berlin Sans FB" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    <table>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                &nbsp;</td>
            
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
