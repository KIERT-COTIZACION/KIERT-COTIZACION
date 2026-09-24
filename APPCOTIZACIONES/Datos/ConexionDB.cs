using System.Configuration;
using System.Data.SqlClient;

namespace COTIZACIONES.Datos
{
    public static class ConexionDB
    {
        public static string CadenaConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["CotizacionesDB"].ConnectionString;
            }
        }

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        /// <summary>
        /// Prueba rápida de conexión. Devuelve true si conecta bien.
        /// </summary>
        public static bool ProbarConexion(out string mensaje)
        {
            mensaje = "";
            try
            {
                using (var conn = ObtenerConexion())
                {
                    conn.Open();
                    mensaje = "✅ Conexión exitosa a SQL Server.";
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                mensaje = "❌ Error de conexión:\n" + ex.Message;
                return false;
            }
        }
    }
}