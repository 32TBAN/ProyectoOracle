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
    public class CalificacionDatos : Conexion
    {
        public static CalificacionEntidad Calificar(CalificacionEntidad calificacionEntidad)
        {
            try
            {
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("GuardarCalificacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idS", OracleType.Number).Value = calificacionEntidad.IdSol;
                        cmd.Parameters.Add("cali", OracleType.Number).Value = calificacionEntidad.Calificacion;
                        cmd.Parameters.Add("comen", OracleType.NVarChar).Value = calificacionEntidad.Comentario;

                        cmd.ExecuteNonQuery();
                    }
                }
                return calificacionEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static CalificacionEntidad SolicitudCal(int id)
        {
            try
            {
                CalificacionEntidad calificacionEntidad = new CalificacionEntidad();
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("BuscarSolicitud", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idS", OracleType.Number).Value = id;
                        cmd.Parameters.Add("buscar", OracleType.Cursor).Direction = ParameterDirection.Output;

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                calificacionEntidad.IdSol = Convert.ToInt32(dr["ID_SOL"].ToString());
                                calificacionEntidad.Calificacion = Convert.ToInt32(dr["CAL_SER"].ToString());
                                calificacionEntidad.Comentario = dr["COM_SER"].ToString();
                            }

                        }
                    }
                }
                return calificacionEntidad;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
