using CapaEntidad;
using CapaLogica;
using FontAwesome.Sharp;
using Proyecto_Minerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        private System.Windows.Forms.Timer activityTimer;
        private string captchaTexto;

        public Login()
        {
            InitializeComponent();
            btnMostrar.Visible = true;
            btnOcultar.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void GenerarCaptcha()
        {
            //Generemos un texto aleatorio
            captchaTexto = GenerarAleatorio(5);

            // Creamos una imagen del texto
            Bitmap imagenCaptcha = new Bitmap(150, 50);

            Graphics g = Graphics.FromImage(imagenCaptcha);
            g.Clear(Color.White);

            using (Font fuente = new Font("Arial", 24, FontStyle.Bold))
            using (SolidBrush pincel = new SolidBrush(Color.Black))
            {
                g.DrawString(captchaTexto, fuente, pincel, new PointF(10, 10));
            }

            // (Opcional) Agrega líneas de ruido
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int x1 = rnd.Next(0, imagenCaptcha.Width);
                int y1 = rnd.Next(0, imagenCaptcha.Height);
                int x2 = rnd.Next(0, imagenCaptcha.Width);
                int y2 = rnd.Next(0, imagenCaptcha.Height);
                g.DrawLine(Pens.Gray, x1, y1, x2, y2);
            }

            pictureBoxCaptcha.Image = imagenCaptcha;
        }


        private string GenerarAleatorio(int longitud)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            Random rnd = new Random();
            char[] texto = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                texto[i] = caracteres[rnd.Next(caracteres.Length)];
            }
            return new String(texto);

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            Principal form = sender as Principal;
            if (form != null && form.UsuarioActual != null)
            {
                new logUsuario().ActualizarEstadoConexion(form.UsuarioActual.Documento, false);
            }
            txtUsuario.Text = "";
            txtPassword.Text = "";
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Gracias por su visita");
                Application.Exit();
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // Vuelve a censurar
            btnOcultar.Visible = false;
            btnMostrar.Visible = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false; // Muestra el texto
            btnMostrar.Visible = false;
            btnOcultar.Visible = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text.Trim();

            // Verificar primero el CAPTCHA
            if (txtCaptcha.Text.Trim().ToUpper() != captchaTexto.ToUpper())
            {
                MessageBox.Show("Captcha incorrecto. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenerarCaptcha(); // Refrescar captcha tras error
                txtCaptcha.Clear();
                return;
            }

            // Si CAPTCHA es correcto, continúa con la validación de usuario
            if (!string.IsNullOrEmpty(usuarioIngresado))
            {
                // Obtener la lista de usuarios
                List<entUsuario> usuarios = logUsuario.Instancia.ListarValidarUsuario();

                // Buscar el usuario por documento
                entUsuario? entUsuario = usuarios.FirstOrDefault(u => u.Usuario == usuarioIngresado);
                entUsuario usuario = entUsuario;

                if (usuario != null)
                {
                    if (usuario.Clave == txtPassword.Text)
                    {
                        if (usuario.Estado)
                        {
                            // Verificar si el usuario ya está conectado
                            if (usuario.EstaConectado)
                            {
                                if (usuario.UltimaActividad != DateTime.MinValue &&
                                    (DateTime.Now - usuario.UltimaActividad).TotalMinutes > 30)
                                {
                                    // Forzar cierre de la sesión anterior por inactividad
                                    logUsuario.Instancia.ActualizarEstadoConexion(usuario.Documento, false);
                                }
                                else
                                {
                                    MessageBox.Show("Este usuario ya tiene una sesión activa en otro equipo.",
                                                    "Sesión activa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            // Marcar al usuario como conectado
                            logUsuario.Instancia.ActualizarEstadoConexion(usuario.Documento, true);

                            Principal form = new Principal(usuario);
                            form.Show();
                            this.Hide();
                            form.FormClosing += frm_closing;
                            MessageBox.Show($"Bienvenido, {usuario.NombreCompleto}!");
                        }
                        else
                        {
                            MessageBox.Show("El usuario está deshabilitado", "Mensaje",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Mensaje",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Documento incorrecto", "Mensaje",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un documento válido", "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("In", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void btnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            GenerarCaptcha();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormRecuperarContraseña formRecuperar = new FormRecuperarContraseña();
            formRecuperar.ShowDialog();
        }
    }
}
