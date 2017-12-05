<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAlumno.master" AutoEventWireup="true" CodeFile="listadoMaterias.aspx.cs" Inherits="listadoMaterias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <div class="row">
        <div class="col s12 m6 l3">
            <div class="row">
                <div class="input-field col s12">
                    <label for="txtBuscar">Buscar Materias</label>
                    <asp:TextBox ID="txtBuscar" runat="server" Width="186px" Height="18px" placeholder="Matematica"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:Button ID="btnBuscar" runat="server" CssClass="btn waves-effect waves-light" Text="Buscar" OnClick="btnBuscar_Click"/>
                </div>
            </div>
        </div>
        <div class="col s12 m6 l9" id="tablaContainer" runat="server">

        </div>
    </div>
</asp:Content>

