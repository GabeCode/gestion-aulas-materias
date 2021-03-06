﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class agregarAdmin : System.Web.UI.Page
{
    Usuarios us;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["nivel"] == null)
            Response.Redirect("inicio.aspx");

        if (int.Parse(Session["nivel"].ToString()) == 1)
            this.Page.MasterPageFile = "~/MasterPageAdmin.master";
        else
            Response.Redirect("inicio.aspx");
    }

    protected void agregaBtn_Click(object sender, EventArgs e)
    {
        us = new Usuarios();
        string idAd = idAdminTxt.Text;
        string idUser = idUserTxt.Text;
        string nombre = nombreTxT.Text;
        string apellido = apellidoTxt.Text;
        string email = emailTxt.Text;
        int estado = 1;
        string mensaje;
        bool respuesta;
        try
        {
            respuesta = us.agregarAdmin(idAd, idUser, nombre, apellido, email, estado);
            if (respuesta == true)
            {

                mensaje = "<div class='card-panel green lighten-2'>";
                mensaje += "<span class='white-text center-align'>Administrador Registrado Correctamente</span>";
                mensaje += "</div>";
                mensajeLbl.Text = mensaje;
                idUserTxt.Text = "";
                idAdminTxt.Text = "";
                nombreTxT.Text = "";
                apellidoTxt.Text = "";
                emailTxt.Text = "";
            }
            else
            {
                mensaje = "<div class='card-panel red lighten-2'>";
                mensaje += "<span class='white-text center-align'>Administrados No Registrado</span>";
                mensaje += "</div>";
                mensajeLbl.Text = mensaje;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}