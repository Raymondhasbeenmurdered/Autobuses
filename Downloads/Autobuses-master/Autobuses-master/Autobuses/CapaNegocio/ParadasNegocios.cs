using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class ParadasNegocios
    {
        ParadasDatos objDatos = new ParadasDatos();

        public List<ParadasEntidades> ListarParadas(string buscar)
        {
            return objDatos.ListarParadas(buscar);
        }

        public void InsertarParadas(ParadasEntidades Paradas)
        {
            objDatos.InsertarParadas(Paradas);
        }

        public void EditarParadas(ParadasEntidades Paradas)
        {
            objDatos.EditarParadas(Paradas);
        }

        public void EliminarParadas(ParadasEntidades Paradas)
        {
            objDatos.EliminarParadas(Paradas);
        }
    }
}