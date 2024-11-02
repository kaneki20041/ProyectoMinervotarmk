namespace Proyecto_Minerva
{
    partial class Carrito
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
            this.dgvDetalleventa = new System.Windows.Forms.DataGridView();
            this.gbIDVenta = new System.Windows.Forms.GroupBox();
            this.comboMetodoPago = new System.Windows.Forms.ComboBox();
            this.comboTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEmitirComprobante = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtTotalGravada = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.btnBuscarDoc = new FontAwesome.Sharp.IconButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleventa)).BeginInit();
            this.gbIDVenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalleventa
            // 
            this.dgvDetalleventa.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvDetalleventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleventa.Location = new System.Drawing.Point(10, 233);
            this.dgvDetalleventa.Name = "dgvDetalleventa";
            this.dgvDetalleventa.RowHeadersWidth = 51;
            this.dgvDetalleventa.RowTemplate.Height = 25;
            this.dgvDetalleventa.Size = new System.Drawing.Size(624, 309);
            this.dgvDetalleventa.TabIndex = 17;
            // 
            // gbIDVenta
            // 
            this.gbIDVenta.Controls.Add(this.comboMetodoPago);
            this.gbIDVenta.Controls.Add(this.comboTipoComprobante);
            this.gbIDVenta.Controls.Add(this.label4);
            this.gbIDVenta.Controls.Add(this.label2);
            this.gbIDVenta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbIDVenta.Location = new System.Drawing.Point(10, 42);
            this.gbIDVenta.Name = "gbIDVenta";
            this.gbIDVenta.Size = new System.Drawing.Size(300, 137);
            this.gbIDVenta.TabIndex = 21;
            this.gbIDVenta.TabStop = false;
            this.gbIDVenta.Text = "INFORMACION PAGO";
            // 
            // comboMetodoPago
            // 
            this.comboMetodoPago.FormattingEnabled = true;
            this.comboMetodoPago.Location = new System.Drawing.Point(154, 77);
            this.comboMetodoPago.Name = "comboMetodoPago";
            this.comboMetodoPago.Size = new System.Drawing.Size(113, 25);
            this.comboMetodoPago.TabIndex = 41;
            // 
            // comboTipoComprobante
            // 
            this.comboTipoComprobante.FormattingEnabled = true;
            this.comboTipoComprobante.Location = new System.Drawing.Point(155, 40);
            this.comboTipoComprobante.Name = "comboTipoComprobante";
            this.comboTipoComprobante.Size = new System.Drawing.Size(112, 25);
            this.comboTipoComprobante.TabIndex = 40;
            this.comboTipoComprobante.SelectedIndexChanged += new System.EventHandler(this.comboTipoComprobante_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(45, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Metodo Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo Comprobante";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(112, 31);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(113, 22);
            this.txtDocumento.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Direccion";
            // 
            // btnEmitirComprobante
            // 
            this.btnEmitirComprobante.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEmitirComprobante.FlatAppearance.BorderSize = 0;
            this.btnEmitirComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirComprobante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEmitirComprobante.Location = new System.Drawing.Point(657, 453);
            this.btnEmitirComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmitirComprobante.Name = "btnEmitirComprobante";
            this.btnEmitirComprobante.Size = new System.Drawing.Size(128, 50);
            this.btnEmitirComprobante.TabIndex = 20;
            this.btnEmitirComprobante.Text = "EMITIR COMPROBANTE";
            this.btnEmitirComprobante.UseVisualStyleBackColor = false;
            this.btnEmitirComprobante.Click += new System.EventHandler(this.btnEmitirComprobante_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.Location = new System.Drawing.Point(556, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fecha - Hora Emision";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(691, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.Location = new System.Drawing.Point(657, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total Gravada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(657, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "IGV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(657, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "SubTotal";
            // 
            // txtIGV
            // 
            this.txtIGV.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtIGV.Location = new System.Drawing.Point(657, 368);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(128, 22);
            this.txtIGV.TabIndex = 34;
            // 
            // txtTotalGravada
            // 
            this.txtTotalGravada.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtTotalGravada.Location = new System.Drawing.Point(657, 322);
            this.txtTotalGravada.Name = "txtTotalGravada";
            this.txtTotalGravada.Size = new System.Drawing.Size(128, 22);
            this.txtTotalGravada.TabIndex = 35;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtSubTotal.Location = new System.Drawing.Point(657, 416);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(128, 22);
            this.txtSubTotal.TabIndex = 36;
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSerie.Location = new System.Drawing.Point(80, 192);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(86, 24);
            this.txtSerie.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(31, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Serie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTipoDoc);
            this.groupBox1.Controls.Add(this.btnBuscarDoc);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox1.Location = new System.Drawing.Point(316, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 137);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO CLIENTE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 59;
            this.label12.Text = "Tipo Doc";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Location = new System.Drawing.Point(336, 31);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(99, 22);
            this.txtTipoDoc.TabIndex = 58;
            // 
            // btnBuscarDoc
            // 
            this.btnBuscarDoc.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscarDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDoc.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarDoc.IconColor = System.Drawing.Color.Black;
            this.btnBuscarDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarDoc.IconSize = 15;
            this.btnBuscarDoc.Location = new System.Drawing.Point(231, 31);
            this.btnBuscarDoc.Name = "btnBuscarDoc";
            this.btnBuscarDoc.Size = new System.Drawing.Size(29, 20);
            this.btnBuscarDoc.TabIndex = 57;
            this.btnBuscarDoc.UseVisualStyleBackColor = false;
            this.btnBuscarDoc.Click += new System.EventHandler(this.btnBuscarDoc_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(112, 95);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(323, 22);
            this.txtDireccion.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 22);
            this.txtNombre.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(657, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "IGV";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPagar.Location = new System.Drawing.Point(657, 258);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(128, 36);
            this.btnPagar.TabIndex = 41;
            this.btnPagar.Text = "PAGAR VENTA";
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(819, 553);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.txtTotalGravada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEmitirComprobante);
            this.Controls.Add(this.gbIDVenta);
            this.Controls.Add(this.dgvDetalleventa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrito";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleventa)).EndInit();
            this.gbIDVenta.ResumeLayout(false);
            this.gbIDVenta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvDetalleventa;
        private GroupBox gbIDVenta;
        private TextBox txtDocumento;
        private Label label6;
        private Label label4;
        private Label label2;
        private Button btnEmitirComprobante;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtIGV;
        private TextBox txtTotalGravada;
        private TextBox txtSubTotal;
        private TextBox txtSerie;
        private Label label10;
        private ComboBox comboMetodoPago;
        private ComboBox comboTipoComprobante;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnBuscarDoc;
        private Label label12;
        private TextBox txtTipoDoc;
        private Label label1;
        private Button btnPagar;
    }
}