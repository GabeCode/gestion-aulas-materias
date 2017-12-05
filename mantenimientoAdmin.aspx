<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="mantenimientoAdmin.aspx.cs" Inherits="mantenimientoAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id_Administrador" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id_Administrador" HeaderText="Id_Administrador" ReadOnly="True" SortExpression="Id_Administrador" />
            <asp:BoundField DataField="Id_Usuario" HeaderText="Id_Usuario" SortExpression="Id_Usuario" ReadOnly="True" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" DeleteCommand="DELETE FROM [Administradores] WHERE [Id_Administrador] = @Id_Administrador" InsertCommand="INSERT INTO [Administradores] ([Id_Administrador], [Id_Usuario], [Nombre], [Apellido], [Email]) VALUES (@Id_Administrador, @Id_Usuario, @Nombre, @Apellido, @Email)" SelectCommand="SELECT [Id_Administrador], [Id_Usuario], [Nombre], [Apellido], [Email] FROM [Administradores]" UpdateCommand="UPDATE [Administradores] SET  [Nombre] = @Nombre, [Apellido] = @Apellido, [Email] = @Email WHERE [Id_Administrador] = @Id_Administrador">
        <DeleteParameters>
            <asp:Parameter Name="Id_Administrador" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Id_Administrador" Type="String" />
            <asp:Parameter Name="Id_Usuario" Type="String" />
            <asp:Parameter Name="Nombre" Type="String" />
            <asp:Parameter Name="Apellido" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Nombre" Type="String" />
            <asp:Parameter Name="Apellido" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Id_Administrador" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <ul>
        <li><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/agregarAdmin.aspx">Agregar Administradores</asp:LinkButton></li>
    </ul>
</asp:Content>

