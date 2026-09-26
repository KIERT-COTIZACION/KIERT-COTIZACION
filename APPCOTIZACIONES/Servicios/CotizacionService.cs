using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;

namespace COTIZACIONES.Servicios
{
    public static class CotizacionService
    {
        // ==========================================================
        // GENERAR NÚMERO DE COTIZACIÓN
        // ==========================================================
        public static string GenerarNumero()
        {
            string baseNum = "COT-" + DateTime.Now.ToString("yyyyMMdd");
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Cotizaciones WHERE Numero LIKE @b + '%'", conn))
                {
                    cmd.Parameters.AddWithValue("@b", baseNum);
                    int n = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    return $"{baseNum}-{n:D4}";
                }
            }
        }

        // ==========================================================
        // GUARDAR COTIZACIÓN (cabecera + detalles)
        // ==========================================================
        public static int GuardarCotizacion(Cotizacion cot)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        string insertCot = @"
                            INSERT INTO Cotizaciones 
                                (Numero, Fecha, ClienteId, ClienteNombre, ClienteDocumento,
                                 Subtotal, IGV, Total, ConIGV, Observaciones, UsuarioId)
                            VALUES 
                                (@Num, GETDATE(), @CliId, @CliNom, @CliDoc,
                                 @Sub, @Igv, @Tot, @ConIgv, @Obs, @Usr);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        int cotId;
                        using (var cmd = new SqlCommand(insertCot, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@Num", cot.Numero ?? "");
                            cmd.Parameters.AddWithValue("@CliId", (object)cot.ClienteId ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@CliNom", (object)cot.ClienteNombre ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@CliDoc", (object)cot.ClienteDocumento ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Sub", cot.Subtotal);
                            cmd.Parameters.AddWithValue("@Igv", cot.Impuesto);
                            cmd.Parameters.AddWithValue("@Tot", cot.Total);
                            cmd.Parameters.AddWithValue("@ConIgv", cot.ConIGV);
                            cmd.Parameters.AddWithValue("@Obs", (object)cot.Observaciones ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@Usr", cot.UsuarioId);
                            cotId = (int)cmd.ExecuteScalar();
                        }

                        string insertDet = @"
                            INSERT INTO CotizacionDetalles 
                                (CotizacionId, ProductoId, Codigo, Descripcion,
                                 Talla, Color, Precio, Cantidad, Subtotal)
                            VALUES 
                                (@Cot, @Pid, @Cod, @Desc,
                                 @Talla, @Color, @Pre, @Cant, @Sub)";

                        foreach (var d in cot.Detalles)
                        {
                            using (var cmd = new SqlCommand(insertDet, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@Cot", cotId);
                                cmd.Parameters.AddWithValue("@Pid", d.ProductoId);
                                cmd.Parameters.AddWithValue("@Cod", (object)d.Codigo ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Desc", (object)d.Descripcion ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Talla", (object)d.Talla ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Color", (object)d.Color ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@Pre", d.Precio);
                                cmd.Parameters.AddWithValue("@Cant", d.Cantidad);
                                cmd.Parameters.AddWithValue("@Sub", d.Subtotal);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                        return cotId;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        // ==========================================================
        // OBTENER HISTORIAL (cabeceras + detalles)
        // ==========================================================
        public static List<Cotizacion> ObtenerHistorial(string filtro = "")
        {
            var lista = new List<Cotizacion>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string q = @"
                    SELECT Id, Numero, Fecha, ClienteId, ClienteNombre, ClienteDocumento,
                           Subtotal, IGV, Total, ConIGV, Observaciones, UsuarioId
                    FROM Cotizaciones
                    WHERE (@filtro = '' 
                           OR Numero LIKE '%' + @filtro + '%' 
                           OR ClienteNombre LIKE '%' + @filtro + '%'
                           OR ClienteDocumento LIKE '%' + @filtro + '%')
                    ORDER BY Fecha DESC";

                using (var cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@filtro", filtro ?? "");
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new Cotizacion
                            {
                                Id = Convert.ToInt32(r["Id"]),
                                Numero = r["Numero"].ToString(),
                                Fecha = Convert.ToDateTime(r["Fecha"]),
                                ClienteId = r["ClienteId"] != DBNull.Value
                                            ? (int?)Convert.ToInt32(r["ClienteId"]) : null,
                                ClienteNombre = r["ClienteNombre"]?.ToString(),
                                ClienteDocumento = r["ClienteDocumento"]?.ToString(),
                                ConIGV = r["ConIGV"] != DBNull.Value && Convert.ToBoolean(r["ConIGV"]),
                                Observaciones = r["Observaciones"]?.ToString(),
                                UsuarioId = r["UsuarioId"] != DBNull.Value
                                            ? Convert.ToInt32(r["UsuarioId"]) : 0,
                                Detalles = new List<DetalleCotizacion>()
                            });
                        }
                    }
                }

                // ✅ Cargar detalles de cada cotización
                foreach (var cot in lista)
                {
                    cot.Detalles = ObtenerDetalles(cot.Id);
                }
            }
            return lista;
        }

        // ==========================================================
        // OBTENER COTIZACIÓN COMPLETA POR NÚMERO
        // ==========================================================
        public static Cotizacion ObtenerPorNumero(string numero)
        {
            Cotizacion cot = null;

            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                string q = @"
                    SELECT Id, Numero, Fecha, ClienteId, ClienteNombre, ClienteDocumento,
                           Subtotal, IGV, Total, ConIGV, Observaciones, UsuarioId
                    FROM Cotizaciones
                    WHERE Numero = @num";

                using (var cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@num", numero ?? "");
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            cot = new Cotizacion
                            {
                                Id = Convert.ToInt32(r["Id"]),
                                Numero = r["Numero"].ToString(),
                                Fecha = Convert.ToDateTime(r["Fecha"]),
                                ClienteId = r["ClienteId"] != DBNull.Value
                                            ? (int?)Convert.ToInt32(r["ClienteId"]) : null,
                                ClienteNombre = r["ClienteNombre"]?.ToString(),
                                ClienteDocumento = r["ClienteDocumento"]?.ToString(),
                                ConIGV = r["ConIGV"] != DBNull.Value && Convert.ToBoolean(r["ConIGV"]),
                                Observaciones = r["Observaciones"]?.ToString(),
                                UsuarioId = r["UsuarioId"] != DBNull.Value
                                            ? Convert.ToInt32(r["UsuarioId"]) : 0,
                                Detalles = new List<DetalleCotizacion>()
                            };
                        }
                    }
                }

                if (cot != null)
                    cot.Detalles = ObtenerDetalles(cot.Id);
            }

            return cot;
        }

        // ==========================================================
        // OBTENER DETALLES DE UNA COTIZACIÓN
        // ==========================================================
        public static List<DetalleCotizacion> ObtenerDetalles(int cotizacionId)
        {
            var lista = new List<DetalleCotizacion>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string q = @"
                    SELECT ProductoId, Codigo, Descripcion, Talla, Color, Precio, Cantidad
                    FROM CotizacionDetalles
                    WHERE CotizacionId = @id
                    ORDER BY Id";

                using (var cmd = new SqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@id", cotizacionId);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new DetalleCotizacion
                            {
                                ProductoId = r["ProductoId"] != DBNull.Value
                                             ? Convert.ToInt32(r["ProductoId"]) : 0,
                                Codigo = r["Codigo"]?.ToString(),
                                Descripcion = r["Descripcion"]?.ToString(),
                                Talla = r["Talla"]?.ToString(),
                                Color = r["Color"]?.ToString(),
                                Precio = r["Precio"] != DBNull.Value
                                         ? Convert.ToDecimal(r["Precio"]) : 0m,
                                Cantidad = r["Cantidad"] != DBNull.Value
                                           ? Convert.ToInt32(r["Cantidad"]) : 0
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}