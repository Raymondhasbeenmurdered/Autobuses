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
    public class ParadasDatos
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        public List<ParadasEntidades> ListarParadas(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_PARADAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<ParadasEntidades> Listar = new List<ParadasEntidades>();

            while (LeerFilas.Read())
            {
                Listar.Add(new ParadasEntidades
                {
                    ID_Parada = LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Ciudad = LeerFilas.GetInt32(2),
                    Nombre = LeerFilas.GetString(3),
                    Direccion = LeerFilas.GetString(4)
                });
            }

            Conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void InsertarParadas(ParadasEntidades Paradas)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_PARADAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@ID_Ciudad", Paradas.Ciudad);
            cmd.Parameters.AddWithValue("@Nombre", Paradas.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", Paradas.Direccion);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarParadas(ParadasEntidades Paradas)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_PARADAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Parada", Paradas.Codigo);
            cmd.Parameters.AddWithValue("@ID_Ciudad", Paradas.Ciudad);
            cmd.Parameters.AddWithValue("@Nombre", Paradas.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", Paradas.Direccion);


            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarParadas(ParadasEntidades Paradas)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_PARADAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Parada", Paradas.Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}