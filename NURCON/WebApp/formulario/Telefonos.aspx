<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Telefonos.aspx.cs" Inherits="WebApp.Telefonos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 264px;
        }
        .auto-style3 {
            width: 266px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                    <asp:Image ID="Image1" runat="server" ImageAlign="Right" ImageUrl="~/imagenes/medical-57_icon-icons.com_73916.png" />
                </td>
                <td class="auto-style2">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/Captura telefonos.PNG" />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image3" runat="server" ImageUrl="~/imagenes/Captura bomb.PNG" />
                    <asp:Image ID="Image4" runat="server" ImageUrl="~/imagenes/FireTruck_Left_Red_26346.png" />
                </td>
                <td class="auto-style2">
                    <asp:Image ID="Image5" runat="server" ImageUrl="~/imagenes/Captura.PNG" />
                    <asp:Image ID="Image6" runat="server" ImageUrl="~/imagenes/images.jpg" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRegresar" runat="server" Font-Names="Berlin Sans FB Demi" OnClick="Button1_Click" Text="Regresar a Inicio" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
