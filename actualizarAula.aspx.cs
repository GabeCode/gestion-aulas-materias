using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class actualizarAula : System.Web.UI.Page
{
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
    protected void RBLCapacidad_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selec = Convert.ToInt32(RBLCapacidad.SelectedIndex.ToString());
        if (selec == 0)
        {
            TXTMax.Text = "120";
            TXTMin.Text = "112";
        }
        else if (selec == 1)
        {
            TXTMax.Text = "85";
            TXTMin.Text = "80";
        }
        else
        {
            TXTMax.Text = "";
            TXTMin.Text = "";
        }
    }
    protected void DDLNew_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id = DDLNew.SelectedValue.ToString();
        ds = Logica.Buscar(id);

        GVBuscar.DataSource = ds;
        GVBuscar.DataBind();
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
    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        string mensaje;
        try
        {
            string id = DDLNew.SelectedValue.ToString();
            string tipo = RBLCapacidad.SelectedValue.ToString();
            int cant = Convert.ToInt32(TXTMax.Text);
            string descrip = DDLCategoria.SelectedValue.ToString();
            

            if (Logica.Actualizar(id, tipo, cant, descrip))
            {
                mensaje = "<div class='card-panel green lighten-2'>";
                mensaje += "<span class='white-text center-align'>Datos actualizados con exito</span>";
                mensaje += "</div>";
                lblMensaje.Text = mensaje;

                ds = Logica.Buscar(id);

                GVBuscar.DataSource = ds;
                GVBuscar.DataBind();
            }
            else
            {
                mensaje = "<div class='card-panel red lighten-2'>";
                mensaje += "<span class='white-text center-align'>Ocurrio un problema durante la actualizacion de los datos</span>";
                mensaje += "</div>";
                lblMensaje.Text = mensaje;
            }
        }
        catch
        {
            mensaje = "<div class='card-panel red lighten-2'>";
            mensaje += "<span class='white-text center-align'>Deben seleccionarse todos los campos!</span>";
            mensaje += "</div>";
            lblMensaje.Text = mensaje;
        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        string id = txtBuscar.Text;
        string mensaje;
        DataSet dsbuscar = new DataSet();
        dsbuscar = Logica.BuscarId(id);

        if (dsbuscar.Tables[0].Rows.Count != 0)
        {
            GVBuscar.DataSource = dsbuscar;
            GVBuscar.DataBind();
        }
        else
        {
            mensaje = "<div class='card-panel red lighten-2'>";
            mensaje += "<span class='white-text center-align'>No se encuentra el aula solicitada</span>";
            mensaje += "</div>";
            lblMensaje.Text = mensaje;
        }
    }
}