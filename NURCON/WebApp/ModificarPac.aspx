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
            <asp:Label ID="Label1" runat="server" Text="Buscar por ID"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Buscar" Width="75px" Height="35px" />
&nbsp;<p>   <asp:Label ID="Label3" runat="server" Text="Nombre Completo"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <p><asp:Label ID="Label5" runat="server" Text="Matricula"></asp:Label><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                      <asp:Label ID="Label2" runat="server" Text="Edad"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
         
                 <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
              
             &nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Guardar" />
              
                    <asp:GridView ID="GridView1" runat="server" Height="100px" Width="602px">
                    </asp:GridView>
              
             </td>
            </tr>

    </table>
    </div>
    </form>
</body>
</html>
