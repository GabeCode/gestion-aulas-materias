using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class eliminarAulaMateria : System.Web.UI.Page
{
    Usuarios us;
    DataSet ds = new DataSet();
    DataSet capturaId = new DataSet();
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

    protected void eliminarBtn_Click(object sender, EventArgs e)
    {
        us = new Usuarios();
        string idAulaMateria, idInscripcion, mensaje;
        string materia = ddlMateria.SelectedValue.ToString();
        string seccion = ddlSeccion.SelectedValue.ToString();
        bool respuesta;
        try
        {
            ds = us.idInscripcionMateria(materia, seccion);
            if (ds.Tables[0].Rows.Count != 0)
            {
                idInscripcion = ds.Tables[0].Rows[0]["Id_InscripcionMateria"].ToString();
                capturaId = us.idMateriaAula(idInscripcion);
                if (capturaId.Tables[0].Rows.Count != 0)
                {
                    idAulaMateria = capturaId.Tables[0].Rows[0]["Id_Materia_Aula"].ToString();
                    respuesta = us.eliminarMateriaAula(idAulaMateria);
                    if(respuesta == true)
                    {
                        mensaje = "<div class='card-panel green lighten-2'>";
                        mensaje += "<span class='white-text center-align'>Materia ha sido eliminada correctamente</span>";
                        mensaje += "</div>";
                        mensajeLbl.Text = mensaje;
                    }
                    else
                    {
                        mensaje = "<div class='card-panel red lighten-2'>";
                        mensaje += "<span class='white-text center-align'>Materia no se ha podido eliminar</span>";
                        mensaje += "</div>";
                        mensajeLbl.Text = mensaje;
                    }
                }
                else
                {
                    mensaje = "<div class='card-panel red lighten-2'>";
                    mensaje += "<span class='white-text center-align'>No se ha podido localizar una inscripcion de esta materia</span>";
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
}