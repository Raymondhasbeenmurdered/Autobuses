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
    public class AutobusesDatos
    {

        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        public List<AutobusesEntidades> ListarAutobuses(string buscar)
        {

            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_AUTOBUSES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<AutobusesEntidades> Listar = new List<AutobusesEntidades>();

            while (LeerFilas.Read())
            {
                Listar.Add(new AutobusesEntidades
                {
                    ID_Autobus = LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Matricula = LeerFilas.GetString(2),
                    Conductor = LeerFilas.GetInt32(3),
                    Asistente = LeerFilas.GetInt32(4),
                    Marca = LeerFilas.GetString(5),
                    Modelo = (string)LeerFilas["Modelo"]

                });

            

            }

            Conexion.Close();
            LeerFilas.Close();

            return Listar;

        }

        public void InsertarAutobuses(AutobusesEntidades Autobuses)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTAR_AUTOBUSES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            Conexion.Open();

            cmd.Parameters.AddWithValue("@Matricula", Autobuses.Matricula);
            cmd.Parameters.AddWithValue("@ID_Conductor", Autobuses.Conductor);
            cmd.Parameters.AddWithValue("@ID_Asistente", Autobuses.Asistente);
            cmd.Parameters.AddWithValue("@Marca", Autobuses.Marca);
            cmd.Parameters.AddWithValue("@Modelo", Autobuses.Modelo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarAutobuses(AutobusesEntidades Autobuses)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_AUTOBUSES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Autobus", Autobuses.Codigo);
            cmd.Parameters.AddWithValue("@Matricula", Autobuses.Matricula);
            cmd.Parameters.AddWithValue("@ID_Conductor", Autobuses.Conductor);
            cmd.Parameters.AddWithValue("@ID_Asistente", Autobuses.Asistente);
            cmd.Parameters.AddWithValue("@Marca", Autobuses.Marca);
            cmd.Parameters.AddWithValue("@Modelo", Autobuses.Modelo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarAutobuses(AutobusesEntidades Autobuses)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_AUTOBUSES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Autobus", Autobuses.Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
