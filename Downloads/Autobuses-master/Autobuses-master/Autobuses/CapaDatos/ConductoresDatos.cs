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
    public class ConductoresDatos
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        public List<ConductoresEntidades> BuscarConductores(string Conductores)
        {
            SqlDataReader Leer_Conductores;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_CONDUCTORES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", Conductores);
            Leer_Conductores = cmd.ExecuteReader();

            List<ConductoresEntidades> Listar_C = new List<ConductoresEntidades>();

            while (Leer_Conductores.Read())
            {
                Listar_C.Add(new ConductoresEntidades
                {
                    ID_Conductor = Leer_Conductores.GetInt32(0),
                    Codigo = Leer_Conductores.GetString(1),
                    Cedula = Leer_Conductores.GetString(2),
                    Nombre = Leer_Conductores.GetString(3),
                    Apellidos = Leer_Conductores.GetString(4),
                    Telefono = Leer_Conductores.GetString(5),
                    F_Nacimiento = Convert.ToDateTime(Leer_Conductores["F_Nacimiento"]).ToString("dd'/'MM'/'yyyy"),
                    Direccion = Leer_Conductores.GetString(7),
                    Sexo = Leer_Conductores.GetString(8),
                    Sueldo = Leer_Conductores.GetDouble(9)
                });
            }

            Conexion.Close();
            Leer_Conductores.Close();

            return Listar_C;
        }

        public void InsertarConductores(ConductoresEntidades Conductores)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_CONDUCTORES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cedula", Conductores.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", Conductores.Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", Conductores.Apellidos);
            cmd.Parameters.AddWithValue("@Telefono", Conductores.Telefono);
            cmd.Parameters.AddWithValue("@Nac", Convert.ToDateTime(Conductores.F_Nacimiento));
            cmd.Parameters.AddWithValue("@Direccion", Conductores.Direccion);
            cmd.Parameters.AddWithValue("@Sexo", Conductores.Sexo);
            cmd.Parameters.AddWithValue("@Sueldo", Conductores.Sueldo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarConductores(ConductoresEntidades Conductores)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_CONDUCTORES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Conductor", Conductores.Codigo);
            cmd.Parameters.AddWithValue("@Cedula", Conductores.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", Conductores.Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", Conductores.Apellidos);
            cmd.Parameters.AddWithValue("@Telefono", Conductores.Telefono);
            cmd.Parameters.AddWithValue("@Nac", Convert.ToDateTime(Conductores.F_Nacimiento));
            cmd.Parameters.AddWithValue("@Direccion", Conductores.Direccion);
            cmd.Parameters.AddWithValue("@Sexo", Conductores.Sexo);
            cmd.Parameters.AddWithValue("@Sueldo", Conductores.Sueldo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarConductores(ConductoresEntidades Conductores)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CONDUCTORES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Conductor", Conductores.Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
