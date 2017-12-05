<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="mantenimientoAulaMateria.aspx.cs" Inherits="mantenimientoAulaMateria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id_Materia_Aula" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id_Materia_Aula" HeaderText="Id_Materia_Aula" ReadOnly="True" SortExpression="Id_Materia_Aula" />
            <asp:BoundField DataField="Nombre_Materia" HeaderText="Nombre_Materia" SortExpression="Nombre_Materia" />
            <asp:BoundField DataField="NumeroSeccion" HeaderText="NumeroSeccion" SortExpression="NumeroSeccion" />
            <asp:BoundField DataField="Cod_aula" HeaderText="Cod_aula" SortExpression="Cod_aula" />
            <asp:BoundField DataField="Dias" HeaderText="Dias" SortExpression="Dias" />
            <asp:BoundField DataField="Hora_Inicio" HeaderText="Hora_Inicio" SortExpression="Hora_Inicio" />
            <asp:BoundField DataField="Hora_Fin" HeaderText="Hora_Fin" SortExpression="Hora_Fin" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="sp_DatosAulaMateria" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    <ul>
        <li><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/agregarMateriaAula.aspx">Asignar Materia al Aula</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/actualizarAulaMateria.aspx">Cambiar de Aula la Materia</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/eliminarAulaMateria.aspx">Eliminar Materia del Aula</asp:LinkButton></li>
    </ul>
</asp:Content>

