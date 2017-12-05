<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="agregarAula.aspx.cs" Inherits="agregarAula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <div class="row">
        <div class="col s12">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/mantenimientoAulas.aspx">Regresar</asp:LinkButton>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="SELECT * FROM [Edificio]"></asp:SqlDataSource>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <label for="DDLEdificio" class="center-align">Edificio</label>
            <asp:DropDownList ID="DDLEdificio" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Id_Edificio" OnSelectedIndexChanged="DDLEdificio_SelectedIndexChanged" CssClass="browser-default">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <label for="ddlNivel" class="center-align">Nivel</label>
            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" CssClass="browser-default">
                <asp:ListItem>-Seleccione-</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <label for="RadioButtonList1" class="center-align">Capacidad</label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" CssClass="browser-default">
                <asp:ListItem>Aula Grande</asp:ListItem>
                <asp:ListItem>Aula Pequena</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6">
            <label for="txtMin" class="center-align">Min</label>
            <asp:TextBox ID="txtMin" runat="server" Width="32px" Enabled="False"></asp:TextBox>
        </div>
        <div class="input-field col s6">
            <label for="txtMax" class="center-align">Max</label>
            <asp:TextBox ID="txtMax" runat="server" Width="33px" Enabled="False"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col s12">
            <label for="DropDownList3" class="center-align">Categoria</label>
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" CssClass="browser-default">
            <asp:ListItem>-Seleccione-</asp:ListItem>
                <asp:ListItem Value="Ventiladores">A</asp:ListItem>
                <asp:ListItem Value="Microfono, Ventiladores">AA</asp:ListItem>
                <asp:ListItem Value="Microfono, Ventiladores, Proyector">AAA</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <asp:Button ID="CrearBtn" runat="server" Text="Crear" CssClass="btn waves-effect waves-light center-align" OnClick="CrearBtn_Click"/>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6">
            <asp:Label ID="LblMessage" runat="server" ></asp:Label>
        </div>
    </div>
    

</asp:Content>
