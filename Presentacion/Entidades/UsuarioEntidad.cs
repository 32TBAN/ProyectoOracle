using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Entidades
{
    public class UsuarioEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nickname { get; set; }
        public string Contraseña { get; set; }
        public string Perfil { get; set; }
        public int NumPerfil { get; set; }
        public UsuarioEntidad()
        {

        }

        public UsuarioEntidad(int id, string nombre, string apellido, string nickname, string contraseña, string perfil, int numPerfil)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Nickname = nickname;
            Contraseña = contraseña;
            Perfil = perfil;
            NumPerfil = numPerfil;
        }
    }
}
