﻿using CapaDatos;
using CapaEntidad;
using CapaLogica;
using CapaPresentacion;
using System.Transactions;

namespace Proyecto_Minerva
{
    public partial class CompraPrenda : Form
    {
        entCompra Compra = new entCompra();
        entDetCompra dCom = new entDetCompra();

        public CompraPrenda()
        {
            InitializeComponent();
            dCom = new entDetCompra();

            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            listarMetodoPago();
            Deshabilitar();
        }

        private void CompraPrenda_Load_1(object sender, EventArgs e)
        {
            CargarNombreCompleto();
            CargarTotalCompras();
        }

        private void BuscProveedor_Click(object sender, EventArgs e)
        {
            using (ReporteProveedor formRepProve = new ReporteProveedor())
            {
                if (formRepProve.ShowDialog() == DialogResult.OK)
                {
                    txtNombreRUC.Text = formRepProve.nombreComercial;
                    txtRazonRUC.Text = formRepProve.razonSocial;
                    txtRUC.Text = formRepProve.ruc;
                }
            }
        }
        public void listarMetodoPago()
        {
            cmbMetodoPago.DataSource = logMetPago.Instancia.ListarMetPago();
            cmbMetodoPago.DisplayMember = "metodopago";
            cmbMetodoPago.ValueMember = "MetPagoid";
        }

        private void btn_buscarPrenVen_Click(object sender, EventArgs e)
        {
            using (ReportePrendas formRepPrenda = new ReportePrendas())
            {
                if (formRepPrenda.ShowDialog() == DialogResult.OK)
                {
                    txtNombrePrenda.Text = formRepPrenda.descripcion;
                    txtTalla.Text = formRepPrenda.talla;
                    txtColegio.Text = formRepPrenda.colegio;
                    txtCategoria.Text = formRepPrenda.categoria;
                    txtPrecioCompra.Text = formRepPrenda.precioCompra;
                    txtStock.Text = formRepPrenda.stock;
                }
            }
        }

        public int confilas = 0;
        public decimal Total = 0;

        private void AgreCompra_Click(object sender, EventArgs e)
        {
            entCompra dCom = new entCompra();
            entPrendas Pren = new entPrendas();

            if ((this.txtRUC.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                int cantidadSolicitada = Convert.ToInt32(txtCantidad.Text);
                int stockDisponible = string.IsNullOrEmpty(txtStock.Text) ? 0 : Convert.ToInt32(txtStock.Text);

                if (cantidadSolicitada > 0)
                {

                    // Agregar a la tabla de compras
                    tablaCompras.Rows.Add(txtNombrePrenda.Text, txtCategoria.Text, txtColegio.Text, txtTalla.Text, txtCantidad.Text, txtPrecioCompra.Text);
                    decimal subTotal = Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[4].Value) * Convert.ToDecimal(tablaCompras.Rows[confilas].Cells[5].Value);
                    tablaCompras.Rows[confilas].Cells[6].Value = subTotal;
                    confilas++;

                    // Recalcular el total
                    Total = 0;
                    foreach (DataGridViewRow Fila in tablaCompras.Rows)
                    {
                        Total += Convert.ToInt32(Fila.Cells[6].Value);
                    }
                    cmbMonto.Text = Total.ToString();
                }
                else
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                Total -= Convert.ToDecimal(tablaCompras.Rows[tablaCompras.CurrentRow.Index].Cells[6].Value);
                //txtTotal.Text = "S/." + Total.ToString();
                cmbMonto.Text = Total.ToString();
                tablaCompras.Rows.RemoveAt(tablaCompras.CurrentRow.Index);
                confilas--;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos requeridos antes de proceder
                if (string.IsNullOrEmpty(cmbMonto.Text) || string.IsNullOrEmpty(txtRUC.Text) ||
                    string.IsNullOrEmpty(cmbMetodoPago.Text) || string.IsNullOrEmpty(txtVendedor.Text))
                {
                    MessageBox.Show("Todos los campos son requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que haya detalles en la tabla
                if (tablaCompras.Rows.Count <= 1)
                {
                    MessageBox.Show("Debe agregar al menos un detalle de compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Preguntar al usuario si ha terminado de registrar la compra
                DialogResult result = MessageBox.Show("¿Has terminado de registrar la compra?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Puedes continuar agregando detalles a la compra.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear y poblar el objeto de compra
                entCompra Com = new entCompra();
                entProveedor p = new entProveedor();
                EntMetPago met = new EntMetPago();
                entUsuario u = new entUsuario();
                int idCom = 0;

                try
                {
                    Com.fechCompra = dateTimePicker1.Value;
                    Com.Monto = Convert.ToDecimal(cmbMonto.Text);
                    p.RUC = txtRUC.Text;
                    p.RazonSocial = txtRazonRUC.Text;
                    met.MetPagoid = Convert.ToInt32(cmbMetodoPago.SelectedValue);
                    u.NombreCompleto = txtVendedor.Text;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, verifique que los valores numéricos sean correctos",
                                  "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Com.NombreCompleto = u;
                Com.Metpagoid = met;
                Com.ID = p;
                Com.RazonSocial = p;

                // Usar TransactionScope para asegurar la integridad de la transacción
                using (TransactionScope scope = new TransactionScope())
                {
                    // Registrar la compra
                    idCom = logCompra.Instancia.InsertarCompra(Com);
                    if (idCom <= 0)
                    {
                        MessageBox.Show("Error al registrar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Grabar los detalles
                    if (GrabarDetalle(idCom))
                    {
                        scope.Complete();
                        MessageBox.Show("Compra registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al grabar los detalles de la compra.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Redirigir al formulario DetalleCompra después de que la transacción haya sido completada
                Form Principal = this.ParentForm;
                Panel panelContainer = (Panel)Principal.Controls["panelconteiner"];
                panelContainer.Controls.Clear();

                DetalleCompra formDetalle = new DetalleCompra(idCom); // Asumiendo que DetalleCompra acepta un idCompra en su constructor
                formDetalle.TopLevel = false;
                formDetalle.FormBorderStyle = FormBorderStyle.None;
                formDetalle.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(formDetalle);
                formDetalle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool GrabarDetalle(int cod)
        {
            bool todoCorrecto = true;
            List<string> errores = new List<string>();

            try
            {
                foreach (DataGridViewRow fila in tablaCompras.Rows)
                {
                    if (fila.IsNewRow || fila.Cells[0].Value == null)
                        continue;

                    try
                    {
                        // Crear nuevo objeto para cada detalle
                        entDetCompra detalleCompra = new entDetCompra();
                        detalleCompra.idCompra = cod;

                        // Validar y obtener la descripción
                        if (string.IsNullOrWhiteSpace(fila.Cells[0].Value?.ToString()))
                        {
                            errores.Add($"Fila {fila.Index + 1}: La descripción está vacía");
                            todoCorrecto = false;
                            continue;
                        }

                        entPrendas pren = new entPrendas();
                        pren.Descripcion = fila.Cells[0].Value.ToString().Trim();
                        pren.Talla = fila.Cells[3].Value.ToString().Trim();
                        detalleCompra.Prenda = pren;

                        // Validar y obtener la cantidad y precio
                        if (!int.TryParse(fila.Cells[4].Value?.ToString(), out int cantidad))
                        {
                            errores.Add($"Fila {fila.Index + 1}: Cantidad inválida");
                            todoCorrecto = false;
                            continue;
                        }

                        if (!decimal.TryParse(fila.Cells[5].Value?.ToString(), out decimal precio))
                        {
                            errores.Add($"Fila {fila.Index + 1}: Precio inválido");
                            todoCorrecto = false;
                            continue;
                        }

                        if (cantidad <= 0 || precio <= 0)
                        {
                            errores.Add($"Fila {fila.Index + 1}: Cantidad y precio deben ser mayores a 0");
                            todoCorrecto = false;
                            continue;
                        }

                        detalleCompra.cantPrenda = cantidad;
                        detalleCompra.precPrenda = precio;

                        // Intentar insertar el detalle
                        try
                        {
                            logCompra.Instancia.InsertarDetCompra(detalleCompra);
                        }
                        catch (Exception ex)
                        {
                            errores.Add($"Fila {fila.Index + 1}: Error al grabar el detalle - {ex.Message}");
                            todoCorrecto = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        errores.Add($"Fila {fila.Index + 1}: {ex.Message}");
                        todoCorrecto = false;
                    }
                }

                if (errores.Count > 0)
                {
                    string mensajeError = "Se encontraron los siguientes errores:\n\n" +
                                        string.Join("\n", errores);
                    MessageBox.Show(mensajeError, "Errores en detalles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return todoCorrecto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al grabar detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void Limpiar()
        {
            this.tablaCompras.Rows.Clear();
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número (permitir sólo números del 0-9)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número, cancelar el evento para no permitir la entrada
                e.Handled = true;
            }

            // Verificar si ya se ha alcanzado la longitud máxima de 9 caracteres
            if (txtRUC.Text.Length >= 20 && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento si se intenta agregar más de 9 caracteres
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número (permitir sólo números del 0-9)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es un número, cancelar el evento para no permitir la entrada
                e.Handled = true;
            }

            // Verificar si ya se ha alcanzado la longitud máxima de 9 caracteres
            if (txtCantidad.Text.Length >= 6 && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento si se intenta agregar más de 9 caracteres
                e.Handled = true;
            }
        }
        public void Deshabilitar()
        {
            gbInfoUser.Enabled = false;
            gbInfoProveedor.Enabled = false;
            gbInfoPrenda.Enabled = false;
            tablaCompras.Enabled = false;
            cmbMonto.Enabled = false;
            cmbMetodoPago.Enabled = false;
            btnGrabar.Enabled = false;
        }
        public void LimpiarVariables()
        {
            txtNombreRUC.Clear();
            txtCantidad.Clear();
            txtCategoria.Clear();
            txtColegio.Clear();
            txtNombrePrenda.Clear();
            txtPrecioCompra.Clear();
            txtRazonRUC.Clear();
            txtRUC.Clear();
            txtStock.Clear();
            txtTalla.Clear();
            txtVendedor.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbInfoUser.Enabled = true;
            gbInfoProveedor.Enabled = true;
            gbInfoPrenda.Enabled = true;
            tablaCompras.Enabled = true;
            cmbMonto.Enabled = true;
            cmbMetodoPago.Enabled = true;
            btnGrabar.Enabled = true;
        }

        private void CargarNombreCompleto()
        {
            logOVenta logicVenta = new logOVenta();

            // Aquí puedes ajustar según tu lógica para obtener el usuario
            var usuariosConectados = logicVenta.ListarUsuariosConectados();

            // Supongamos que solo necesitas el primer usuario conectado
            if (usuariosConectados.Count > 0)
            {
                txtVendedor.Text = usuariosConectados[0]; // Cargar el NombreCompleto en el TextBox
            }
            else
            {
                txtVendedor.Text = "No hay usuarios conectados"; // Mensaje alternativo
            }
        }
        private void CargarTotalCompras()
        {
            logCompra logicaComprita = new logCompra();
            string totalCompras = logicaComprita.ContarCompras();

            txtNumCompra.Text = totalCompras; // Asumiendo que tienes un TextBox para mostrar el total
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}