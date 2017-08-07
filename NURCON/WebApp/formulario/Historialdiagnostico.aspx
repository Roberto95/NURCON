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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td class="auto-style1">
            <center>  
               <p>
<asp:Label ID="Label1" runat="server" Text="Especificar alumno (matrícula):"></asp:Label>
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              <asp:Button ID="Button1" runat="server" Text="Button" Width="79px" /> </p>
                <p>
                    &nbsp;</p></center>  

            </td>
            <tr>
            <td class="auto-style1">
                <center> <asp:Button ID="txtVisDiagMat" runat="server" Text="Buscar" Width="76px" OnClick="txtVisDiagMat_Click" />
            &nbsp;&nbsp; <br>
                    <asp:Button ID="btnVerDiag" runat="server" Text="Ver Todos" Width="84px" OnClick="btnVerDiag_Click" />
                <asp:GridView ID="dgvVisualizar" runat="server" Width="516px"></asp:GridView>
            </tr>
        </tr>
    </table>
        <div>
    
    </div>
    </form>
</body>
</html>
