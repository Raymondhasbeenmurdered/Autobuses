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
    public class RutasDatos
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        public List<RutasEntidades> ListarRuta(string buscar){

            SqlDataReader LeerFilas;

            SqlCommand cmd = new SqlCommand("SP_BUSCAR_RUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<RutasEntidades> Listar = new List<RutasEntidades>();

            while (LeerFilas.Read())
            {
                Listar.Add(new RutasEntidades
                {
                    ID_Ruta = LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Partida = LeerFilas.GetString(3),
                    Destino = LeerFilas.GetString(4),
                    ParadaINTER = LeerFilas.GetInt32(5),
                    Ciudad = LeerFilas.GetInt32(6),
                    Autobus = LeerFilas.GetInt32(7)
                });
            }

            Conexion.Close();
            LeerFilas.Close();

            return Listar;

            }


        public void InsertarRuta(RutasEntidades Ruta)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_RUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Ruta.Nombre);
            cmd.Parameters.AddWithValue("@Partida", Ruta.Partida);
            cmd.Parameters.AddWithValue("@Destino", Ruta.Destino);
            cmd.Parameters.AddWithValue("@ID_ParadaINTER", Ruta.ParadaINTER);
            cmd.Parameters.AddWithValue("@ID_Ciudad", Ruta.Ciudad);
            cmd.Parameters.AddWithValue("@ID_Autobus", Ruta.Autobus);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarRuta(RutasEntidades Ruta)
        {

            SqlCommand cmd = new SqlCommand("SP_EDITAR_RUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Ruta", Ruta.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", Ruta.Nombre);
            cmd.Parameters.AddWithValue("@Partida", Ruta.Partida);
            cmd.Parameters.AddWithValue("@Destino", Ruta.Destino);
            cmd.Parameters.AddWithValue("@ID_ParadaINTER", Ruta.ParadaINTER);
            cmd.Parameters.AddWithValue("@ID_Ciudad", Ruta.Ciudad);
            cmd.Parameters.AddWithValue("@ID_Autobus", Ruta.Autobus);

            cmd.ExecuteNonQuery();
            Conexion.Close();

        }

        public void EliminarRuta (RutasEntidades Ruta)
        {

            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_RUTAS ", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Ruta", Ruta.Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();

        }
    }
}
