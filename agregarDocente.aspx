<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="agregarDocente.aspx.cs" Inherits="agregarDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
   <div class="row">
        <div class="col s12">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/mantenimientoDocentes.aspx">Regresar</asp:LinkButton>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="idDocenteTxt" class="center-align">Id Docente</label>
            <asp:TextBox ID="idDocenteTxt" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="idUserTxt" class="center-align">Id Usuario</label>
            <asp:TextBox ID="idUserTxt" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="nombreTxT" class="center-align">Nombre</label>
            <asp:TextBox ID="nombreTxT" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="apellidoTxt" class="center-align">Apellido</label>
            <asp:TextBox ID="apellidoTxt" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="emailTxt" class="center-align">Email</label>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
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

