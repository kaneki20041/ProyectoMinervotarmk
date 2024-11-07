using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCliente
    {
        #region Singleton
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion Singleton

        #region Metodos

        /// Listado
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        #endregion Metodos

        public void InsertaCliente(entCliente cli)
        {
            datCliente.Instancia.InsertaCliente(cli);
        }

        //public void ModificarCliente(entCliente cliente)
        //{
        //    datCliente.Instancia.ModificarCliente(cliente);
        //}
        public string BuscarNombreCompletoPorDocumento(int documento)
        {
            return datCliente.Instancia.BuscarDocCliente(documento);
        }
        public entCliente BuscarClientePorID(string documento)
        {
            return datCliente.Instancia.BuscarClientePorID(documento);
        }
        public entCliente BuscarClientePorVentaID(int oventaID)
        {
            try
            {
                return datCliente.Instancia.BuscarClientePorVentaID(oventaID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la lógica al buscar cliente por venta ID: " + ex.Message);
            }
        }
        public List<string> ObtenerTiposClientes()
        {
            return datCliente.Instancia.ObtenerTiposClientes();
        }

        public List<string> ObtenerTiposDocumentos()
        {
            return datCliente.Instancia.ObtenerTiposDocumentos();
        }


    }
}