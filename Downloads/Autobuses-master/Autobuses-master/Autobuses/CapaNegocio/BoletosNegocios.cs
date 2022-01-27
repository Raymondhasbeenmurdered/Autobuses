using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class BoletosNegocios
    {
        BoletosDatos objDatos = new BoletosDatos();

        public List<BoletosEntidades> ListandoBoletos(string buscar)
        {
            return objDatos.ListarBoletos(buscar);
        }

        public void InsertandoBoletos(BoletosEntidades boletos)
        {
            objDatos.InsertarBoletos(boletos);
        }

        public void EditandoBoletos(BoletosEntidades boletos)
        {
            objDatos.EditarBoletos(boletos);
        }

        public void EliminandoBoletos(BoletosEntidades boletos)
        {
            objDatos.EliminarBoletos(boletos);
        }
    }
}
