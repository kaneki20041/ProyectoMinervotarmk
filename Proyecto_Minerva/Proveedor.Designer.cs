namespace Proyecto_Minerva
{
    partial class Proveedor
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorRUC = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.grupBoxDatos2 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dvgProveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoUbigeo = new System.Windows.Forms.TextBox();
            this.groupBoxUbigeo = new System.Windows.Forms.GroupBox();
            this.btnBuscUbigeo = new System.Windows.Forms.Button();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grupBoxDatos.SuspendLayout();
            this.grupBoxDatos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProveedor)).BeginInit();
            this.groupBoxUbigeo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rubro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(85, 99);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 22);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.Location = new System.Drawing.Point(721, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(742, 403);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 46);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAgregar.Location = new System.Drawing.Point(47, 217);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 40);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(162, 217);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 40);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnInhabilitar.FlatAppearance.BorderSize = 0;
            this.btnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhabilitar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnInhabilitar.Location = new System.Drawing.Point(279, 217);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(92, 40);
            this.btnInhabilitar.TabIndex = 15;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = false;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(772, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.UseWaitCursor = true;
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.btnBuscarPorRUC);
            this.grupBoxDatos.Controls.Add(this.cbEstado);
            this.grupBoxDatos.Controls.Add(this.txtRazonSocial);
            this.grupBoxDatos.Controls.Add(this.txtRUC);
            this.grupBoxDatos.Controls.Add(this.label11);
            this.grupBoxDatos.Controls.Add(this.comboBoxRubro);
            this.grupBoxDatos.Controls.Add(this.btnInhabilitar);
            this.grupBoxDatos.Controls.Add(this.txtNombre);
            this.grupBoxDatos.Controls.Add(this.btnModificar);
            this.grupBoxDatos.Controls.Add(this.label4);
            this.grupBoxDatos.Controls.Add(this.btnAgregar);
            this.grupBoxDatos.Controls.Add(this.label3);
            this.grupBoxDatos.Controls.Add(this.label2);
            this.grupBoxDatos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.grupBoxDatos.Location = new System.Drawing.Point(10, 38);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(409, 278);
            this.grupBoxDatos.TabIndex = 17;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Informacion";
            // 
            // btnBuscarPorRUC
            // 
            this.btnBuscarPorRUC.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarPorRUC.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorRUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorRUC.Location = new System.Drawing.Point(317, 109);
            this.btnBuscarPorRUC.Name = "btnBuscarPorRUC";
            this.btnBuscarPorRUC.Size = new System.Drawing.Size(69, 31);
            this.btnBuscarPorRUC.TabIndex = 22;
            this.btnBuscarPorRUC.Text = "Buscar";
            this.btnBuscarPorRUC.UseVisualStyleBackColor = false;
            this.btnBuscarPorRUC.Click += new System.EventHandler(this.btnBuscarPorRUC_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Checked = true;
            this.cbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstado.Location = new System.Drawing.Point(178, 176);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(67, 21);
            this.cbEstado.TabIndex = 21;
            this.cbEstado.Text = "Estado";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(114, 62);
            this.txtRazonSocial.Multiline = true;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(187, 45);
            this.txtRazonSocial.TabIndex = 14;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(114, 113);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(187, 22);
            this.txtRUC.TabIndex = 13;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Razon Social";
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(114, 141);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(187, 25);
            this.comboBoxRubro.TabIndex = 10;
            // 
            // grupBoxDatos2
            // 
            this.grupBoxDatos2.Controls.Add(this.txtDireccion);
            this.grupBoxDatos2.Controls.Add(this.label8);
            this.grupBoxDatos2.Controls.Add(this.txtTelefono);
            this.grupBoxDatos2.Controls.Add(this.txtEmail);
            this.grupBoxDatos2.Controls.Add(this.label6);
            this.grupBoxDatos2.Controls.Add(this.label5);
            this.grupBoxDatos2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.grupBoxDatos2.Location = new System.Drawing.Point(425, 38);
            this.grupBoxDatos2.Name = "grupBoxDatos2";
            this.grupBoxDatos2.Size = new System.Drawing.Size(432, 134);
            this.grupBoxDatos2.TabIndex = 18;
            this.grupBoxDatos2.TabStop = false;
            this.grupBoxDatos2.Text = "Contacto";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(85, 28);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(324, 22);
            this.txtDireccion.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Direccion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ciudad";
            // 
            // dvgProveedor
            // 
            this.dvgProveedor.BackgroundColor = System.Drawing.Color.MintCream;
            this.dvgProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProveedor.Location = new System.Drawing.Point(12, 325);
            this.dvgProveedor.Name = "dvgProveedor";
            this.dvgProveedor.ReadOnly = true;
            this.dvgProveedor.RowHeadersWidth = 51;
            this.dvgProveedor.RowTemplate.Height = 25;
            this.dvgProveedor.Size = new System.Drawing.Size(706, 266);
            this.dvgProveedor.TabIndex = 19;
            this.dvgProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProveedor_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ubigeo";
            // 
            // txtCodigoUbigeo
            // 
            this.txtCodigoUbigeo.Location = new System.Drawing.Point(119, 27);
            this.txtCodigoUbigeo.Name = "txtCodigoUbigeo";
            this.txtCodigoUbigeo.Size = new System.Drawing.Size(75, 22);
            this.txtCodigoUbigeo.TabIndex = 23;
            // 
            // groupBoxUbigeo
            // 
            this.groupBoxUbigeo.Controls.Add(this.btnBuscUbigeo);
            this.groupBoxUbigeo.Controls.Add(this.txtProvincia);
            this.groupBoxUbigeo.Controls.Add(this.txtDistrito);
            this.groupBoxUbigeo.Controls.Add(this.label13);
            this.groupBoxUbigeo.Controls.Add(this.label12);
            this.groupBoxUbigeo.Controls.Add(this.txtDepartamento);
            this.groupBoxUbigeo.Controls.Add(this.label10);
            this.groupBoxUbigeo.Controls.Add(this.txtCodigoUbigeo);
            this.groupBoxUbigeo.Controls.Add(this.label1);
            this.groupBoxUbigeo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBoxUbigeo.Location = new System.Drawing.Point(425, 175);
            this.groupBoxUbigeo.Name = "groupBoxUbigeo";
            this.groupBoxUbigeo.Size = new System.Drawing.Size(432, 141);
            this.groupBoxUbigeo.TabIndex = 24;
            this.groupBoxUbigeo.TabStop = false;
            this.groupBoxUbigeo.Text = "Ubigeo";
            // 
            // btnBuscUbigeo
            // 
            this.btnBuscUbigeo.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscUbigeo.FlatAppearance.BorderSize = 0;
            this.btnBuscUbigeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscUbigeo.Location = new System.Drawing.Point(200, 23);
            this.btnBuscUbigeo.Name = "btnBuscUbigeo";
            this.btnBuscUbigeo.Size = new System.Drawing.Size(69, 30);
            this.btnBuscUbigeo.TabIndex = 22;
            this.btnBuscUbigeo.Text = "Buscar";
            this.btnBuscUbigeo.UseVisualStyleBackColor = false;
            this.btnBuscUbigeo.Click += new System.EventHandler(this.btnBuscUbigeo_Click);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(287, 98);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(122, 22);
            this.txtProvincia.TabIndex = 28;
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(73, 98);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(127, 22);
            this.txtDistrito.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Departamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Provincia";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(119, 63);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(290, 22);
            this.txtDepartamento.TabIndex = 24;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(742, 455);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 46);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(869, 603);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBoxUbigeo);
            this.Controls.Add(this.dvgProveedor);
            this.Controls.Add(this.grupBoxDatos2);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            this.grupBoxDatos2.ResumeLayout(false);
            this.grupBoxDatos2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProveedor)).EndInit();
            this.groupBoxUbigeo.ResumeLayout(false);
            this.groupBoxUbigeo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Label label7;
        private Button btnNuevo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnInhabilitar;
        private DateTimePicker dateTimePicker1;
        private GroupBox grupBoxDatos;
        private GroupBox grupBoxDatos2;
        private TextBox txtDireccion;
        private Label label8;
        private DataGridView dvgProveedor;
        private ComboBox comboBoxRubro;
        private TextBox txtRazonSocial;
        private TextBox txtRUC;
        private Label label11;
        private Label label10;
        private CheckBox cbEstado;
        private Label label1;
        private TextBox txtCodigoUbigeo;
        private GroupBox groupBoxUbigeo;
        private Button btnBuscUbigeo;
        private TextBox txtProvincia;
        private TextBox txtDistrito;
        private Label label13;
        private Label label12;
        private TextBox txtDepartamento;
        private Button btnCancelar;
        private Button btnBuscarPorRUC;
    }
}