using Presentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion.Datos;

namespace Presentacion.Negocio
{
    public static class CalificacionNegocio
    {
        internal static CalificacionEntidad Calificar(CalificacionEntidad calificacionEntidad)
        {
            return CalificacionDatos.Calificar(calificacionEntidad);
        }

        public static CalificacionEntidad SolicitudCal(int id)
        {
            return CalificacionDatos.SolicitudCal(id);
        }
    }
}
