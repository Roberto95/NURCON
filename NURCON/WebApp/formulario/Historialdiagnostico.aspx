<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Historialdiagnostico.aspx.cs" Inherits="WebApp.formulario.Historialdiagnostico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 478px;
        }
        .auto-style2 {
            width: 129px;
        }
        .auto-style3 {
            width: 223px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 62%;">
            <tr>
                <td class="auto-style2">
                    <asp:Image ID="Image1" runat="server" Height="69px" ImageUrl="~/imagenes/UTE_logo.png" Width="125px" />
                </td>
                <td class="auto-style3">
<asp:Label ID="Label1" runat="server" Text="Especificar alumno (matrícula):" Font-Names="Berlin Sans FB"></asp:Label>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:TextBox ID="txtMat" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                &nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="txtVisDiagMat" runat="server" Text="Buscar" Width="76px" OnClick="txtVisDiagMat_Click" Font-Names="Berlin Sans FB" />
                </td>
                <td>
                    <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Male_icon-icons.com_75053.png" Width="60px" />
                    <asp:Image ID="Image3" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Female_icon-icons.com_75052.png" />
                </td>
            </tr>
        </table>
    <table>
        <tr>
            <td class="auto-style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnVerDiag" runat="server" Text="Ver Todos" Width="84px" OnClick="btnVerDiag_Click" />

            </td>
            <tr>
            <td class="auto-style1">
                <center> &nbsp;&nbsp; <br>
                <asp:GridView ID="dgvVisualizar" runat="server" Width="516px"></asp:GridView>
                    <br />
                    <br />
                    <asp:Button ID="btnRegresar" runat="server" Font-Names="Berlin Sans FB Demi" OnClick="Button1_Click" Text="Regresar a Inicio" />
            </tr>
        </tr>
    </table>
        <div>
    
    </div>
    </form>
</body>
</html>
