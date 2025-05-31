namespace CapaPresentacion
{
    partial class FormRecuperarContraseña
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnVerificarDocumento = new System.Windows.Forms.Button();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCambioClave = new System.Windows.Forms.Panel();
            this.txtCodigoVerificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerificarCodigo = new System.Windows.Forms.Button();
            this.panelCambioClave.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Documento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(91, 70);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(258, 26);
            this.txtDocumento.TabIndex = 1;
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarClave.Location = new System.Drawing.Point(154, 371);
            this.btnCambiarClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(193, 28);
            this.btnCambiarClave.TabIndex = 2;
            this.btnCambiarClave.Text = "Cambiar Clave";
            this.btnCambiarClave.UseVisualStyleBackColor = true;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(88, 100);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 15);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "label2";
            // 
            // btnVerificarDocumento
            // 
            this.btnVerificarDocumento.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarDocumento.Location = new System.Drawing.Point(356, 70);
            this.btnVerificarDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerificarDocumento.Name = "btnVerificarDocumento";
            this.btnVerificarDocumento.Size = new System.Drawing.Size(119, 31);
            this.btnVerificarDocumento.TabIndex = 4;
            this.btnVerificarDocumento.Text = "Enviar Codigo";
            this.btnVerificarDocumento.UseVisualStyleBackColor = true;
            this.btnVerificarDocumento.Click += new System.EventHandler(this.btnVerificarDocumento_Click);
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Location = new System.Drawing.Point(37, 30);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.PasswordChar = '*';
            this.txtNuevaClave.Size = new System.Drawing.Size(258, 20);
            this.txtNuevaClave.TabIndex = 5;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(37, 93);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(258, 20);
            this.txtConfirmarClave.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nueva Clave";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirmar Clave";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelCambioClave
            // 
            this.panelCambioClave.Controls.Add(this.txtNuevaClave);
            this.panelCambioClave.Controls.Add(this.txtConfirmarClave);
            this.panelCambioClave.Controls.Add(this.label2);
            this.panelCambioClave.Controls.Add(this.label3);
            this.panelCambioClave.Location = new System.Drawing.Point(54, 223);
            this.panelCambioClave.Name = "panelCambioClave";
            this.panelCambioClave.Size = new System.Drawing.Size(370, 129);
            this.panelCambioClave.TabIndex = 6;
            // 
            // txtCodigoVerificacion
            // 
            this.txtCodigoVerificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVerificacion.Location = new System.Drawing.Point(93, 165);
            this.txtCodigoVerificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoVerificacion.Name = "txtCodigoVerificacion";
            this.txtCodigoVerificacion.Size = new System.Drawing.Size(258, 26);
            this.txtCodigoVerificacion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo de Verificación";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVerificarCodigo
            // 
            this.btnVerificarCodigo.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnVerificarCodigo.Location = new System.Drawing.Point(357, 165);
            this.btnVerificarCodigo.Name = "btnVerificarCodigo";
            this.btnVerificarCodigo.Size = new System.Drawing.Size(118, 26);
            this.btnVerificarCodigo.TabIndex = 7;
            this.btnVerificarCodigo.Text = "Verificar Codigo";
            this.btnVerificarCodigo.UseVisualStyleBackColor = true;
            this.btnVerificarCodigo.Click += new System.EventHandler(this.btnVerificarCodigo_Click);
            // 
            // FormRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 434);
            this.Controls.Add(this.btnVerificarCodigo);
            this.Controls.Add(this.panelCambioClave);
            this.Controls.Add(this.btnVerificarDocumento);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.btnCambiarClave);
            this.Controls.Add(this.txtCodigoVerificacion);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecuperarContraseña";
            this.panelCambioClave.ResumeLayout(false);
            this.panelCambioClave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDocumento;
        private Button btnCambiarClave;
        private Label lblCorreo;
        private Button btnVerificarDocumento;
        private TextBox txtNuevaClave;
        private TextBox txtConfirmarClave;
        private Label label2;
        private Label label3;
        private Panel panelCambioClave;
        private TextBox txtCodigoVerificacion;
        private Label label4;
        private Button btnVerificarCodigo;
    }
}