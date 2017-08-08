<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarPac.aspx.cs" Inherits="WebApp.ModificarPac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 493px;
        }
        .auto-style2 {
            width: 232px;
        }
        .auto-style3 {
            width: 177px;
        }
        .auto-style4 {
            width: 270px;
        }
        .auto-style5 {
            width: 220px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                        <asp:Image ID="Image1" runat="server" Height="91px" ImageUrl="~/imagenes/Caduceus_icon-icons.com_75041.png" Width="76px" />
                    </td>
                <td class="auto-style4">
            <asp:Label ID="Label1" runat="server" Text="Buscar por ID" Font-Names="Berlin Sans FB"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtBuscarID" runat="server" Width="105px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                    <asp:Button ID="btnBuscarModificar" runat="server" Text="Buscar" Width="75px" Height="35px" OnClick="btnBuscarModificar_Click" Font-Names="Berlin Sans FB Demi" />
                </td>
                <td class="auto-style5">
                        <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Male_icon-icons.com_75053.png" Width="60px" />
                        <asp:Image ID="Image3" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Female_icon-icons.com_75052.png" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Label ID="Label3" runat="server" Text="Nombre Completo" Font-Names="Berlin Sans FB"></asp:Label></td>
                <td class="auto-style4"><asp:TextBox ID="txtNombreModificar" runat="server" Width="297px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><asp:Label ID="Label5" runat="server" Text="Matricula" Font-Names="Berlin Sans FB"></asp:Label>&nbsp;<asp:TextBox ID="txtMatModificar" runat="server" Width="91px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                      </td>
                <td class="auto-style4">
                      <asp:Label ID="Label2" runat="server" Text="Edad" Font-Names="Berlin Sans FB"></asp:Label>&nbsp; <asp:TextBox ID="txtEdadModificar" runat="server" Width="37px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
         
                 &nbsp;&nbsp;&nbsp;
         
                 <asp:Label ID="Label4" runat="server" Text="Sexo" Font-Names="Berlin Sans FB"></asp:Label>&nbsp; <asp:DropDownList ID="cboSexoM" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666">
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                    </asp:DropDownList>
              
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnGuardarModi" runat="server" Text="Guardar" OnClick="btnGuardarModi_Click" style="height: 26px" Font-Names="Berlin Sans FB Demi" />
              
                    </td>
            </tr>
        </table>
     <table class="auto-style2">
        <tr>
        <td class="auto-style1">
                <p style="height: 134px; width: 688px">&nbsp;
                                  
                    <asp:GridView ID="DGModificar" runat="server" Height="100px" Width="602px">
                    </asp:GridView>
              
                <p style="height: 134px; width: 688px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRegresar" runat="server" Font-Names="Berlin Sans FB Demi" OnClick="Button1_Click" Text="Regresar a Inicio" />
              
             </td>
            </tr>

    </table>
    </div>
    </form>
</body>
</html>
