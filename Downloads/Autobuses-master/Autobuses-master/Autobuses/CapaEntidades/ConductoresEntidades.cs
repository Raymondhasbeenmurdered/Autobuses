using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ConductoresEntidades
    {
        private int _ID_Conductor;
        private string _Codigo;
        private string _Cedula;
        private string _Nombre;
        private string _Apellidos;
        private string _Telefono;
        private string _F_Nacimiento;
        private string _Direccion;
        private string _Sexo;
        private double _Sueldo;

        public int ID_Conductor { get => _ID_Conductor; set => _ID_Conductor = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string F_Nacimiento { get => _F_Nacimiento; set => _F_Nacimiento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public double Sueldo { get => _Sueldo; set => _Sueldo = value; }
    }
}
