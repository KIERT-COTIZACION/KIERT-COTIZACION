using System.Collections.Generic;

namespace COTIZACIONES.Modelos
{
    public class BancoInfo
    {
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string CCI { get; set; }
    }

    public class EmpresaConfig
    {
        public int Id { get; set; }
        public string NombreEmpresa { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string SitioWeb { get; set; }

        public byte[] LogoImage { get; set; }
        public string LogoNombreArchivo { get; set; }

        public List<BancoInfo> DatosBancarios { get; set; } = new List<BancoInfo>();
        public string NotasCotizacion { get; set; }
        public int ValidezDias { get; set; } = 30;
        public string TiempoEntrega { get; set; } = "5-10 días hábiles";
        public decimal PorcentajeIGV { get; set; } = 18.00m;
        public string Moneda { get; set; } = "S/";

        // Colores de la app
        public string ColorPrimario { get; set; } = "#69383e";
        public string ColorSecundario { get; set; } = "#a6a5a0";
        public string ColorTerciario { get; set; } = "#5d5a55";
        public string ColorFondo { get; set; } = "#fefefe";

        // ✅ NUEVO: Color específico para el PDF
        public string ColorPdf { get; set; } = "#69383e";
    }
}