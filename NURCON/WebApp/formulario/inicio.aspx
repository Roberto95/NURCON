<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="WebApp.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-right: 0px;
        }
        .auto-style3 {
            width: 499px;
        }
        .auto-style4 {
            width: 499px;
            height: 39px;
        }
        .auto-style5 {
            height: 39px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
         <table style="width: 667px; height: 365px;">
            
             <tr>
                 <td class="auto-style4">
                    
                 </td>
                 <td class="auto-style5">
                     <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Bienvenido" Font-Names="Microsoft Sans Serif"></asp:Label></h1>
                 </td>
                 <td class="auto-style5">

                 </td>

                  <tr>
                 <td class="auto-style3">
                    
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Image ID="Image2" runat="server" Height="58px" ImageUrl="~/imagenes/Doctor_Male_icon-icons.com_75051.png" Width="59px" ImageAlign="Right" />
                    
                 </td>
                  <td>
                      <h1 style="width: 239px">&nbsp;&nbsp; <asp:Label ID="Label2" runat="server" Text="Nursing Control" Font-Bold="False" Font-Italic="False" Font-Names="Berlin Sans FB" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" ForeColor="#339966"></asp:Label></h1>
                  </td>
                  <td>

                      <asp:Image ID="Image3" runat="server" Height="58px" ImageUrl="~/imagenes/Doctor_Female_icon-icons.com_75050.png" Width="59px" />

                  </td>
                  </tr>
             </tr>
             <tr>
                 <td class="auto-style3">
                     <br />
                     <br />
                     <asp:Button ID="Button1" runat="server" Text="Nuevo Paciente / Control de diagnósticos" Width="248px" Height="87px" OnClick="Button1_Click" Font-Names="Berlin Sans FB" />
                
                      <br />
                     <br />
                
                           <asp:Button ID="Button3" runat="server" Text="Eliminar paciente" Width="251px" Height="74px" OnClick="Button3_Click" Font-Names="Berlin Sans FB" />
                
                      <br />
                     <br />
                     
               </td>
                 <td>
                     

                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Image ID="Image1" runat="server" Height="152px" ImageUrl="~/imagenes/NC.jpg" Width="139px" />
                     

                 </td>
                 <td>

                      <asp:Button ID="Button2" runat="server" Text="Modificar paciente" Height="84px" Width="231px" OnClick="Button2_Click" Font-Names="Berlin Sans FB" />
                
                           <br />
                     <br />
                
                      <asp:Button ID="Button4" runat="server" Text="Telefonos de Emergencias" Height="75px" Width="229px" CssClass="auto-style2" OnClick="Button4_Click" Font-Names="Berlin Sans FB" />
                     
                 </td>

               </tr>
             </table>
       

















    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     
                      <asp:Button ID="Button5" runat="server" Text="Salir" Height="32px" Width="106px" Font-Names="Berlin Sans FB" />
    
    </div>
    </form>
</body>
</html>
