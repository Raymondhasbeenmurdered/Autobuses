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
    public class AsistentesNegocios
    {
        AsistentesDatos objAsistentesDatos = new AsistentesDatos();

        public List<AsistentesEntidades> BuscandoAsistentes(string Asistentes)
        {
            return objAsistentesDatos.BuscarAsistentes(Asistentes);
        }

        public void InsertandoAsistentes(AsistentesEntidades Asistentes)
        {
            objAsistentesDatos.InsertarAsistentes(Asistentes);
        }
        public void EditandoAsistentes(AsistentesEntidades Asistentes)
        {
            objAsistentesDatos.EditarAsistentes(Asistentes);
        }
        public void EliminandoAsistentes(AsistentesEntidades Asistentes)
        {
            objAsistentesDatos.EliminarAsistentes(Asistentes);
        }

    }
}