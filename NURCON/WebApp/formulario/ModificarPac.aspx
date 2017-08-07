<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarPac.aspx.cs" Inherits="WebApp.ModificarPac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table class="auto-style2">
        <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Buscar por ID"></asp:Label><asp:TextBox ID="txtBuscarID" runat="server"></asp:TextBox>
              &nbsp;&nbsp;&nbsp;<asp:Button ID="btnBuscarModificar" runat="server" Text="Buscar" Width="75px" Height="35px" OnClick="btnBuscarModificar_Click" />
&nbsp;<p>   <asp:Label ID="Label3" runat="server" Text="Nombre Completo"></asp:Label><asp:TextBox ID="txtNombreModificar" runat="server" style="height: 22px"></asp:TextBox>
                <p><asp:Label ID="Label5" runat="server" Text="Matricula"></asp:Label><asp:TextBox ID="txtMatModificar" runat="server"></asp:TextBox>
                      <asp:Label ID="Label2" runat="server" Text="Edad"></asp:Label><asp:TextBox ID="txtEdadModificar" runat="server"></asp:TextBox>
         
                 <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label><asp:DropDownList ID="cboSexoM" runat="server">
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                    </asp:DropDownList>
              
             &nbsp;
                    <asp:Button ID="btnGuardarModi" runat="server" Text="Guardar" OnClick="btnGuardarModi_Click" style="height: 26px" />
              
                    <asp:GridView ID="DGModificar" runat="server" Height="100px" Width="602px">
                    </asp:GridView>
              
             </td>
            </tr>

    </table>
    </div>
    </form>
</body>
</html>
