using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class SucursalesEntidades
    {
        private int _ID_Sucursal;
        private string _Codigo;
        private int _Ciudad;
        private string _Direccion;

        public int ID_Sucursal { get => _ID_Sucursal; set => _ID_Sucursal = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public int Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
    }
}
