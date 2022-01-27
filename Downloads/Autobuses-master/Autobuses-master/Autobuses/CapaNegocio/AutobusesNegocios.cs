using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{

    public class AutobusesNegocios
    {
        AutobusesDatos objDatos = new AutobusesDatos();

        public List<AutobusesEntidades> ListarAutobuses(string buscar)
        {

            return objDatos.ListarAutobuses(buscar);

        }

        public void InsertarAutobuses(AutobusesEntidades Autobuses)
        {

            objDatos.InsertarAutobuses(Autobuses);

        }

        public void EditandoAutobuses(AutobusesEntidades Autobuses)
        {

            objDatos.EditarAutobuses(Autobuses);

        }

        public void EliminandoAutobuses(AutobusesEntidades Autobuses)
        {

            objDatos.EliminarAutobuses(Autobuses);

        }

    }
}
