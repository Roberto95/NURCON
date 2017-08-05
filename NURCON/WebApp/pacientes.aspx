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
    
        <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Nombre completo"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              <p>   <asp:Label ID="Label3" runat="server" Text="Matricula"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  <asp:Label ID="Label2" runat="server" Text="Edad"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                  <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
              </p>  
             </td>
            <tr>
                <td>
                    <asp:Panel ID="Panel1" runat="server" Height="186px">
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="TextBox6" runat="server" Height="58px" Width="177px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        
                        <br />
                        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox9" runat="server" Height="58px" Width="177px"></asp:TextBox>
                        <br />
                 </asp:Panel>

                </td>

            </tr>
    </tr>


                


     
        
        
        
        
        
      
    
    </div>
             
             <asp:Button ID="Button1" runat="server" Text="guardar" />
             
    </form>
</body>
</html>
