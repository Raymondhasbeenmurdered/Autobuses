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
    public class BoletosDatos
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<BoletosEntidades> ListarBoletos(string buscar)
        {
            SqlDataReader Leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_BOLETOS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            Leer = cmd.ExecuteReader();

            List<BoletosEntidades> Listar = new List<BoletosEntidades>();

            while (Leer.Read())
            {
                Listar.Add(new BoletosEntidades
                {
                    Id = Leer.GetInt32(0),
                    Codigo = Leer.GetString(1),
                    Ruta = Leer.GetInt32(2),
                    Precio = Leer.GetDouble(3),
                    Fecha = Convert.ToDateTime(Leer["Fecha"]).ToString("dd'/'MM'/'yyyy"),
                    Hora = TimeSpan.Parse(Leer["Hora"].ToString())
                });
            }

            Conexion.Close();
            Leer.Close();

            return Listar;
        }

        public void InsertarBoletos(BoletosEntidades boletos)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_BOLETOS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@ID_Ruta", boletos.Ruta);
            cmd.Parameters.AddWithValue("@Precio", boletos.Precio);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarBoletos(BoletosEntidades boletos)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_BOLETOS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Boletos", boletos.Codigo);
            cmd.Parameters.AddWithValue("@Precio", boletos.Precio);
            cmd.Parameters.AddWithValue("@ID_Ruta", boletos.Ruta);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarBoletos(BoletosEntidades boletos)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_BOLETOS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Boletos", boletos.Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
