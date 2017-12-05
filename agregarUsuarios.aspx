<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="agregarUsuarios.aspx.cs" Inherits="agregarUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <div class="row">
        <div class="col s12">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/mantenimientoUser.aspx">Regresar</asp:LinkButton>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="idUserTxT" class="center-align">Id Usuario</label>
            <asp:TextBox ID="idUserTxT" runat="server" TextMode="SingleLine"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="contraseñaTxt" class="center-align">Contraseña</label>
            <asp:TextBox ID="contraseñaTxt" runat="server" TextMode="SingleLine"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <label for="nivelTxT" class="center-align">Nivel</label>
            <asp:TextBox ID="nivelTxT" runat="server" TextMode="SingleLine"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="nivelTxT" ErrorMessage="Ingrese Valores Numericos 1 o 2"
                            ForeColor="Red"
                            ValidationExpression="[1,2]">
            </asp:RegularExpressionValidator>
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

