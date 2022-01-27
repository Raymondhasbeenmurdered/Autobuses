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
    public class IntermediasDatos
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<IntermediasEntidades> ListarIntermedias(string buscar)
        {
            SqlDataReader Leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_PARADASINTER", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            Leer = cmd.ExecuteReader();

            List<IntermediasEntidades> Listar = new List<IntermediasEntidades>();

            while (Leer.Read())
            {
                Listar.Add(new IntermediasEntidades
                {
                    Id = Leer.GetInt32(0),
                    Codigo = Leer.GetString(1),
                    Nombre = Leer.GetString(2),
                    Direccion = Leer.GetString(3),
                    Tipo = Leer.GetString(4)
                });
            }

            Conexion.Close();
            Leer.Close();

            return Listar;
        }

        public void InsertarParadaINTER(IntermediasEntidades intermedias)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_PARADASINTER", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", intermedias.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", intermedias.Direccion);
            cmd.Parameters.AddWithValue("@Tipo", intermedias.Tipo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarParadaINTER(IntermediasEntidades intermedias)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_PARADASINTER", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_ParadasINTER", intermedias.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", intermedias.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", intermedias.Direccion);
            cmd.Parameters.AddWithValue("@Tipo", intermedias.Tipo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarParadaINTER(IntermediasEntidades intermedias)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_PARADASINTER", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_ParadasINTER", intermedias.Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}


