﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaLogica;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        ApisPeru ApísPeru = new ApisPeru();
        private List<entdescUsuario> listaUsuarios;

        public Usuarios()
        {
            InitializeComponent();

        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            gboDetalleUsuario.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnInhabilitar.Enabled = false;
            gboxBusqueda.Enabled = false;

            //Para impedir que dentro de los combo box se pueda escribir
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;


            cbEstado.Items.Add(new OpcionesCombo() { Valor = true, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionesCombo() { Valor = false, Texto = "Inactivo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;

            //Metodos
            listarRol();
            listarUsuario();
            CambiarEncabezados();
        }

        public void CambiarEncabezados()
        {
            dgvUsuarios.Columns["UsuarioID"].HeaderText = "ID";
            dgvUsuarios.Columns["Documento"].HeaderText = "DNI";
            dgvUsuarios.Columns["descripcion"].HeaderText = "Rol";
            dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
            dgvUsuarios.Columns["Usuario"].HeaderText = "Usuario";
            dgvUsuarios.Columns["FechaRegistro"].HeaderText = "Fecha de Registro";
            dgvUsuarios.Columns["Correo"].HeaderText = "Correo Electrónico";
            dgvUsuarios.Columns["Estado"].HeaderText = "Estado"; // Cambiar el encabezado si es necesario
        }

        private void LimpiarVariables()
        {
            txtDocumento.Text = "";
            txtCorreo.Text = "";
            txtNombre.Text = "";
            txtPass.Text = "";
            cbEstado.Text = "";
            cbRol.Text = "";
            txtID.Text = "";
            txtUsuario.Text = "";
        }

        public void listarRol()
        {
            cbRol.DataSource = logRol.Instancia.ListarRol();
            cbRol.DisplayMember = "Descripcion";
            cbRol.ValueMember = "RolID";
        }

        public void listarUsuario()
        {
            dgvUsuarios.DataSource = logUsuario.Instancia.ListarUsuario();
            CambiarEncabezados(); // Cambia los encabezados de las columnas

            // Establecer el nuevo orden de las columnas
            dgvUsuarios.Columns["UsuarioID"].DisplayIndex = 0; // ID
            dgvUsuarios.Columns["Documento"].DisplayIndex = 1; // DNI
            dgvUsuarios.Columns["NombreCompleto"].DisplayIndex = 2; // Nombre
            dgvUsuarios.Columns["Usuario"].DisplayIndex = 3; //Usuario
            dgvUsuarios.Columns["Clave"].DisplayIndex = 4; // Clave
            dgvUsuarios.Columns["Correo"].DisplayIndex = 5; // Correo
            dgvUsuarios.Columns["FechaRegistro"].DisplayIndex = 6; // Fecha
            dgvUsuarios.Columns["descripcion"].DisplayIndex = 7; // Rol
            dgvUsuarios.Columns["Estado"].DisplayIndex = 8; // Estado
        }

        private void btnNuevoUsuari_Click(object sender, EventArgs e)
        {
            gboDetalleUsuario.Enabled = true;
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = true;
            btnInhabilitar.Enabled = true;
            gboxBusqueda.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtCorreo.Text = "";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtPass.Text = "";
            cbRol.Text = "";
            cbEstado.Text = "";

            txtID.Enabled = false;
            gboDetalleUsuario.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnInhabilitar.Enabled = false;
            gboxBusqueda.Enabled = false;
        }

        private bool EsContrasenaSegura(string contrasena)
        {
            // Al menos 8 caracteres, 1 mayúscula, 1 número y 1 carácter especial
            string patron = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@!#$%^&*.,_+=-]).{8,}$";
            return Regex.IsMatch(contrasena, patron);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string clave = txtPass.Text.Trim();

                if (!EsContrasenaSegura(clave))
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una mayúscula, un número y un carácter especial (@, !, #, etc).",
                                    "Contraseña débil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                entUsuario p = new entUsuario();

                p.Documento = Convert.ToInt32(txtDocumento.Text);
                p.idRol = Convert.ToInt32(cbRol.SelectedValue);
                p.NombreCompleto = txtNombre.Text;
                p.Estado = ((OpcionesCombo)cbEstado.SelectedItem).Valor;
                p.Clave = clave;
                p.FechaRegistro = DateTime.Now;
                p.Correo = txtCorreo.Text;
                p.Usuario = txtUsuario.Text;

                logUsuario.Instancia.InsertarUsuarios(p);

                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarVariables();
            listarUsuario();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvUsuarios.Rows[e.RowIndex]; //
            txtID.Text = filaActual.Cells[0].Value.ToString();
            txtDocumento.Text = filaActual.Cells[1].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString();
            txtPass.Text = filaActual.Cells[5].Value.ToString();
            txtCorreo.Text = filaActual.Cells[7].Value.ToString();
            cbRol.Text = filaActual.Cells[2].Value.ToString();
            txtUsuario.Text = filaActual.Cells[8].Value.ToString();

            foreach (OpcionesCombo oc in cbEstado.Items)
            {
                if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(filaActual.Cells[4].Value))
                {
                    int indice_combo = cbEstado.Items.IndexOf(oc);
                    cbEstado.SelectedIndex = indice_combo;
                    break;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de entTrabajador
                entUsuario u = new entUsuario();

                // Capturar los datos del trabajador desde el formulario
                u.UsuarioID = int.Parse(txtID.Text.Trim());
                u.Documento = int.Parse(txtDocumento.Text.Trim());
                u.NombreCompleto = txtNombre.Text.Trim();
                u.Clave = txtPass.Text.Trim();
                u.FechaRegistro = DateTime.Now;
                u.idRol = Convert.ToInt32(cbRol.SelectedValue); // Usar SelectedValue para obtener el valor de idRol
                u.Estado = ((OpcionesCombo)cbEstado.SelectedItem).Valor; // Usar SelectedItem para obtener el estado como booleano
                u.Correo = txtCorreo.Text.Trim();
                u.Usuario = txtUsuario.Text.Trim();


                // Llamar al método para editar el trabajador
                logUsuario.Instancia.ModificarUsuario(u);
                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            gboDetalleUsuario.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnInhabilitar.Enabled = false;
            gboxBusqueda.Enabled = false;

            //// Actualizar la lista de usuarios
            listarUsuario();
            LimpiarVariables();
        }


        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario c = new entUsuario();

                c.UsuarioID = int.Parse(txtID.Text.Trim());
                c.Estado = ((OpcionesCombo)cbEstado.SelectedItem).Valor;
                //c.Estado = cbEstado.Checked;
                logUsuario.Instancia.DeshabilitarUsuarios(c);

                MessageBox.Show("Usuario inhabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gboDetalleUsuario.Enabled = false;
            listarUsuario();
        }

        private void consultarDni()
        {
            try
            {
                //---------DNI-----------
                if (txtDocumento.Text.Length == 8)
                {
                    var apisPeru = new ApisPeru();
                    dynamic respuesta = apisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDocumento.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImRhdmlsYWpob2phbkBnbWFpbC5jb20ifQ.OexW2Uf_nGrZjUiqutNGmMODVk4zHCDV7CA9SHR8HVM");
                    txtNombre.Text = respuesta.nombres.ToString() + " " + respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                    txtNombre.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el número de documento proporcionado.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error... " + ex.Message);
            }
        }


        private void btnBuscarDni_Click_1(object sender, EventArgs e)
        {
            consultarDni();

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void AplicarFiltroUsuario()
        {
            //if (cbBusqueda.SelectedItem == null) return;

            //string filtro = cbBusqueda.SelectedItem.ToString();
            //string busqueda = txtBusqueda.Text.ToLower();

            //var proveedoresFiltrados = listaUsuarios.Where(p =>
            //{
            //    switch (filtro)
            //    {
            //        case "Documento":
            //            return p.Documento.ToString().Contains(busqueda);
            //        case "Nombre":
            //            return p.NombreCompleto.ToString().Contains(busqueda);
            //        default:
            //            return false;
            //    }
            //}).ToList();

            //dgvUsuarios.DataSource = proveedoresFiltrados;
        }

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AplicarFiltroUsuario();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
