using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class login : System.Web.UI.Page
{
    Usuarios us;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnIniciar_Click1(object sender, EventArgs e)
    {
        us = new Usuarios();
        string user = txtuser.Text;
        string password = contraseñaTxt.Text;
        int nivel;
        bool resp;
        resp = us.validarUsuario(user, password);
        if (resp == true)
        {
            ds = us.nivelUsuario(user);
            Session["Id_usuario"] = user;
            nivel = int.Parse(ds.Tables[0].Rows[0]["nivel"].ToString());
            Session["nivel"] = nivel;
            if (nivel == 1 || nivel == 2)
            {
                Response.Redirect("home.aspx");
            }

        }
        else
        {
            Response.Write("<script>alert('Usuario o Password incorrecto');</script>");
        }

    }
}