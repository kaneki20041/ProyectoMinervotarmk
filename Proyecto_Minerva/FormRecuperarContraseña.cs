using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CapaPresentacion
{
    public partial class FormRecuperarContraseña : Form
    {
        private string correoUsuario = "";
        private int idUsuario = 0;
        private string codigoGenerado = "";


        public FormRecuperarContraseña()
        {
            InitializeComponent();
            panelCambioClave.Visible = false;
        }

        private bool EsContrasenaSegura(string contrasena)
        {
            // Al menos 8 caracteres, una mayúscula, un número y un carácter especial
            string patron = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@!#$%^&*.,_+=-]).{8,}$";
            return Regex.IsMatch(contrasena, patron);
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            string nueva = txtNuevaClave.Text.Trim();
            string confirmar = txtConfirmarClave.Text.Trim();

            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsContrasenaSegura(nueva))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una mayúscula, un número y un carácter especial (@, !, #, etc).",
                                "Contraseña débil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "UPDATE Usuario SET Clave = @clave WHERE UsuarioID = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@clave", HashSHA256(nueva));
                    cmd.Parameters.AddWithValue("@id", idUsuario); // Asegúrate que esta variable esté definida

                    cn.Open();
                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Contraseña cambiada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // o redirige si es necesario
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string HashSHA256(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void btnVerificarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                string documento = txtDocumento.Text.Trim();

                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string query = "SELECT UsuarioID, correo FROM Usuario WHERE documento = @documento";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@documento", documento);

                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        idUsuario = Convert.ToInt32(reader["UsuarioID"]);
                        correoUsuario = reader["correo"].ToString();

                        codigoGenerado = new Random().Next(100000, 999999).ToString();
                        EnviarCodigoPorCorreo(correoUsuario, codigoGenerado);

                        lblCorreo.Text = $"Se ha enviado un código a: {correoUsuario}";
                        lblCorreo.Visible = true;
                        txtCodigoVerificacion.Visible = true;
                        btnVerificarCodigo.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Documento no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarCodigoPorCorreo(string destinatario, string codigo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("davilajhojan@gmail.com");
                mail.To.Add(destinatario);
                mail.Subject = "Código de recuperación";
                mail.Body = $"Tu código de verificación es: {codigo}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("davilajhojan@gmail.com", "eakl srvf uinm ucgo");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Código enviado al correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerificarCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigoVerificacion.Text.Trim() == codigoGenerado)
            {
                MessageBox.Show("Código verificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelCambioClave.Visible = true; // Mostrar campos para nueva clave
            }
            else
            {
                MessageBox.Show("Código incorrecto. Verifica tu correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
