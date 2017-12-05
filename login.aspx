<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<!-- Compiled and minified CSS -->
<link href="css/page-center.css" type="text/css" rel="stylesheet" media="screen,projection"/>
<link href="css/style.min.css" type="text/css" rel="stylesheet" media="screen,projection"/>
<link rel="stylesheet" href="css/materialize.min.css"/>
<!-- Compiled and minified JavaScript -->
<link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    <title></title>
</head>
<body class="red lighten-1">
    <form id="form1" runat="server">
          <!-- Start Page Loading -->
          <div id="loader-wrapper">
              <div id="loader"></div>        
              <div class="loader-section section-left"></div>
              <div class="loader-section section-right"></div>
          </div>
          <!-- End Page Loading -->
        <div id="login-page" class="row">
            <div class="col s12 z-depth-4 card-panel">
              <div class="login-form">
                <div class="row">
                  <div class="input-field col s12 center">
                    <img src="img/brand.png" alt="" class="circle responsive-img valign profile-image-login"/>
                    <p class="center login-form-text">Sing in</p>
                  </div>
                </div>
                <div class="row margin">
                  <div class="input-field col s12">
                    <i class="mdi-social-person-outline prefix"></i>
                    <label for="txtuser" class="center-align">Usuario</label>
                    <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                  </div>
                </div>
                <div class="row margin">
                  <div class="input-field col s12">
                    <i class="mdi-action-lock-outline prefix"></i>
                    <label for="contraseñaTxt">Password</label>
                    <asp:TextBox ID="contraseñaTxt" runat="server" TextMode="Password"></asp:TextBox>
                  </div>
                </div>
                <div class="row">
                  <div class="input-field col s12">
                      <asp:Button ID="btnIniciar" runat="server" CssClass="btn waves-effect waves-light col s12" Text="Iniciar Sesión" OnClick="btnIniciar_Click1"/>
                  </div>
                </div>
              </div>
            </div>
          </div>
        
    </form>
    <script type="text/javascript" src="scripts/jquery-3.2.1.min.js"></script>
    <script type="text/javascript" src="js/materialize.min.js"></script>
    <script type="text/javascript">
 
        setTimeout(function () {
            document.getElementById('loader-wrapper').classList.add("hide");
        },3000);
    </script>
</body>
</html>
