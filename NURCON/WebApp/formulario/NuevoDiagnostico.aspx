<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoDiagnostico.aspx.cs" Inherits="WebApp.formulario.NuevoDiagnostico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <tr>
        <td>
         
               <p>
<asp:Label ID="Label1" runat="server" Text="Especificar alumno (matrícula):"></asp:Label>
                   <asp:TextBox ID="txtMatriculaNR" runat="server"></asp:TextBox>
        </p>
                <p>
              </p>  
             </td>
            <tr>
                <td>
                    <asp:Panel ID="Panel1" runat="server" Height="186px">
                        <asp:Label ID="Label5" runat="server" Text="Diagnostico"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtTipoSangreND" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label6" runat="server" Text="Sintomas"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtSintomasND" runat="server" Height="51px" Width="160px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="Motivo de Visita"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="cboMotivoVisitaND" runat="server">
                            <asp:ListItem>Malestar</asp:ListItem>
                            <asp:ListItem>Molestia</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                       
                        
                        <br />
                        <asp:Label ID="Label8" runat="server" Text="Medicamento"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtMedicamentosNDiag" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label9" runat="server" Text="Notas"></asp:Label>
                        &nbsp;<asp:TextBox ID="txtNotasND" runat="server" Height="49px" Width="177px"></asp:TextBox>
                        <br />

                        <asp:Button ID="btnGuardarNDiag" runat="server" Text="Guardar" Height="32px" OnClick="btnGuardarNDiag_Click" Width="86px" />
                 </asp:Panel>

                </td>

            </tr>
    </tr>
    </div>
    </form>
</body>
</html>
