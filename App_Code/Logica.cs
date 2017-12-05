using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Descripción breve de Logica
/// </summary>
public static class Logica
{
    static private string cadena = "Data Source=DEFT-STONE; Initial Catalog= proyectoV3; Integrated Security=true";
    static private string consulta = "";
    static private SqlConnection cn;
    static private SqlCommand cmd;

    public static int Num_Niv(string id)
    {
        int num = 0;
        cn = new SqlConnection(cadena);
        consulta = "select Num_niveles from Edificio where Id_Edificio=@id ";
        cmd = new SqlCommand(consulta, cn);
        cmd.Parameters.AddWithValue("@id", id);
        try
        {
            cn.Open();
            num = (Int32)cmd.ExecuteScalar();
            cn.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return num;
    }
    public static DataSet Niveles(int niv)
    {
        cn = new SqlConnection(cadena);
        consulta = " select * from Niveles where Nivel<=@niv";
        SqlDataAdapter da = new SqlDataAdapter();
        cmd = new SqlCommand(consulta, cn);
        cmd.Parameters.AddWithValue("@niv", niv);
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        cn.Open();
        da.Fill(ds);
        cn.Close();

        return ds;

    }

    public static int cod(string niv, string edif)
    {
        int codi = 0;
        cn = new SqlConnection(cadena);
        consulta = "select Count(*) FROM Aulas where Id_Nivel=@niv and Id_Edificio=@edif group by Id_Edificio ";
        cmd = new SqlCommand(consulta, cn);
        cmd.Parameters.AddWithValue("@niv", niv);
        cmd.Parameters.AddWithValue("@edif", edif);

        try
        {
            cn.Open();
            codi = (Int32)cmd.ExecuteScalar();
            cn.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return codi;
    }

    public static bool insert(string cod, string idniv, string edif, string tipo, int cant, string descrip)
    {
        bool resp;
        cn = new SqlConnection(cadena);
        consulta = "INSERT INTO Aulas(Cod_aula, Id_Nivel, Id_Edificio, tipo, CantMax_Alumnos, Descripcion) VALUES(@cod, @idniv, @edif, @tipo, @cant, @descrip);";
        cmd = new SqlCommand(consulta, cn);
        cmd.Parameters.AddWithValue("@cod", cod);
        cmd.Parameters.AddWithValue("@idniv", idniv);
        cmd.Parameters.AddWithValue("@edif", edif);
        cmd.Parameters.AddWithValue("@tipo", tipo);
        cmd.Parameters.AddWithValue("@cant", cant);
        cmd.Parameters.AddWithValue("@descrip", descrip);
        try
        {

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            resp = true;
        }
        catch
        {
            resp = false;
        }


        return resp;

    }
    public static DataSet Aulas(string idNivel, string idEdificio)
    {
        cn = new SqlConnection(cadena);
        consulta = "select*from Aulas where Id_Nivel=@Nivel and Id_Edificio=@Edificio";
        SqlDataAdapter da = new SqlDataAdapter();
        cmd = new SqlCommand(consulta, cn);
        cmd.Parameters.AddWithValue("@Nivel", idNivel);
        cmd.Parameters.AddWithValue("@Edificio", idEdificio);
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        cn.Open();

        da.Fill(ds);

        cn.Close();
        return ds;
    }

    public static DataSet Buscar(string idAula)
    {

        cn = new SqlConnection(cadena);
        consulta = "select Cod_aula, tipo, CantMax_Alumnos, Descripcion from Aulas where Cod_aula=@aula ";
        SqlDataAdapter da = new SqlDataAdapter();
        cmd = new SqlCommand(consulta, cn);
        cmd.Parameters.AddWithValue("@aula", idAula);
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        cn.Open();
        da.Fill(ds);
        cn.Close();

        return ds;
    }

    public static DataSet BuscarId(string id)
    {
        cn = new SqlConnection(cadena);
        consulta = "select Cod_aula, tipo, CantMax_Alumnos, Descripcion from Aulas where Cod_aula like @id";
        SqlDataAdapter da = new SqlDataAdapter();
        cmd = new SqlCommand(consulta, cn);
        cmd.Parameters.AddWithValue("@id", "%" + id + "%");
        da.SelectCommand = cmd;

        DataSet ds = new DataSet();
        cn.Open();
        da.Fill(ds);
        cn.Close();

        return ds;
    }

    public static bool Actualizar(string cod, string tipo, int cant, string descrip)
    {
        bool resp;
        cn = new SqlConnection(cadena);
        consulta = "update Aulas set tipo=@tipo, CantMax_Alumnos=@cant, Descripcion=@descrip where Cod_aula=@cod";
        cmd = new SqlCommand(consulta, cn);
        cmd.Parameters.AddWithValue("@cod", cod);
        cmd.Parameters.AddWithValue("@tipo", tipo);
        cmd.Parameters.AddWithValue("@cant", cant);
        cmd.Parameters.AddWithValue("@descrip", descrip);
        try
        {

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            resp = true;
        }
        catch
        {
            resp = false;
        }


        return resp;
    }

    public static bool Eliminar(string id)
    {
        bool resp;
        cn = new SqlConnection(cadena);
        consulta = "delete from Aulas where Cod_aula=@id";
        cmd = new SqlCommand(consulta, cn);
        cmd.Parameters.AddWithValue("@id", id);

        try
        {
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            resp = true;
        }
        catch
        {
            resp = false;
        }
        return resp;
    }
}