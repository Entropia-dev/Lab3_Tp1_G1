<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Punto3.aspx.cs" Inherits="Trabajo_Practico_G1.Punto3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            Seleccionar Tema:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlTemas" runat="server" Height="16px" Width="220px" >
            </asp:DropDownList>
            <br />
            <br />
               <%--<asp:LinkButton runat="server" id="btnLibros" href="punto3a.aspx" CssClass="btn btn-primary btn-sm" OnClick="btnLibros_Click1">Ver Libros</asp:LinkButton>--%>
            <asp:LinkButton runat="server" ID="btnLibro" OnClick="btnLibro_Click" >Ver libros</asp:LinkButton>
            <br />
        </div>
    </form>
</body>
</html>
