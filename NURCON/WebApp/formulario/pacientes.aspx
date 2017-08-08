<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pacientes.aspx.cs" Inherits="WebApp.pacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   
             <div>
    
        
        <td>
            <asp:Label ID="Label1" runat="server" Text="Nombre completo"></asp:Label><asp:TextBox ID="txtPaciente" runat="server" Width="224px"></asp:TextBox>
              <p>   <asp:Label ID="Label3" runat="server" Text="Matricula"></asp:Label><asp:TextBox ID="txtMatricula" runat="server" Width="158px"></asp:TextBox>
                  <asp:Label ID="Label2" runat="server" Text="Edad"></asp:Label><asp:TextBox ID="txtEdad" runat="server" Width="77px"></asp:TextBox>
                  <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label><asp:DropDownList ID="cboSexo" runat="server">
                      <asp:ListItem>M</asp:ListItem>
                      <asp:ListItem>F</asp:ListItem>
                      <asp:ListItem></asp:ListItem>
                  </asp:DropDownList>
                  
              </p>  
             </td>
            
                
                    <asp:Panel ID="Panel1" runat="server" Height="186px">
                        <asp:Label ID="Label5" runat="server" Text="Diagnostico"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtTipo_sangre" runat="server" Height="16px" Width="178px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label6" runat="server" Text="Sintomas"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtSintomas" runat="server" Height="25px" Width="167px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="Motivo de Visita"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="cboMotivoVisita" runat="server" Width="104px">
                            <asp:ListItem>Accidente</asp:ListItem>
                            <asp:ListItem>Malestar</asp:ListItem>
                        </asp:DropDownList>
                       
                        
                        <br />
                        <asp:Label ID="Label8" runat="server" Text="Medicamento"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtMedicamento" runat="server" Height="22px" Width="159px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label9" runat="server" Text="Notas"></asp:Label>
                        &nbsp;<asp:TextBox ID="txtNotas" runat="server" Height="26px" Width="197px"></asp:TextBox>
                        <br />
                 </asp:Panel>

                

       


    </div>
             
             <asp:Button ID="btnGuardar" runat="server" Text="guardar" Height="40px" Width="157px" OnClick="btnGuardar_Click" />
             
    </form>
</body>
</html>
