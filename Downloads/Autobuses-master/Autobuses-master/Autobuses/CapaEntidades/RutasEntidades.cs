using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class RutasEntidades
    {
        private int _ID_Ruta;
        private string _Codigo;
        private string _Nombre;
        private string _Partida;
        private string _Destino;
        private int _ParadaINTER;
        private int _Ciudad;
        private int _Autobus;

        public int ID_Ruta { get => _ID_Ruta; set => _ID_Ruta = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Partida { get => _Partida; set => _Partida = value; }
        public string Destino { get => _Destino; set => _Destino = value; }
        public int ParadaINTER { get => _ParadaINTER; set => _ParadaINTER = value; }
        public int Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public int Autobus { get => _Autobus; set => _Autobus = value; }
    }
}
