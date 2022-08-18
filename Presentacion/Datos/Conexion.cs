using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Datos
{
    public abstract class Conexion
    {
        protected static OracleConnection ObtenerConexion()
        {
            return new OracleConnection("Data Source=xe;User ID=PROYECTOORACLE;Password=PROYECTOORACLE;Unicode=True");
        }
    }
}
