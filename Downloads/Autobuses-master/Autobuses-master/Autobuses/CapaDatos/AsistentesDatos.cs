using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class AsistentesDatos
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        public List<AsistentesEntidades> BuscarAsistentes(string Asistentes)
        {
            SqlDataReader Leer_Asistentes;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_ASISTENTES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", Asistentes);
            Leer_Asistentes = cmd.ExecuteReader();

            List<AsistentesEntidades> Listar_C = new List<AsistentesEntidades>();

            while (Leer_Asistentes.Read())
            {
                Listar_C.Add(new AsistentesEntidades
                {
                    ID_Asistente = Leer_Asistentes.GetInt32(0),
                    Codigo = Leer_Asistentes.GetString(1),
                    Cedula = Leer_Asistentes.GetString(2),
                    Nombre = Leer_Asistentes.GetString(3),
                    Apellidos = Leer_Asistentes.GetString(4),
                    Telefono = Leer_Asistentes.GetString(5),
                    F_Nacimiento = Convert.ToDateTime(Leer_Asistentes["F_Nacimiento"]).ToString("dd'/'MM'/'yyyy"),
                    Direccion = Leer_Asistentes.GetString(7),
                    Sexo = Leer_Asistentes.GetString(8),
                    Sueldo = Leer_Asistentes.GetDouble(9)
                });
            }

            Conexion.Close();
            Leer_Asistentes.Close();

            return Listar_C;
        }

        public void InsertarAsistentes(AsistentesEntidades Asistentes)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_ASISTENTES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cedula", Asistentes.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", Asistentes.Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", Asistentes.Apellidos);
            cmd.Parameters.AddWithValue("@Telefono", Asistentes.Telefono);
            cmd.Parameters.AddWithValue("@Nac", Convert.ToDateTime(Asistentes.F_Nacimiento));
            cmd.Parameters.AddWithValue("@Direccion", Asistentes.Direccion);
            cmd.Parameters.AddWithValue("@Sexo", Asistentes.Sexo);
            cmd.Parameters.AddWithValue("@Sueldo", Asistentes.Sueldo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarAsistentes(AsistentesEntidades Asistentes)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_ASISTENTES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Asistente", Asistentes.Codigo);
            cmd.Parameters.AddWithValue("@Cedula", Asistentes.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", Asistentes.Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", Asistentes.Apellidos);
            cmd.Parameters.AddWithValue("@Telefono", Asistentes.Telefono);
            cmd.Parameters.AddWithValue("@Nac", Convert.ToDateTime(Asistentes.F_Nacimiento));
            cmd.Parameters.AddWithValue("@Direccion", Asistentes.Direccion);
            cmd.Parameters.AddWithValue("@Sexo", Asistentes.Sexo);
            cmd.Parameters.AddWithValue("@Sueldo", Asistentes.Sueldo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarAsistentes(AsistentesEntidades Asistentes)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_ASISTENTES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Asistente", Asistentes.Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
