<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="agregarMateria.aspx.cs" Inherits="agregarMateria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <div class="row">
        <div class="col s12">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/mantenimientoMaterias.aspx">Regresar</asp:LinkButton>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <label for="ddlMateria" class="center-align">Materia</label>
            <asp:DropDownList ID="ddlMateria" runat="server" CssClass="browser-default" DataSourceID="SqlDataSource4" DataTextField="Nombre_Materia" DataValueField="Id_Materia"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="SELECT [Id_Materia], [Nombre_Materia] FROM [Materias]"></asp:SqlDataSource>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="cantAlumnosTxT" class="center-align">Cantidad de Alumnos</label>
            <asp:TextBox ID="cantAlumnosTxT" runat="server" TextMode="SingleLine"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="cantAlumnosTxT" ErrorMessage="Ingrese Valores Numericos menores a 119"
                            ForeColor="Red"
                            ValidationExpression="([1-9]?[0-9]?)|([1][0,1][0-9])|([1][2][0])">
            </asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <label for="ddlSeccion" class="center-align">Seccion</label>
            <asp:DropDownList ID="ddlSeccion" runat="server" DataSourceID="SqlDataSource1" DataTextField="NumeroSeccion" DataValueField="Id_Seccion" CssClass="browser-default"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="SELECT [Id_Seccion], [NumeroSeccion] FROM [Seccion]"></asp:SqlDataSource>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <label for="ddlDias" class="center-align">Dias</label>
            <asp:DropDownList ID="ddlDias" runat="server" DataSourceID="SqlDataSource3" DataTextField="Dias" DataValueField="Dias" CssClass="browser-default"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="Select DISTINCT Dias from [Horario]"></asp:SqlDataSource>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <label for="ddlHoraInicio" class="center-align">Hora Inicio</label>
            <asp:DropDownList ID="ddlHoraInicio" runat="server" DataSourceID="SqlDataSource2" DataTextField="Hora_Inicio" DataValueField="Hora_Inicio" CssClass="browser-default"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="SELECT DISTINCT [Hora_Inicio], [Hora_Fin] FROM [Horario]"></asp:SqlDataSource>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <label for="ddHoraFin" class="center-align">Hora Fin</label>
            <asp:DropDownList ID="ddHoraFin" runat="server" DataSourceID="SqlDataSource2" DataTextField="Hora_Fin" DataValueField="Hora_Fin" CssClass="browser-default"></asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <asp:Button ID="agregaBtn" runat="server" Text="Agregar" CssClass="btn waves-effect waves-light center-align" OnClick="agregaBtn_Click"/>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6">
            <asp:Label ID="mensajeLbl" runat="server" Text=""></asp:Label>
        </div>
    </div>
    </asp:Content>

