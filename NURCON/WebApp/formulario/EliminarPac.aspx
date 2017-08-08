<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarPac.aspx.cs" Inherits="WebApp.EliminarPac" %>

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
        .auto-style3 {
            width: 122px;
        }
        .auto-style4 {
            width: 255px;
        }
        .auto-style5 {
            width: 122px;
            height: 99px;
        }
        .auto-style6 {
            width: 255px;
            height: 99px;
        }
        .auto-style7 {
            height: 99px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="auto-style2">
        <tr>
        <td class="auto-style1">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image1" runat="server" Height="91px" ImageUrl="~/imagenes/Caduceus_icon-icons.com_75041.png" Width="76px" />
                    </td>
                    <td class="auto-style6">
            <asp:Label ID="Label1" runat="server" Text="Introducir Matricula" Font-Names="Berlin Sans FB"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtMatriculaEliminar" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
              &nbsp;&nbsp; <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="75px" OnClick="btnBuscar_Click" Height="35px" Font-Names="Berlin Sans FB Demi" />
                    </td>
                    <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Male_icon-icons.com_75053.png" Width="60px" />
                        <asp:Image ID="Image3" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Female_icon-icons.com_75052.png" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">   <asp:Label ID="Label3" runat="server" Text="Nombre Completo" Font-Names="Berlin Sans FB"></asp:Label></td>
                    <td class="auto-style4"><asp:TextBox ID="txtPacienteEliminar" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">  <asp:Label ID="Label2" runat="server" Text="Edad" Font-Names="Berlin Sans FB"></asp:Label>&nbsp;&nbsp; <asp:TextBox ID="txtEdadEliminar" runat="server" Width="58px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                 <asp:Label ID="Label4" runat="server" Text="Sexo" Font-Names="Berlin Sans FB"></asp:Label>&nbsp; <asp:DropDownList ID="cboSexoEliminar" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666">
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                    </asp:DropDownList>
                    
              
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Font-Names="Berlin Sans FB Demi" />
              
                    </td>
                </tr>
            </table>
              &nbsp;&nbsp;&nbsp;&nbsp;<p>  &nbsp;
                                  
                    <asp:GridView ID="GVEliminar" runat="server" Height="100px" Width="602px">
                    </asp:GridView>
              
             
            <p>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRegresar" runat="server" Font-Names="Berlin Sans FB Demi" OnClick="Button1_Click" Text="Regresar a Inicio" />
              
             
            </tr>

    </table>
    </div>
    </form>
</body>
</html>
