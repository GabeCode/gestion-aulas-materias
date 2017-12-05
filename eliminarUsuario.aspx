<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="eliminarUsuario.aspx.cs" Inherits="eliminarUsuario" %>

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
            <label for="idUserTxT" class="center-align">Ingresar id del usuario a eliminar</label>
            <asp:TextBox ID="idUserTxT" runat="server" TextMode="SingleLine"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s12">
            <asp:Button ID="eliminarBtn" runat="server" Text="Eliminar" CssClass="btn waves-effect waves-light center-align" OnClick="eliminarBtn_Click"/>
        </div>
    </div>
    <div class="row">  
        <div class="input-field col s6">
            <asp:Label ID="mensajeLbl" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

