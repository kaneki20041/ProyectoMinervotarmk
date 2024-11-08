namespace Proyecto_Minerva
{
    partial class Ventauniforme
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarDni = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtColegio = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tablaVentas = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Talla";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button1.Location = new System.Drawing.Point(735, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Registrar Venta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(110, 37);
            this.txtDocumento.Multiline = true;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(104, 20);
            this.txtDocumento.TabIndex = 20;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(103, 36);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(196, 22);
            this.txtDescripcion.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumVenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVendedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 108);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Venta";
            // 
            // txtNumVenta
            // 
            this.txtNumVenta.Location = new System.Drawing.Point(103, 30);
            this.txtNumVenta.Name = "txtNumVenta";
            this.txtNumVenta.ReadOnly = true;
            this.txtNumVenta.Size = new System.Drawing.Size(119, 22);
            this.txtNumVenta.TabIndex = 60;
            this.txtNumVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nº Venta";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(103, 66);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(295, 22);
            this.txtVendedor.TabIndex = 58;
            this.txtVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Vendedor";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(304, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(94, 22);
            this.dateTimePicker2.TabIndex = 36;
            this.dateTimePicker2.UseWaitCursor = true;
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
            this.btnBuscarDni.Location = new System.Drawing.Point(226, 37);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(29, 20);
            this.btnBuscarDni.TabIndex = 55;
            this.btnBuscarDni.UseVisualStyleBackColor = false;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarDni);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDocumento);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox2.Location = new System.Drawing.Point(473, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 108);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nombre";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(103, 145);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.ReadOnly = true;
            this.txtTalla.Size = new System.Drawing.Size(196, 22);
            this.txtTalla.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(445, 92);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(102, 22);
            this.txtPrecio.TabIndex = 39;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(445, 129);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(102, 22);
            this.txtStock.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cantidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.iconButton2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtCategoria);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtColegio);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtStock);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTalla);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 183);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Prenda";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(445, 54);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(102, 22);
            this.txtCantidad.TabIndex = 57;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.PowderBlue;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 15;
            this.iconButton2.Location = new System.Drawing.Point(317, 36);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(33, 22);
            this.iconButton2.TabIndex = 56;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 51;
            this.label15.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(103, 111);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(196, 20);
            this.txtCategoria.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Colegio";
            // 
            // txtColegio
            // 
            this.txtColegio.Location = new System.Drawing.Point(103, 74);
            this.txtColegio.Multiline = true;
            this.txtColegio.Name = "txtColegio";
            this.txtColegio.ReadOnly = true;
            this.txtColegio.Size = new System.Drawing.Size(196, 20);
            this.txtColegio.TabIndex = 38;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.textBox6.Location = new System.Drawing.Point(735, 430);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(111, 22);
            this.textBox6.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label11.Location = new System.Drawing.Point(760, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Sub Total";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button2.Location = new System.Drawing.Point(581, 105);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 45);
            this.button2.TabIndex = 45;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tablaVentas
            // 
            this.tablaVentas.BackgroundColor = System.Drawing.Color.MintCream;
            this.tablaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Colegio,
            this.Categoria,
            this.Talla,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.tablaVentas.Location = new System.Drawing.Point(12, 321);
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.RowHeadersWidth = 51;
            this.tablaVentas.RowTemplate.Height = 25;
            this.tablaVentas.Size = new System.Drawing.Size(701, 270);
            this.tablaVentas.TabIndex = 47;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Colegio
            // 
            this.Colegio.HeaderText = "Colegio";
            this.Colegio.Name = "Colegio";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Talla
            // 
            this.Talla.HeaderText = "Talla";
            this.Talla.Name = "Talla";
            this.Talla.Width = 60;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 80;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 80;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button3.Location = new System.Drawing.Point(581, 54);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 45);
            this.button3.TabIndex = 48;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label13.Location = new System.Drawing.Point(741, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Monto Cambio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label16.Location = new System.Drawing.Point(751, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 17);
            this.label16.TabIndex = 50;
            this.label16.Text = "Monto Pago";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.textBox13.Location = new System.Drawing.Point(735, 381);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(111, 22);
            this.textBox13.TabIndex = 51;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.textBox14.Location = new System.Drawing.Point(735, 479);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(111, 22);
            this.textBox14.TabIndex = 52;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.Location = new System.Drawing.Point(735, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 45);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(735, 187);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 45);
            this.btnNuevo.TabIndex = 58;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Ventauniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(869, 603);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.tablaVentas);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventauniforme";
            this.Load += new System.EventHandler(this.Ventauniforme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label5;
        private TextBox txtNombre;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox txtDocumento;
        private TextBox txtDescripcion;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private TextBox txtTalla;
        private Label label3;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label9;
        private Label label10;
        private GroupBox groupBox3;
        private Label label11;
        private TextBox textBox6;
        private Button button2;
        private TextBox txtColegio;
        private Label label15;
        private TextBox txtCategoria;
        private Label label14;
        private DataGridView tablaVentas;
        private Button button3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnBuscarDni;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label13;
        private Label label16;
        private TextBox textBox13;
        private TextBox textBox14;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Colegio;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
        private TextBox txtCantidad;
        private TextBox txtVendedor;
        private Label label1;
        private TextBox txtNumVenta;
        private Button btnCancelar;
        private Button btnNuevo;
    }
}