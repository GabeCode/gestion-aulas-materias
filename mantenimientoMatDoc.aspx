<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="mantenimientoMatDoc.aspx.cs" Inherits="mantenimientoMatDoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IdDocenteMateria" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="IdDocenteMateria" HeaderText="IdDocenteMateria" ReadOnly="True" SortExpression="IdDocenteMateria" />
            <asp:BoundField DataField="Docente" HeaderText="Docente" SortExpression="Docente" />
            <asp:BoundField DataField="Nombre_Materia" HeaderText="Nombre_Materia" SortExpression="Nombre_Materia" />
            <asp:BoundField DataField="NumeroSeccion" HeaderText="NumeroSeccion" SortExpression="NumeroSeccion" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="sp_mostrarMateriaDocente" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    <ul>
        <li><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/agregarMateriaDocente.aspx">Asignar Materia a Docente</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/actualizarMateriaDocente.aspx">Actualizar Datos</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/eliminarMateriaDocente.aspx">Eliminar Datos</asp:LinkButton></li>
    </ul>
</asp:Content>

