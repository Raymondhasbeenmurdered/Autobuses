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
    public class UsuariosDatos
    {

        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString);

        public List<UsuariosEntidades> ListarUsuarios(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_USUARIOS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<UsuariosEntidades> Listar = new List<UsuariosEntidades>();

            while (LeerFilas.Read())
            {
                Listar.Add(new UsuariosEntidades
                {
                    ID_Usuario = LeerFilas.GetInt32(0),
                    Codigo = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Contraseña = LeerFilas.GetString(3),
                    Rol = LeerFilas.GetString(4)
                });
            }

            Conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void InsertarUsuario(UsuariosEntidades Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_USUARIOS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Usuario.Nombre);
            cmd.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña);
            cmd.Parameters.AddWithValue("@Rol", Usuario.Rol);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarUsuario(UsuariosEntidades Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_USUARIOS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("Cod_Usuario", Usuario.Codigo);
            cmd.Parameters.AddWithValue("Nombre", Usuario.Nombre);
            cmd.Parameters.AddWithValue("Contraseña", Usuario.Contraseña);
            cmd.Parameters.AddWithValue("Rol", Usuario.Rol);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarUsuario(UsuariosEntidades Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_USUARIOS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@Cod_Usuario", Usuario.Codigo);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
