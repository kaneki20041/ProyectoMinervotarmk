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
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace CapaPresentacion
{
    public partial class Categoriaa : Form
    {
        public Categoriaa()
        {
            InitializeComponent();
            listarCat();
            Deshabilitado();
            txtID.Enabled = false;
            gbDatos.Enabled = false;

        }

        public void listarCat()
        {
            dgvCategoria.DataSource = logCat.Instancia.ListaCategoria();
        }

        public void Deshabilitado()
        {
            dgvCategoria.Enabled = false;
            gbDatos.Enabled = false;
            txtID.Clear();
            txtCategoria.Clear();
            cbEstado.Checked = false;
        }

        public void Habilitado()
        {
            dgvCategoria.Enabled = true;
            gbDatos.Enabled = true;
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCategoria gato = new entCategoria();
                gato.descripcion = txtCategoria.Text.Trim();
                cbEstado.Checked = true;
                gato.estado = cbEstado.Checked;
                logCat.Instancia.InsertaCat(gato);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarCat();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Deshabilitado();

        }

        private void Limpiar()
        {
            txtID.Clear();
            txtCategoria.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id;

                // Verifica que se ha buscado un proveedor
                if (!int.TryParse(txtID.Text, out id))
                {
                    MessageBox.Show("Por favor, busca un categoria antes de modificarlo.");
                    return;
                }

                string cat = txtCategoria.Text.Trim();

                // Verifica que el RUC no está vacío
                if (string.IsNullOrWhiteSpace(cat))
                {
                    MessageBox.Show("Por favor, ingresa una categoria en el campo Categoria.");
                    return;
                }

                bool estado = cbEstado.Checked;

                entCategoria categoriaActualizado = new entCategoria
                {
                    categoriaID = id,
                    descripcion = cat,
                    estado = estado
                };

                logCat.Instancia.ModificarCat(categoriaActualizado);
                MessageBox.Show("Categoria modificada con éxito");
                Limpiar();
                listarCat();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que ocurra
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }

            gbDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            // Verifica si el campo txtBuscarID no está vacío
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Por favor, ingresa un ID válido para inhabilitar.");
                return;
            }

            // Confirmación de inhabilitación
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas inhabilitar esta categoria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    logProveedor.Instancia.InhabilitarProveedor(txtID.Text);
                    MessageBox.Show("Categoria inhabilitada con éxito.");
                    txtID.Clear();
                    listarCat();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategoria.Rows[e.RowIndex];

                // Asumiendo que tus TextBox se llaman txtID, txtDescripcion y txtPrecio
                txtID.Text = row.Cells["categoriaID"].Value.ToString();
                txtCategoria.Text = row.Cells["descripcion"].Value.ToString();
                cbEstado.Checked = Convert.ToBoolean(row.Cells["estado"].Value);

                // No actualizamos el "Nuevo Precio" ya que parece ser un campo para entrada del usuario
            }
            txtID.Enabled = false;


        }
    }
}
