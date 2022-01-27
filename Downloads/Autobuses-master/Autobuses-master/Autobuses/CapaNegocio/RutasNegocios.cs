using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
   public  class RutasNegocios
    {

        RutasDatos objDatos = new RutasDatos();

        public List<RutasEntidades> ListarRuta(string buscar)
        {

            return objDatos.ListarRuta(buscar);

        }
        public void InsertandoRutas(RutasEntidades Ruta)
        {

            objDatos.InsertarRuta(Ruta);

        }

        public void EditandoRutas(RutasEntidades Ruta)
        {

            objDatos.EditarRuta(Ruta);

        }

        public void EliminandoRutas(RutasEntidades Ruta)
        {

            objDatos.EliminarRuta(Ruta);

        }
    }
}
