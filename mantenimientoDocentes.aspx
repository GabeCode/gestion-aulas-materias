<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="mantenimientoDocentes.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">

    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id_Docente" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            <asp:BoundField DataField="Id_Docente" HeaderText="Id_Docente" ReadOnly="True" SortExpression="Id_Docente" />
            <asp:BoundField DataField="Id_Usuario" HeaderText="Id_Usuario" ReadOnly="True" SortExpression="Id_Usuario" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" DeleteCommand="UPDATE [Docente] SET [estado] = 2 WHERE [Id_Docente] = @Id_Docente" InsertCommand="INSERT INTO [Docente] ([Id_Docente], [Id_Usuario], [Nombre], [Apellido], [Email]) VALUES (@Id_Docente, @Id_Usuario, @Nombre, @Apellido, @Email)" SelectCommand="SELECT * FROM [Docente] WHERE [estado] = 1" UpdateCommand="UPDATE [Docente] SET [Nombre] = @Nombre, [Apellido] = @Apellido, [Email] = @Email WHERE [Id_Docente] = @Id_Docente">
        <DeleteParameters>
            <asp:Parameter Name="Id_Docente" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Id_Docente" Type="String" />
            <asp:Parameter Name="Id_Usuario" Type="String" />
            <asp:Parameter Name="Nombre" Type="String" />
            <asp:Parameter Name="Apellido" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Nombre" Type="String" />
            <asp:Parameter Name="Apellido" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Id_Docente" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/agregarDocente.aspx">Agregar Nuevo Docente</asp:LinkButton>
</asp:Content>

