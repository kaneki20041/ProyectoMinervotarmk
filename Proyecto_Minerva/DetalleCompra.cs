using CapaEntidad;
using CapaLogica;
using Newtonsoft.Json;

namespace Proyecto_Minerva
{
    public partial class DetalleCompra : Form
    {
        public DetalleCompra()
        {
            InitializeComponent();
            ListarPedidos();
        }

        public void ListarPedidos()
        {
            List<entCompra> listaCompra = logCompra.Instancia.ListarCompra();

            if (listaCompra.Count >= 0)
            {
                detallito.Columns.Clear(); // se eliminan todas las columnas existentes del DataGridView antes de mostrar el resultado de la consulta
                //BindingSource datosEnlazados = new BindingSource(); // objeto para vincular el resultado de la consulta al DataGridView
                //datosEnlazados.DataSource = listaPedido;
                ///tablaPedidos.DataSource = datosEnlazados; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                detallito.DataSource = listaCompra; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                                                    //tablaPedidos.Rows[listaPedido.Count - 1].Cells[2].Value = listaPedido[listaPedido.Count - 1].idCliente.idCliente;

                this.detallito.Columns["ID"].Visible = false;
                this.detallito.Columns["Metpagoid"].Visible = false;
                this.detallito.Columns["UsuarioID"].Visible = false;
                this.detallito.Columns["RazonSocial"].Visible = false;
                //configurarColumnasDataGridView();
                //tablaPedidos.Rows[0].Selected = false; // permite que la primera fila del DataGridView no esté seleccionada
            }
        }

        //private void btnEmitirComprobante_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtDocumento.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
        //        string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtTipoDoc.Text.Trim()) ||
        //        comboTipoComprobante.SelectedIndex == -1 || comboMetodoPago.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Por favor, rellene todos los campos del Cliente y Pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        // Crear una lista para almacenar los detalles de los productos
        //        var detallesProductos = new List<object>();

        //        // Iterar sobre las filas del DataGridView
        //        foreach (DataGridViewRow row in dgvDetalleventa.Rows)
        //        {
        //            // Asegúrate de no procesar la fila de nuevo registro si está presente
        //            if (!row.IsNewRow)
        //            {
        //                decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value);
        //                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

        //                detallesProductos.Add(new
        //                {
        //                    codProducto = row.Cells["OventaID"].Value?.ToString(),
        //                    descripcion = row.Cells["Descripcion"].Value?.ToString(),
        //                    cantidad = cantidad,
        //                    mtoValorUnitario = precioVenta,
        //                    mtoValorVenta = precioVenta * cantidad,
        //                    mtoBaseIgv = precioVenta * cantidad,
        //                    porcentajeIgv = 18m,
        //                    igv = (precioVenta * cantidad) * 0.18m,
        //                    tipAfeIgv = 10,
        //                    totalImpuestos = (precioVenta * cantidad) * 0.18m,
        //                    mtoPrecioUnitario = precioVenta * 1.18m
        //                });
        //            }
        //        }

        //        // Obtener los totales desde los TextBox
        //        decimal mtoOperGravadas = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim());
        //        decimal mtoIGV = Convert.ToDecimal(txtIGV.Text.Replace("S/", "").Trim());
        //        decimal subTotal = Convert.ToDecimal(txtSubTotal.Text.Replace("S/", "").Trim());

        //        var facturacionData = new
        //        {
        //            ublVersion = "2.1",
        //            tipoOperacion = "0101",
        //            tipoDoc = "03",
        //            serie = txtSerie.Text,
        //            correlativo = "1",
        //            fechaEmision = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
        //            formaPago = new
        //            {
        //                moneda = "PEN",
        //                tipo = comboMetodoPago.Text.Trim(),
        //            },
        //            tipoMoneda = "PEN",
        //            client = new
        //            {
        //                tipoDoc = txtTipoDoc.Text.Trim(),
        //                numDoc = txtDocumento.Text.Trim(),
        //                rznSocial = txtNombre.Text.Trim(),
        //                address = new
        //                {
        //                    direccion = txtDireccion.Text.Trim(),
        //                    provincia = "LIMA",
        //                    departamento = "LIMA",
        //                    distrito = "LIMA",
        //                    ubigueo = "150101"
        //                }
        //            },
        //            company = new
        //            {
        //                ruc = 20482329731,
        //                razonSocial = "Minerva",
        //                nombreComercial = "Minerva",
        //                address = new
        //                {
        //                    direccion = "Av. America Oeste Mz H Lt 27, Trujillo, Peru",
        //                    provincia = "Trujillo",
        //                    departamento = "La Libertad",
        //                    distrito = "Trujillo",
        //                    ubigueo = "150101"
        //                }
        //            },
        //            mtoOperGravadas = mtoOperGravadas,
        //            mtoIGV = mtoIGV,
        //            valorVenta = mtoOperGravadas,
        //            totalImpuestos = mtoIGV,
        //            subTotal = subTotal,
        //            mtoImpVenta = subTotal,
        //            details = detallesProductos,
        //            legends = new[]
        //            {
        //        new
        //        {
        //            code = "1000",
        //            value = ConvertirNumeroALetras(subTotal) + " SOLES"
        //        }
        //    }
        //        };
        //        entComprobanteventa comprobante = new entComprobanteventa
        //        {
        //            id_venta = _idVenta,
        //            descripcion = comboTipoComprobante.SelectedItem.ToString(),
        //            numero_comprobante = txtSerie.Text,
        //            fecha_emision = dateTimePicker2.Value,
        //            subtotal = Convert.ToDecimal(txtSubTotal.Text.Replace("S/", "").Trim()),
        //            igv = Convert.ToDecimal(txtIGV.Text.Replace("S/", "").Trim()),
        //            total = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim())
        //        };
        //        int idComprobante = logComprobante.Instancia.RegistrarComprobantePago(comprobante);

        //        MessageBox.Show($"Comprobante registrado con ID: {idComprobante}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        string url = "https://facturacion.apisperu.com/api/v1/invoice/pdf";
        //        dynamic respuesta = api.Post(url, facturacionData);

        //        // Verificar si el PDF fue guardado correctamente
        //        if (respuesta != null && respuesta.pdf_url != null)
        //        {
        //            string pdfPath = respuesta.pdf_url.ToString();

        //            // Asegurarse de que la ruta sea absoluta
        //            if (!Path.IsPathRooted(pdfPath))
        //            {
        //                pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), pdfPath);
        //            }

        //            MessageBox.Show($"PDF generado y guardado como: {pdfPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Abrir el PDF con el visor predeterminado
        //            try
        //            {
        //                var psi = new System.Diagnostics.ProcessStartInfo
        //                {
        //                    UseShellExecute = true,
        //                    FileName = pdfPath
        //                };
        //                System.Diagnostics.Process.Start(psi);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Error al abrir el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Respuesta de la API: {JsonConvert.SerializeObject(respuesta, Formatting.Indented)}", "Respuesta de la API", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        dgvDetalleventa.DataSource = null;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al emitir factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
