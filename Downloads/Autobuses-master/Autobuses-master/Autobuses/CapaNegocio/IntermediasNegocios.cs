using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class IntermediasNegocios
    {
        IntermediasDatos objDatos = new IntermediasDatos();

        public List<IntermediasEntidades> ListandoIntermedias(string buscar)
        {
            return objDatos.ListarIntermedias(buscar);
        }

        public void InsertandoIntermedias(IntermediasEntidades intermedias)
        {
            objDatos.InsertarParadaINTER(intermedias);
        }

        public void EditandoIntermedias(IntermediasEntidades intermedias)
        {
            objDatos.EditarParadaINTER(intermedias);
        }

        public void EliminandoIntermedias(IntermediasEntidades intermedias)
        {
            objDatos.EliminarParadaINTER(intermedias);
        }
    }
}

