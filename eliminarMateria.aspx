﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="eliminarMateria.aspx.cs" Inherits="eliminarMateria" %>

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
        <div class="col s12">
            <label for="ddlSeccion" class="center-align">Seccion</label>
            <asp:DropDownList ID="ddlSeccion" runat="server" DataSourceID="SqlDataSource1" DataTextField="NumeroSeccion" DataValueField="Id_Seccion" CssClass="browser-default"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="SELECT [Id_Seccion], [NumeroSeccion] FROM [Seccion]"></asp:SqlDataSource>
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

