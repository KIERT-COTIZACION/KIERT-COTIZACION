using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;

namespace COTIZACIONES.Servicios
{
    public static class EmpresaService
    {
        // ================= OBTENER CONFIGURACIÓN =================
        public static EmpresaConfig ObtenerConfiguracion()
        {
            var config = new EmpresaConfig();
            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();

                    // Datos generales
                    using (var cmd = new SqlCommand(
                        @"SELECT TOP 1 Id, NombreEmpresa, Ruc, Direccion, Telefono1, Telefono2,
                                 Email, Instagram, Facebook, SitioWeb, LogoImage, LogoNombreArchivo,
                                 NotasCotizacion, ValidezDias, TiempoEntrega, PorcentajeIGV, Moneda,
                                 ColorPrimario, ColorSecundario, ColorTerciario, ColorFondo
                          FROM EmpresaConfig", conn))
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            config.Id = Convert.ToInt32(r["Id"]);
                            config.NombreEmpresa = r["NombreEmpresa"]?.ToString() ?? "MI EMPRESA";
                            config.Ruc = r["Ruc"]?.ToString();
                            config.Direccion = r["Direccion"]?.ToString();
                            config.Telefono1 = r["Telefono1"]?.ToString();
                            config.Telefono2 = r["Telefono2"]?.ToString();
                            config.Email = r["Email"]?.ToString();
                            config.Instagram = r["Instagram"]?.ToString();
                            config.Facebook = r["Facebook"]?.ToString();
                            config.SitioWeb = r["SitioWeb"]?.ToString();

                            // ✅ LOGO — leer bytes correctamente
                            if (r["LogoImage"] != DBNull.Value)
                                config.LogoImage = (byte[])r["LogoImage"];

                            config.LogoNombreArchivo = r["LogoNombreArchivo"]?.ToString();
                            config.NotasCotizacion = r["NotasCotizacion"]?.ToString();

                            config.ValidezDias = r["ValidezDias"] != DBNull.Value
                                ? Convert.ToInt32(r["ValidezDias"]) : 30;
                            config.TiempoEntrega = r["TiempoEntrega"]?.ToString()
                                ?? "5-10 días hábiles";
                            config.PorcentajeIGV = r["PorcentajeIGV"] != DBNull.Value
                                ? Convert.ToDecimal(r["PorcentajeIGV"]) : 18m;
                            config.Moneda = r["Moneda"]?.ToString() ?? "S/";

                            config.ColorPrimario = r["ColorPrimario"]?.ToString() ?? "#69383e";
                            config.ColorSecundario = r["ColorSecundario"]?.ToString() ?? "#a6a5a0";
                            config.ColorTerciario = r["ColorTerciario"]?.ToString() ?? "#5d5a55";
                            config.ColorFondo = r["ColorFondo"]?.ToString() ?? "#fefefe";
                        }
                    }

                    // Datos bancarios
                    config.DatosBancarios = new List<BancoInfo>();
                    using (var cmd = new SqlCommand(
                        "SELECT Banco, Cuenta, CCI FROM Bancos ORDER BY Id", conn))
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            config.DatosBancarios.Add(new BancoInfo
                            {
                                Banco = r["Banco"]?.ToString(),
                                Cuenta = r["Cuenta"]?.ToString(),
                                CCI = r["CCI"]?.ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error ObtenerConfiguracion: " + ex.Message);
            }
            return config;
        }

        // ================= GUARDAR CONFIGURACIÓN =================
        public static bool GuardarConfiguracion(EmpresaConfig config)
        {
            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();

                    // Verificar si existe la fila
                    int existe = 0;
                    using (var cmd = new SqlCommand("SELECT COUNT(*) FROM EmpresaConfig", conn))
                        existe = Convert.ToInt32(cmd.ExecuteScalar());

                    if (existe == 0)
                    {
                        // INSERT
                        string q = @"INSERT INTO EmpresaConfig 
                                     (NombreEmpresa, Ruc, Direccion, Telefono1, Telefono2, Email,
                                      Instagram, Facebook, SitioWeb, LogoImage, LogoNombreArchivo,
                                      NotasCotizacion, ValidezDias, TiempoEntrega, PorcentajeIGV, Moneda,
                                      ColorPrimario, ColorSecundario, ColorTerciario, ColorFondo)
                                     VALUES 
                                     (@n, @r, @d, @t1, @t2, @e, @i, @f, @w, @logo, @logoNom,
                                      @notas, @val, @tiempo, @igv, @mon, @cp, @cs, @ct, @cf)";
                        using (var cmd = new SqlCommand(q, conn))
                        {
                            AgregarParametros(cmd, config);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // UPDATE
                        string q = @"UPDATE EmpresaConfig SET 
                                     NombreEmpresa=@n, Ruc=@r, Direccion=@d, Telefono1=@t1, Telefono2=@t2,
                                     Email=@e, Instagram=@i, Facebook=@f, SitioWeb=@w,
                                     LogoImage=@logo, LogoNombreArchivo=@logoNom,
                                     NotasCotizacion=@notas, ValidezDias=@val, TiempoEntrega=@tiempo,
                                     PorcentajeIGV=@igv, Moneda=@mon,
                                     ColorPrimario=@cp, ColorSecundario=@cs, ColorTerciario=@ct, ColorFondo=@cf";
                        using (var cmd = new SqlCommand(q, conn))
                        {
                            AgregarParametros(cmd, config);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Guardar bancos: borrar y reinsertar
                    using (var cmd = new SqlCommand("DELETE FROM Bancos", conn))
                        cmd.ExecuteNonQuery();

                    if (config.DatosBancarios != null)
                    {
                        foreach (var b in config.DatosBancarios)
                        {
                            using (var cmd = new SqlCommand(
                                "INSERT INTO Bancos (Banco, Cuenta, CCI) VALUES (@b, @c, @cci)", conn))
                            {
                                cmd.Parameters.AddWithValue("@b", (object)b.Banco ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@c", (object)b.Cuenta ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@cci", (object)b.CCI ?? DBNull.Value);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error al guardar configuración:\n" + ex.Message,
                    "Error", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        private static void AgregarParametros(SqlCommand cmd, EmpresaConfig config)
        {
            cmd.Parameters.AddWithValue("@n", (object)config.NombreEmpresa ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@r", (object)config.Ruc ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@d", (object)config.Direccion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@t1", (object)config.Telefono1 ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@t2", (object)config.Telefono2 ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@e", (object)config.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@i", (object)config.Instagram ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@f", (object)config.Facebook ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@w", (object)config.SitioWeb ?? DBNull.Value);

            // ✅ LOGO
            cmd.Parameters.AddWithValue("@logo",
                config.LogoImage != null && config.LogoImage.Length > 0
                    ? (object)config.LogoImage
                    : DBNull.Value);
            cmd.Parameters.AddWithValue("@logoNom",
                (object)config.LogoNombreArchivo ?? DBNull.Value);

            cmd.Parameters.AddWithValue("@notas", (object)config.NotasCotizacion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@val", config.ValidezDias);
            cmd.Parameters.AddWithValue("@tiempo", (object)config.TiempoEntrega ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@igv", config.PorcentajeIGV);
            cmd.Parameters.AddWithValue("@mon", (object)config.Moneda ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@cp", (object)config.ColorPrimario ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@cs", (object)config.ColorSecundario ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ct", (object)config.ColorTerciario ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@cf", (object)config.ColorFondo ?? DBNull.Value);
        }

        // ================= OBTENER LOGO COMO IMAGEN =================
        public static Image ObtenerLogoComoImagen(EmpresaConfig config)
        {
            if (config == null || config.LogoImage == null || config.LogoImage.Length == 0)
                return null;

            try
            {
                using (var ms = new MemoryStream(config.LogoImage))
                {
                    // Copiar a un nuevo MemoryStream para evitar problemas de posición
                    var ms2 = new MemoryStream();
                    ms.Position = 0;
                    ms.CopyTo(ms2);
                    ms2.Position = 0;
                    return Image.FromStream(ms2);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al leer logo: " + ex.Message);
                return null;
            }
        }

        // ================= CONVERTIR LOGO A BYTES =================
        public static byte[] ConvertirImagenABytes(Image img, System.Drawing.Imaging.ImageFormat formato = null)
        {
            if (img == null) return null;
            formato = formato ?? System.Drawing.Imaging.ImageFormat.Png;

            using (var ms = new MemoryStream())
            {
                img.Save(ms, formato);
                return ms.ToArray();
            }
        }
    }
}