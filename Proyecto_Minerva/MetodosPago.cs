﻿using CapaDatos;
using CapaEntidad;
using CapaLogica;

namespace Proyecto_Minerva
{
    public partial class MetodosPago :Form
    {
        public MetodosPago()
        {
            InitializeComponent();
            listarMetPago();
            Deshabilitar();
        }
        private void Desc_Formpago_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtMetpago.Enabled = false;
            cbkEstMetPago.Enabled = false;
        }
        public void listarMetPago()
        {
            dgvMetPago.DataSource = logMetPago.Instancia.ListarMetPago();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            txtid.Clear();
            txtMetpago.Enabled = true;
            txtid.Enabled = false;
            cbkEstMetPago.Checked = true;
            cbkEstMetPago.Enabled = false;
            btnAgreMpag.Visible = true;
            btnModFpag.Visible = true;
            LimpiarVariables();
        }
        private void btnAgreMpag_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntMetPago m = new EntMetPago();
                m.metodopago = txtMetpago.Text.Trim();
                m.estMetpago = cbkEstMetPago.Checked;
                logMetPago.Instancia.InsertaMetpago(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarMetPago();
        }
        private void LimpiarVariables()
        {
            txtid.Text = "";
            txtMetpago.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            txtid.Enabled = true;
            txtMetpago.Enabled = true;
            cbkEstMetPago.Enabled = false;
            btnModFpag.Visible = true;
            btnAgreMpag.Visible = false;
        }
        private void btnModFpag_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetPago m = new EntMetPago();
                m.MetPagoid = int.Parse(txtid.Text.Trim());
                m.metodopago = txtMetpago.Text.Trim();
                m.estMetpago = cbkEstMetPago.Checked;
                logMetPago.Instancia.EditaMetPago(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarMetPago();
            LimpiarVariables();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetPago m = new EntMetPago();
                m.MetPagoid = int.Parse(txtid.Text.Trim());
                m.estMetpago = cbkEstMetPago.Checked;
                logMetPago.Instancia.DeshabilitaMetPago(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarMetPago();

        }

        private void btnCancelFpag_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBox2.Enabled = false;
            btnModFpag.Visible = true;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            txtid.Enabled = true;
            txtMetpago.Enabled = false;
            cbkEstMetPago.Enabled = true;
        }
        public void Deshabilitar()
        {
            groupBox2.Enabled=false;
            txtMetpago.Clear();
            txtid.Clear();
        }

        private void dgvMetPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMetPago.Rows[e.RowIndex];

                // Asumiendo que tus TextBox se llaman txtID, txtDescripcion y txtPrecio
                txtid.Text = row.Cells["MetPagoid"].Value.ToString();
                txtMetpago.Text = row.Cells["metodopago"].Value.ToString();
                cbkEstMetPago.Checked = Convert.ToBoolean(row.Cells["estMetpago"].Value);

                // No actualizamos el "Nuevo Precio" ya que parece ser un campo para entrada del usuario
            }
            txtid.Enabled = false;
        }
    }
}
