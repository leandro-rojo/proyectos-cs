<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="check_in.aspx.cs" Inherits="Hotel.check_in" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Check-In</title>
    <style type="text/css">
        .auto-style1 {
            width: 337px;
        }
    </style>
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
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1"><asp:Label ID="Label1" runat="server" Text="Fecha de Entrada: "></asp:Label></td>
                    <td><asp:Label ID="Label2" runat="server" Text="Fecha de Salida: "></asp:Label></td>
                </tr>
                <tr>
                    <td class="auto-style1"><asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar></td>
                    <td><asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar></td>
                </tr>
            </table>
            <asp:Label ID="Label3" runat="server" Text="Tipo de Habitacion:"></asp:Label>
            <br />
            <asp:DropDownList ID="Ddl1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Lbl_4" runat="server" Text="Habitaciones Disponibles:" Visible="False"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RBLst" runat="server" AutoPostBack="True" >
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="DNI:"></asp:Label>
            <br />
            <asp:TextBox ID="TxtBox_1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server"></asp:Label>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registrar.aspx" Visible="False">Registrar Huesped</asp:HyperLink>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
