﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
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
            this.Page.MasterPageFile = "~/MasterPageAlumno.master";
    }

    protected void agregaBtn_Click(object sender, EventArgs e)
    {
        us = new Usuarios();
        string idUser = idUserTxt.Text;
        string contra = contraseñaTxt.Text;
        string mensaje;
        int nivel = Convert.ToInt32(nivelTxt.Text);
        bool respuesta;
        try
        {
            respuesta = us.agregarUsuario(idUser, contra, nivel);
            if (respuesta == true)
            {

                mensaje = "<div class='card-panel green lighten-2'>";
                mensaje += "<span class='white-text center-align'>Usuario Registrado Correctamente</span>";
                mensaje += "</div>";
                mensajeLbl.Text = mensaje;
            }  
            else
            {
                mensaje = "<div class='card-panel red lighten-2'>";
                mensaje += "<span class='white-text center-align'>Usuario No Registrado</span>";
                mensaje += "</div>";
                mensajeLbl.Text = mensaje;
            }
            idUserTxt.Text = "";
            contraseñaTxt.Text = "";
            nivelTxt.Text = "";
        }
        catch (Exception)
        {
            throw;
        }
        

    }
}