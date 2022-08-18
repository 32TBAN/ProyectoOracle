using Presentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Datos
{
    public class UsuarioDatos : Conexion
    {
        public static UsuarioEntidad BuscarUsuarioNickname(string texts)
        {
            try
            {
                UsuarioEntidad usuarioEntidad = new UsuarioEntidad();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("BuscarUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("nickname", OracleType.VarChar).Value = texts;
                        cmd.Parameters.Add("buscar", OracleType.Cursor).Direction = ParameterDirection.Output;

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                usuarioEntidad.Id = Convert.ToInt16(dr["ID_USU"].ToString());
                                usuarioEntidad.Nombre = dr["NOM_USU"].ToString();
                                usuarioEntidad.Apellido = dr["APE_USU"].ToString();
                                usuarioEntidad.Contraseña = dr["CON_USU"].ToString();
                                usuarioEntidad.Nickname = dr["NICKNAME"].ToString();
                                usuarioEntidad.NumPerfil = Convert.ToInt16(dr["TIP_USU"].ToString());
                            }
                        }

                    }
                }


                foreach (var item in ListaTipoPerfil())
                {
                    if (item.Id == usuarioEntidad.NumPerfil)
                    {
                        usuarioEntidad.Perfil = item.Tipo;
                    }
                }

                return usuarioEntidad;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private static List<TipoPerfilEntidad> ListaTipoPerfil()
        {
            try
            {
                List<TipoPerfilEntidad> tipoPerfilEntidad = new List<TipoPerfilEntidad>();
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("TipoPerfil", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("salida", OracleType.Cursor).Direction = ParameterDirection.Output;
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                tipoPerfilEntidad.Add(new TipoPerfilEntidad(
                                    Convert.ToInt16(dr["ID_TIP"].ToString()), dr["NOM_TIPO"].ToString()));
                            }
                        }
                    }
                }
                return tipoPerfilEntidad;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static UsuarioEntidad Actualizar(UsuarioEntidad usuarioEntidad)
        {
            try
            {
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("ActualizarUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idG", OracleType.Number).Value = usuarioEntidad.Id;
                        cmd.Parameters.Add("nombreG", OracleType.VarChar).Value = usuarioEntidad.Nombre;
                        cmd.Parameters.Add("apellidoG", OracleType.VarChar).Value = usuarioEntidad.Apellido;
                        cmd.Parameters.Add("nicknameG", OracleType.VarChar).Value = usuarioEntidad.Nickname;
                        cmd.Parameters.Add("perfilG", OracleType.Number).Value = usuarioEntidad.NumPerfil;
                        cmd.Parameters.Add("contraseG", OracleType.VarChar).Value = usuarioEntidad.Contraseña;
                        cmd.ExecuteNonQuery();
                    }
                }
                return usuarioEntidad;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public static UsuarioEntidad Guardar(UsuarioEntidad usuarioEntidad)
        {
            try
            {
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("GuardarUsuarios", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("nombreG", OracleType.VarChar).Value = usuarioEntidad.Nombre;
                        cmd.Parameters.Add("apellidoG", OracleType.VarChar).Value = usuarioEntidad.Apellido;
                        cmd.Parameters.Add("nicknameG", OracleType.VarChar).Value = usuarioEntidad.Nickname;
                        cmd.Parameters.Add("perfilG", OracleType.Number).Value = usuarioEntidad.NumPerfil;
                        cmd.Parameters.Add("contraseG", OracleType.VarChar).Value = usuarioEntidad.Contraseña;

                        cmd.ExecuteNonQuery();
                    }
                }
                return usuarioEntidad;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static UsuarioEntidad BuscarUsuarioID(int idTecnico)
        {
            try
            {
                UsuarioEntidad usuarioEntidad = new UsuarioEntidad();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("BuscarUsuarioID", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idU", OracleType.Number).Value = idTecnico;
                        cmd.Parameters.Add("buscar", OracleType.Cursor).Direction = ParameterDirection.Output;

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                usuarioEntidad.Id = Convert.ToInt16(dr["ID_USU"].ToString());
                                usuarioEntidad.Nombre = dr["NOM_USU"].ToString();
                                usuarioEntidad.Apellido = dr["APE_USU"].ToString();
                                usuarioEntidad.Contraseña = dr["CON_USU"].ToString();
                                usuarioEntidad.Nickname = dr["NICKNAME"].ToString();
                                usuarioEntidad.NumPerfil = Convert.ToInt16(dr["TIP_USU"].ToString());
                            }
                        }

                    }
                }

                foreach (var item in ListaTipoPerfil())
                {
                    if (item.Id == usuarioEntidad.NumPerfil)
                    {
                        usuarioEntidad.Perfil = item.Tipo;
                    }
                }

                return usuarioEntidad;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<UsuarioEntidad> ListaUsuarios()
        {
            try
            {
                List<UsuarioEntidad> listaUsuarioEntidad = new List<UsuarioEntidad>();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("ListaUsuarios", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("buscar", OracleType.Cursor).Direction = ParameterDirection.Output;

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string tipo = "";
                                foreach (var item in ListaTipoPerfil())
                                {
                                    if (item.Id == Convert.ToInt16(dr["TIP_USU"].ToString()))
                                    {
                                        tipo = item.Tipo;
                                    }
                                }
                                listaUsuarioEntidad.Add(new UsuarioEntidad(
                                Convert.ToInt16(dr["ID_USU"].ToString()),
                                dr["NOM_USU"].ToString(),
                                dr["APE_USU"].ToString(),
                                dr["NICKNAME"].ToString(),
                                dr["CON_USU"].ToString(),
                                tipo,
                                Convert.ToInt16(dr["TIP_USU"].ToString())));
                            }

                        }

                    }
                }

                return listaUsuarioEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

