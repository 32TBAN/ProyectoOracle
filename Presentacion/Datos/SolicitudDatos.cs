using Presentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Datos
{
    public class SolicitudDatos : Conexion
    {
        public static List<SolicitudEntidad> ListaSolicitudesCompleta()
        {
            try
            {
                List<SolicitudEntidad> listaSolicitud = new List<SolicitudEntidad>();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("ListaUsuariosC", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("buscar", OracleType.Cursor).Direction = ParameterDirection.Output;

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int idTec = 0;
                                if (dr["ID_TEC"].ToString() == "")
                                    idTec = 0;
                                else
                                    idTec = Convert.ToInt32(dr["ID_TEC"].ToString());

                                DateTime fecuaFin = DateTime.Now;
                                if (dr["FEC_FIN_SOL"].ToString() == "")
                                     fecuaFin = DateTime.Now;
                                else
                                     fecuaFin = (DateTime)(dr["FEC_FIN_SOL"]);


                                double t = 0;
                                if (dr["TOT_SOL"].ToString() == "")
                                    t = 0;
                                else
                                    Convert.ToDouble(dr["TOT_SOL"].ToString());

                                listaSolicitud.Add(new SolicitudEntidad(
                                    Convert.ToInt32(dr["ID_SOL"].ToString()),
                                    Convert.ToInt32(dr["ID_USU"].ToString()),
                                    idTec, 
                                    dr["ASU_SOL"].ToString(),
                                    dr["DES_SOL"].ToString(),
                                    dr["URG_SOL"].ToString(),
                                    dr["DIS_SOL"].ToString(),
                                    dr["ARE_SOL"].ToString(),
                                    (DateTime)(dr["FEC_ENV_SOL"]),
                                    fecuaFin,
                                    dr["RES_TEC"].ToString(),
                                    t,
                                    Convert.ToInt16(dr["EST_SOL"].ToString())));
                            }
                        }

                    }

                }
                return listaSolicitud;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static SolicitudEntidad BuscarSolicitud(int idSolicitud)
        {
            try
            {
                SolicitudEntidad solicitud = new SolicitudEntidad();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("BuscarSolicitudID", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idS", OracleType.Number).Value = idSolicitud;
                        cmd.Parameters.Add("buscar", OracleType.Cursor).Direction = ParameterDirection.Output;

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                solicitud.Id = Convert.ToInt32(dr["ID_SOL"].ToString());
                                solicitud.IdUsuario = Convert.ToInt32(dr["ID_USU"].ToString());

                                if (dr["ID_TEC"].ToString() == "")
                                    solicitud.IdTecnico = 0;
                                else
                                    solicitud.IdTecnico = Convert.ToInt32(dr["ID_TEC"].ToString());

                                solicitud.Asunto = dr["ASU_SOL"].ToString();
                                solicitud.Descripcion = dr["DES_SOL"].ToString();
                                solicitud.Urgencia = dr["URG_SOL"].ToString();
                                solicitud.Dispositivo = dr["DIS_SOL"].ToString();
                                solicitud.Area = dr["ARE_SOL"].ToString();
                                solicitud.FechaEnvio = (DateTime)(dr["FEC_ENV_SOL"]);

                                if (dr["FEC_FIN_SOL"].ToString() == "")
                                    solicitud.FechaEntrega = DateTime.Now;
                                else
                                    solicitud.FechaEntrega = (DateTime)(dr["FEC_FIN_SOL"]);

                                solicitud.Respuesta = dr["RES_TEC"].ToString();

                                if (dr["TOT_SOL"].ToString() == "")
                                    solicitud.Total = 0;
                                else
                                    solicitud.Total = Convert.ToDouble(dr["TOT_SOL"].ToString());

                                solicitud.Estado = Convert.ToInt16(dr["EST_SOL"].ToString());
                            }
                        }

                    }
                }
                return solicitud;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static SolicitudEntidad Actualizar(SolicitudEntidad solicitudEntidad)
        {
            try
            {
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("ActualizarSolicitud", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idSol", OracleType.Number).Value = solicitudEntidad.Id;
                        cmd.Parameters.Add("idTec", OracleType.Number).Value = solicitudEntidad.IdTecnico;
                        cmd.Parameters.Add("asuntoG", OracleType.NVarChar).Value = solicitudEntidad.Asunto;
                        cmd.Parameters.Add("descripcionG", OracleType.NVarChar).Value = solicitudEntidad.Descripcion;
                        cmd.Parameters.Add("urgenciaG", OracleType.NVarChar).Value = solicitudEntidad.Urgencia;
                        cmd.Parameters.Add("dispocitivoG", OracleType.NVarChar).Value = solicitudEntidad.Dispositivo;
                        cmd.Parameters.Add("areaG", OracleType.NVarChar).Value = solicitudEntidad.Area;
                        cmd.Parameters.Add("fechaEnv", OracleType.DateTime).Value = solicitudEntidad.FechaEnvio;
                        cmd.Parameters.Add("fechaFin", OracleType.DateTime).Value = solicitudEntidad.FechaEntrega;
                        cmd.Parameters.Add("resTec", OracleType.NVarChar).Value = solicitudEntidad.Respuesta;
                        cmd.Parameters.Add("totalG", OracleType.Number).Value = solicitudEntidad.Total;
                        cmd.Parameters.Add("estadoG", OracleType.Number).Value = Convert.ToInt16(solicitudEntidad.Estado);

                        cmd.ExecuteNonQuery();
                    }
                }
                return solicitudEntidad;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static SolicitudEntidad Guardar(SolicitudEntidad solicitudEntidad)
        {
            try
            {
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("GuardarSolicitud", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("id_usuG", OracleType.Number).Value = solicitudEntidad.IdUsuario;
                        cmd.Parameters.Add("asuntoG", OracleType.NVarChar).Value = solicitudEntidad.Asunto;
                        cmd.Parameters.Add("descripcionG", OracleType.NVarChar).Value = solicitudEntidad.Descripcion;
                        cmd.Parameters.Add("urgenciaG", OracleType.NVarChar).Value = solicitudEntidad.Urgencia;
                        cmd.Parameters.Add("dispocitivoG", OracleType.NVarChar).Value = solicitudEntidad.Dispositivo;
                        cmd.Parameters.Add("areaG", OracleType.NVarChar).Value = solicitudEntidad.Area;
                        cmd.Parameters.Add("fechaG", OracleType.DateTime).Value = solicitudEntidad.FechaEnvio;
                        cmd.Parameters.Add("estadoG", OracleType.Number).Value = Convert.ToInt16(solicitudEntidad.Estado);

                        cmd.ExecuteNonQuery();
                    }
                }
                return solicitudEntidad;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool EliminarSolicitud(int id)
        {
            try
            {
                int filasAfectadas = 0;
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("EliminarSolicitud", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idS", OracleType.Number).Value = id;

                        filasAfectadas = Convert.ToInt32(cmd.ExecuteNonQuery());
                    }
                }
                return filasAfectadas > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
