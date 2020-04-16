<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Punto2.aspx.cs" Inherits="Trabajo_Practico_G1.Punto2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id Producto:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlProducto" runat="server" Height="23px" Width="220px">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
        </div>
        <p>
            Id Categoria:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCategoria" runat="server" Height="25px" Width="220px">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" Width="180px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnQuitarfiltro" runat="server" Text="Quitar Filtro" Width="180px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="grdProductos" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
