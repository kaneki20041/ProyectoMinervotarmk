namespace Proyecto_Minerva
{
    partial class Clientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtBuscarDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gboInformacion = new System.Windows.Forms.GroupBox();
            this.btnBuscarDni = new FontAwesome.Sharp.IconButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDocumento = new System.Windows.Forms.ComboBox();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.gboDatosBusqueda = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbContacto.SuspendLayout();
            this.gboInformacion.SuspendLayout();
            this.gboDatosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(632, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de Registro";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(755, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 22);
            this.dtpFecha.TabIndex = 13;
            this.dtpFecha.UseWaitCursor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(18, 327);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.Size = new System.Drawing.Size(826, 264);
            this.dgvCliente.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAgregar.Location = new System.Drawing.Point(619, 179);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 40);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(619, 227);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 40);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModifCliente_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnInhabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInhabilitar.FlatAppearance.BorderSize = 0;
            this.btnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnInhabilitar.Location = new System.Drawing.Point(619, 275);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(100, 40);
            this.btnInhabilitar.TabIndex = 18;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(88, 66);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(149, 22);
            this.txtCel.TabIndex = 21;
            this.txtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCel_KeyPress);
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.txtCel);
            this.gbContacto.Controls.Add(this.label11);
            this.gbContacto.Controls.Add(this.txtDireccion);
            this.gbContacto.Controls.Add(this.chkEstado);
            this.gbContacto.Controls.Add(this.txtEmail);
            this.gbContacto.Controls.Add(this.label6);
            this.gbContacto.Controls.Add(this.label5);
            this.gbContacto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbContacto.Location = new System.Drawing.Point(244, 172);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(353, 143);
            this.gbContacto.TabIndex = 22;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(88, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(245, 22);
            this.txtDireccion.TabIndex = 33;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.chkEstado.Location = new System.Drawing.Point(266, 67);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(67, 21);
            this.chkEstado.TabIndex = 28;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtBuscarDocumento
            // 
            this.txtBuscarDocumento.Location = new System.Drawing.Point(101, 50);
            this.txtBuscarDocumento.Name = "txtBuscarDocumento";
            this.txtBuscarDocumento.Size = new System.Drawing.Size(108, 22);
            this.txtBuscarDocumento.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(334, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 22);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // gboInformacion
            // 
            this.gboInformacion.Controls.Add(this.btnBuscarDni);
            this.gboInformacion.Controls.Add(this.txtID);
            this.gboInformacion.Controls.Add(this.label1);
            this.gboInformacion.Controls.Add(this.label7);
            this.gboInformacion.Controls.Add(this.cbxDocumento);
            this.gboInformacion.Controls.Add(this.cbxTipoCliente);
            this.gboInformacion.Controls.Add(this.txtDocumento);
            this.gboInformacion.Controls.Add(this.label10);
            this.gboInformacion.Controls.Add(this.txtApellido);
            this.gboInformacion.Controls.Add(this.label9);
            this.gboInformacion.Controls.Add(this.txtNombre);
            this.gboInformacion.Controls.Add(this.label4);
            this.gboInformacion.Controls.Add(this.label3);
            this.gboInformacion.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gboInformacion.Location = new System.Drawing.Point(12, 40);
            this.gboInformacion.Name = "gboInformacion";
            this.gboInformacion.Size = new System.Drawing.Size(845, 126);
            this.gboInformacion.TabIndex = 26;
            this.gboInformacion.TabStop = false;
            this.gboInformacion.Text = "Informacion";
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscarDni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDni.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarDni.IconColor = System.Drawing.Color.Black;
            this.btnBuscarDni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarDni.IconSize = 15;
            this.btnBuscarDni.Location = new System.Drawing.Point(455, 30);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(29, 22);
            this.btnBuscarDni.TabIndex = 39;
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(101, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 22);
            this.txtID.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Nº Doc";
            // 
            // cbxDocumento
            // 
            this.cbxDocumento.FormattingEnabled = true;
            this.cbxDocumento.Location = new System.Drawing.Point(646, 26);
            this.cbxDocumento.Name = "cbxDocumento";
            this.cbxDocumento.Size = new System.Drawing.Size(117, 25);
            this.cbxDocumento.TabIndex = 35;
            // 
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.FormattingEnabled = true;
            this.cbxTipoCliente.Location = new System.Drawing.Point(101, 74);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(125, 25);
            this.cbxTipoCliente.TabIndex = 34;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(334, 30);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(115, 22);
            this.txtDocumento.TabIndex = 30;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(561, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Documento";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(646, 72);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 22);
            this.txtApellido.TabIndex = 27;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(577, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Apellidos";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCli.FlatAppearance.BorderSize = 0;
            this.btnBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCli.Location = new System.Drawing.Point(82, 90);
            this.btnBuscarCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(70, 30);
            this.btnBuscarCli.TabIndex = 37;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = false;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNuevoCliente.Location = new System.Drawing.Point(744, 200);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(100, 45);
            this.btnNuevoCliente.TabIndex = 27;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // gboDatosBusqueda
            // 
            this.gboDatosBusqueda.Controls.Add(this.label2);
            this.gboDatosBusqueda.Controls.Add(this.btnBuscarCli);
            this.gboDatosBusqueda.Controls.Add(this.txtBuscarDocumento);
            this.gboDatosBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gboDatosBusqueda.Location = new System.Drawing.Point(12, 172);
            this.gboDatosBusqueda.Name = "gboDatosBusqueda";
            this.gboDatosBusqueda.Size = new System.Drawing.Size(226, 143);
            this.gboDatosBusqueda.TabIndex = 28;
            this.gboDatosBusqueda.TabStop = false;
            this.gboDatosBusqueda.Text = "Datos de Búsqueda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(744, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 45);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Registrocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(869, 603);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gboDatosBusqueda);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.gboInformacion);
            this.Controls.Add(this.gbContacto);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrocliente";
            this.Text = "Registrocliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbContacto.ResumeLayout(false);
            this.gbContacto.PerformLayout();
            this.gboInformacion.ResumeLayout(false);
            this.gboInformacion.PerformLayout();
            this.gboDatosBusqueda.ResumeLayout(false);
            this.gboDatosBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private DateTimePicker dtpFecha;
        private DataGridView dgvCliente;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnInhabilitar;
        private TextBox txtEmail;
        private TextBox txtCel;
        private GroupBox gbContacto;
        private TextBox txtBuscarDocumento;
        private TextBox txtNombre;
        private GroupBox gboInformacion;
        private Button btnNuevoCliente;
        private TextBox txtDocumento;
        private Label label10;
        private TextBox txtApellido;
        private Label label9;
        private TextBox txtDireccion;
        private Label label11;
        private Label label7;
        private ComboBox cbxDocumento;
        private ComboBox cbxTipoCliente;
        private CheckBox chkEstado;
        private Button btnBuscarCli;
        private GroupBox gboDatosBusqueda;
        private TextBox txtID;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnBuscarDni;
        private Button btnCancelar;
    }
}