<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Punto1.aspx.cs" Inherits="Trabajo_Practico_G1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            color: #CC0000;
        }
        .auto-style2 {
            font-size: large;
            color: #666666;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 320px">
          <p>  <u><strong><span class="auto-style2">DESTINO INICIO</span></strong></u> </p>
            <strong>PROVINCIA</strong>:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlPciaInicio" runat="server" Height="23px" Width="269px" AutoPostBack="True" OnSelectedIndexChanged="ProvinciaSeleccionada">
            </asp:DropDownList>
            <br />
            <br />
            <strong>LOCALIDAD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
            <asp:DropDownList ID="ddlLocalidadinicio" runat="server" Width="263px" OnSelectedIndexChanged="LocalidadSeleccionada" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
           <p> <u><strong><span class="auto-style1">DESTINO FINAL</span></strong></u>  </p> 

            <strong>PROVINCIA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlPciaDestino" runat="server" Height="16px" Width="263px" AutoPostBack="True" OnSelectedIndexChanged="PciaDestino">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMensajeError" runat="server"></asp:Label>
            <br />
            </strong>
            <br />
            <strong>LOCALIDAD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlLocalidaddestino" runat="server" Height="26px" Width="262px" AutoPostBack="True" OnSelectedIndexChanged="LocDestino">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            </strong></div>
    </form>
</body>
</html>
