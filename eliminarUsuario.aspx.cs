using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class eliminarUsuario : System.Web.UI.Page
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
    protected void eliminarBtn_Click(object sender, EventArgs e)
    {
        us = new Usuarios();
        string idUser = idUserTxT.Text;
        bool resp;
        string mensaje;
        if (idUser != "")
        {
            try
            {
                resp = us.eliminarUsuario(idUser);
                if (resp == true)
                {
                    mensaje = "<div class='card-panel green lighten-2'>";
                    mensaje += "<span class='white-text center-align'>Usuario Eliminado Correctamente</span>";
                    mensaje += "</div>";
                    mensajeLbl.Text = mensaje;
                }
                else
                {
                    mensaje = "<div class='card-panel red lighten-2'>";
                    mensaje += "<span class='white-text center-align'>Usuario no eliminado intente nuevamente</span>";
                    mensaje += "</div>";
                    mensajeLbl.Text = mensaje;
                }
            }
            catch (Exception ex)
            {
                string m;
                m = ex.Message;
            }
            finally
            {
                idUserTxT.Text = "";
            }
        }
        else
        {
            mensaje = "<div class='card-panel red lighten-2'>";
            mensaje += "<span class='white-text center-align'>El Campo Id Usuario no puede estar vacio</span>";
            mensaje += "</div>";
            mensajeLbl.Text = mensaje;
        }
        
    }
}