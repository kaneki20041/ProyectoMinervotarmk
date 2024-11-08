namespace Proyecto_Minerva
{
    partial class CompraPrenda
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMonto = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtRazonRUC = new System.Windows.Forms.TextBox();
            this.gbInfoPrenda = new System.Windows.Forms.GroupBox();
            this.txtColegio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.AgreCompra = new System.Windows.Forms.Button();
            this.btn_buscarPrenVen = new System.Windows.Forms.Button();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtNombrePrenda = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbInfoUser = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbInfoProveedor = new System.Windows.Forms.GroupBox();
            this.txtNombreRUC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscProveedor = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.tablaCompras = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbInfoPrenda.SuspendLayout();
            this.gbInfoUser.SuspendLayout();
            this.gbInfoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "RUC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Razon Social";
            // 
            // cmbMonto
            // 
            this.cmbMonto.Location = new System.Drawing.Point(738, 306);
            this.cmbMonto.Name = "cmbMonto";
            this.cmbMonto.ReadOnly = true;
            this.cmbMonto.Size = new System.Drawing.Size(96, 20);
            this.cmbMonto.TabIndex = 10;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(102, 64);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(143, 22);
            this.txtRUC.TabIndex = 17;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // txtRazonRUC
            // 
            this.txtRazonRUC.Location = new System.Drawing.Point(102, 94);
            this.txtRazonRUC.Multiline = true;
            this.txtRazonRUC.Name = "txtRazonRUC";
            this.txtRazonRUC.ReadOnly = true;
            this.txtRazonRUC.Size = new System.Drawing.Size(264, 39);
            this.txtRazonRUC.TabIndex = 18;
            // 
            // gbInfoPrenda
            // 
            this.gbInfoPrenda.Controls.Add(this.txtColegio);
            this.gbInfoPrenda.Controls.Add(this.txtCantidad);
            this.gbInfoPrenda.Controls.Add(this.label9);
            this.gbInfoPrenda.Controls.Add(this.txtCategoria);
            this.gbInfoPrenda.Controls.Add(this.label4);
            this.gbInfoPrenda.Controls.Add(this.label12);
            this.gbInfoPrenda.Controls.Add(this.btnLimpiar);
            this.gbInfoPrenda.Controls.Add(this.label14);
            this.gbInfoPrenda.Controls.Add(this.txtStock);
            this.gbInfoPrenda.Controls.Add(this.btnQuitar);
            this.gbInfoPrenda.Controls.Add(this.txtPrecioCompra);
            this.gbInfoPrenda.Controls.Add(this.label15);
            this.gbInfoPrenda.Controls.Add(this.AgreCompra);
            this.gbInfoPrenda.Controls.Add(this.btn_buscarPrenVen);
            this.gbInfoPrenda.Controls.Add(this.txtTalla);
            this.gbInfoPrenda.Controls.Add(this.txtNombrePrenda);
            this.gbInfoPrenda.Controls.Add(this.label17);
            this.gbInfoPrenda.Controls.Add(this.label18);
            this.gbInfoPrenda.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbInfoPrenda.Location = new System.Drawing.Point(20, 175);
            this.gbInfoPrenda.Name = "gbInfoPrenda";
            this.gbInfoPrenda.Size = new System.Drawing.Size(677, 185);
            this.gbInfoPrenda.TabIndex = 45;
            this.gbInfoPrenda.TabStop = false;
            this.gbInfoPrenda.Text = "Informacion de Prenda";
            // 
            // txtColegio
            // 
            this.txtColegio.Location = new System.Drawing.Point(89, 109);
            this.txtColegio.Name = "txtColegio";
            this.txtColegio.ReadOnly = true;
            this.txtColegio.Size = new System.Drawing.Size(165, 22);
            this.txtColegio.TabIndex = 56;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(434, 86);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(104, 22);
            this.txtCantidad.TabIndex = 50;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Colegio";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(89, 150);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(165, 22);
            this.txtCategoria.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Categoria";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Cantidad";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnLimpiar.Location = new System.Drawing.Point(563, 125);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 44);
            this.btnLimpiar.TabIndex = 55;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(386, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(434, 125);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(104, 22);
            this.txtStock.TabIndex = 40;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnQuitar.Location = new System.Drawing.Point(563, 77);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(93, 42);
            this.btnQuitar.TabIndex = 53;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(434, 49);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.ReadOnly = true;
            this.txtPrecioCompra.Size = new System.Drawing.Size(104, 22);
            this.txtPrecioCompra.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(362, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "P.Compra";
            // 
            // AgreCompra
            // 
            this.AgreCompra.BackColor = System.Drawing.Color.PowderBlue;
            this.AgreCompra.FlatAppearance.BorderSize = 0;
            this.AgreCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgreCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AgreCompra.Location = new System.Drawing.Point(563, 28);
            this.AgreCompra.Name = "AgreCompra";
            this.AgreCompra.Size = new System.Drawing.Size(93, 43);
            this.AgreCompra.TabIndex = 51;
            this.AgreCompra.Text = "Agregar";
            this.AgreCompra.UseVisualStyleBackColor = false;
            this.AgreCompra.Click += new System.EventHandler(this.AgreCompra_Click);
            // 
            // btn_buscarPrenVen
            // 
            this.btn_buscarPrenVen.BackColor = System.Drawing.Color.LightCyan;
            this.btn_buscarPrenVen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarPrenVen.FlatAppearance.BorderSize = 0;
            this.btn_buscarPrenVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarPrenVen.Location = new System.Drawing.Point(271, 24);
            this.btn_buscarPrenVen.Name = "btn_buscarPrenVen";
            this.btn_buscarPrenVen.Size = new System.Drawing.Size(72, 29);
            this.btn_buscarPrenVen.TabIndex = 0;
            this.btn_buscarPrenVen.Text = "Buscar";
            this.btn_buscarPrenVen.UseVisualStyleBackColor = false;
            this.btn_buscarPrenVen.Click += new System.EventHandler(this.btn_buscarPrenVen_Click);
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(89, 68);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.ReadOnly = true;
            this.txtTalla.Size = new System.Drawing.Size(165, 22);
            this.txtTalla.TabIndex = 37;
            // 
            // txtNombrePrenda
            // 
            this.txtNombrePrenda.Location = new System.Drawing.Point(90, 29);
            this.txtNombrePrenda.Name = "txtNombrePrenda";
            this.txtNombrePrenda.Size = new System.Drawing.Size(165, 22);
            this.txtNombrePrenda.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Prenda";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(48, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "Talla";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label13.Location = new System.Drawing.Point(742, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Metodo Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label11.Location = new System.Drawing.Point(763, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Monto";
            // 
            // gbInfoUser
            // 
            this.gbInfoUser.Controls.Add(this.label3);
            this.gbInfoUser.Controls.Add(this.txtVendedor);
            this.gbInfoUser.Controls.Add(this.label2);
            this.gbInfoUser.Controls.Add(this.dateTimePicker1);
            this.gbInfoUser.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbInfoUser.Location = new System.Drawing.Point(413, 16);
            this.gbInfoUser.Name = "gbInfoUser";
            this.gbInfoUser.Size = new System.Drawing.Size(284, 153);
            this.gbInfoUser.TabIndex = 49;
            this.gbInfoUser.TabStop = false;
            this.gbInfoUser.Text = "Informacion de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Fecha";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(89, 48);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(174, 22);
            this.txtVendedor.TabIndex = 51;
            this.txtVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.UseWaitCursor = true;
            // 
            // gbInfoProveedor
            // 
            this.gbInfoProveedor.Controls.Add(this.txtNombreRUC);
            this.gbInfoProveedor.Controls.Add(this.label1);
            this.gbInfoProveedor.Controls.Add(this.BuscProveedor);
            this.gbInfoProveedor.Controls.Add(this.txtRazonRUC);
            this.gbInfoProveedor.Controls.Add(this.txtRUC);
            this.gbInfoProveedor.Controls.Add(this.label6);
            this.gbInfoProveedor.Controls.Add(this.label5);
            this.gbInfoProveedor.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbInfoProveedor.Location = new System.Drawing.Point(20, 16);
            this.gbInfoProveedor.Name = "gbInfoProveedor";
            this.gbInfoProveedor.Size = new System.Drawing.Size(387, 153);
            this.gbInfoProveedor.TabIndex = 50;
            this.gbInfoProveedor.TabStop = false;
            this.gbInfoProveedor.Text = "Informacion de Proveedor";
            // 
            // txtNombreRUC
            // 
            this.txtNombreRUC.Location = new System.Drawing.Point(102, 33);
            this.txtNombreRUC.Name = "txtNombreRUC";
            this.txtNombreRUC.Size = new System.Drawing.Size(143, 22);
            this.txtNombreRUC.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre";
            // 
            // BuscProveedor
            // 
            this.BuscProveedor.BackColor = System.Drawing.Color.LightCyan;
            this.BuscProveedor.FlatAppearance.BorderSize = 0;
            this.BuscProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscProveedor.Location = new System.Drawing.Point(270, 30);
            this.BuscProveedor.Name = "BuscProveedor";
            this.BuscProveedor.Size = new System.Drawing.Size(72, 29);
            this.BuscProveedor.TabIndex = 50;
            this.BuscProveedor.Text = "Buscar";
            this.BuscProveedor.UseVisualStyleBackColor = false;
            this.BuscProveedor.Click += new System.EventHandler(this.BuscProveedor_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.LightBlue;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGrabar.Location = new System.Drawing.Point(736, 150);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(96, 45);
            this.btnGrabar.TabIndex = 52;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // tablaCompras
            // 
            this.tablaCompras.BackgroundColor = System.Drawing.Color.MintCream;
            this.tablaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column8});
            this.tablaCompras.Location = new System.Drawing.Point(60, 377);
            this.tablaCompras.Name = "tablaCompras";
            this.tablaCompras.RowTemplate.Height = 25;
            this.tablaCompras.Size = new System.Drawing.Size(742, 214);
            this.tablaCompras.TabIndex = 54;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prenda";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoria";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Colegio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Talla";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cantidad";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Subtotal";
            this.Column8.Name = "Column8";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(738, 249);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(96, 21);
            this.cmbMetodoPago.TabIndex = 52;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(736, 48);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 45);
            this.btnNuevo.TabIndex = 56;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(736, 99);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 45);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CompraPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(869, 603);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tablaCompras);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.gbInfoProveedor);
            this.Controls.Add(this.gbInfoUser);
            this.Controls.Add(this.gbInfoPrenda);
            this.Controls.Add(this.cmbMonto);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompraPrenda";
            this.Text = "Cambio";
            this.gbInfoPrenda.ResumeLayout(false);
            this.gbInfoPrenda.PerformLayout();
            this.gbInfoUser.ResumeLayout(false);
            this.gbInfoUser.PerformLayout();
            this.gbInfoProveedor.ResumeLayout(false);
            this.gbInfoProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox cmbMonto;
        private TextBox txtRUC;
        private TextBox txtRazonRUC;
        private GroupBox gbInfoPrenda;
        private Label label13;
        private Label label11;
        private Label label12;
        private Label label14;
        private TextBox txtStock;
        private TextBox txtPrecioCompra;
        private Label label15;
        private TextBox txtTalla;
        private TextBox txtNombrePrenda;
        private Label label17;
        private Label label18;
        private Button btn_buscarPrenVen;
        private GroupBox gbInfoUser;
        private DateTimePicker dateTimePicker1;
        private GroupBox gbInfoProveedor;
        private Button BuscProveedor;
        private Button AgreCompra;
        private Button btnGrabar;
        private Button btnQuitar;
        private DataGridView tablaCompras;
        private TextBox txtCategoria;
        private Label label4;
        private TextBox txtCantidad;
        private TextBox txtColegio;
        private Label label9;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Colegio;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PCompra;
        private DataGridViewTextBoxColumn Subtotal;
        private Button btnLimpiar;
        private TextBox txtVendedor;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private TextBox txtNombreRUC;
        private Label label1;
        private ComboBox cmbMetodoPago;
        private Label label3;
        private Button btnNuevo;
        private Button btnCancelar;
    }
}