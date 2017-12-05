<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="eliminarAula.aspx.cs" Inherits="eliminarAula" %>

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
                    <asp:DropDownList ID="DDLEdificio" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Id_Edificio" CssClass="browser-default" OnSelectedIndexChanged="DDLEdificio_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="col s12">
                    <label for="DDLNivel" class="center-align">Nivel</label>
                    <asp:DropDownList ID="DDLNivel" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLNivel_SelectedIndexChanged" CssClass="browser-default">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn waves-effect waves-light center-align" OnClick="btnEliminar_Click" />
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
                <div class="col s12">
                    <asp:GridView ID="GVMostrar" runat="server">
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

