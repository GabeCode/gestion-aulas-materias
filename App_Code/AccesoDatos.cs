using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de AccesoDatos
/// </summary>
public static class AccesoDatos
{

    //metodo para conectar datos
    static public string cadena = "Data Source=DEFT-STONE; Initial Catalog= proyectoV3; Integrated Security=true";
    static public SqlConnection con = new SqlConnection(cadena);
    static public SqlCommand cmd;

}