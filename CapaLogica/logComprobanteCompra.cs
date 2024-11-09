using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapaLogica
{
    public class logComprobanteCompra
    {
        private static readonly logComprobanteCompra instancia = new logComprobanteCompra();
        public static logComprobanteCompra Instancia
        {
            get { return instancia; }
        }

        public string GenerarNumeroComprobanteCompra()
        {
            // Llama al método de la capa de datos para generar el número de comprobante
            return datComprobanteCompra.Instancia.GenerarNumeroComprobanteCompra();
        }

        public int GenerarNuevoNumeroCorrelativo()
        {
            return datComprobanteCompra.Instancia.GenerarCorrelativoCompra();
        }
    }
}
