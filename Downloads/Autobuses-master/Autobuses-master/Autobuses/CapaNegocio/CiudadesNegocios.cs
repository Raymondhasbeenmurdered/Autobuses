using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CiudadesNegocios
    {
        CiudadesDatos objDatos = new CiudadesDatos();

        public List<CiudadesEntidades>ListarCiudades(string buscar)
        {
            return objDatos.ListarCiudades(buscar);
        }

        public void InsertarCiudad(CiudadesEntidades Ciudad)
        {
            objDatos.InsertarCiudad(Ciudad);
        }

        public void EditarCiudad(CiudadesEntidades Ciudad)
        {
            objDatos.EditarCiudad(Ciudad);
        }

        public void EliminarCiudad(CiudadesEntidades Ciudad)
        {
            objDatos.EliminarCiudad(Ciudad);
        }
    }
}
