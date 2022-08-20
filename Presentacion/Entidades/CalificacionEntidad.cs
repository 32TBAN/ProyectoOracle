using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Entidades
{
    public class CalificacionEntidad
    {
        public int IdSol { get; set; }
        public int Calificacion { get; set; }
        public string Comentario { get; set; }
        public CalificacionEntidad()
        {

        }

        public CalificacionEntidad(int idSol, int calificacion, string comentario)
        {
            IdSol = idSol;
            Calificacion = calificacion;
            Comentario = comentario;
        }
    }
}
