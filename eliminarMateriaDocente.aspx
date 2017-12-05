<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="eliminarMateriaDocente.aspx.cs" Inherits="eliminarMateriaDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <div class="row">
        <div class="col s12">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/mantenimientoMatDoc.aspx">Regresar</asp:LinkButton>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="idMateriaDocentetxt" class="center-align">IdMateriaDocente a editar</label>
            <asp:TextBox ID="idMateriaDocentetxt" runat="server" TextMode="SingleLine"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <asp:Button ID="EliminarBtn" runat="server" Text="Eliminar" CssClass="btn waves-effect waves-light center-align" OnClick="EliminarBtn_Click"/>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6">
            <asp:Label ID="mensajeLbl" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

