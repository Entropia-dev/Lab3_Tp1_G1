<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Punto3a.aspx.cs" Inherits="Trabajo_Practico_G1.Punto3a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Listado de libros:<br />
            <asp:GridView ID="gvLibros" runat="server">
            </asp:GridView>
        </div>
    </form>
    <p>
      <a href="Punto3.aspx">Consultar otro tema </a>
</body>
</html>
