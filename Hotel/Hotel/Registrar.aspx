<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Hotel.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
            text-align: left;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: left;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            text-align: right;
            width: 489px;
        }
        .auto-style5 {
            height: 23px;
            text-align: right;
            width: 489px;
        }
        .auto-style6 {
            text-align: right;
            width: 489px;
        }
        .auto-style7 {
            width: 489px;
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
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox3" runat="server" Width="231px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label2" runat="server" Text="Numero De Tarjeta"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="233px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label3" runat="server" Text="DNI"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox4" runat="server" Width="234px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style4"> 
                    <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
                    </td>
                    <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server" Width="234px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"> 
                    <asp:Label ID="Label5" runat="server" Text="Telefono"></asp:Label>
                    </td>
                    <td class="auto-style2">
                    <asp:TextBox ID="TextBox6" runat="server" Width="231px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                   <td style="text-align: left">
                       <asp:Button ID="Button1" runat="server" Text="Registrar" Width="94px" OnClick="Button1_Click" />
                       <asp:Label ID="Label6" runat="server"></asp:Label>
                    </td> 
                    

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
