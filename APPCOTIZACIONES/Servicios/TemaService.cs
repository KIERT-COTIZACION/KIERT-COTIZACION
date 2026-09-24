using System;
using System.Drawing;
using System.Windows.Forms;

namespace COTIZACIONES.Servicios
{
    public static class TemaService
    {
        // ========== COLORES DEL TEMA ACTUAL ==========
        public static Color ColorPrimario { get; private set; } = ColorTranslator.FromHtml("#69383e");
        public static Color ColorSecundario { get; private set; } = ColorTranslator.FromHtml("#a6a5a0");
        public static Color ColorTerciario { get; private set; } = ColorTranslator.FromHtml("#5d5a55");
        public static Color ColorFondo { get; private set; } = ColorTranslator.FromHtml("#fefefe");

        // ✅ NUEVO: Color exclusivo para el PDF
        public static Color ColorPdf { get; private set; } = ColorTranslator.FromHtml("#69383e");

        // ========== COLORES DE TEXTO CALCULADOS ==========
        public static Color TextoSobrePrimario { get; private set; } = Color.White;
        public static Color TextoSobreSecundario { get; private set; } = Color.Black;
        public static Color TextoSobreTerciario { get; private set; } = Color.White;
        public static Color TextoSobreFondo { get; private set; } = Color.Black;

        // ========== PALETAS PREDEFINIDAS ==========
        public class Paleta
        {
            public string Nombre { get; set; }
            public Color Primario { get; set; }
            public Color Secundario { get; set; }
            public Color Terciario { get; set; }
            public Color Fondo { get; set; }
        }

        public static Paleta[] PaletasDisponibles => new[]
        {
            new Paleta { Nombre = "Marrón Elegante (Predeterminado)",
                Primario = ColorTranslator.FromHtml("#69383e"),
                Secundario = ColorTranslator.FromHtml("#a6a5a0"),
                Terciario = ColorTranslator.FromHtml("#5d5a55"),
                Fondo = ColorTranslator.FromHtml("#fefefe") },

            new Paleta { Nombre = "Azul Clásico",
                Primario = ColorTranslator.FromHtml("#1e3a8a"),
                Secundario = ColorTranslator.FromHtml("#3b82f6"),
                Terciario = ColorTranslator.FromHtml("#1e40af"),
                Fondo = ColorTranslator.FromHtml("#f0f9ff") },

            new Paleta { Nombre = "Verde Esmeralda",
                Primario = ColorTranslator.FromHtml("#065f46"),
                Secundario = ColorTranslator.FromHtml("#10b981"),
                Terciario = ColorTranslator.FromHtml("#047857"),
                Fondo = ColorTranslator.FromHtml("#f0fdf4") },

            new Paleta { Nombre = "Rojo Intenso",
                Primario = ColorTranslator.FromHtml("#991b1b"),
                Secundario = ColorTranslator.FromHtml("#ef4444"),
                Terciario = ColorTranslator.FromHtml("#7f1d1d"),
                Fondo = ColorTranslator.FromHtml("#fef2f2") },

            new Paleta { Nombre = "Morado Real",
                Primario = ColorTranslator.FromHtml("#5b21b6"),
                Secundario = ColorTranslator.FromHtml("#8b5cf6"),
                Terciario = ColorTranslator.FromHtml("#4c1d95"),
                Fondo = ColorTranslator.FromHtml("#faf5ff") },

            new Paleta { Nombre = "Naranja Cálido",
                Primario = ColorTranslator.FromHtml("#9a3412"),
                Secundario = ColorTranslator.FromHtml("#f97316"),
                Terciario = ColorTranslator.FromHtml("#7c2d12"),
                Fondo = ColorTranslator.FromHtml("#fff7ed") },

            new Paleta { Nombre = "Gris Profesional",
                Primario = ColorTranslator.FromHtml("#1f2937"),
                Secundario = ColorTranslator.FromHtml("#6b7280"),
                Terciario = ColorTranslator.FromHtml("#374151"),
                Fondo = ColorTranslator.FromHtml("#f9fafb") },

            new Paleta { Nombre = "Rosa Moderno",
                Primario = ColorTranslator.FromHtml("#9d174d"),
                Secundario = ColorTranslator.FromHtml("#ec4899"),
                Terciario = ColorTranslator.FromHtml("#831843"),
                Fondo = ColorTranslator.FromHtml("#fdf2f8") },
        };

        // ========== APLICAR PALETA ==========
        public static void AplicarPaleta(Color primario, Color secundario, Color terciario, Color fondo)
        {
            ColorPrimario = primario;
            ColorSecundario = secundario;
            ColorTerciario = terciario;
            ColorFondo = fondo;

            // Por defecto, el PDF sigue al primario
            ColorPdf = primario;

            TextoSobrePrimario = CalcularTextoContraste(primario);
            TextoSobreSecundario = CalcularTextoContraste(secundario);
            TextoSobreTerciario = CalcularTextoContraste(terciario);
            TextoSobreFondo = CalcularTextoContraste(fondo);
        }

        public static void AplicarPaleta(Paleta p)
        {
            AplicarPaleta(p.Primario, p.Secundario, p.Terciario, p.Fondo);
        }

        // ✅ NUEVO: establecer el color del PDF por separado
        public static void EstablecerColorPdf(Color colorPdf)
        {
            ColorPdf = colorPdf;
        }

        // ========== CALCULAR CONTRASTE (BLANCO O NEGRO) ==========
        public static Color CalcularTextoContraste(Color fondo)
        {
            double yiq = ((fondo.R * 299) + (fondo.G * 587) + (fondo.B * 114)) / 1000.0;
            return yiq >= 128 ? Color.Black : Color.White;
        }

        // ========== CONVERTIR HEX <-> COLOR ==========
        public static string ColorToHex(Color c)
        {
            return $"#{c.R:X2}{c.G:X2}{c.B:X2}";
        }

        public static Color HexToColor(string hex)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(hex)) return Color.Gray;
                if (!hex.StartsWith("#")) hex = "#" + hex;
                return ColorTranslator.FromHtml(hex);
            }
            catch { return Color.Gray; }
        }

        // ========== APLICAR TEMA A UN FORMULARIO COMPLETO ==========
        public static void AplicarTemaAFormulario(Form form)
        {
            form.BackColor = ColorFondo;
            form.ForeColor = TextoSobreFondo;
            AplicarTemaAControles(form.Controls);
        }

        private static void AplicarTemaAControles(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                try
                {
                    if (c is Button btn)
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                        if (EsBotonPrimario(btn.Text))
                        {
                            btn.BackColor = ColorPrimario;
                            btn.ForeColor = TextoSobrePrimario;
                        }
                        else if (EsBotonSecundario(btn.Text))
                        {
                            btn.BackColor = ColorSecundario;
                            btn.ForeColor = TextoSobreSecundario;
                        }
                        else if (EsBotonPeligro(btn.Text))
                        {
                            btn.BackColor = Color.FromArgb(220, 38, 38);
                            btn.ForeColor = Color.White;
                        }
                        else if (EsBotonExito(btn.Text))
                        {
                            btn.BackColor = Color.FromArgb(16, 185, 129);
                            btn.ForeColor = Color.White;
                        }
                        else
                        {
                            btn.BackColor = ColorTerciario;
                            btn.ForeColor = TextoSobreTerciario;
                        }
                    }
                    else if (c is Label lbl)
                    {
                        if (lbl.Parent != null && lbl.BackColor == lbl.Parent.BackColor)
                        {
                            lbl.ForeColor = lbl.Parent.ForeColor;
                        }
                        else if (lbl.BackColor == ColorFondo || lbl.BackColor == Color.White)
                        {
                            lbl.ForeColor = TextoSobreFondo;
                        }
                        else if (lbl.BackColor == ColorPrimario)
                        {
                            lbl.ForeColor = TextoSobrePrimario;
                        }
                    }
                    else if (c is TextBox txt)
                    {
                        txt.BackColor = Color.White;
                        txt.ForeColor = Color.Black;
                    }
                    else if (c is ComboBox cmb)
                    {
                        cmb.BackColor = Color.White;
                        cmb.ForeColor = Color.Black;
                    }
                    else if (c is Panel pnl)
                    {
                        if (pnl.BackColor == Color.FromArgb(30, 58, 138) || EsColorOscuro(pnl.BackColor))
                        {
                            pnl.BackColor = ColorPrimario;
                            pnl.ForeColor = TextoSobrePrimario;
                        }
                    }
                    else if (c is GroupBox gb)
                    {
                        gb.ForeColor = ColorPrimario;
                    }
                    else if (c is TabControl tab)
                    {
                        tab.ForeColor = TextoSobreFondo;
                    }

                    if (c.HasChildren)
                        AplicarTemaAControles(c.Controls);
                }
                catch { }
            }
        }

        private static bool EsBotonPrimario(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return false;
            var t = texto.ToUpper();
            return t.Contains("GUARDAR") || t.Contains("INICIAR") || t.Contains("AGREGAR")
                || t.Contains("NUEVA") || t.Contains("NUEVO") || t.Contains("BUSCAR")
                || t.Contains("EXPORTAR") || t.Contains("PDF") || t.Contains("COTIZACIÓN");
        }

        private static bool EsBotonSecundario(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return false;
            var t = texto.ToUpper();
            return t.Contains("EDITAR") || t.Contains("ACTUALIZAR") || t.Contains("VER");
        }

        private static bool EsBotonPeligro(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return false;
            var t = texto.ToUpper();
            return t.Contains("ELIMINAR") || t.Contains("SALIR") || t.Contains("CANCELAR")
                || t.Contains("CERRAR SESIÓN");
        }

        private static bool EsBotonExito(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return false;
            var t = texto.ToUpper();
            return t.Contains("✓") || t.Contains("OK") || t.Contains("CONFIRMAR");
        }

        private static bool EsColorOscuro(Color c)
        {
            double yiq = ((c.R * 299) + (c.G * 587) + (c.B * 114)) / 1000.0;
            return yiq < 128;
        }
    }
}