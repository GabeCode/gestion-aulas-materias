using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class editarMateria : System.Web.UI.Page
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
    protected void actualizarBtn_Click(object sender, EventArgs e)
    {
        us = new Usuarios();
        string idMat = ddlMateria.SelectedValue.ToString();
        string idSec = ddlSeccion.SelectedValue.ToString();
        string dias = ddlDias.SelectedValue.ToString();
        string horaInicio = ddlHoraInicio.SelectedValue.ToString();
        string horaFin = ddHoraFin.SelectedValue.ToString();
        string idH, mensaje, idInscripcion;
        bool resp, respuesta;
        if (cantAlumnosTxT.Text != "")
        {
            int canti = int.Parse(cantAlumnosTxT.Text);
            try
            {
                ds = us.idInscripcionMateria(idMat, idSec);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    idInscripcion = ds.Tables[0].Rows[0]["Id_InscripcionMateria"].ToString();
                    resp = us.validarHorario(dias, horaInicio, horaFin);
                    if (resp == true)
                    {
                        ds = us.idHorario(dias, horaInicio, horaFin);
                        idH = ds.Tables[0].Rows[0]["Id_Horario"].ToString();
                        respuesta = us.actualizarrMateria(idInscripcion, idMat, canti, idSec, idH);
                        if (respuesta == true)
                        {
                            mensaje = "<div class='card-panel green lighten-2'>";
                            mensaje += "<span class='white-text center-align'>Materia Actulizada Correctamente</span>";
                            mensaje += "</div>";
                            mensajeLbl.Text = mensaje;
                        }
                        else
                        {
                            mensaje = "<div class='card-panel red lighten-2'>";
                            mensaje += "<span class='white-text center-align'>Materia No Actualizada</span>";
                            mensaje += "</div>";
                            mensajeLbl.Text = mensaje;
                        }
                    }
                    else
                    {
                        mensaje = "<div class='card-panel red lighten-2'>";
                        mensaje += "<span class='white-text center-align'>El horario seleccionado no está establecido en la base de datos</span>";
                        mensaje += "</div>";
                        mensajeLbl.Text = mensaje;
                    }
                }
                else
                {
                    mensaje = "<div class='card-panel red lighten-2'>";
                    mensaje += "<span class='white-text center-align'>No hay materia inscrita con ese numero de sección</span>";
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
            mensaje += "<span class='white-text center-align'>Todos los campos son necesarios!</span>";
            mensaje += "</div>";
            mensajeLbl.Text = mensaje;
        }
        
    }
    
}