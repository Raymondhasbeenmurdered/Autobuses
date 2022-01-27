using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class AutobusesEntidades
    {

        private int _ID_Autobus;
        private string _Codigo;
        private string _Matricula;
        private int _Conductor;
        private int _Asistente;
        private string _Marca;
        private string _Modelo;

        public int ID_Autobus { get => _ID_Autobus; set => _ID_Autobus = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Matricula { get => _Matricula; set => _Matricula = value; }
        public int Conductor { get => _Conductor; set => _Conductor = value; }
        public int Asistente { get => _Asistente; set => _Asistente = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
    }

}
