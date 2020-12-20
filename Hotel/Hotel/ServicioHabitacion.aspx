<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServicioHabitacion.aspx.cs" Inherits="Hotel.ServicioHabitacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#FFFBD6" />
                <DynamicSelectedStyle BackColor="#FFCC66" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/check_in.aspx" Text="Check-In" Value="Check-In"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Registrar.aspx" Text="Registrar Huesped" Value="Nuevo elemento"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/ServicioHabitacion.aspx" Text="Servicios Habitacion" Value="Nuevo elemento"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/check_out.aspx" Text="Check-Out" Value="Nuevo elemento"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Consultas.aspx" Text="Consultas" Value="Consultas"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#FFCC66" />
            </asp:Menu>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Servicios:"></asp:Label>
&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Lavado</asp:ListItem>
                <asp:ListItem>Bar</asp:ListItem>
                <asp:ListItem>Planchado</asp:ListItem>
                <asp:ListItem>Niñera</asp:ListItem>
            </asp:DropDownList>
            <br />
&nbsp;<asp:Label ID="Label3" runat="server" Text="Piso:"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
            </asp:DropDownList>
            <br />
&nbsp;<asp:Label ID="Label2" runat="server" Text="Numero De Habitacion:"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Importe Por Servicio:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label5" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cargar" />
        </div>
    </form>
</body>
</html>
