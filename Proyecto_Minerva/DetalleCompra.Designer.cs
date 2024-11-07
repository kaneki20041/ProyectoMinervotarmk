﻿namespace Proyecto_Minerva
{
    partial class DetalleCompra
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
            this.detallito = new System.Windows.Forms.DataGridView();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.btnBuscarDoc = new FontAwesome.Sharp.IconButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gbIDVenta = new System.Windows.Forms.GroupBox();
            this.comboMetodoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeneraXML = new System.Windows.Forms.Button();
            this.btnEstadoSunat = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtTotalGravada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEmitirComprobante = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.detallito)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbIDVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // detallito
            // 
            this.detallito.BackgroundColor = System.Drawing.Color.MintCream;
            this.detallito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detallito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallito.Location = new System.Drawing.Point(31, 213);
            this.detallito.Name = "detallito";
            this.detallito.RowHeadersWidth = 51;
            this.detallito.RowTemplate.Height = 25;
            this.detallito.Size = new System.Drawing.Size(533, 246);
            this.detallito.TabIndex = 29;
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorrelativo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCorrelativo.Location = new System.Drawing.Point(143, 190);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.ReadOnly = true;
            this.txtCorrelativo.Size = new System.Drawing.Size(43, 17);
            this.txtCorrelativo.TabIndex = 52;
            this.txtCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(126, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(11, 13);
            this.textBox2.TabIndex = 51;
            this.textBox2.Text = "-";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label13);
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
            this.groupBox1.Location = new System.Drawing.Point(313, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 160);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO PROVEEDOR";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 22);
            this.txtEmail.TabIndex = 61;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 60;
            this.label13.Text = "Email";
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
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(112, 95);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(323, 22);
            this.txtDireccion.TabIndex = 44;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 22);
            this.txtNombre.TabIndex = 43;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "RUC";
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
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(78, 30);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(113, 22);
            this.txtDocumento.TabIndex = 33;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(28, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "Serie:";
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSerie.Location = new System.Drawing.Point(77, 190);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(43, 17);
            this.txtSerie.TabIndex = 48;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(688, 8);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.Location = new System.Drawing.Point(553, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fecha - Hora Emision";
            // 
            // gbIDVenta
            // 
            this.gbIDVenta.Controls.Add(this.textBox1);
            this.gbIDVenta.Controls.Add(this.comboMetodoPago);
            this.gbIDVenta.Controls.Add(this.label4);
            this.gbIDVenta.Controls.Add(this.label2);
            this.gbIDVenta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbIDVenta.Location = new System.Drawing.Point(7, 38);
            this.gbIDVenta.Name = "gbIDVenta";
            this.gbIDVenta.Size = new System.Drawing.Size(300, 137);
            this.gbIDVenta.TabIndex = 45;
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
            // btnGeneraXML
            // 
            this.btnGeneraXML.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGeneraXML.FlatAppearance.BorderSize = 0;
            this.btnGeneraXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneraXML.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGeneraXML.Location = new System.Drawing.Point(672, 440);
            this.btnGeneraXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneraXML.Name = "btnGeneraXML";
            this.btnGeneraXML.Size = new System.Drawing.Size(110, 42);
            this.btnGeneraXML.TabIndex = 63;
            this.btnGeneraXML.Text = "DESCARGAR XML";
            this.btnGeneraXML.UseVisualStyleBackColor = false;
            // 
            // btnEstadoSunat
            // 
            this.btnEstadoSunat.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEstadoSunat.FlatAppearance.BorderSize = 0;
            this.btnEstadoSunat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoSunat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEstadoSunat.Location = new System.Drawing.Point(672, 488);
            this.btnEstadoSunat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstadoSunat.Name = "btnEstadoSunat";
            this.btnEstadoSunat.Size = new System.Drawing.Size(110, 42);
            this.btnEstadoSunat.TabIndex = 62;
            this.btnEstadoSunat.Text = "CONSULTAR ESTADO SUNAT";
            this.btnEstadoSunat.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPagar.Location = new System.Drawing.Point(668, 208);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(114, 44);
            this.btnPagar.TabIndex = 61;
            this.btnPagar.Text = "COMPRAR PRENDAS";
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtSubTotal.Location = new System.Drawing.Point(665, 367);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(128, 22);
            this.txtSubTotal.TabIndex = 59;
            // 
            // txtIGV
            // 
            this.txtIGV.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtIGV.Location = new System.Drawing.Point(665, 319);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(128, 22);
            this.txtIGV.TabIndex = 55;
            // 
            // txtTotalGravada
            // 
            this.txtTotalGravada.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtTotalGravada.Location = new System.Drawing.Point(665, 274);
            this.txtTotalGravada.Name = "txtTotalGravada";
            this.txtTotalGravada.Size = new System.Drawing.Size(128, 22);
            this.txtTotalGravada.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(665, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "SubTotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(665, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "IGV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.Location = new System.Drawing.Point(662, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Total Gravada";
            // 
            // btnEmitirComprobante
            // 
            this.btnEmitirComprobante.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEmitirComprobante.FlatAppearance.BorderSize = 0;
            this.btnEmitirComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirComprobante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEmitirComprobante.Location = new System.Drawing.Point(672, 394);
            this.btnEmitirComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmitirComprobante.Name = "btnEmitirComprobante";
            this.btnEmitirComprobante.Size = new System.Drawing.Size(110, 42);
            this.btnEmitirComprobante.TabIndex = 53;
            this.btnEmitirComprobante.Text = "DESCARGAR PDF";
            this.btnEmitirComprobante.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "FACTURA";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(819, 553);
            this.Controls.Add(this.btnGeneraXML);
            this.Controls.Add(this.btnEstadoSunat);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.txtTotalGravada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEmitirComprobante);
            this.Controls.Add(this.txtCorrelativo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbIDVenta);
            this.Controls.Add(this.detallito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleCompra";
            this.Text = "IngMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.detallito)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbIDVenta.ResumeLayout(false);
            this.gbIDVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView detallito;
        private DataGridViewTextBoxColumn Telefono;
        private TextBox txtCorrelativo;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private Label label13;
        private Label label12;
        private TextBox txtTipoDoc;
        private FontAwesome.Sharp.IconButton btnBuscarDoc;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label5;
        private Label label11;
        private Label label6;
        private TextBox txtDocumento;
        private Label label10;
        private TextBox txtSerie;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private GroupBox gbIDVenta;
        private ComboBox comboMetodoPago;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private Button btnGeneraXML;
        private Button btnEstadoSunat;
        private Button btnPagar;
        private TextBox txtSubTotal;
        private TextBox txtIGV;
        private TextBox txtTotalGravada;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnEmitirComprobante;
    }
}