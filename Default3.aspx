<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAlumno.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <div class="col s12">
        <label for="ddlSeccion" class="center-align">Id Seccion</label>
        <asp:DropDownList ID="ddlSeccion" runat="server" DataSourceID="SqlDataSource1" DataTextField="NumeroSeccion" DataValueField="NumeroSeccion" CssClass="browser-default"></asp:DropDownList>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProjectConnectionString %>" SelectCommand="SELECT [NumeroSeccion] FROM [Seccion]"></asp:SqlDataSource>
</asp:Content>

