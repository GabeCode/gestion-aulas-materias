using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class actualizarAulaMateria : System.Web.UI.Page
{
    Usuarios us;
    DataSet ds = new DataSet();
    DataSet ds2 = new DataSet();
    DataSet validacion = new DataSet();
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
    protected void DDLEdificio_SelectedIndexChanged(object sender, EventArgs e)
    {
        string idEdif = DDLEdificio.SelectedValue.ToString();

        int Niv = Convert.ToInt32(Logica.Num_Niv(idEdif));

        ds = Logica.Niveles(Niv);

        DDLNivel.DataSource = ds;
        DDLNivel.DataValueField = "Id_Nivel";
        DDLNivel.DataTextField = "Nivel";
        DDLNivel.DataBind();
        string aux = "";
        aux = DDLNivel.Text;

        //string idNivel = DDLNivel.SelectedValue.ToString();
        string idEdificio = DDLEdificio.SelectedValue.ToString();

        DataSet ds2 = new DataSet();
        ds2 = Logica.Aulas(aux, idEdificio);

        DDLNew.DataSource = ds2;
        DDLNew.DataValueField = "Cod_aula";
        DDLNew.DataTextField = "Cod_aula";
        DDLNew.DataBind();

    }
    protected void DDLNivel_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string idNivel = DDLNivel.SelectedValue.ToString();
        string idEdificio = DDLEdificio.SelectedValue.ToString();

        ds = Logica.Aulas(idNivel, idEdificio);

        DDLNew.DataSource = ds;
        DDLNew.DataValueField = "Cod_aula";
        DDLNew.DataTextField = "Cod_aula";
        DDLNew.DataBind();
    }

    protected void actualizarBtn_Click(object sender, EventArgs e)
    {
        us = new Usuarios();
        //TimeSpan tiempoIni, tiempoFin, resultado;
        string idAulaMateria;
        string idInscripcion, idHorario, dias, horaIni, horaFin, mensaje;
        string materia = ddlMateria.SelectedValue.ToString();
        string seccion = ddlSeccion.SelectedValue.ToString();
        string codigoAula = DDLNew.SelectedValue.ToString();
        bool respuesta;
        int cantidadMax, cantidadActual;
        try
        {
            ds = us.idInscripcionMateria(materia, seccion);
            if (ds.Tables[0].Rows.Count != 0)
            {
                idInscripcion = ds.Tables[0].Rows[0]["Id_InscripcionMateria"].ToString();
                idHorario = ds.Tables[0].Rows[0]["Id_Horario"].ToString();
                ds2 = us.datosHorario(idHorario);
                capturaId = us.idMateriaAula(idInscripcion);
                if (ds2.Tables[0].Rows.Count != 0 && capturaId.Tables[0].Rows.Count != 0)
                {
                    idAulaMateria = capturaId.Tables[0].Rows[0]["Id_Materia_Aula"].ToString();
                    dias = ds2.Tables[0].Rows[0]["Dias"].ToString();
                    horaIni = ds2.Tables[0].Rows[0]["Hora_Inicio"].ToString();
                    horaFin = ds2.Tables[0].Rows[0]["Hora_Fin"].ToString();
                    validacion = us.ValidacionHorarioMateria(dias, codigoAula, horaIni, horaFin);
                    if (validacion.Tables[0].Rows.Count == 0)
                    {
                        /*tiempoIni = TimeSpan.Parse(horaIni);
                        tiempoFin = TimeSpan.Parse(horaFin);
                        resultado = tiempoFin - tiempoIni;
                        string duracionClase = resultado.ToString();*/
                        ds = us.cantidadAula(codigoAula);
                        ds2 = us.idInscripcionMateria(materia, seccion);
                        if (ds.Tables[0].Rows.Count != 0 && ds2.Tables[0].Rows.Count != 0)
                        {
                            cantidadMax = Convert.ToInt32(ds.Tables[0].Rows[0]["CantMax_Alumnos"].ToString());
                            cantidadActual = Convert.ToInt32(ds2.Tables[0].Rows[0]["CantAlumnos"].ToString());
                            if (cantidadActual <= cantidadMax)
                            {
                                respuesta = us.actualizarMateriaAula(idAulaMateria, codigoAula, dias, horaIni, horaFin);
                                if (respuesta == true)
                                {
                                    mensaje = "<div class='card-panel green lighten-2'>";
                                    mensaje += "<span class='white-text center-align'>Materia Actualizada Correctamente</span>";
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
                                mensaje += "<span class='white-text center-align'>La Materia sobrepasa la cantidad de alumnos que pueden estar en esta Aula</span>";
                                mensaje += "</div>";
                                mensajeLbl.Text = mensaje;
                            }

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
                        mensaje += "<span class='white-text center-align'>Ya hay una materia siendo impartida en esa Aula en el rango de horas clase de esta Materia</span>";
                        mensaje += "</div>";
                        mensajeLbl.Text = mensaje;
                    }

                }
                else
                {
                    mensaje = "<div class='card-panel red lighten-2'>";
                    mensaje += "<span class='white-text center-align'>No existe Horario con esta Materia</span>";
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