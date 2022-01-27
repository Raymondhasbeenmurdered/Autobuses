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
    public class CiudadesDatos
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        public List<CiudadesEntidades>ListarCiudades(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_CIUDADES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<CiudadesEntidades> Listar = new List<CiudadesEntidades>();

            while (LeerFilas.Read())
            {
                Listar.Add(new CiudadesEntidades
                {
                    ID_Ciudad = LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Region = LeerFilas.GetString(3)
                });
            }

            Conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void InsertarCiudad(CiudadesEntidades Ciudad)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_CIUDADES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Ciudad.Nombre);
            cmd.Parameters.AddWithValue("@Region", Ciudad.Region);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarCiudad(CiudadesEntidades Ciudad)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_CIUDADES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Ciudad", Ciudad.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", Ciudad.Nombre);
            cmd.Parameters.AddWithValue("@Region", Ciudad.Region);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarCiudad(CiudadesEntidades Ciudad)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CIUDADES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Ciudad", Ciudad.Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
