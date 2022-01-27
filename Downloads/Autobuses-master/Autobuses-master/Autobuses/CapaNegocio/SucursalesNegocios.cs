using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class SucursalesNegocios
    {
        SucursalesDatos objDatos = new SucursalesDatos();

        public List<SucursalesEntidades> ListarSucursales(string buscar)
        {
            return objDatos.ListarSucursales(buscar);
        }

        public void InsertarSucursales(SucursalesEntidades Sucursales)
        {
            objDatos.InsertarSucursales(Sucursales);
        }

        public void EditarSucursales(SucursalesEntidades Sucursales)
        {
            objDatos.EditarSucursales(Sucursales);
        }

        public void EliminarSucursales(SucursalesEntidades Sucursales)
        {
            objDatos.EliminarSucursales(Sucursales);
        }
    }
}
