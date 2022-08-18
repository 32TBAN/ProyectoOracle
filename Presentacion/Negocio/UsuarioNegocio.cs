using Presentacion.Datos;
using Presentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Negocio
{
    public static class UsuarioNegocio
    {
        public static UsuarioEntidad BuscarUsuarioNickname(string texts)
        {
            return UsuarioDatos.BuscarUsuarioNickname(texts);
        }
        public static UsuarioEntidad Guardar(UsuarioEntidad usuarioEntidad)
        {
            if (usuarioEntidad.Id == 0)
                return UsuarioDatos.Guardar(usuarioEntidad);
            else
                return UsuarioDatos.Actualizar(usuarioEntidad);

        }

        public static UsuarioEntidad BuscarUsuarioID(int idTecnico)
        {
            return UsuarioDatos.BuscarUsuarioID(idTecnico);
        }

        public static List<UsuarioEntidad> ListaUsuarios()
        {
            return UsuarioDatos.ListaUsuarios();
        }
    }
}
