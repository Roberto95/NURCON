<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoDiagnostico.aspx.cs" Inherits="WebApp.formulario.NuevoDiagnostico" %>

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
            width: 281px;
        }
        .auto-style3 {
            width: 287px;
        }
        .auto-style4 {
            width: 97px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <tr>
        <td>
         
               <p>
                   <table style="width:100%;">
                       <tr>
                           <td class="auto-style1">
                    <asp:Image ID="Image1" runat="server" Height="69px" ImageUrl="~/imagenes/UTE_logo.png" Width="125px" />
                           </td>
                           <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label1" runat="server" Text="Especificar alumno (matrícula):" Font-Names="Berlin Sans FB Demi"></asp:Label>
                               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:TextBox ID="txtMatriculaNR" runat="server" Font-Names="Berlin Sans FB" Width="148px" ForeColor="#666666"></asp:TextBox>
                           </td>
                           <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Male_icon-icons.com_75053.png" Width="60px" />
                        <asp:Image ID="Image3" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Female_icon-icons.com_75052.png" Width="60px" />
                           </td>
                       </tr>
                       <tr>
                           <td class="auto-style1">
<asp:Label ID="Label10" runat="server" Text="Diagnostico" Font-Names="Berlin Sans FB Demi"></asp:Label>
                           </td>
                           <td class="auto-style2">&nbsp;</td>
                           <td>&nbsp;</td>
                       </tr>
                   </table>
                   <table style="width:100%;">
                       <tr>
                           <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text="Tipo de sangre" Font-Names="Berlin Sans FB"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtTipoSangreND" runat="server" Font-Names="Berlin Sans FB" style="margin-top: 0px" ForeColor="#666666"></asp:TextBox>
                           </td>
                           <td class="auto-style4">&nbsp;</td>
                           <td>
                        <asp:Label ID="Label6" runat="server" Text="Sintomas" Font-Names="Berlin Sans FB"></asp:Label>
                        &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtSintomasND" runat="server" Height="78px" Width="180px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                           </td>
                       </tr>
                       <tr>
                           <td class="auto-style3">
                        <asp:Label ID="Label7" runat="server" Text="Motivo de Visita" Font-Names="Berlin Sans FB"></asp:Label>
                        &nbsp;
                        <asp:DropDownList ID="cboMotivoVisitaND" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666">
                            <asp:ListItem>Malestar</asp:ListItem>
                            <asp:ListItem>Molestia</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                       
                        
                           </td>
                           <td class="auto-style4">
                        <asp:Image ID="Image4" runat="server" Height="91px" ImageUrl="~/imagenes/Caduceus_icon-icons.com_75041.png" Width="76px" />
                           </td>
                           <td>&nbsp;</td>
                       </tr>
                       <tr>
                           <td class="auto-style3">
                        <asp:Label ID="Label8" runat="server" Text="Medicamento" Font-Names="Berlin Sans FB"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtMedicamentosNDiag" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                           </td>
                           <td class="auto-style4">&nbsp;</td>
                           <td>
                        <asp:Label ID="Label9" runat="server" Text="Notas" Font-Names="Berlin Sans FB"></asp:Label>
                               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNotasND" runat="server" Height="65px" Width="197px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                           </td>
                       </tr>
                   </table>
        </p>
             </td>
            <tr>
                <td>
                    <asp:Panel ID="Panel1" runat="server" Height="67px" Width="686px">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                        <asp:Button ID="btnGuardarNDiag" runat="server" Text="Guardar" Height="32px" OnClick="btnGuardarNDiag_Click" Width="86px" Font-Names="Berlin Sans FB Demi" />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
                 </asp:Panel>

                </td>

            </tr>
    </tr>
    </div>
    </form>
</body>
</html>
