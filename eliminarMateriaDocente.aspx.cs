using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class eliminarMateriaDocente : System.Web.UI.Page
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

    protected void EliminarBtn_Click(object sender, EventArgs e)
    {
        us = new Usuarios();
        bool respuesta;
        string mensaje;
        if (idMateriaDocentetxt.Text != "")
        {
            int idMatDoc = Convert.ToInt32(idMateriaDocentetxt.Text);
            try
            {
                respuesta = us.eliminarMateriaDocente(idMatDoc);
                if (respuesta == true)
                {
                    mensaje = "<div class='card-panel green lighten-2'>";
                    mensaje += "<span class='white-text center-align'>Se ha eliminado Correctamente</span>";
                    mensaje += "</div>";
                    mensajeLbl.Text = mensaje;
                }
                else
                {
                    mensaje = "<div class='card-panel red lighten-2'>";
                    mensaje += "<span class='white-text center-align'>No Se ha podido Eliminar</span>";
                    mensaje += "</div>";
                    mensajeLbl.Text = mensaje;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                idMateriaDocentetxt.Text = "";
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