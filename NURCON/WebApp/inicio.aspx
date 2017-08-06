<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="WebApp.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 36px;
        }
        .auto-style2 {
            margin-right: 0px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
         <table style="width: 667px; height: 365px;">
            
             <tr>
                 <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="bienvenidos"></asp:Label>
                 </td>
                  <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="bienvenidos a nurcon"></asp:Label>
                 </td>
                       </tr>
             </tr>
             <tr>
                 <td>
                     <asp:Button ID="Button1" runat="server" Text="Nuevo Paciente / Control de diagnósticos" Width="248px" Height="87px" />
                
                      <asp:Button ID="Button2" runat="server" Text="Modificar paciente" Height="84px" Width="231px" OnClick="Button2_Click" />
                
                           <asp:Button ID="Button3" runat="server" Text="Eliminar paciente" Width="251px" Height="74px" />
                
                      <asp:Button ID="Button4" runat="server" Text="Telefonos de Emergencias" Height="75px" Width="229px" CssClass="auto-style2" />
                     
                      <br />
                     <br />
                     
                      <asp:Button ID="Button5" runat="server" Text="Salir" Height="32px" Width="106px" />
               </td>
               </tr>
             </table>
       

















    <div>
    
    </div>
    </form>
</body>
</html>
