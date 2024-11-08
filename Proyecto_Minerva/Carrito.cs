using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;
using System.Net;
using System.Xml.Linq;

namespace Proyecto_Minerva
{
    public partial class Carrito : Form
    {
        private int _idVenta;
        private FacturacionApi api;
        private entComprobanteventa comprobante;


        public Carrito(int idVenta)
        {
            _idVenta = idVenta;
            InitializeComponent();

            ListarVentas();
            InicializarComboBoxes();
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJ1c2VybmFtZSI6ImthbmVraTIwMDQxIiwiaWF0IjoxNzMwOTU1OTY1LCJleHAiOjE3MzEwNDIzNjV9.DFID5FNHt4ZjNka_9c9Ad9-msIWmI6WVpe2jDpJE4X1G2eu_E7kmajD4UtlugAcg8e9y_OLIax-mXZlXmq_4biDdHqPsubNWEKE2z-skdlc8vXqNDeIC-Q3VexLQz01lfLRCZDKYF_VTxknxrL77INAoxmoNSaCMjhYnvCMF1HhYhveSyDKBSuoRpplRlXuoOry8d26whLySfli_fFtfn-tFZW5InOR9wUi9ITehxxqKkeJ0UWv1rYUgSZICzXK9A-oTo7Enb__4cxChsSplLaBAtAQfLMCUMI0jymjfaM-7SOiopKHGhGPfrZrAviA9bPs5MoUpumZITT_1CJTNPuiUUy02k8nlsu4_fLhoU135X4_sqtrzbnyZW7peydXQ97I8487l8V44CNkKUOgigm5jgQcfkP5yPGDq25Zi2ErRGou6RNrBTrrcu0rDROyCc2HASLerzhIpYbT9NXGcVrNW6oSwmZwIwwVFn9GIBk5RVkMDEELgl32KHpCgjTk7TIpUSPn3EAsTrrrbz1WsvpLRVy_GzEc5l8hOm1gxyYYBnL42PXCTj63nLvx8olZXI9BZzzfE7xACnp1TrKDe4xdhwPbfG21IfkNEQA-c4RzfyFx7h8_E0MI3mG8vATtNmp7RjxQaoppybqnp36bCEGPLQEuUJZ0cNrpnVrcLumA";
            api = new FacturacionApi(token);
            decimal montoTotal = logOVenta.Instancia.ObtenerMontoTotalPorId(_idVenta);
            txtTotalGravada.Text = $"S/ {montoTotal:F2}"; // Formatear como moneda
            decimal montoTotalGravado = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim());
            // Calcular IGV (18% del monto total gravado)
            decimal igv = montoTotalGravado * 0.18m;

            // Calcular subtotal
            decimal subtotal = montoTotalGravado + igv;

            // Mostrar los resultados en los TextBoxes correspondientes (ajusta los nombres según tu formulario)
            txtIGV.Text = $"S/ {igv:F2}"; // Formatea como moneda
            txtSubTotal.Text = $"S/ {subtotal:F2}"; // Formatea como moneda


            // Llamar a la capa lógica para obtener la información del cliente
            entCliente cliente = logCliente.Instancia.BuscarClientePorVentaID(_idVenta);

            if (cliente != null)
            {
                // Mostrar los datos del cliente en los TextBoxes correspondientes
                txtTipoDoc.Text = cliente.TipoDoc;
                txtDocumento.Text = cliente.Documento.ToString();
                txtNombre.Text = $"{cliente.Nombre} {cliente.Apellidos}";
                txtEmail.Text = cliente.Email;
                txtDireccion.Text = cliente.Direccion;
            }
            else
            {
                MessageBox.Show("No se encontró información del cliente para esta venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //this.FormClosing += Carrito_FormClosing;
        }

        private void ListarVentas()
        {
            try
            {
                dgvDetalleventa.DataSource = null;
                List<entOVenta> lista = logOVenta.Instancia.ListarVentasPorId(_idVenta);
                dgvDetalleventa.DataSource = lista; // Asumiendo que dgvDetalleventa es tu DataGridView
                dgvDetalleventa.Columns["Documento"].Visible = false;
                dgvDetalleventa.Columns["NombreCompleto"].Visible = false;
                dgvDetalleventa.Columns["NombreCliente"].Visible = false;
                dgvDetalleventa.Columns["MontoCambio"].Visible = false;
                dgvDetalleventa.Columns["MontoPago"].Visible = false;
                dgvDetalleventa.Columns["FRegistroV"].Visible = false;
                dgvDetalleventa.Columns["MontoTotal"].Visible = false;
                dgvDetalleventa.Columns["Descripcion"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al listar las ventas: {ex.Message}");
            }
        }

        private void InicializarComboBoxes()
        {
            // Llenado de ComboBox comboBox2 (Categorias)
            comboTipoComprobante.Items.Clear();
            List<string> Comprobante = logComprobante.Instancia.ObtenerComprobante();
            foreach (string compr in Comprobante)
            {
                comboTipoComprobante.Items.Add(compr);
            }

            comboMetodoPago.Items.Clear();
            List<string> metodo = logMetPago.Instancia.ObtenerMetodosPago();
            foreach (string met in metodo)
            {
                comboMetodoPago.Items.Add(met);
            }
        }

        private void comboTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Solo ejecuta si hay un tipo de comprobante seleccionado
            if (comboTipoComprobante.SelectedItem != null)
            {
                string tipoComprobante = comboTipoComprobante.SelectedItem.ToString();

                // Llama al método de la capa lógica para generar la serie del comprobante
                string serie = logComprobante.Instancia.GenerarNumeroComprobante(tipoComprobante);

                // Llama al método de la capa lógica para generar el correlativo del comprobante
                string correlativo = logComprobante.Instancia.GenerarCorrelativo(tipoComprobante);

                // Muestra la serie en txtSerie y el correlativo en txtCorrelativo
                txtSerie.Text = serie;
                txtCorrelativo.Text = correlativo;
            }
        }


        private async void btnEmitirComprobante_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrEmpty(txtDocumento.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtTipoDoc.Text.Trim()) ||
                comboTipoComprobante.SelectedIndex == -1 || comboMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, rellene todos los campos del Cliente y Pago.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear una lista para almacenar los detalles de los productos
                var detallesProductos = new List<object>();

                // Iterar sobre las filas del DataGridView
                foreach (DataGridViewRow row in dgvDetalleventa.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        detallesProductos.Add(new
                        {
                            codProducto = row.Cells["OventaID"].Value?.ToString(),
                            descripcion = row.Cells["Descripcion"].Value?.ToString(),
                            cantidad = cantidad,
                            mtoValorUnitario = precioVenta,
                            mtoValorVenta = precioVenta * cantidad,
                            mtoBaseIgv = precioVenta * cantidad,
                            porcentajeIgv = 18m,
                            igv = (precioVenta * cantidad) * 0.18m,
                            tipAfeIgv = 10,
                            totalImpuestos = (precioVenta * cantidad) * 0.18m,
                            mtoPrecioUnitario = precioVenta * 1.18m
                        });
                    }
                }

                // Obtener los totales
                decimal mtoOperGravadas = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim());
                decimal mtoIGV = Convert.ToDecimal(txtIGV.Text.Replace("S/", "").Trim());
                decimal subTotal = Convert.ToDecimal(txtSubTotal.Text.Replace("S/", "").Trim());

                var facturacionData = new
                {
                    ublVersion = "2.1",
                    tipoOperacion = "0101",
                    tipoDoc = "03",
                    serie = txtSerie.Text,
                    correlativo = txtCorrelativo.Text,
                    fechaEmision = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                    formaPago = new
                    {
                        moneda = "PEN",
                        tipo = comboMetodoPago.Text.Trim(),
                    },
                    tipoMoneda = "PEN",
                    client = new
                    {
                        tipoDoc = txtTipoDoc.Text.Trim(),
                        numDoc = txtDocumento.Text.Trim(),
                        rznSocial = txtNombre.Text.Trim(),
                        address = new
                        {
                            direccion = txtDireccion.Text.Trim(),
                            provincia = "LIMA",
                            departamento = "LIMA",
                            distrito = "LIMA",
                            ubigueo = "150101"
                        }
                    },
                    company = new
                    {
                        ruc = 20482329731,
                        razonSocial = "Minerva",
                        nombreComercial = "Minerva",
                        address = new
                        {
                            direccion = "Av. America Oeste Mz H Lt 27, Trujillo, Peru",
                            provincia = "Trujillo",
                            departamento = "La Libertad",
                            distrito = "Trujillo",
                            ubigueo = "150101"
                        }
                    },
                    mtoOperGravadas = mtoOperGravadas,
                    mtoIGV = mtoIGV,
                    valorVenta = mtoOperGravadas,
                    totalImpuestos = mtoIGV,
                    subTotal = subTotal,
                    mtoImpVenta = subTotal,
                    details = detallesProductos,
                    legends = new[]
                    {
                new
                {
                    code = "1000",
                    value = ConvertirNumeroALetras(subTotal) + " SOLES"
                }
            }
                };

                // Registrar el comprobante en la base de datos local
                entComprobanteventa comprobante = new entComprobanteventa
                {
                    id_venta = _idVenta,
                    descripcion = comboTipoComprobante.SelectedItem.ToString(),
                    numero_comprobante = txtSerie.Text,
                    fecha_emision = dateTimePicker2.Value,
                    subtotal = Convert.ToDecimal(txtSubTotal.Text.Replace("S/", "").Trim()),
                    igv = Convert.ToDecimal(txtIGV.Text.Replace("S/", "").Trim()),
                    total = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim())
                };

                int idComprobante = logComprobante.Instancia.RegistrarComprobantePago(comprobante);
                MessageBox.Show($"Comprobante registrado con ID: {idComprobante}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Generar y guardar el PDF usando el nuevo cliente HTTP
                string url = "https://facturacion.apisperu.com/api/v1/invoice/pdf";
                string pdfPath = api.PostForPdfResponse(url, facturacionData);

                if (!string.IsNullOrEmpty(pdfPath))
                {
                    MessageBox.Show($"PDF generado y guardado como: {pdfPath}", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el PDF con el visor predeterminado
                    try
                    {
                        var psi = new System.Diagnostics.ProcessStartInfo
                        {
                            UseShellExecute = true,
                            FileName = pdfPath
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al abrir el PDF: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al emitir factura: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para convertir número a letras (debes implementar esta función)
        private string ConvertirNumeroALetras(decimal numero)
        {
            // Implementa la lógica para convertir el número a letras
            // Por ejemplo: "CIENTO DIECIOCHO CON 00/100"
            return "IMPLEMENTAR CONVERSIÓN A LETRAS";
        }

        private List<object> ObtenerItems()
        {
            var items = new List<object>();
            // Asumiendo que tienes un DataGridView llamado dgvItems
            foreach (DataGridViewRow row in dgvDetalleventa.Rows)
            {
                if (!row.IsNewRow)
                {
                    items.Add(new
                    {
                        producto = row.Cells["NombreCliente"].Value.ToString(),
                        cantidad = row.Cells["Cantidad"].Value.ToString(),
                        precio_base = row.Cells["PrecioBase"].Value.ToString(),
                        codigo_sunat = row.Cells["CodigoSunat"].Value.ToString(),
                        codigo_producto = row.Cells["CodigoProducto"].Value.ToString(),
                        codigo_unidad = row.Cells["CodigoUnidad"].Value.ToString(),
                        tipo_igv_codigo = "10" // Asumiendo gravado - operación onerosa, ajusta según sea necesario
                    });
                }
            }
            return items;
        }
        private void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            // Obtener el documento del TextBox (suponiendo que se llama txtDocumento)
            string documento = txtDocumento.Text.Trim();

            // Validar que el documento no esté vacío
            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor, ingrese un documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una instancia de logCliente (ajusta esto según cómo se inicializa en tu aplicación)
            var logCliente = new logCliente(); // Asegúrate de que esta línea sea correcta

            // Buscar el cliente por documento usando el método de la capa lógica
            entCliente cliente = logCliente.BuscarClientePorID(documento);

            // Validar si se encontró el cliente
            if (cliente != null)
            {
                // Mostrar los datos en los TextBox correspondientes
                txtTipoDoc.Text = cliente.TipoDoc; // Asumiendo que txtTipoDoc es un TextBox
                txtNombre.Text = $"{cliente.Nombre} {cliente.Apellidos}"; // Asumiendo que tienes un TextBox para el nombre
                txtDireccion.Text = cliente.Direccion; // Asumiendo que txtDireccion es un TextBox
                txtEmail.Text = cliente.Email;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private MercadoPagoService _mpService;
        private string _currentPaymentId;

        private async void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mpService == null)
                {
                    _mpService = new MercadoPagoService("APP_USR-5285098916376801-110216-c16e75512007e3ff410033cc29d5ebc4-1947200127");
                }

                btnPagar.Enabled = false; // Deshabilitar el botón mientras se procesa

                decimal montoTotal = Convert.ToDecimal(txtSubTotal.Text.Replace("S/", "").Trim());
                _currentPaymentId = Guid.NewGuid().ToString();

                string paymentUrl = await _mpService.CrearPreferencia(
                    montoTotal,
                    $"Pago Minerva - Orden #{_idVenta}",
                    _currentPaymentId
                );

                Process.Start(new ProcessStartInfo
                {
                    FileName = paymentUrl,
                    UseShellExecute = true
                });

                await VerificarPagoPeriodicamenteAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnPagar.Enabled = true; // Rehabilitar el botón
            }
        }
        private async Task VerificarPagoPeriodicamenteAsync()
        {
            int intentos = 0;
            const int maximoIntentos = 20; // Tiempo máximo de espera de 5 minutos (15 segundos * 20 intentos)

            while (intentos < maximoIntentos)
            {
                try
                {
                    // Llama al método que obtiene el estado del pago
                    string estadoPago = await _mpService.ObtenerEstadoPago(_currentPaymentId);

                    if (estadoPago == "approved")
                    {
                        MessageBox.Show("¡Pago realizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (estadoPago == "in_process")
                    {
                        // El pago sigue pendiente
                    }
                    else if (estadoPago == "rejected" || estadoPago == "cancelled" || estadoPago == "expired")
                    {
                        // Si el pago fue rechazado, cancelado o expirado
                        MessageBox.Show("El pago no se realizó o fue cancelado.", "Pago no realizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Espera 15 segundos antes de volver a verificar
                    await Task.Delay(5000);
                    intentos++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al verificar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Si se agota el tiempo sin un estado "approved"
            MessageBox.Show("El tiempo de espera para la verificación del pago ha expirado. " +
                            "Por favor, verifique manualmente el estado del pago.",
                            "Tiempo agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGeneraXML_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrEmpty(txtDocumento.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtTipoDoc.Text.Trim()) ||
                comboTipoComprobante.SelectedIndex == -1 || comboMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, rellene todos los campos del Cliente y Pago.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear una lista para almacenar los detalles de los productos
                var detallesProductos = new List<object>();

                // Iterar sobre las filas del DataGridView
                foreach (DataGridViewRow row in dgvDetalleventa.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        detallesProductos.Add(new
                        {
                            codProducto = row.Cells["OventaID"].Value?.ToString(),
                            unidad = "NIU",
                            descripcion = row.Cells["Descripcion"].Value?.ToString(),
                            cantidad = cantidad,
                            mtoValorUnitario = precioVenta,
                            mtoValorVenta = precioVenta * cantidad,
                            mtoBaseIgv = precioVenta * cantidad,
                            porcentajeIgv = 18m,
                            igv = (precioVenta * cantidad) * 0.18m,
                            tipAfeIgv = 10,
                            totalImpuestos = (precioVenta * cantidad) * 0.18m,
                            mtoPrecioUnitario = precioVenta * 1.18m
                        });
                    }
                }

                // Obtener los totales desde los TextBox
                decimal mtoOperGravadas = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim());
                decimal mtoIGV = Convert.ToDecimal(txtIGV.Text.Replace("S/", "").Trim());
                decimal subTotal = Convert.ToDecimal(txtSubTotal.Text.Replace("S/", "").Trim());

                var facturacionData = new
                {
                    ublVersion = "2.1",
                    tipoOperacion = "0101",
                    tipoDoc = "03",
                    serie = txtSerie.Text,
                    correlativo = txtCorrelativo.Text,
                    fechaEmision = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                    formaPago = new
                    {
                        moneda = "PEN",
                        tipo = comboMetodoPago.Text.Trim()
                    },
                    tipoMoneda = "PEN",
                    client = new
                    {
                        tipoDoc = txtTipoDoc.Text.Trim(),
                        numDoc = txtDocumento.Text.Trim(),
                        rznSocial = txtNombre.Text.Trim(),
                        address = new
                        {
                            direccion = txtDireccion.Text.Trim(),
                            provincia = "LIMA",
                            departamento = "LIMA",
                            distrito = "LIMA",
                            ubigueo = "150101"
                        }
                    },
                    company = new
                    {
                        ruc = "20482329731",
                        razonSocial = "Minerva",
                        nombreComercial = "Minerva",
                        address = new
                        {
                            direccion = "Av. America Oeste Mz H Lt 27, Trujillo, Peru",
                            provincia = "LIMA",
                            departamento = "LIMA",
                            distrito = "LIMA",
                            ubigueo = "150101"
                        }
                    },
                    mtoOperGravadas = mtoOperGravadas,
                    mtoIGV = mtoIGV,
                    valorVenta = mtoOperGravadas,
                    totalImpuestos = mtoIGV,
                    subTotal = subTotal,
                    mtoImpVenta = subTotal,
                    details = detallesProductos,
                    legends = new[]
                    {
                new
                {
                    code = "1000",
                    value = ConvertirNumeroALetras(subTotal) + " SOLES"
                }
            }
                };

                // Llamar a la API para generar el XML usando el nuevo cliente HTTP
                string url = "https://facturacion.apisperu.com/api/v1/invoice/xml";
                string xmlContent = api.PostForXmlResponse(url, facturacionData);

                if (!string.IsNullOrEmpty(xmlContent))
                {
                    // Generar nombre de archivo único
                    string xmlPath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        $"Comprobante_{txtSerie.Text}_{DateTime.Now:yyyyMMddHHmmss}.xml"
                    );

                    try
                    {
                        // Guardar el archivo XML
                        File.WriteAllText(xmlPath, xmlContent);
                        MessageBox.Show($"XML generado y guardado como: {xmlPath}", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrir el XML con el programa predeterminado
                        var psi = new System.Diagnostics.ProcessStartInfo
                        {
                            UseShellExecute = true,
                            FileName = xmlPath
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar o abrir el XML: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo generar el XML. La respuesta está vacía.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar XML: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
