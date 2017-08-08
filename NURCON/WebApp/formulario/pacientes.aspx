<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pacientes.aspx.cs" Inherits="WebApp.pacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
        .auto-style2 {
            height: 22px;
            width: 116px;
        }
        .auto-style3 {
            width: 116px;
        }
        .auto-style4 {
            height: 22px;
            width: 572px;
        }
        .auto-style5 {
            width: 572px;
        }
        .auto-style6 {
            width: 282px;
        }
        .auto-style7 {
            height: 22px;
            width: 201px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   
             <p>
                 <br />
                 <table style="width:100%;">
                     <tr>
                         <td class="auto-style2">
                    <asp:Image ID="Image1" runat="server" Height="69px" ImageUrl="~/imagenes/UTE_logo.png" Width="125px" />
                           </td>
                         <td class="auto-style4">
            <asp:Label ID="Label1" runat="server" Text="Nombre completo" Font-Names="Berlin Sans FB"></asp:Label>&nbsp;<asp:TextBox ID="txtPaciente" runat="server" Width="354px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                             <br />
                             <asp:Label ID="Label3" runat="server" Text="Matricula" Font-Names="Berlin Sans FB"></asp:Label>&nbsp;<asp:TextBox ID="txtMatricula" runat="server" Width="158px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                  &nbsp;&nbsp;
                  <asp:Label ID="Label2" runat="server" Text="Edad" Font-Names="Berlin Sans FB"></asp:Label>&nbsp;<asp:TextBox ID="txtEdad" runat="server" Width="77px" Font-Names="Berlin Sans FB" ForeColor="#666666" Height="22px"></asp:TextBox>
                  &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Label ID="Label4" runat="server" Text="Sexo" Font-Names="Berlin Sans FB"></asp:Label>&nbsp;<asp:DropDownList ID="cboSexo" runat="server" Font-Names="Berlin Sans FB" ForeColor="#666666">
                      <asp:ListItem>M</asp:ListItem>
                      <asp:ListItem>F</asp:ListItem>
                      <asp:ListItem></asp:ListItem>
                  </asp:DropDownList>
                  
                         </td>
                         <td class="auto-style1">
                        <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Male_icon-icons.com_75053.png" Width="60px" />
                        <asp:Image ID="Image3" runat="server" Height="60px" ImageUrl="~/imagenes/Patient_Female_icon-icons.com_75052.png" Width="60px" />
                           </td>
                     </tr>
                     <tr>
                         <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text="Diagnostico" Font-Names="Berlin Sans FB Demi"></asp:Label>
                         </td>
                         <td class="auto-style5">&nbsp;</td>
                         <td>&nbsp;</td>
                     </tr>
                 </table>
             </p>
   
             <div>
    
        
        <td>
                   <table style="width:100%;">
                       <tr>
                           <td class="auto-style6">
                        <asp:Label ID="Label10" runat="server" Text="Tipo de sangre" Font-Names="Berlin Sans FB"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtTipo_sangre" runat="server" Height="16px" Width="143px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                           </td>
                           <td class="auto-style7">&nbsp;</td>
                           <td>
                        <asp:Label ID="Label11" runat="server" Text="Sintomas" Font-Names="Berlin Sans FB"></asp:Label>
                        &nbsp;<br />
                        <asp:TextBox ID="txtSintomas" runat="server" Height="74px" Width="171px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           </td>
                       </tr>
                       <tr>
                           <td class="auto-style6">
                        <asp:Label ID="Label12" runat="server" Text="Motivo de Visita" Font-Names="Berlin Sans FB"></asp:Label>
                        &nbsp;
                        <asp:DropDownList ID="cboMotivoVisita" runat="server" Width="104px" Font-Names="Berlin Sans FB" ForeColor="#666666">
                            <asp:ListItem>Accidente</asp:ListItem>
                            <asp:ListItem>Malestar</asp:ListItem>
                        </asp:DropDownList>
                       
                        
                           </td>
                           <td class="auto-style7">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Image ID="Image4" runat="server" Height="91px" ImageUrl="~/imagenes/Caduceus_icon-icons.com_75041.png" Width="76px" />
                           </td>
                           <td>&nbsp;</td>
                       </tr>
                       <tr>
                           <td class="auto-style6">
                        <asp:Label ID="Label13" runat="server" Text="Medicamento" Font-Names="Berlin Sans FB"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtMedicamento" runat="server" Height="22px" Width="159px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                           </td>
                           <td class="auto-style7">&nbsp;</td>
                           <td>
                        <asp:Label ID="Label14" runat="server" Text="Notas" Font-Names="Berlin Sans FB"></asp:Label>
                               <br />
                               <asp:TextBox ID="txtNotas" runat="server" Height="74px" Width="209px" Font-Names="Berlin Sans FB" ForeColor="#666666"></asp:TextBox>
                               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                           </td>
                       </tr>
                   </table>

                

       


    </div>
             
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
             <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="40px" Width="157px" OnClick="btnGuardar_Click" Font-Names="Berlin Sans FB Demi" />
             
    </form>
</body>
</html>
