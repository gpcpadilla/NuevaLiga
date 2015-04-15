<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IFicha.aspx.cs" Inherits="NuevaLiga.Web.IFicha" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name Super Herue"></asp:Label>
        <asp:TextBox ID="tbname" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Alias"></asp:Label>
        <asp:TextBox ID="tbalias" runat="server"></asp:TextBox>
        <br />
       
        <asp:Label ID="Label3" runat="server" Text="Planeta"></asp:Label>
        <asp:TextBox ID="tbplaneta" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Genero"></asp:Label>
        <asp:TextBox ID="tbgenero" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Habilidad"></asp:Label>
        <asp:TextBox ID="tbhabilidad" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Debilidad"></asp:Label>
        <asp:TextBox ID="tbdebilidad" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Peso"></asp:Label>
        <asp:TextBox ID="tbpeso" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Tamaño"></asp:Label>
        <asp:TextBox ID="tbtamaño" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
    
    </div>
    </form>
</body>
</html>