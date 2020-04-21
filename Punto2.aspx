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
            <asp:DropDownList ID="ddlProducto" runat="server" Height="23px" Width="220px" AutoPostBack="True" OnSelectedIndexChanged="ddlProducto_SelectedIndexChanged">
                <asp:ListItem>--Selecione--</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
        </div>
        <p>
            Id Categoria:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCategoria" runat="server" Height="25px" Width="220px">
                <asp:ListItem>--Seleccione--</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCategoria" runat="server" OnTextChanged="txtCategoria_TextChanged"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" Width="180px" OnClick="btnFiltrar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnQuitarfiltro" runat="server" Text="Quitar Filtro" Width="180px" OnClick="btnQuitarfiltro_Click" />
        </p>
        <p>
            <asp:Label ID="LblMensaje" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:GridView ID="grdProductos" runat="server">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
