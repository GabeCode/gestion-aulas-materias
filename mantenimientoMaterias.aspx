<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="mantenimientoMaterias.aspx.cs" Inherits="mantenimientoMaterias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id_InscripcionMateria" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id_InscripcionMateria" HeaderText="Id_InscripcionMateria" ReadOnly="True" SortExpression="Id_InscripcionMateria" />
            <asp:BoundField DataField="Nombre_Materia" HeaderText="Nombre_Materia" SortExpression="Nombre_Materia" ReadOnly="True" />
            <asp:BoundField DataField="NumeroSeccion" HeaderText="NumeroSeccion" SortExpression="NumeroSeccion" ReadOnly="True"/>
            <asp:BoundField DataField="CantAlumnos" HeaderText="CantAlumnos" SortExpression="CantAlumnos"/>
            <asp:BoundField DataField="Dias" HeaderText="Dias" SortExpression="Dias" ReadOnly="True"/>
            <asp:BoundField DataField="Hora_Inicio" HeaderText="Hora_Inicio" SortExpression="Hora_Inicio" ReadOnly="True"/>
            <asp:BoundField DataField="Hora_Fin" HeaderText="Hora_Fin" SortExpression="Hora_Fin" ReadOnly="True"/>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" DeleteCommand="DELETE FROM [InscripcionMateria] WHERE [Id_InscripcionMateria] = @Id_InscripcionMateria" InsertCommand="INSERT INTO [InscripcionMateria] ([Id_InscripcionMateria], [Id_Materia], [Id_Seccion], [CantAlumnos], [Id_Horario]) VALUES (@Id_InscripcionMateria, @Id_Materia, @Id_Seccion, @CantAlumnos, @Id_Horario)" SelectCommand="sp_mostrarTablaMateria" UpdateCommand="UPDATE [InscripcionMateria] SET [CantAlumnos] = @CantAlumnos WHERE [Id_InscripcionMateria] = @Id_InscripcionMateria" SelectCommandType="StoredProcedure">
        <DeleteParameters>
            <asp:Parameter Name="Id_InscripcionMateria" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Id_InscripcionMateria" Type="String" />
            <asp:Parameter Name="Id_Materia" Type="String" />
            <asp:Parameter Name="Id_Seccion" Type="String" />
            <asp:Parameter Name="CantAlumnos" Type="Int32" />
            <asp:Parameter Name="Id_Horario" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CantAlumnos" Type="Int32" />
            <asp:Parameter Name="Id_InscripcionMateria" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <ul>
        <li><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/agregarMateria.aspx">Agregar Nueva Materia</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/editarMateria.aspx">Actualizar Materia</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/eliminarMateria.aspx">Eliminar Materia</asp:LinkButton></li>
    </ul>
        

    
</asp:Content>

