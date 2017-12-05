using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class eliminarAula : System.Web.UI.Page
{
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
        string res = DDLEdificio.SelectedValue.ToString();

        int num = Convert.ToInt32(Logica.Num_Niv(res));

        DataSet ds = new DataSet();
        ds = Logica.Niveles(num);

        DDLNivel.DataSource = ds;
        DDLNivel.DataValueField = "Id_Nivel";
        DDLNivel.DataTextField = "Nivel";
        DDLNivel.DataBind();
    }
    protected void DDLNivel_SelectedIndexChanged(object sender, EventArgs e)
    {
        string mensaje;
        try
        {
            string edif = DDLEdificio.SelectedValue.ToString();
            string niv = DDLNivel.SelectedValue.ToString();

            DataSet ds = new DataSet();
            ds = Logica.Aulas(niv, edif);



            if (ds.Tables[0].Rows.Count != 0)
            {
                GVMostrar.DataSource = ds;
                GVMostrar.DataBind();
                lblMensaje.Text = "";
            }
            else
            {
                
                mensaje = "<div class='card-panel red lighten-2'>";
                mensaje += "<span class='white-text center-align'>No hay aulas inscritas en este nivel</span>";
                mensaje += "</div>";
                lblMensaje.Text = mensaje;
            }
        }
        catch
        {
            mensaje = "<div class='card-panel red lighten-2'>";
            mensaje += "<span class='white-text center-align'>Los dos datos son necesarios</span>";
            mensaje += "</div>";
            lblMensaje.Text = mensaje;
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        string edif = DDLEdificio.SelectedValue.ToString();
        string niv = DDLNivel.SelectedValue.ToString();
        string mensaje;
        string part2cod = "";

        switch (niv)
        {
            case "n1":
                part2cod = "10";
                break;

            case "n2":
                part2cod = "20";
                break;

            case "n3":
                part2cod = "30";
                break;

            case "n4":
                part2cod = "40";
                break;

            case "n5":
                part2cod = "50";
                break;

            default:
                part2cod = "";
                break;
        }

        int fcod = Logica.cod(niv, edif);

        if (fcod == 0)
        {
            mensaje = "<div class='card-panel red lighten-2'>";
            mensaje += "<span class='white-text center-align'>No hay aulas que eliminar</span>";
            mensaje += "</div>";
            lblMensaje.Text = mensaje;
        }
        else
        {
            string num = Convert.ToString(Logica.cod(niv, edif));

            string Id = edif + part2cod + num;

            if (Logica.Eliminar(Id))
            {
                mensaje = "<div class='card-panel green lighten-2'>";
                mensaje += "<span class='white-text center-align'>Datos eliminados con exito</span>";
                mensaje += "</div>";
                lblMensaje.Text = mensaje;
                DataSet ds = new DataSet();
                ds = Logica.Aulas(niv, edif);



                if (ds.Tables[0].Rows.Count != 0)
                {
                    GVMostrar.DataSource = ds;
                    GVMostrar.DataBind();
                }
                else
                {
                    mensaje = "<div class='card-panel red lighten-2'>";
                    mensaje += "<span class='white-text center-align'>Ya no hay aulas inscritas en este nivel</span>";
                    mensaje += "</div>";
                    lblMensaje.Text = mensaje;
                    GVMostrar.DataSource = ds;
                    GVMostrar.DataBind();
                }

            }
            else
            {
                mensaje = "<div class='card-panel red lighten-2'>";
                mensaje += "<span class='white-text center-align'>Ocurrio un problema durante la eliminacion</span>";
                mensaje += "</div>";
                lblMensaje.Text = mensaje;
            }

        }
    }
}