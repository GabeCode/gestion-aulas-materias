using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class agregarAula : System.Web.UI.Page
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
        DropDownList4.DataSource = ds;
        DropDownList4.DataValueField = "Id_Nivel";
        DropDownList4.DataTextField = "Nivel";
        DropDownList4.DataBind();
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selec = Convert.ToInt32(RadioButtonList1.SelectedIndex.ToString());
        if (selec == 0)
        {
            txtMax.Text = "120";
            txtMin.Text = "112";
        }
        else if (selec == 1)
        {
            txtMax.Text = "85";
            txtMin.Text = "80";
        }
        else
        {
            txtMax.Text = "";
            txtMin.Text = "";
        }

    }
    protected void CrearBtn_Click(object sender, EventArgs e)
    {
        string idEdif = DDLEdificio.SelectedValue.ToString();
        string mensaje;
        string part2cod = "";
        string struc = DropDownList4.SelectedValue.ToString();
        switch (struc)
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
        try
        {
            int part3cod = Logica.cod(struc, idEdif) + 1;
            string id = idEdif + part2cod + Convert.ToString(part3cod);
            int cant = Convert.ToInt32(txtMax.Text);
            string descrip = DropDownList3.SelectedValue.ToString();
            string tipo = RadioButtonList1.SelectedValue.ToString();
            if (Logica.insert(id, struc, idEdif, tipo, cant, descrip))
            {
                mensaje = "<div class='card-panel green lighten-2'>";
                mensaje += "<span class='white-text center-align'>Datos ingresados con exito</span>";
                mensaje += "</div>";
                LblMessage.Text = mensaje;
            }
            else
            {
                mensaje = "<div class='card-panel red lighten-2'>";
                mensaje += "<span class='white-text center-align'>Ocurrio un problema durante la insercion de los datos</span>";
                mensaje += "</div>";
                LblMessage.Text = mensaje;
            }
        }
        catch
        {
            mensaje = "<div class='card-panel red lighten-2'>";
            mensaje += "<span class='white-text center-align'>Llenar todos los campos!</span>";
            mensaje += "</div>";
            LblMessage.Text = mensaje;
        }

    }

}