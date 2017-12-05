using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Net.Mail;
using System.Net;

/// <summary>
/// Descripción breve de Usuarios
/// </summary>
public class Usuarios
{
    
    private string _Id_Usuario;
    private string _contraseña;
    private int _nivel;

    public Usuarios()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    //Propiedades
    public string Id_Usuario
    {
        get
        {
            return _Id_Usuario;
        }

        set
        {
            _Id_Usuario = value;
        }
    }

    public string Contraseña
    {
        get
        {
            return _contraseña;
        }

        set
        {
            _contraseña = value;
        }
    }

    public int Nivel
    {
        get
        {
            return _nivel;
        }

        set
        {
            _nivel = value;
        }
    }
    //Fin Propiedades
 
    public bool agregarUsuario(string idUser, string pass, int nivel)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_IngresarUsuario", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Usuario", idUser);
            AccesoDatos.cmd.Parameters.AddWithValue("@contraseña", pass);
            AccesoDatos.cmd.Parameters.AddWithValue("@nivel", nivel);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool actualizarUsuario(string idUser, string pass, int nivel)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_ActualizarUsuario", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Usuario", idUser);
            AccesoDatos.cmd.Parameters.AddWithValue("@contraseña", pass);
            AccesoDatos.cmd.Parameters.AddWithValue("@nivel", nivel);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool eliminarUsuario(string idUser)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_EliminarUsuario", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Usuario", idUser);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool agregarMateriaDocente(int idDocMat, string idDoc, string idMat)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_asignarMateriaDocente", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_DocenteMateria", idDocMat);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Docente", idDoc);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_InscripcionMateria", idMat);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool actualizarMateriaDocente(int idDocMat, string idDoc, string idMat)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_actualizarMateriaDocente", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_DocenteMateria", idDocMat);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Docente", idDoc);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_InscripcionMateria", idMat);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool eliminarMateriaDocente(int idDocMat)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_eliminarMateriaDocente", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_DocenteMateria", idDocMat);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool agregarMateriaAula(string idAulaMAt, string idInsc, string codAula, string dias, string hInicio, string hFin)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_agregarMateriaAula", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Materia_Aula", idAulaMAt);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_InscripcionMateria", idInsc);
            AccesoDatos.cmd.Parameters.AddWithValue("@Cod_aula", codAula);
            AccesoDatos.cmd.Parameters.AddWithValue("@Dias", dias);
            AccesoDatos.cmd.Parameters.AddWithValue("@Hora_Inicio", hInicio);
            AccesoDatos.cmd.Parameters.AddWithValue("@Hora_Fin", hFin);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool actualizarMateriaAula(string idAulaMAt, string codAula, string dias, string hInicio, string hFin)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_actualizarMateriaAula", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Materia_Aula", idAulaMAt);
            AccesoDatos.cmd.Parameters.AddWithValue("@Cod_aula", codAula);
            AccesoDatos.cmd.Parameters.AddWithValue("@Dias", dias);
            AccesoDatos.cmd.Parameters.AddWithValue("@Hora_Inicio", hInicio);
            AccesoDatos.cmd.Parameters.AddWithValue("@Hora_Fin", hFin);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool eliminarMateriaAula(string IdMatAula)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_eliminarMateriaAula", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Materia_Aula", IdMatAula);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool validarHorario(string d, string hi, string hf)
    {
        bool resp;
        SqlDataReader dr;
        AccesoDatos.cmd = new SqlCommand("sp_ValidarHorarios", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Dias", d);
        AccesoDatos.cmd.Parameters.AddWithValue("@Hora_Inicio", hi);
        AccesoDatos.cmd.Parameters.AddWithValue("@Hora_Fin", hf);
        try
        {
            AccesoDatos.con.Open();
            dr = AccesoDatos.cmd.ExecuteReader();
            if (dr.Read())
            {
                resp = true;
            }
            else
            {

                resp = false;

            }

            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool validarSeccion(string m, string s)
    {
        bool resp;
        SqlDataReader dr;
        AccesoDatos.cmd = new SqlCommand("sp_ValidarSeccion", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@materia", m);
        AccesoDatos.cmd.Parameters.AddWithValue("@seccion", s);
        try
        {
            AccesoDatos.con.Open();
            dr = AccesoDatos.cmd.ExecuteReader();
            if (dr.Read())
            {
                resp = true;
            }
            else
            {

                resp = false;

            }

            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool validarUsuario(string u, string c)
    {
        bool resp;
        SqlDataReader dr;
        AccesoDatos.cmd = new SqlCommand("sp_ValidarUsuarios", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Id_Usuario", u);
        AccesoDatos.cmd.Parameters.AddWithValue("@contraseña", c);

        try
        {
            AccesoDatos.con.Open();
            dr = AccesoDatos.cmd.ExecuteReader();
            if (dr.Read())
            {

                resp = true;
            }
            else
            {

                resp = false;

            }

            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public DataSet nivelUsuario(string usuario)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        AccesoDatos.cmd = new SqlCommand("sp_DatosUsuario", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Id_Usuario", usuario);
        da = new SqlDataAdapter(AccesoDatos.cmd);
        

        try
        {
            AccesoDatos.con.Open();
            da.Fill(ds);
            AccesoDatos.con.Close();
        }
        catch(Exception ex)
        {
            string m;
            m = ex.Message;
        }
        return ds;
    }

    public DataSet idMateriaAula(string idIns)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        AccesoDatos.cmd = new SqlCommand("sp_DatosMateriaAula", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Id_Inscripcion", idIns);
        da = new SqlDataAdapter(AccesoDatos.cmd);
        try
        {
            AccesoDatos.con.Open();
            da.Fill(ds);
            AccesoDatos.con.Close();
        }
        catch (Exception ex)
        {
            string m;
            m = ex.Message;
        }
        return ds;
    }

    public DataSet cantidadAula(string Cod)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        AccesoDatos.cmd = new SqlCommand("sp_DatosAula", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Cod_aula", Cod);
        da = new SqlDataAdapter(AccesoDatos.cmd);


        try
        {
            AccesoDatos.con.Open();
            da.Fill(ds);
            AccesoDatos.con.Close();
        }
        catch (Exception ex)
        {
            string m;
            m = ex.Message;
        }
        return ds;
    }

    public DataSet ValidacionHorarioMateria(string d, string a, string hi, string hf)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        AccesoDatos.cmd = new SqlCommand("sp_ValidacionHorarioMateria", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Dias", d);
        AccesoDatos.cmd.Parameters.AddWithValue("@Aula", a);
        AccesoDatos.cmd.Parameters.AddWithValue("@Inicio", hi);
        AccesoDatos.cmd.Parameters.AddWithValue("@Fin", hf);
        da = new SqlDataAdapter(AccesoDatos.cmd);
        try
        {
            AccesoDatos.con.Open();
            da.Fill(ds);
            AccesoDatos.con.Close();
        }
        catch (Exception ex)
        {
            string m;
            m = ex.Message;
        }
        return ds;
    }

    public DataSet ValidacionHorarioMateria2(string d, string a, string hi)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        AccesoDatos.cmd = new SqlCommand("sp_ValidacionHorarioMateria2", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Dias", d);
        AccesoDatos.cmd.Parameters.AddWithValue("@Aula", a);
        AccesoDatos.cmd.Parameters.AddWithValue("@Inicio", hi);
        da = new SqlDataAdapter(AccesoDatos.cmd);
        try
        {
            AccesoDatos.con.Open();
            da.Fill(ds);
            AccesoDatos.con.Close();
        }
        catch (Exception ex)
        {
            string m;
            m = ex.Message;
        }
        return ds;
    }

    public DataSet datosHorario(string idHorario)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        AccesoDatos.cmd = new SqlCommand("sp_DatosHorario", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Id_Horario", idHorario);
        da = new SqlDataAdapter(AccesoDatos.cmd);


        try
        {
            AccesoDatos.con.Open();
            da.Fill(ds);
            AccesoDatos.con.Close();
        }
        catch (Exception ex)
        {
            string m;
            m = ex.Message;
        }
        return ds;
    }

    public DataSet idInscripcionMateria(string idMat, string idSec)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        AccesoDatos.cmd = new SqlCommand("sp_DatosInscripcionMateria", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Id_Materia", idMat);
        AccesoDatos.cmd.Parameters.AddWithValue("@Id_Seccion", idSec);
        da = new SqlDataAdapter(AccesoDatos.cmd);
        try
        {
            AccesoDatos.con.Open();
            da.Fill(ds);
            AccesoDatos.con.Close();
        }
        catch (Exception ex)
        {
            string m;
            m = ex.Message;
        }
        return ds;
    }

    public DataSet idHorario(string d, string hi, string hf)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        AccesoDatos.cmd = new SqlCommand("sp_ValidarHorarios", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@Dias", d);
        AccesoDatos.cmd.Parameters.AddWithValue("@Hora_Inicio", hi);
        AccesoDatos.cmd.Parameters.AddWithValue("@Hora_Fin", hf);
        da = new SqlDataAdapter(AccesoDatos.cmd);


        try
        {
            AccesoDatos.con.Open();
            da.Fill(ds);
            AccesoDatos.con.Close();
        }
        catch (Exception ex)
        {
            string m;
            m = ex.Message;
        }
        return ds;
    }

    public StringBuilder tabla(string materia)
    {
        SqlDataReader sqlDr;
        StringBuilder lectura;
        lectura = new StringBuilder();
        AccesoDatos.cmd = new SqlCommand("sp_mostrarMateria", AccesoDatos.con);
        AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
        AccesoDatos.cmd.Parameters.AddWithValue("@materia", "%" + materia + "%");
        try
        {
            AccesoDatos.con.Open();
            sqlDr = AccesoDatos.cmd.ExecuteReader();
            if (sqlDr.HasRows)
            {
                //Encabezado de la tabla
                lectura.Append("<table class='responsive-table striped'>");
                lectura.Append("<thead><tr>");
                lectura.Append("<th>Nombre</th>");
                lectura.Append("<th>Seccion</th>");
                lectura.Append("<th>Dias</th>");
                lectura.Append("<th>Hora Inicio</th>");
                lectura.Append("<th>Hora Fin</th>");
                lectura.Append("</tr></thead>");
                //Hacer que los datos aparezcan de forma dinamica
                while (sqlDr.Read())
                {
                    lectura.Append("<tr>");
                    lectura.Append("<td>" + sqlDr.GetString(0) + "</td>");
                    lectura.Append("<td>" + sqlDr.GetInt32(1) + "</td>");
                    lectura.Append("<td>" + sqlDr.GetString(2) + "</td>");
                    lectura.Append("<td>" + sqlDr.GetTimeSpan(3) + "</td>");
                    lectura.Append("<td>" + sqlDr.GetTimeSpan(4) + "</td>");
                    lectura.Append("</tr>");
                }
                lectura.Append("</table>");
                AccesoDatos.con.Close();
            }
            else
            {
                lectura.Append("<h1>No se encontraron resultados</h1>");

            }
        }
        catch
        {
            lectura.Append("<h3>Lo sentimos, estamos trabajando en el servidor</h3>");
        }

        return lectura;
    }

    public bool agregarDocente(string idDoc, string idUser, string nombre, string apellido, string email, int estado)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_IngresarDocente", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Docente", idDoc);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Usuario", idUser);
            AccesoDatos.cmd.Parameters.AddWithValue("@Nombre", nombre);
            AccesoDatos.cmd.Parameters.AddWithValue("@Apellido", apellido);
            AccesoDatos.cmd.Parameters.AddWithValue("@Email", email);
            AccesoDatos.cmd.Parameters.AddWithValue("@estado", estado);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool agregarAdmin(string idDoc, string idUser, string nombre, string apellido, string email, int estado)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_IngresarAdministrador", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Administrador", idDoc);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Usuario", idUser);
            AccesoDatos.cmd.Parameters.AddWithValue("@Nombre", nombre);
            AccesoDatos.cmd.Parameters.AddWithValue("@Apellido", apellido);
            AccesoDatos.cmd.Parameters.AddWithValue("@Email", email);
            AccesoDatos.cmd.Parameters.AddWithValue("@Estado", estado);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool agregarMateria(string idInscripcionMateria,string idMateria, int cant, string idSec, string idHora)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_InscribirMateria", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Inscripcion", idInscripcionMateria);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Materia", idMateria);
            AccesoDatos.cmd.Parameters.AddWithValue("@CantAlumnos", cant);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Seccion", idSec);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Horario", idHora);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool actualizarrMateria(string idInscripcionMateria, string idMateria, int cant, string idSec, string idHora)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_actualizarInscripcionMateria", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Inscripcion", idInscripcionMateria);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Materia", idMateria);
            AccesoDatos.cmd.Parameters.AddWithValue("@CantAlumnos", cant);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Seccion", idSec);
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Horario", idHora);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public bool eliminarMateria(string idInscripcionMateria)
    {
        bool resp;
        try
        {
            AccesoDatos.con.Open();
            AccesoDatos.cmd = new SqlCommand("sp_eliminarInscripcionMateria", AccesoDatos.con);
            AccesoDatos.cmd.CommandType = CommandType.StoredProcedure;
            AccesoDatos.cmd.Parameters.AddWithValue("@Id_Inscripcion", idInscripcionMateria);
            AccesoDatos.cmd.ExecuteNonQuery();
            resp = true;
            AccesoDatos.con.Close();
        }
        catch
        {
            resp = false;
        }
        return resp;
    }

    public void sendMail(string to, string sub, string body)
    { 
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
        mail.From = new MailAddress("example@gmail.com", "MiNombre", Encoding.UTF8);
        //Aquí ponemos el asunto del correo
        mail.Subject = sub;
        //Aquí ponemos el mensaje que incluirá el correo
        mail.Body = body;
        //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
        mail.To.Add(to);
        //Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran
        //mail.Attachments.Add(new Attachment(@"C:\Documentos\carta.docx"));

        //Configuracion del SMTP
        SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios
                               //Especificamos las credenciales con las que enviaremos el mail
        SmtpServer.Credentials = new System.Net.NetworkCredential("example@gmail.com", "pasword");
        SmtpServer.EnableSsl = true;
        SmtpServer.Send(mail);
    }

}
