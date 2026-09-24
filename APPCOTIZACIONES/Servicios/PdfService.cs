using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using COTIZACIONES.Modelos;

namespace COTIZACIONES.Servicios
{
    public static class PdfService
    {
        public static void GenerarPdf(string rutaArchivo, EmpresaConfig empresa, string numero,
            string clienteNombre, string clienteDoc, string telefono, string email, string direccion,
            string vendedor, string condicionPago, bool conIgv, decimal subtotal, decimal igv, decimal total,
            List<DetalleCotizacion> items, string totalLetras)
        {
            // ==================================================
            // COLORES DINÁMICOS
            // ==================================================
            var colorPrimario = HexToBaseColor(empresa.ColorPdf, new BaseColor(105, 56, 62));
            var colorSecundario = HexToBaseColor(empresa.ColorSecundario, new BaseColor(166, 165, 160));
            var colorTerciario = HexToBaseColor(empresa.ColorTerciario, new BaseColor(93, 90, 85));
            var colorFondoSuave = HexToBaseColor(empresa.ColorFondo, new BaseColor(254, 254, 254));

            var colorGrisClaro = new BaseColor(245, 245, 245);
            var colorGrisMedio = new BaseColor(220, 220, 220);
            var colorGrisTexto = new BaseColor(80, 80, 80);
            var colorBlanco = new BaseColor(255, 255, 255);
            var colorNegro = new BaseColor(0, 0, 0);

            var textoPrimario = EsColorClaro(colorPrimario) ? new BaseColor(30, 30, 30) : colorBlanco;

            // ==================================================
            // FUENTES
            // ==================================================
            var fTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22, colorPrimario);
            var fSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA, 9, colorGrisTexto);
            var fNormal = FontFactory.GetFont(FontFactory.HELVETICA, 9, colorNegro);
            var fNormalGris = FontFactory.GetFont(FontFactory.HELVETICA, 8, colorGrisTexto);
            var fNegrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, colorNegro);
            var fNegritaBlanca = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, textoPrimario);
            var fHeaderTabla = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, textoPrimario);
            var fTotalGrande = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, colorPrimario);
            var fSeccion = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, colorPrimario);

            // ==================================================
            // DOCUMENTO
            // ==================================================
            var doc = new Document(PageSize.A4, 40, 40, 40, 50);
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            // BANDA SUPERIOR
            var bandaSuperior = new PdfPTable(1) { WidthPercentage = 100 };
            bandaSuperior.AddCell(new PdfPCell(new Phrase(" "))
            {
                BackgroundColor = colorPrimario,
                Border = Rectangle.NO_BORDER,
                FixedHeight = 6f
            });
            doc.Add(bandaSuperior);
            doc.Add(new Paragraph("\n") { SpacingAfter = 5f });

            // ENCABEZADO
            var headerTable = new PdfPTable(3) { WidthPercentage = 100 };
            headerTable.SetWidths(new float[] { 18f, 52f, 30f });
            headerTable.SpacingAfter = 8f;

            var logoCell = new PdfPCell
            {
                Border = Rectangle.NO_BORDER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                HorizontalAlignment = Element.ALIGN_LEFT,
                PaddingTop = 5f,
                PaddingBottom = 5f
            };

            if (empresa.LogoImage != null && empresa.LogoImage.Length > 0)
            {
                try
                {
                    var img = iTextSharp.text.Image.GetInstance(empresa.LogoImage);
                    img.ScaleToFit(90f, 90f);
                    img.Alignment = Element.ALIGN_LEFT;
                    logoCell.AddElement(img);
                }
                catch
                {
                    logoCell.AddElement(new Paragraph(" ", fNormal));
                }
            }
            else
            {
                logoCell.AddElement(new Paragraph(" ", fNormal));
            }
            headerTable.AddCell(logoCell);

            var datosEmpresaCell = new PdfPCell
            {
                Border = Rectangle.NO_BORDER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                PaddingLeft = 10f,
                PaddingRight = 5f
            };

            datosEmpresaCell.AddElement(new Paragraph(empresa.NombreEmpresa ?? "MI EMPRESA", fTitulo)
            {
                SpacingAfter = 2f
            });

            if (!string.IsNullOrEmpty(empresa.Ruc))
                datosEmpresaCell.AddElement(new Paragraph("RUC: " + empresa.Ruc, fSubtitulo) { SpacingAfter = 1f });
            if (!string.IsNullOrEmpty(empresa.Direccion))
                datosEmpresaCell.AddElement(new Paragraph("Dirección: " + empresa.Direccion, fSubtitulo) { SpacingAfter = 1f });
            if (!string.IsNullOrEmpty(empresa.Telefono1))
            {
                string tels = "Teléfono: " + empresa.Telefono1;
                if (!string.IsNullOrEmpty(empresa.Telefono2)) tels += " / " + empresa.Telefono2;
                datosEmpresaCell.AddElement(new Paragraph(tels, fSubtitulo) { SpacingAfter = 1f });
            }
            if (!string.IsNullOrEmpty(empresa.Email))
                datosEmpresaCell.AddElement(new Paragraph("Email: " + empresa.Email, fSubtitulo) { SpacingAfter = 1f });

            headerTable.AddCell(datosEmpresaCell);

            var cajaNumero = new PdfPTable(1) { WidthPercentage = 100 };
            cajaNumero.AddCell(new PdfPCell(new Phrase("COTIZACIÓN",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, textoPrimario)))
            {
                BackgroundColor = colorPrimario,
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_CENTER,
                PaddingTop = 5f,
                PaddingBottom = 3f
            });
            cajaNumero.AddCell(new PdfPCell(new Phrase(numero ?? "---",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, colorPrimario)))
            {
                Border = Rectangle.BOX,
                BorderColor = colorPrimario,
                BorderWidth = 1.5f,
                HorizontalAlignment = Element.ALIGN_CENTER,
                PaddingTop = 8f,
                PaddingBottom = 8f,
                BackgroundColor = colorBlanco
            });

            var numeroCell = new PdfPCell(cajaNumero)
            {
                Border = Rectangle.NO_BORDER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                PaddingLeft = 5f
            };
            headerTable.AddCell(numeroCell);

            doc.Add(headerTable);

            doc.Add(new Paragraph(new Chunk(new LineSeparator(2f, 100f, colorPrimario, Element.ALIGN_CENTER, -2f)))
            {
                SpacingBefore = 5f,
                SpacingAfter = 12f
            });

            // INFO CLIENTE
            doc.Add(new Paragraph("INFORMACIÓN DEL CLIENTE", fSeccion) { SpacingAfter = 5f });

            var infoCliente = new PdfPTable(4) { WidthPercentage = 100 };
            infoCliente.SetWidths(new float[] { 15f, 35f, 15f, 35f });
            infoCliente.SpacingAfter = 15f;

            AgregarInfoCliente(infoCliente, "Cliente:", clienteNombre ?? "-", fNegrita, fNormal, colorGrisClaro);
            AgregarInfoCliente(infoCliente, "Fecha:", DateTime.Now.ToString("dd/MM/yyyy"), fNegrita, fNormal, colorGrisClaro);
            AgregarInfoCliente(infoCliente, "Documento:", clienteDoc ?? "-", fNegrita, fNormal, colorGrisClaro);
            AgregarInfoCliente(infoCliente, "Condición:", condicionPago ?? "Contado", fNegrita, fNormal, colorGrisClaro);
            AgregarInfoCliente(infoCliente, "Teléfono:", telefono ?? "-", fNegrita, fNormal, colorGrisClaro);
            AgregarInfoCliente(infoCliente, "Email:", email ?? "-", fNegrita, fNormal, colorGrisClaro);
            AgregarInfoCliente(infoCliente, "Dirección:", direccion ?? "-", fNegrita, fNormal, colorGrisClaro);
            AgregarInfoCliente(infoCliente, "Vendedor:", vendedor ?? "-", fNegrita, fNormal, colorGrisClaro);

            doc.Add(infoCliente);

            doc.Add(new Paragraph(
                "Por medio de la presente y en atención a su solicitud, le hacemos llegar la siguiente oferta:",
                fNormal)
            {
                SpacingAfter = 10f
            });

            // ==================================================
            // TABLA PRODUCTOS CON TALLA Y COLOR
            // ==================================================
            var tabla = new PdfPTable(8) { WidthPercentage = 100 };
            tabla.SetWidths(new float[] { 4f, 11f, 26f, 8f, 12f, 8f, 12f, 15f });
            tabla.SpacingAfter = 10f;

            string[] headers = { "#", "CÓDIGO", "DESCRIPCIÓN", "TALLA", "COLOR", "CANT.", "P. UNIT.", "SUBTOTAL" };
            foreach (var h in headers)
            {
                tabla.AddCell(new PdfPCell(new Phrase(h, fHeaderTabla))
                {
                    BackgroundColor = colorPrimario,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    Padding = 5f,
                    Border = Rectangle.NO_BORDER,
                    MinimumHeight = 22f
                });
            }

            int i = 1;
            bool alterna = false;
            foreach (var it in items)
            {
                var bgFila = alterna ? colorGrisClaro : colorBlanco;
                alterna = !alterna;

                tabla.AddCell(CeldaDato(i.ToString(), fNormal, Element.ALIGN_CENTER, bgFila));
                tabla.AddCell(CeldaDato(it.Codigo ?? "-", fNormal, Element.ALIGN_CENTER, bgFila));
                tabla.AddCell(CeldaDato(it.Descripcion ?? "-", fNormal, Element.ALIGN_LEFT, bgFila));
                tabla.AddCell(CeldaDato(it.Talla ?? "—", fNormal, Element.ALIGN_CENTER, bgFila));   // ✅ TALLA
                tabla.AddCell(CeldaDato(it.Color ?? "—", fNormal, Element.ALIGN_CENTER, bgFila));   // ✅ COLOR
                tabla.AddCell(CeldaDato(it.Cantidad.ToString(), fNormal, Element.ALIGN_CENTER, bgFila));
                tabla.AddCell(CeldaDato($"{empresa.Moneda} {it.Precio:F2}", fNormal, Element.ALIGN_RIGHT, bgFila));
                tabla.AddCell(CeldaDato($"{empresa.Moneda} {it.Subtotal:F2}", fNegrita, Element.ALIGN_RIGHT, bgFila));
                i++;
            }
            doc.Add(tabla);

            // TOTALES
            var totTable = new PdfPTable(2) { WidthPercentage = 45, HorizontalAlignment = Element.ALIGN_RIGHT };
            totTable.SetWidths(new float[] { 55f, 45f });
            totTable.SpacingAfter = 12f;

            AgregarTotal(totTable, "Subtotal:", $"{empresa.Moneda} {subtotal:F2}", fNormal, colorGrisClaro, false);
            if (conIgv)
                AgregarTotal(totTable, $"IGV ({empresa.PorcentajeIGV}%):", $"{empresa.Moneda} {igv:F2}", fNormal, colorGrisClaro, false);
            else
                AgregarTotal(totTable, "IGV:", "NO APLICA", fNormal, colorGrisClaro, false);

            AgregarTotal(totTable, "TOTAL A PAGAR:", $"{empresa.Moneda} {total:F2}", fTotalGrande, colorPrimario, true);

            doc.Add(totTable);

            var cajaLetras = new PdfPTable(1) { WidthPercentage = 100 };
            cajaLetras.SpacingAfter = 15f;
            cajaLetras.AddCell(new PdfPCell(new Phrase("Son: " + (totalLetras ?? "").ToUpper(),
                FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9, colorPrimario)))
            {
                BackgroundColor = new BaseColor(250, 248, 245),
                Border = Rectangle.BOX,
                BorderColor = colorPrimario,
                BorderWidth = 0.5f,
                Padding = 8f,
                HorizontalAlignment = Element.ALIGN_LEFT
            });
            doc.Add(cajaLetras);

            // BANCOS
            if (empresa.DatosBancarios != null && empresa.DatosBancarios.Count > 0)
            {
                doc.Add(new Paragraph("CUENTAS BANCARIAS", fSeccion) { SpacingAfter = 5f });

                var bTable = new PdfPTable(3) { WidthPercentage = 100 };
                bTable.SetWidths(new float[] { 25f, 40f, 35f });
                bTable.SpacingAfter = 15f;

                foreach (var h in new[] { "Banco", "Cuenta", "CCI" })
                    bTable.AddCell(new PdfPCell(new Phrase(h, fHeaderTabla))
                    {
                        BackgroundColor = colorPrimario,
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_MIDDLE,
                        Padding = 6f,
                        Border = Rectangle.NO_BORDER
                    });

                bool alternaB = false;
                foreach (var b in empresa.DatosBancarios)
                {
                    var bg = alternaB ? colorGrisClaro : colorBlanco;
                    alternaB = !alternaB;

                    bTable.AddCell(CeldaDato(b.Banco ?? "", fNormal, Element.ALIGN_CENTER, bg));
                    bTable.AddCell(CeldaDato(b.Cuenta ?? "", fNormal, Element.ALIGN_CENTER, bg));
                    bTable.AddCell(CeldaDato(b.CCI ?? "", fNormal, Element.ALIGN_CENTER, bg));
                }
                doc.Add(bTable);
            }

            // NOTAS
            doc.Add(new Paragraph("NOTAS Y CONDICIONES", fSeccion) { SpacingAfter = 5f });

            var cajaNotas = new PdfPTable(1) { WidthPercentage = 100 };
            cajaNotas.SpacingAfter = 12f;

            var celdaNotas = new PdfPCell
            {
                BackgroundColor = colorGrisClaro,
                Border = Rectangle.BOX,
                BorderColor = colorGrisMedio,
                BorderWidth = 0.5f,
                Padding = 10f
            };

            string notas = empresa.NotasCotizacion;
            if (!string.IsNullOrWhiteSpace(notas))
            {
                celdaNotas.AddElement(new Paragraph(notas, fNormal) { SpacingAfter = 3f });
            }
            celdaNotas.AddElement(new Paragraph("• Cotización válida por " + empresa.ValidezDias + " días.", fNormalGris));
            celdaNotas.AddElement(new Paragraph("• Precios en " + (empresa.Moneda == "S/" ? "soles peruanos" : "dólares") + ".", fNormalGris));
            celdaNotas.AddElement(new Paragraph("• Tiempo de entrega: " + (empresa.TiempoEntrega ?? "5-10 días hábiles") + ".", fNormalGris));

            cajaNotas.AddCell(celdaNotas);
            doc.Add(cajaNotas);

            // DESPEDIDA
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("¡Gracias por su preferencia!",
                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, colorPrimario))
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 3f
            });
            doc.Add(new Paragraph(empresa.NombreEmpresa ?? "", fNormalGris)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 3f
            });

            // PIE
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph(new Chunk(new LineSeparator(1f, 100f, colorGrisMedio, Element.ALIGN_CENTER, -2f))));

            string pieLinea = "";
            if (!string.IsNullOrEmpty(empresa.Telefono1)) pieLinea += empresa.Telefono1;
            if (!string.IsNullOrEmpty(empresa.Email)) pieLinea += (pieLinea.Length > 0 ? " | " : "") + empresa.Email;
            if (!string.IsNullOrEmpty(empresa.SitioWeb)) pieLinea += (pieLinea.Length > 0 ? " | " : "") + empresa.SitioWeb;

            if (!string.IsNullOrEmpty(pieLinea))
                doc.Add(new Paragraph(pieLinea, fNormalGris) { Alignment = Element.ALIGN_CENTER, SpacingBefore = 3f });

            doc.Close();
        }

        private static void AgregarInfoCliente(PdfPTable t, string label, string valor, Font fl, Font fv, BaseColor bg)
        {
            t.AddCell(new PdfPCell(new Phrase(label, fl))
            {
                Border = Rectangle.NO_BORDER,
                BackgroundColor = bg,
                Padding = 6f,
                VerticalAlignment = Element.ALIGN_MIDDLE
            });
            t.AddCell(new PdfPCell(new Phrase(valor, fv))
            {
                Border = Rectangle.NO_BORDER,
                BackgroundColor = bg,
                Padding = 6f,
                VerticalAlignment = Element.ALIGN_MIDDLE
            });
        }

        private static void AgregarTotal(PdfPTable t, string label, string valor, Font f, BaseColor bg, bool esTotal)
        {
            var cLabel = new PdfPCell(new Phrase(label, f))
            {
                Border = Rectangle.BOX,
                BorderColor = bg,
                BorderWidth = 0.5f,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Padding = 8f,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = bg
            };
            var cValor = new PdfPCell(new Phrase(valor, f))
            {
                Border = Rectangle.BOX,
                BorderColor = bg,
                BorderWidth = 0.5f,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Padding = 8f,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                BackgroundColor = bg
            };

            if (esTotal)
            {
                var textoContraste = EsColorClaro(bg)
                    ? new BaseColor(0, 0, 0)
                    : new BaseColor(255, 255, 255);

                cLabel.Phrase = new Phrase(label,
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, textoContraste));
                cValor.Phrase = new Phrase(valor,
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, textoContraste));
            }

            t.AddCell(cLabel);
            t.AddCell(cValor);
        }

        private static PdfPCell CeldaDato(string texto, Font f, int alineacion, BaseColor bg)
        {
            return new PdfPCell(new Phrase(texto ?? "", f))
            {
                HorizontalAlignment = alineacion,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Padding = 5f,
                Border = Rectangle.BOTTOM_BORDER,
                BorderColor = new BaseColor(230, 230, 230),
                BorderWidth = 0.3f,
                BackgroundColor = bg,
                MinimumHeight = 20f
            };
        }

        private static BaseColor HexToBaseColor(string hex, BaseColor porDefecto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(hex)) return porDefecto;
                if (!hex.StartsWith("#")) hex = "#" + hex;
                if (hex.Length != 7) return porDefecto;

                int r = Convert.ToInt32(hex.Substring(1, 2), 16);
                int g = Convert.ToInt32(hex.Substring(3, 2), 16);
                int b = Convert.ToInt32(hex.Substring(5, 2), 16);
                return new BaseColor(r, g, b);
            }
            catch
            {
                return porDefecto;
            }
        }

        private static bool EsColorClaro(BaseColor c)
        {
            double yiq = ((c.R * 299) + (c.G * 587) + (c.B * 114)) / 1000.0;
            return yiq >= 128;
        }
    }
}