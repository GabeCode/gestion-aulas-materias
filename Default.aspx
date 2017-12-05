<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageDocente.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <div class="row">
        <div class="input-field col s12">
            <label for="idUserTxt" class="center-align">Usuario</label>
            <asp:TextBox ID="idUserTxt" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="contraseñaTxt" class="center-align">Contraseña</label>
            <asp:TextBox ID="contraseñaTxt" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="nivelTxt" class="center-align">Nivel</label>
            <asp:TextBox ID="nivelTxt" runat="server"></asp:TextBox>
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

