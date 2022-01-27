using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class IntermediasEntidades
    {
        private int _Id;
        private string _Codigo;
        private string _Nombre;
        private string _Direccion;
        private string _Tipo;

        public int Id { get => _Id; set => _Id = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
    }
}

