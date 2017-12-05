using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class agregarMateria : System.Web.UI.Page
{
    
    Random rnd = new Random();
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

    protected void agregaBtn_Click(object sender, EventArgs e)
    {
        us = new Usuarios();
        string idIns = Convert.ToString(rnd.Next(1147483647));
        string idMat = ddlMateria.SelectedValue.ToString();
        int canti = int.Parse(cantAlumnosTxT.Text);
        string idSec = ddlSeccion.SelectedValue.ToString();
        string dias = ddlDias.SelectedValue.ToString();
        string horaInicio = ddlHoraInicio.SelectedValue.ToString();
        string horaFin = ddHoraFin.SelectedValue.ToString();
        string idH, mensaje;
        bool seccion, resp, respuesta;
        try
        {
            resp = us.validarHorario(dias, horaInicio, horaFin);
            if(resp == true)
            {
                seccion = us.validarSeccion(idMat, idSec);
                if (seccion == false)
                {
                    ds = us.idHorario(dias, horaInicio, horaFin);
                    idH = ds.Tables[0].Rows[0]["Id_Horario"].ToString();
                    respuesta = us.agregarMateria(idIns, idMat, canti, idSec, idH);
                    if (respuesta == true)
                    {
                        mensaje = "<div class='card-panel green lighten-2'>";
                        mensaje += "<span class='white-text center-align'>Materia Registrada Correctamente</span>";
                        mensaje += "</div>";
                        mensajeLbl.Text = mensaje;
                    }
                    else
                    {
                        mensaje = "<div class='card-panel red lighten-2'>";
                        mensaje += "<span class='white-text center-align'>Materia No Registrada</span>";
                        mensaje += "</div>";
                        mensajeLbl.Text = mensaje;
                    }
                }
                else
                {
                    mensaje = "<div class='card-panel red lighten-2'>";
                    mensaje += "<span class='white-text center-align'>Ya existe esta materia inscrita con ese numero de sección</span>";
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
            
            cantAlumnosTxT.Text = "";

        }
        catch (Exception)
        {
            throw;
        }
    }
}