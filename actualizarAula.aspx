<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="actualizarAula.aspx.cs" Inherits="actualizarAula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <div class="row">
        <div class="col s6">
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
                    <label for="DDLNivel" class="center-align">Nivel</label>
                    <asp:DropDownList ID="DDLNivel" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLNivel_SelectedIndexChanged1" CssClass="browser-default">
                        <asp:ListItem>-selecione-</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="col s12">
                    <label for="DDLNew" class="center-align">Salon</label>
                    <asp:DropDownList ID="DDLNew" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLNew_SelectedIndexChanged" CssClass="browser-default">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="col s12">
                    <label for="RadioButtonList1" class="center-align">Capacidad</label>
                    <asp:RadioButtonList ID="RBLCapacidad" runat="server" OnSelectedIndexChanged="RBLCapacidad_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>Aula Grande</asp:ListItem>
                        <asp:ListItem Value="Aula Pequena">Aula Pequena</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s6">
                    <label for="txtMin" class="center-align">Min</label>
                    <asp:TextBox ID="TXTMin" runat="server" Width="39px" Enabled="False"></asp:TextBox>
                </div>
                <div class="input-field col s6">
                    <label for="txtMax" class="center-align">Max</label>
                    <asp:TextBox ID="TXTMax" runat="server" Width="39px" Enabled="False"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col s12">
                    <label for="DDLCategoria" class="center-align">Categoria</label>
                    <asp:DropDownList ID="DDLCategoria" runat="server" CssClass="browser-default">
                        <asp:ListItem>-Seleccione-</asp:ListItem>
                        <asp:ListItem Value="Ventiladores">A</asp:ListItem>
                        <asp:ListItem Value="Microfono, Ventiladores">AA</asp:ListItem>
                        <asp:ListItem Value="Microfono, Ventiladores, Proyector">AAA</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="btn waves-effect waves-light center-align" OnClick="btnActualizar_Click"/>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:Label ID="lblMensaje" runat="server" ></asp:Label>
                </div>
            </div>
        </div>
        <div class="col s6">
            <div class="row">
                <div class="input-field col s12">
                    <label for="txtMin" class="center-align">Aula</label>
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn waves-effect waves-light center-align" OnClick="btnBuscar_Click"/>
                </div>
            </div>
            <div class="row">
                <div class="col s12">
                    <asp:GridView ID="GVBuscar" runat="server">
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

