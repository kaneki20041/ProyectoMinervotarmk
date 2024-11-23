namespace CapaPresentacion
{
    partial class Usuarios
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
            this.gboDetalleUsuario = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarDni = new FontAwesome.Sharp.IconButton();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevoUsuari = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.gboxBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscarUsuario = new FontAwesome.Sharp.IconButton();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gboDetalleUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gboxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboDetalleUsuario
            // 
            this.gboDetalleUsuario.Controls.Add(this.txtUsuario);
            this.gboDetalleUsuario.Controls.Add(this.label10);
            this.gboDetalleUsuario.Controls.Add(this.btnBuscarDni);
            this.gboDetalleUsuario.Controls.Add(this.btnInhabilitar);
            this.gboDetalleUsuario.Controls.Add(this.btnModificar);
            this.gboDetalleUsuario.Controls.Add(this.txtID);
            this.gboDetalleUsuario.Controls.Add(this.btnAgregar);
            this.gboDetalleUsuario.Controls.Add(this.label7);
            this.gboDetalleUsuario.Controls.Add(this.cbEstado);
            this.gboDetalleUsuario.Controls.Add(this.cbRol);
            this.gboDetalleUsuario.Controls.Add(this.label6);
            this.gboDetalleUsuario.Controls.Add(this.label5);
            this.gboDetalleUsuario.Controls.Add(this.txtCorreo);
            this.gboDetalleUsuario.Controls.Add(this.label4);
            this.gboDetalleUsuario.Controls.Add(this.txtPass);
            this.gboDetalleUsuario.Controls.Add(this.txtNombre);
            this.gboDetalleUsuario.Controls.Add(this.txtDocumento);
            this.gboDetalleUsuario.Controls.Add(this.label3);
            this.gboDetalleUsuario.Controls.Add(this.label2);
            this.gboDetalleUsuario.Controls.Add(this.label1);
            this.gboDetalleUsuario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gboDetalleUsuario.Location = new System.Drawing.Point(207, 43);
            this.gboDetalleUsuario.Name = "gboDetalleUsuario";
            this.gboDetalleUsuario.Size = new System.Drawing.Size(650, 244);
            this.gboDetalleUsuario.TabIndex = 13;
            this.gboDetalleUsuario.TabStop = false;
            this.gboDetalleUsuario.Text = "Detalle del Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(290, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 22);
            this.txtUsuario.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Usuario";
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDni.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarDni.IconColor = System.Drawing.Color.Black;
            this.btnBuscarDni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarDni.IconSize = 15;
            this.btnBuscarDni.Location = new System.Drawing.Point(219, 99);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(29, 22);
            this.btnBuscarDni.TabIndex = 13;
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click_1);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnInhabilitar.FlatAppearance.BorderSize = 0;
            this.btnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnInhabilitar.Location = new System.Drawing.Point(533, 153);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(100, 45);
            this.btnInhabilitar.TabIndex = 19;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = false;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(533, 102);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 45);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(96, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(41, 22);
            this.txtID.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAgregar.Location = new System.Drawing.Point(533, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 45);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(329, 191);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(114, 25);
            this.cbEstado.TabIndex = 7;
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(329, 141);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(114, 25);
            this.cbRol.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rol";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(34, 144);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(168, 22);
            this.txtCorreo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(34, 194);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(168, 22);
            this.txtPass.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(290, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(33, 99);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(169, 22);
            this.txtDocumento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 301);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(700, 290);
            this.dgvUsuarios.TabIndex = 20;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(740, 448);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 45);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevoUsuari
            // 
            this.btnNuevoUsuari.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevoUsuari.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuari.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNuevoUsuari.Location = new System.Drawing.Point(740, 397);
            this.btnNuevoUsuari.Name = "btnNuevoUsuari";
            this.btnNuevoUsuari.Size = new System.Drawing.Size(100, 45);
            this.btnNuevoUsuari.TabIndex = 14;
            this.btnNuevoUsuari.Text = "Nuevo";
            this.btnNuevoUsuari.UseVisualStyleBackColor = false;
            this.btnNuevoUsuari.Click += new System.EventHandler(this.btnNuevoUsuari_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "dd-MM-yyyy";
            this.dtFecha.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(767, 12);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(90, 22);
            this.dtFecha.TabIndex = 15;
            this.dtFecha.UseWaitCursor = true;
            // 
            // gboxBusqueda
            // 
            this.gboxBusqueda.Controls.Add(this.txtBusqueda);
            this.gboxBusqueda.Controls.Add(this.btnLimpiar);
            this.gboxBusqueda.Controls.Add(this.btnBuscarUsuario);
            this.gboxBusqueda.Controls.Add(this.cbBusqueda);
            this.gboxBusqueda.Controls.Add(this.label8);
            this.gboxBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gboxBusqueda.Location = new System.Drawing.Point(12, 43);
            this.gboxBusqueda.Name = "gboxBusqueda";
            this.gboxBusqueda.Size = new System.Drawing.Size(189, 244);
            this.gboxBusqueda.TabIndex = 21;
            this.gboxBusqueda.TabStop = false;
            this.gboxBusqueda.Text = "Buscar Usuario";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(24, 122);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(137, 22);
            this.txtBusqueda.TabIndex = 14;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 15;
            this.btnLimpiar.Location = new System.Drawing.Point(101, 166);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(29, 20);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarUsuario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarUsuario.IconSize = 15;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(50, 166);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(29, 20);
            this.btnBuscarUsuario.TabIndex = 14;
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "Documento",
            "Nombre"});
            this.cbBusqueda.Location = new System.Drawing.Point(24, 85);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(137, 25);
            this.cbBusqueda.TabIndex = 14;
            this.cbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbBusqueda_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Buscar por:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(713, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(869, 603);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gboxBusqueda);
            this.Controls.Add(this.gboDetalleUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevoUsuari);
            this.Controls.Add(this.dtFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "RegistroUsuarios";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            this.gboDetalleUsuario.ResumeLayout(false);
            this.gboDetalleUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gboxBusqueda.ResumeLayout(false);
            this.gboxBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gboDetalleUsuario;
        private ComboBox cbEstado;
        private ComboBox cbRol;
        private Label label6;
        private Label label5;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtPass;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnInhabilitar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvUsuarios;
        private Button btnCancelar;
        private Button btnNuevoUsuari;
        private DateTimePicker dtFecha;
        private FontAwesome.Sharp.IconButton btnBuscarDni;
        private TextBox txtID;
        private Label label7;
        private GroupBox gboxBusqueda;
        private ComboBox cbBusqueda;
        private Label label8;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscarUsuario;
        private Label label9;
        private TextBox txtUsuario;
        private Label label10;
    }
}