using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class BoletosEntidades
    {
        private int _id;
        private string _codigo;
        private int _Ruta;
        private double _precio;
        private string _fecha;
        private TimeSpan _hora;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public int Ruta { get => _Ruta; set => _Ruta = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public TimeSpan Hora { get => _hora; set => _hora = value; }
    }
}
