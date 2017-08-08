<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="WebApp.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 52px;
            margin-left: 40px;
            width: 164px;
        }
        .auto-style2 {
            height: 78px;
        }
        .auto-style3 {
            margin-right: 28px;
        }
        .auto-style6 {
        }
        .auto-style7 {
            width: 53px;
            height: 95px;
        }
        .auto-style8 {
            width: 354px;
            height: 95px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <table class="auto-style2">
        <tr>
        <td class="auto-style1">
            <table style="width: 168%; height: 203px; margin-right: 0px;">
                <tr>
                    <td class="auto-style7">&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Usuario" Font-Names="Berlin Sans FB"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtUser" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Contraseña" Font-Names="Berlin Sans FB"></asp:Label> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <br />
                        <br />
                        <asp:Image ID="Image5" runat="server" Height="99px" ImageUrl="~/imagenes/Doctor_Male_icon-icons.com_75051.png" Width="104px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Entrar" CssClass="auto-style3" Width="77px" OnClick="Button1_Click" Font-Names="Berlin Sans FB" />
              
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
            </table>
            &nbsp;&nbsp;<br />
              
             </td>
            </tr>

    </table>
    
    </div>
    </form>
</body>
</html>
