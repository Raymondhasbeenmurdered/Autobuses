using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class UsuariosEntidades
    {

        private int _ID_Usuario;
        private string _Codigo;
        private string _Nombre;
        private string _Contraseña;
        private string _Rol;

        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string Rol { get => _Rol; set => _Rol = value; }
    }
}
