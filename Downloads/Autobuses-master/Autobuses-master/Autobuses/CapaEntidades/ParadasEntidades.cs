using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ParadasEntidades
    {
        private int _ID_Parada;
        private string _Codigo;
        private int _Ciudad;
        private string _Nombre;
        private string _Direccion;

        public int ID_Parada { get => _ID_Parada; set => _ID_Parada = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public int Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
    }
}