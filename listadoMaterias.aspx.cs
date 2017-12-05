using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class listadoMaterias : System.Web.UI.Page
{
    Usuarios us = new Usuarios();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["nivel"] == null)
            this.Page.MasterPageFile = "~/MasterPageAlumno.master";
        else if (int.Parse(Session["nivel"].ToString()) == 1)
            this.Page.MasterPageFile = "~/MasterPageAdmin.master";
        else
            this.Page.MasterPageFile = "~/MasterPageDocente.master";
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        tablaContainer.InnerHtml = us.tabla(txtBuscar.Text).ToString();
        txtBuscar.Text = "";
    }
}