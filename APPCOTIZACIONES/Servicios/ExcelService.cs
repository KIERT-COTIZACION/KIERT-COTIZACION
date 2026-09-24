using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using COTIZACIONES.Modelos;

namespace COTIZACIONES.Servicios
{
    public static class ExcelService
    {
        public static void Exportar(string rutaArchivo, EmpresaConfig empresa, string numero,
            string clienteNombre, string clienteDoc, string telefono, string email, string direccion,
            string vendedor, bool conIgv, decimal subtotal, decimal igv, decimal total,
            List<DetalleCotizacion> items, string totalLetras)
        {
            string logoBase64 = "";
            if (empresa.LogoImage != null && empresa.LogoImage.Length > 0)
            {
                logoBase64 = Convert.ToBase64String(empresa.LogoImage);
            }

            var sb = new StringBuilder();
            sb.AppendLine("<html xmlns:o='urn:schemas-microsoft-com:office:office'");
            sb.AppendLine("      xmlns:x='urn:schemas-microsoft-com:office:excel'");
            sb.AppendLine("      xmlns='http://www.w3.org/TR/REC-html40'>");
            sb.AppendLine("<head>");
            sb.AppendLine("<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>");
            sb.AppendLine("<style>");
            sb.AppendLine("  body { font-family: 'Segoe UI', Arial, sans-serif; font-size: 11px; }");
            sb.AppendLine("  table { border-collapse: collapse; width: 100%; }");
            sb.AppendLine("  th { background-color: #1e3a8a; color: white; padding: 6px; border: 1px solid #ccc; }");
            sb.AppendLine("  td { padding: 5px; border: 1px solid #ddd; }");
            sb.AppendLine("  .titulo { font-size: 18px; font-weight: bold; color: #1e3a8a; text-align: center; }");
            sb.AppendLine("  .total { background-color: #dbeafe; font-weight: bold; }");
            sb.AppendLine("  .right { text-align: right; }");
            sb.AppendLine("  .center { text-align: center; }");
            sb.AppendLine("</style>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");

            // ENCABEZADO
            sb.AppendLine("<table>");
            sb.AppendLine("<tr>");
            sb.AppendLine("<td style='width:120px; text-align:center; vertical-align:middle; border:none;'>");
            if (!string.IsNullOrEmpty(logoBase64))
            {
                sb.AppendLine($"<img src='data:image/png;base64,{logoBase64}' width='100' height='100' style='object-fit:contain;'/>");
            }
            sb.AppendLine("</td>");
            sb.AppendLine("<td style='text-align:center; vertical-align:middle; border:none;'>");
            sb.AppendLine($"<div class='titulo'>{Escape(empresa.NombreEmpresa ?? "MI EMPRESA")}</div>");
            if (!string.IsNullOrEmpty(empresa.Ruc))
                sb.AppendLine($"<div>RUC: {Escape(empresa.Ruc)}</div>");
            if (!string.IsNullOrEmpty(empresa.Direccion))
                sb.AppendLine($"<div>{Escape(empresa.Direccion)}</div>");
            sb.AppendLine("</td>");
            sb.AppendLine("</tr>");
            sb.AppendLine("</table>");

            sb.AppendLine("<hr style='border:1px solid #1e3a8a;'>");
            sb.AppendLine("<br>");

            // DATOS CLIENTE
            sb.AppendLine("<table>");
            sb.AppendLine($"<tr><td style='width:120px;'><b>Cliente:</b></td><td>{Escape(clienteNombre ?? "-")}</td>");
            sb.AppendLine($"<td style='width:100px;'><b>Fecha:</b></td><td>{DateTime.Now:dd/MM/yyyy}</td></tr>");
            sb.AppendLine($"<tr><td><b>Documento:</b></td><td>{Escape(clienteDoc ?? "-")}</td>");
            sb.AppendLine($"<td><b>Cotización N°:</b></td><td>{Escape(numero)}</td></tr>");
            sb.AppendLine($"<tr><td><b>Teléfono:</b></td><td>{Escape(telefono ?? "-")}</td>");
            sb.AppendLine($"<td><b>Email:</b></td><td>{Escape(email ?? "-")}</td></tr>");
            sb.AppendLine($"<tr><td><b>Dirección:</b></td><td>{Escape(direccion ?? "-")}</td>");
            sb.AppendLine($"<td><b>Vendedor:</b></td><td>{Escape(vendedor ?? "-")}</td></tr>");
            sb.AppendLine("</table>");

            sb.AppendLine("<br>");
            sb.AppendLine("<p>Por medio de la presente y en atención a su solicitud, le hacemos llegar la siguiente oferta:</p>");
            sb.AppendLine("<br>");

            // ================= TABLA PRODUCTOS CON TALLA Y COLOR =================
            sb.AppendLine("<table>");
            sb.AppendLine("<thead><tr>");
            sb.AppendLine("<th>#</th><th>Código</th><th>Descripción</th>");
            sb.AppendLine("<th>Talla</th><th>Color</th>");                     // ✅ NUEVO
            sb.AppendLine("<th>P. Unit.</th><th>Cant.</th><th>Subtotal</th>");
            sb.AppendLine("</tr></thead><tbody>");

            int n = 1;
            foreach (var it in items)
            {
                sb.AppendLine("<tr>");
                sb.AppendLine($"<td class='center'>{n}</td>");
                sb.AppendLine($"<td class='center'>{Escape(it.Codigo ?? "-")}</td>");
                sb.AppendLine($"<td>{Escape(it.Descripcion ?? "-")}</td>");
                sb.AppendLine($"<td class='center'>{Escape(it.Talla ?? "—")}</td>");   // ✅ NUEVO
                sb.AppendLine($"<td class='center'>{Escape(it.Color ?? "—")}</td>");   // ✅ NUEVO
                sb.AppendLine($"<td class='right'>{empresa.Moneda} {it.Precio:F2}</td>");
                sb.AppendLine($"<td class='center'>{it.Cantidad}</td>");
                sb.AppendLine($"<td class='right'>{empresa.Moneda} {it.Subtotal:F2}</td>");
                sb.AppendLine("</tr>");
                n++;
            }
            sb.AppendLine("</tbody></table>");
            sb.AppendLine("<br>");

            // TOTALES
            sb.AppendLine("<table style='width:50%; float:right;'>");
            sb.AppendLine($"<tr><td class='right'><b>Subtotal:</b></td><td class='right'>{empresa.Moneda} {subtotal:F2}</td></tr>");
            if (conIgv)
                sb.AppendLine($"<tr><td class='right'><b>IGV ({empresa.PorcentajeIGV}%):</b></td><td class='right'>{empresa.Moneda} {igv:F2}</td></tr>");
            else
                sb.AppendLine("<tr><td class='right'><b>IGV:</b></td><td class='right'>NO APLICA</td></tr>");
            sb.AppendLine($"<tr class='total'><td class='right'><b>TOTAL:</b></td><td class='right'><b>{empresa.Moneda} {total:F2}</b></td></tr>");
            sb.AppendLine("</table>");
            sb.AppendLine("<div style='clear:both;'></div>");
            sb.AppendLine("<br>");
            sb.AppendLine($"<p>Son: {(totalLetras ?? "").ToUpper()}</p>");
            sb.AppendLine("<br>");

            // BANCOS
            if (empresa.DatosBancarios != null && empresa.DatosBancarios.Count > 0)
            {
                sb.AppendLine("<p><b>CUENTAS BANCARIAS</b></p>");
                sb.AppendLine("<table>");
                sb.AppendLine("<thead><tr><th>Banco</th><th>Cuenta</th><th>CCI</th></tr></thead><tbody>");
                foreach (var b in empresa.DatosBancarios)
                {
                    sb.AppendLine("<tr>");
                    sb.AppendLine($"<td class='center'>{Escape(b.Banco ?? "")}</td>");
                    sb.AppendLine($"<td class='center'>{Escape(b.Cuenta ?? "")}</td>");
                    sb.AppendLine($"<td class='center'>{Escape(b.CCI ?? "")}</td>");
                    sb.AppendLine("</tr>");
                }
                sb.AppendLine("</tbody></table>");
                sb.AppendLine("<br>");
            }

            // CONTACTO
            sb.AppendLine("<p><b>DATOS DE CONTACTO</b></p>");
            if (!string.IsNullOrEmpty(empresa.Direccion)) sb.AppendLine($"<p>Dirección: {Escape(empresa.Direccion)}</p>");
            if (!string.IsNullOrEmpty(empresa.Telefono1)) sb.AppendLine($"<p>Teléfonos: {Escape(empresa.Telefono1)} / {Escape(empresa.Telefono2)}</p>");
            if (!string.IsNullOrEmpty(empresa.Email)) sb.AppendLine($"<p>Email: {Escape(empresa.Email)}</p>");
            if (!string.IsNullOrEmpty(empresa.Instagram)) sb.AppendLine($"<p>Instagram: {Escape(empresa.Instagram)}</p>");
            if (!string.IsNullOrEmpty(empresa.Facebook)) sb.AppendLine($"<p>Facebook: {Escape(empresa.Facebook)}</p>");
            if (!string.IsNullOrEmpty(empresa.SitioWeb)) sb.AppendLine($"<p>Web: {Escape(empresa.SitioWeb)}</p>");
            sb.AppendLine("<br>");

            // NOTAS
            sb.AppendLine("<p><b>NOTAS</b></p>");
            sb.AppendLine($"<p>• {Escape(empresa.NotasCotizacion ?? "Cotización válida por " + empresa.ValidezDias + " días.")}</p>");
            sb.AppendLine($"<p>• Precios en {(empresa.Moneda == "S/" ? "soles peruanos" : "dólares")}</p>");
            sb.AppendLine($"<p>• Tiempo de entrega: {Escape(empresa.TiempoEntrega)}</p>");
            sb.AppendLine("<br>");
            sb.AppendLine("<p><b>¡Gracias por su preferencia!</b></p>");
            sb.AppendLine($"<p>{Escape(empresa.NombreEmpresa ?? "")}</p>");

            sb.AppendLine("</body></html>");

            File.WriteAllText(rutaArchivo, sb.ToString(), Encoding.UTF8);
        }

        private static string Escape(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return s.Replace("&", "&amp;")
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;")
                    .Replace("\"", "&quot;");
        }
    }
}