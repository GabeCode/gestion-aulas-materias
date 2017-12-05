<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="mantenimientoAulas.aspx.cs" Inherits="mantenimientoAulas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Cod_aula" DataSourceID="SqlDataSource1" AllowSorting="True">
        <Columns>
            <asp:BoundField DataField="Cod_aula" HeaderText="Cod_aula" ReadOnly="True" SortExpression="Cod_aula" />
            <asp:BoundField DataField="Edificio" HeaderText="Edificio" SortExpression="Edificio"  ReadOnly="True"/>
            <asp:BoundField DataField="Nivel" HeaderText="Nivel" SortExpression="Nivel" ReadOnly="True" />
            <asp:BoundField DataField="CantMax_Alumnos" HeaderText="CantMax_Alumnos" SortExpression="CantMax_Alumnos" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" DeleteCommand="DELETE FROM [Aulas] WHERE [Cod_aula] = @Cod_aula" InsertCommand="INSERT INTO [Aulas] ([Cod_aula], [Id_Nivel], [Id_Edificio], [CantMax_Alumnos], [Descripcion]) VALUES (@Cod_aula, @Id_Nivel, @Id_Edificio, @CantMax_Alumnos, @Descripcion)" SelectCommand="sp_mostrarTablaAulas" UpdateCommand="UPDATE [Aulas] SET [CantMax_Alumnos] = @CantMax_Alumnos, [Descripcion] = @Descripcion WHERE [Cod_aula] = @Cod_aula" SelectCommandType="StoredProcedure">
        <DeleteParameters>
            <asp:Parameter Name="Cod_aula" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Cod_aula" Type="String" />
            <asp:Parameter Name="Id_Nivel" Type="String" />
            <asp:Parameter Name="Id_Edificio" Type="String" />
            <asp:Parameter Name="CantMax_Alumnos" Type="Int32" />
            <asp:Parameter Name="Descripcion" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CantMax_Alumnos" Type="Int32" />
            <asp:Parameter Name="Descripcion" Type="String" />
            <asp:Parameter Name="Cod_aula" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <ul>
        <li><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/agregarAula.aspx">Agregar Nueva Aula</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/actualizarAula.aspx">Actualizar Aula</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/eliminarAula.aspx">Eliminar Aula</asp:LinkButton></li>
    </ul>
</asp:Content>

