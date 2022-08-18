using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Entidades
{
    public class TipoPerfilEntidad
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public TipoPerfilEntidad()
        {

        }

        public TipoPerfilEntidad(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }
    }
}
