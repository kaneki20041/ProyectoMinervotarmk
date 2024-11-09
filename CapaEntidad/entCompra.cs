namespace CapaEntidad
{
    public class entCompra
    {
        public int idCompra { get; set; }
        public DateTime fechCompra { get; set; }
        public entProveedor ID { get; set; }
        public EntMetPago Metpagoid { get; set; }

        public int IDProveedor { get; set; }

        public entProveedor RazonSocial { get; set; }

        public string RazonSocia { get; set; }

        public int Metodopagoid { get; set; }

        public entUsuario NombreCompleto { get; set; }

        public int UsuID { get; set; }
        public int? PrendaID { get; set; } // Agregado
        public string Descripcion { get; set; } // Agregado

        public int Cantidad { get; set; } // Agregado
        public decimal PrecioCompra { get; set; } // Agregado

        public Decimal Monto { get; set; }
        //public entCompra()
        //{
        //    ID=new entProveedor();
        //    Metpagoid = new EntMetPago();
        //}
    }
}