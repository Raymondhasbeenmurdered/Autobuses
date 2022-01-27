using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CiudadesEntidades
    {
        private int _ID_Ciudad;
        private string _Codigo;
        private string _Nombre;
        private string _Region;

        public int ID_Ciudad { get => _ID_Ciudad; set => _ID_Ciudad = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Region { get => _Region; set => _Region = value; }
    }
}
