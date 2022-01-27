using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class ConductoresNegocios
    {
        ConductoresDatos objConductoresDatos = new ConductoresDatos();

        public List<ConductoresEntidades> BuscandoConductores(string Conductores)
        {
            return objConductoresDatos.BuscarConductores(Conductores);
        }

        public void InsertandoConductores(ConductoresEntidades Conductores)
        {
            objConductoresDatos.InsertarConductores(Conductores);
        }
        public void EditandoConductores(ConductoresEntidades Conductores)
        {
            objConductoresDatos.EditarConductores(Conductores);
        }
        public void EliminandoConductores(ConductoresEntidades Conductores)
        {
            objConductoresDatos.EliminarConductores(Conductores);
        }

    }
}
