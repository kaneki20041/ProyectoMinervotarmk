using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inventario : Form
    {
        // Mantener una lista original de prendas
        private List<entPrendas> listaOriginalPrendas;

        public string idprenda { get; private set; }
        public string descripcion { get; private set; }
        public string categoria { get; private set; }
        public string talla { get; private set; }
        public string colegio { get; private set; }
        public string precioCompra { get; private set; }
        public string precioVenta { get; private set; }
        public string stock { get; private set; }

        public Inventario()
        {
            InitializeComponent();
            dgvInvetario.CellDoubleClick += dgvInventario_CellDoubleClick;
        }

        private void AplicarFiltroPrenda()
        {
            if (cbBusqueda.SelectedItem == null) return;

            string filtro = cbBusqueda.SelectedItem.ToString();
            string busqueda = txtBuscar.Text.ToLower();

            var prendasFiltradas = listaOriginalPrendas.Where(p =>
            {
                switch (filtro)
                {
                    case "Descripcion":
                        return p.Descripcion.ToLower().Contains(busqueda);
                    case "Categoria":
                        return p.Categoria.ToLower().Contains(busqueda);
                    case "Talla":
                        // Modificamos esta parte para manejar tallas numéricas y de letras
                        if (int.TryParse(busqueda, out int tallaNumero))
                        {
                            // Si la búsqueda es un número, comparamos con igualdad
                            return p.Talla.Trim() == busqueda;
                        }
                        else
                        {
                            // Si la búsqueda es texto, buscamos coincidencia parcial
                            return p.Talla.Trim().ToLower().Contains(busqueda);
                        }
                    case "Colegio":
                        return p.Colegio.ToLower().Contains(busqueda);

                    default:
                        return false;
                }
            }).ToList();

            dgvInvetario.DataSource = prendasFiltradas;
        }

        public void listarPrendas()
        {
            try
            {
                // Cargar la lista original de prendas
                listaOriginalPrendas = logPrendas.Instancia.ListarPrendas();

                // Asignar la lista al DataGridView sin filtrar
                dgvInvetario.DataSource = listaOriginalPrendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInvetario.Rows[e.RowIndex];

                // Asumiendo que tus TextBox se llaman txtID, txtDescripcion y txtPrecio
                txtID.Text = row.Cells["PrendaID"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = row.Cells["PrecioVenta"].Value.ToString();

                // No actualizamos el "Nuevo Precio" ya que parece ser un campo para entrada del usuario
            }
            txtID.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            txtNuevoPrecio.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            cbBusqueda.Text = "";
            txtBuscar.Text = "";
        }

        private void btnActualizarForm_Click(object sender, EventArgs e)
        {
            try
            {
                int prendaID = int.Parse(txtID.Text); // Asumiendo que tienes un TextBox para el ID
                decimal nuevoPrecio = decimal.Parse(txtNuevoPrecio.Text); // Asumiendo que tienes un TextBox para el nuevo precio

                // Llamada a la capa lógica
                logPrendas.Instancia.ModificarPrecioUnidad(prendaID, nuevoPrecio);
                MessageBox.Show("Precio actualizado correctamente.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de entrada no válido. Asegúrese de ingresar un número.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
            listarPrendas();
            limpiarCampos();

            gbBuscar.Enabled = false;
            gbPrenda.Enabled = false;



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbBuscar.Enabled = true;
        }
        
        public void limpiarCampos()
        {
            txtID.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtNuevoPrecio.Text = "";
        }

        private void Inventario_Load_1(object sender, EventArgs e)
        {
            listarPrendas();
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNuevoPrecio.Enabled = false;

            gbBuscar.Enabled = false;
            gbPrenda.Enabled = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbBuscar.Enabled = true;
            gbPrenda.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtNuevoPrecio.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            gbBuscar.Enabled = false;
            gbPrenda.Enabled = false;
            limpiarCampos();

        }

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltroPrenda();
        }
    }
}
