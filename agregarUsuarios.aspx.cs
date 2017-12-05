using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class agregarUsuarios : System.Web.UI.Page
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
        bool resp;
        string mensaje;
        if(idUserTxT.Text != "" && contraseñaTxt.Text != "" && nivelTxT.Text != "")
        {
            string idUser = idUserTxT.Text;
            string pass = contraseñaTxt.Text;
            int nivel = Convert.ToInt32(nivelTxT.Text);
            try
            {
                resp = us.agregarUsuario(idUser, pass, nivel);
                if (resp == true)
                {
                    mensaje = "<div class='card-panel green lighten-2'>";
                    mensaje += "<span class='white-text center-align'>Usuario Registrado Correctamente</span>";
                    mensaje += "</div>";
                    mensajeLbl.Text = mensaje;
                }
                else
                {
                    mensaje = "<div class='card-panel red lighten-2'>";
                    mensaje += "<span class='white-text center-align'>Usuario No Registrado intente nuevamente</span>";
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
                contraseñaTxt.Text = "";
                nivelTxT.Text = "";
            }
        }
        else
        {
            mensaje = "<div class='card-panel red lighten-2'>";
            mensaje += "<span class='white-text center-align'>Todos Los campos son necesarios, asegurese de que no estén vacios</span>";
            mensaje += "</div>";
            mensajeLbl.Text = mensaje;
        }
        

    }
}