<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Punto1.aspx.cs" Inherits="Trabajo_Practico_G1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 320px">
          <p>  <u>DESTINO INICIO</u> </p>
            <strong>PROVINCIA</strong>:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlPciaInicio" runat="server" Height="23px" Width="269px">
            </asp:DropDownList>
            <br />
            <br />
            <strong>LOCALIDAD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
            <asp:DropDownList ID="ddlLocalidadinicio" runat="server" Width="263px">
            </asp:DropDownList>
            <br />
            <br />
           <p> <u>DESTINO FINAL</u>  </p> 

            <strong>PROVINCIA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlPciaDestino" runat="server" Height="16px" Width="263px">
            </asp:DropDownList>
            <br />
            </strong>
            <br />
            <strong>LOCALIDAD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlLocalidaddestino" runat="server" Height="26px" Width="262px">
            </asp:DropDownList>
            </strong></div>
    </form>
</body>
</html>
