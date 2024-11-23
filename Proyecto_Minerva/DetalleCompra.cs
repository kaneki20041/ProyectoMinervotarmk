using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
using Newtonsoft.Json;

namespace Proyecto_Minerva
{
    public partial class DetalleCompra : Form
    {
        private int _idCompra;
        private FacturacionApi api;

        public DetalleCompra(int idCompra)
        {
            _idCompra = idCompra;
            InitializeComponent();
            comboMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            //ListarPedidos();
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJ1c2VybmFtZSI6ImthbmVraTIwMDQxIiwiaWF0IjoxNzMyMzQ3OTM0LCJleHAiOjE3MzI0MzQzMzR9.lkgPuHwu8gFdeyjN69ARUycodJOvWQ65F6_L4hKMproHudR92w3UwTN7ew-t0Ejqt1423YJBdklSv9MYWQz0jH_o3P5FPZtt3elqxxrpXXAllPJsoAycqACn0WmrXLsGHzA2zPnsVtZw_TjeoI_2viYr-PvD_-5fgACzxzIiDDpoSBM08WncBA3_EKvF0wjyRRbqHDhPhtHO3O8-NxIn1P-DFrUsiaGxXctW1ZwClTPtsxWqyuxVPebfUudgIc9MKcM0ZVDyb9pkIHjDU-BgfRRDc9japj0FH8UXIi4dbMaExKfPSI46VqwD3i0PW2cQASP9tLvMSS_YZOSEeAUrSSeVxiZl16UBxMwwAI2Sa_9f4pBJoa69IBrHpaWRHV8EDxgU9QTaQxKbHYxICbUr_LjQ1ZkoOLifSyT9t28MZ_sk6ftS2OqjpnejECEJ95i7jOUxOUgAB3kBg5Kge0MVwBJMohkxBwKWmrjtwBhevrTuDA-fuu-7OgMnv9w_UE5hrQmbBtNmDZGrfEddqc_s7muQDg_pf8xF66BJzmPhqG_kCTOA2uceiWs434rxLt2fD6cQgie6ISt-Zxy4ZnwN2VijFw_qyFfQJGH0JBnwYuZGdsLJdT00PYv_w3VRSBBrGssbBfE0Yf2t3VkLlaaztQX_Zo8C6LL3dzwIDgb55WY";
            api = new FacturacionApi(token);
            InicializarComboBoxes();
            ListarCompras();

            // Obtener el monto total de la compra
            decimal montoTotal = logCompra.Instancia.ObtenerMontoTotalPorId(_idCompra);
            txtTotalGravada.Text = $"S/ {montoTotal:F2}"; // Formatear como moneda

            // Obtener el monto total gravado desde txtTotalGravada
            decimal montoTotalGravado = Convert.ToDecimal(txtTotalGravada.Text.Replace("S/", "").Trim());

            // Calcular IGV (18% del monto total gravado)
            decimal igv = montoTotalGravado * 0.18m;

            // Calcular subtotal (monto gravado + IGV)
            decimal subtotal = montoTotalGravado + igv;

            // Calcular el total exonerado (monto total de la factura - monto gravado - IGV)
            decimal montoTotalExoneradas = montoTotal - montoTotalGravado - igv;

            // Mostrar los resultados en los TextBoxes correspondientes (ajusta los nombres según tu formulario)
            txtIGV.Text = $"S/ {igv:F2}"; // Formatear como moneda
            txtSubTotal.Text = $"S/ {subtotal:F2}"; // Formatear como moneda
            txtTotalExoneradas.Text = $"S/ {montoTotalExoneradas:F2}"; // Mostrar el total exonerado

            // Generar el número de comprobante
            string numeroComprobante = logComprobanteCompra.Instancia.GenerarNumeroComprobanteCompra();
            txtSerie.Text = numeroComprobante;

            // Generar el número correlativo
            int numeroCorrelativo = logComprobanteCompra.Instancia.GenerarNuevoNumeroCorrelativo();
            txtCorrelativo.Text = numeroCorrelativo.ToString(); // Convertir el número a string

            // Llamar a la capa lógica para obtener la información del proveedor
            entProveedor prov = logProveedor.Instancia.BuscarProveedorporID(_idCompra);

            if (prov != null)
            {
                // Mostrar los datos del proveedor en los TextBoxes correspondientes
                txtRubro.Text = prov.Rubro;
                txtDocumento.Text = prov.RUC.ToString();
                txtNombre.Text = prov.NombreComercial.ToString();
                txtEmail.Text = prov.Email;
                txtDireccion.Text = prov.Direccion;
            }
            else
            {
                MessageBox.Show("No se encontró información del proveedor para esta compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void ListarCompras()
        {
            try
            {
                detallito.DataSource = null;
                List<entCompra> lista = logCompra.Instancia.ListarComprasPorId(_idCompra);
                detallito.DataSource = lista; // Asumiendo que dgvDetalleventa es tu DataGridView
                detallito.Columns["fechCompra"].Visible = false;
                detallito.Columns["ID"].Visible = false;
                detallito.Columns["Metodopagoid"].Visible = false;
                detallito.Columns["Metpagoid"].Visible = false;
                detallito.Columns["NombreCompleto"].Visible = false;
                detallito.Columns["IDProveedor"].Visible = false;
                detallito.Columns["RazonSocial"].Visible = false;
                detallito.Columns["RazonSocia"].Visible = false;
                detallito.Columns["UsuID"].Visible = false;
                detallito.Columns["Descripcion"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al listar las ventas: {ex.Message}");
            }
        }

        private void InicializarComboBoxes()
        {
            comboMetodoPago.Items.Clear();
            List<string> metodo = logMetPago.Instancia.ObtenerMetodosPago();
            foreach (string met in metodo)
            {
                comboMetodoPago.Items.Add(met);
            }
        }
        private void btnEmitirComprobante_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrEmpty(txtDocumento.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtRubro.Text.Trim()) ||
                string.IsNullOrEmpty(txtBoxTipoComprobante.Text.Trim()))
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
                foreach (DataGridViewRow row in detallito.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioCompra"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        detallesProductos.Add(new
                        {
                            codProducto = row.Cells["idCompra"].Value?.ToString(),
                            unidad = "NIU", // Asegúrate de que este dato se puede obtener correctamente
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

                // Crear el cuerpo de la solicitud
                var facturacionData = new
                {
                    ublVersion = "2.1",
                    tipoOperacion = "0101",
                    tipoDoc = "03", // Asegúrate de que este tipo de documento sea el correcto
                    serie = txtSerie.Text,
                    correlativo = txtCorrelativo.Text,
                    fechaEmision = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                    formaPago = new
                    {
                        moneda = "PEN",
                        tipo = txtBoxTipoComprobante.Text,
                    },
                    tipoMoneda = "PEN",
                    client = new
                    {
                        tipoDoc = txtRubro.Text.Trim(),
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
                        ruc = 20482329731, // Modifica esto si es necesario
                        razonSocial = "Minerva",
                        nombreComercial = "Minerva",
                        address = new
                        {
                            direccion = "Av. America Oeste Mz H Lt 27, Trujillo, Peru", // Modifica según la empresa
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
                entComprobanteCompra comprobante = new entComprobanteCompra
                {
                    id_compra = _idCompra,
                    descripcion = txtBoxTipoComprobante.Text,
                    numero_comprobante = txtSerie.Text,
                    fecha_emision = dateTimePicker2.Value,
                    subtotal = mtoOperGravadas,
                    igv = mtoIGV,
                    total = mtoOperGravadas + mtoIGV
                };

                int idComprobante = logComprobante.Instancia.RegistrarComprobantePagoCompra(comprobante);
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

        private void btnGeneraXML_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrEmpty(txtDocumento.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtRubro.Text.Trim()) ||
                string.IsNullOrEmpty(txtBoxTipoComprobante.Text.Trim()) || comboMetodoPago.SelectedIndex == -1)
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
                foreach (DataGridViewRow row in detallito.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioCompra"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        detallesProductos.Add(new
                        {
                            codProducto = row.Cells["PrendaID"].Value?.ToString(),
                            unidad = "NIU",  // Asegúrate de tener la unidad en el DataGridView
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
                decimal mtoOperExoneradas = Convert.ToDecimal(txtTotalExoneradas.Text.Replace("S/", "").Trim());
                decimal mtoIGV = Convert.ToDecimal(txtIGV.Text.Replace("S/", "").Trim());
                decimal subTotal = Convert.ToDecimal(txtSubTotal.Text.Replace("S/", "").Trim());
                decimal totalImpuestos = mtoOperGravadas * 0.18m;

                var facturacionData = new
                {
                    ublVersion = "2.1",
                    fecVencimiento = DateTime.Now.AddDays(30).ToString("yyyy-MM-ddTHH:mm:sszzz"), // Fecha de vencimiento, se ajusta a 30 días por defecto
                    tipoOperacion = "0101",
                    tipoDoc = "01", // Para factura
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
                        tipoDoc = txtRubro.Text.Trim(),
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
                    mtoOperExoneradas = mtoOperExoneradas,
                    mtoIGV = mtoIGV,
                    totalImpuestos = totalImpuestos,
                    valorVenta = mtoOperGravadas,
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

        private void btnEstadoSunat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumento.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtRubro.Text.Trim()) ||
                string.IsNullOrEmpty(txtBoxTipoComprobante.Text.Trim()) || comboMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, rellene todos los campos del Cliente y Pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear una lista para almacenar los detalles de los productos
                var detallesProductos = new List<object>();

                // Iterar sobre las filas del DataGridView
                foreach (DataGridViewRow row in detallito.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        decimal precioVenta = Convert.ToDecimal(row.Cells["PrecioCompra"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        detallesProductos.Add(new
                        {
                            codProducto = row.Cells["idCompra"].Value?.ToString(),
                            unidad = "NIU", // Unidad por defecto
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
                    tipoOperacion = "0101",  // Definir el tipo de operación
                    tipoDoc = "01",  // Tipo de documento (Factura)
                    serie = txtSerie.Text,
                    correlativo = "123",
                    fechaEmision = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                    formaPago = new
                    {
                        moneda = "PEN",
                        tipo = "Contado"  // Tipo de pago
                    },
                    tipoMoneda = "PEN",
                    client = new
                    {
                        tipoDoc = "6",  // Tipo de documento del cliente
                        numDoc = txtDocumento.Text.Trim(),  // Número de documento del cliente
                        rznSocial = txtNombre.Text.Trim(),  // Razón social del cliente
                        address = new
                        {
                            direccion = txtDireccion.Text.Trim(),
                            provincia = "LIMA",  // Provincia por defecto
                            departamento = "LIMA",  // Departamento por defecto
                            distrito = "LIMA",  // Distrito por defecto
                            ubigueo = "150101"  // Código de ubigeo de Lima
                        }
                    },
                    company = new
                    {
                        ruc = 20482329731,  // RUC de la empresa
                        razonSocial = "Minerva",  // Razón social de la empresa
                        nombreComercial = "Minerva",  // Nombre comercial de la empresa
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
                    legends = new[] {
                new {
                    code = "1000",
                    value = ConvertirNumeroALetras(subTotal) + " SOLES"
                }
            }
                };

                // Llamar a la API para generar el XML
                string url = "https://facturacion.apisperu.com/api/v1/invoice/send";
                dynamic respuesta = api.PostForJsonResponse(url, facturacionData);

                // Verificar la respuesta y manejar el XML
                if (respuesta != null)
                {
                    if (respuesta.sunatResponse != null)
                    {
                        string mensajeSunat = respuesta.sunatResponse.ToString();
                        MessageBox.Show($"Respuesta de SUNAT: {mensajeSunat}", "Respuesta SUNAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (respuesta.xmlSigned != null)
                    {
                        // Guardar el XML en documentos
                        string xmlPath = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                            $"Comprobante_{txtSerie.Text}_{DateTime.Now:yyyyMMddHHmmss}.xml"
                        );

                        try
                        {
                            File.WriteAllText(xmlPath, respuesta.xmlSigned.ToString());
                            MessageBox.Show($"XML guardado en: {xmlPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (File.Exists(xmlPath))
                            {
                                var psi = new System.Diagnostics.ProcessStartInfo
                                {
                                    UseShellExecute = true,
                                    FileName = xmlPath
                                };

                                System.Diagnostics.Process.Start(psi);
                            }
                            else
                            {
                                MessageBox.Show("El archivo XML no se ha guardado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al guardar o abrir el XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se recibió respuesta de la API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
