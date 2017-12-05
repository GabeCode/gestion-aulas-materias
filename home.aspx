<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageDocente.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript" src="scripts/jquery-3.2.1.min.js"></script>
    <script type="text/javascript" src="js/materialize.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoContent" Runat="Server">
    <div class="row">
        <div class="col s12">
            <div class="slider">
                <ul class="slides">
                    <li><img src="img/1.jpg"></li>
                    <li><img src="img/2.jpg"></li>
                    <li><img src="img/3.jpg"></li>
                    <li><img src="img/4.jpg"></li>
                </ul>
            </div>
        </div>
    </div>


    <!-- funcion Slide -->
    <script type="text/javascript">
        $(document).ready(function () {
            $('.slider').slider({ fullWidth: true });
        });
    </script>
</asp:Content>

