<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="mantenimientoUser.aspx.cs" Inherits="mantenimientoUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id_Usuario" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="Id_Usuario" HeaderText="Id_Usuario" ReadOnly="True" SortExpression="Id_Usuario" />
        <asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" ApplyFormatInEditMode="False" DataFormatString="*****" />
        <asp:BoundField DataField="nivel" HeaderText="nivel" SortExpression="nivel" />
    </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="SELECT * FROM [Usuarios]">
    </asp:SqlDataSource>
    <ul>
        <li><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/agregarUsuarios.aspx">Agregar Usuario</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/actualizarUsuario.aspx">Actualizar Usuario</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/eliminarUsuario.aspx">Eliminar Usuario</asp:LinkButton></li>
    </ul>
   
</asp:Content>

