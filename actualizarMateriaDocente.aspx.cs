﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class actualizarMateriaDocente : System.Web.UI.Page
{
    Usuarios us;
    DataSet ds = new DataSet();
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
    protected void ActualizarBtn_Click(object sender, EventArgs e)
    {
        us = new Usuarios();
        string idMat = ddlMateria.SelectedValue.ToString();
        string idSec = ddlSeccion.SelectedValue.ToString();
        string idInscripcion, mensaje;
        bool respuesta;
        if (idDocTxT.Text != "" && idMateriaDocentetxt.Text != "")
        {
            try
            {
                int idIns = Convert.ToInt32(idMateriaDocentetxt.Text);
                string idDoc = idDocTxT.Text;
                ds = us.idInscripcionMateria(idMat, idSec);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    idInscripcion = ds.Tables[0].Rows[0]["Id_InscripcionMateria"].ToString();
                    respuesta = us.actualizarMateriaDocente(idIns, idDoc, idInscripcion);
                    if (respuesta == true)
                    {
                        mensaje = "<div class='card-panel green lighten-2'>";
                        mensaje += "<span class='white-text center-align'>Actualización se ha realizado Correctamente</span>";
                        mensaje += "</div>";
                        mensajeLbl.Text = mensaje;
                    }
                    else
                    {
                        mensaje = "<div class='card-panel red lighten-2'>";
                        mensaje += "<span class='white-text center-align'>Actualización no se ha realizado Correctamente</span>";
                        mensaje += "</div>";
                        mensajeLbl.Text = mensaje;
                    }
                }
                else
                {
                    mensaje = "<div class='card-panel red lighten-2'>";
                    mensaje += "<span class='white-text center-align'>No existe Materia con esta sección</span>";
                    mensaje += "</div>";
                    mensajeLbl.Text = mensaje;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        else
        {
            mensaje = "<div class='card-panel red lighten-2'>";
            mensaje += "<span class='white-text center-align'>Llenar todos los campos!</span>";
            mensaje += "</div>";
            mensajeLbl.Text = mensaje;
        }
    }
}