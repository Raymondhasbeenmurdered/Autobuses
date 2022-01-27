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
    public class SucursalesDatos
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        public List<SucursalesEntidades> ListarSucursales(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_SUCURSALES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<SucursalesEntidades> Listar = new List<SucursalesEntidades>();

            while (LeerFilas.Read())
            {
                Listar.Add(new SucursalesEntidades
                {
                    ID_Sucursal = LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Ciudad = LeerFilas.GetInt32(2),
                    Direccion = LeerFilas.GetString(3)
                });
            }

            Conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void InsertarSucursales(SucursalesEntidades Sucursales)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_SUCURSALES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@ID_Ciudad", Sucursales.Ciudad);
            cmd.Parameters.AddWithValue("@Direccion", Sucursales.Direccion);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarSucursales(SucursalesEntidades Sucursales)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_SUCURSALES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Sucursal", Sucursales.Codigo);
            cmd.Parameters.AddWithValue("@ID_Ciudad", Sucursales.Ciudad);
            cmd.Parameters.AddWithValue("@Direccion", Sucursales.Direccion);


            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarSucursales(SucursalesEntidades Sucursales)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_SUCURSALES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Sucursal", Sucursales.@Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
