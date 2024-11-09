
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtTotalGravada = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.btnBuscarDoc = new FontAwesome.Sharp.IconButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.btnEstadoSunat = new System.Windows.Forms.Button();
            this.btnGeneraXML = new System.Windows.Forms.Button();
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
            this.dgvDetalleventa.Location = new System.Drawing.Point(12, 222);
            this.dgvDetalleventa.Name = "dgvDetalleventa";
            this.dgvDetalleventa.RowHeadersWidth = 51;
            this.dgvDetalleventa.RowTemplate.Height = 25;
            this.dgvDetalleventa.Size = new System.Drawing.Size(608, 369);
            this.dgvDetalleventa.TabIndex = 17;
            // 
            // gbIDVenta
            // 
            this.gbIDVenta.Controls.Add(this.comboMetodoPago);
            this.gbIDVenta.Controls.Add(this.comboTipoComprobante);
            this.gbIDVenta.Controls.Add(this.label4);
            this.gbIDVenta.Controls.Add(this.label2);
            this.gbIDVenta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbIDVenta.Location = new System.Drawing.Point(8, 43);
            this.gbIDVenta.Name = "gbIDVenta";
            this.gbIDVenta.Size = new System.Drawing.Size(300, 126);
            this.gbIDVenta.TabIndex = 21;
            this.gbIDVenta.TabStop = false;
            this.gbIDVenta.Text = "INFORMACION PAGO";
            // 
            // comboMetodoPago
            // 
            this.comboMetodoPago.FormattingEnabled = true;
            this.comboMetodoPago.Location = new System.Drawing.Point(158, 75);
            this.comboMetodoPago.Name = "comboMetodoPago";
            this.comboMetodoPago.Size = new System.Drawing.Size(113, 25);
            this.comboMetodoPago.TabIndex = 41;
            // 
            // comboTipoComprobante
            // 
            this.comboTipoComprobante.FormattingEnabled = true;
            this.comboTipoComprobante.Location = new System.Drawing.Point(159, 38);
            this.comboTipoComprobante.Name = "comboTipoComprobante";
            this.comboTipoComprobante.Size = new System.Drawing.Size(112, 25);
            this.comboTipoComprobante.TabIndex = 40;
            this.comboTipoComprobante.SelectedIndexChanged += new System.EventHandler(this.comboTipoComprobante_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(49, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Metodo Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo Comprobante";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(125, 28);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(113, 22);
            this.txtDocumento.TabIndex = 33;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 94);
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
            this.btnEmitirComprobante.Location = new System.Drawing.Point(758, 441);
            this.btnEmitirComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmitirComprobante.Name = "btnEmitirComprobante";
            this.btnEmitirComprobante.Size = new System.Drawing.Size(99, 51);
            this.btnEmitirComprobante.TabIndex = 20;
            this.btnEmitirComprobante.Text = "DESCARGAR PDF";
            this.btnEmitirComprobante.UseVisualStyleBackColor = false;
            this.btnEmitirComprobante.Click += new System.EventHandler(this.btnEmitirComprobante_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.Location = new System.Drawing.Point(637, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fecha - Hora Emision";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(772, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.Location = new System.Drawing.Point(700, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total Gravada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(716, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "SubTotal";
            // 
            // txtIGV
            // 
            this.txtIGV.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtIGV.Location = new System.Drawing.Point(682, 333);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(128, 22);
            this.txtIGV.TabIndex = 34;
            // 
            // txtTotalGravada
            // 
            this.txtTotalGravada.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtTotalGravada.Location = new System.Drawing.Point(682, 287);
            this.txtTotalGravada.Name = "txtTotalGravada";
            this.txtTotalGravada.Size = new System.Drawing.Size(128, 22);
            this.txtTotalGravada.TabIndex = 35;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtSubTotal.Location = new System.Drawing.Point(682, 381);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(128, 22);
            this.txtSubTotal.TabIndex = 36;
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSerie.Location = new System.Drawing.Point(61, 184);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(43, 17);
            this.txtSerie.TabIndex = 37;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(12, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Serie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nombre";
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
            this.groupBox1.Location = new System.Drawing.Point(314, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 167);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO CLIENTE";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(362, 22);
            this.txtEmail.TabIndex = 61;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 60;
            this.label13.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 59;
            this.label12.Text = "Tipo Doc";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Location = new System.Drawing.Point(387, 28);
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
            this.btnBuscarDoc.Location = new System.Drawing.Point(244, 28);
            this.btnBuscarDoc.Name = "btnBuscarDoc";
            this.btnBuscarDoc.Size = new System.Drawing.Size(29, 22);
            this.btnBuscarDoc.TabIndex = 57;
            this.btnBuscarDoc.UseVisualStyleBackColor = false;
            this.btnBuscarDoc.Click += new System.EventHandler(this.btnBuscarDoc_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(125, 91);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(362, 22);
            this.txtDireccion.TabIndex = 44;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(362, 22);
            this.txtNombre.TabIndex = 43;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(729, 313);
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
            this.btnPagar.Location = new System.Drawing.Point(636, 441);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(116, 51);
            this.btnPagar.TabIndex = 41;
            this.btnPagar.Text = "PAGAR VENTA";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(110, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(11, 13);
            this.textBox2.TabIndex = 43;
            this.textBox2.Text = "-";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorrelativo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCorrelativo.Location = new System.Drawing.Point(127, 184);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.ReadOnly = true;
            this.txtCorrelativo.Size = new System.Drawing.Size(43, 17);
            this.txtCorrelativo.TabIndex = 44;
            this.txtCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEstadoSunat
            // 
            this.btnEstadoSunat.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEstadoSunat.FlatAppearance.BorderSize = 0;
            this.btnEstadoSunat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoSunat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEstadoSunat.Location = new System.Drawing.Point(636, 496);
            this.btnEstadoSunat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstadoSunat.Name = "btnEstadoSunat";
            this.btnEstadoSunat.Size = new System.Drawing.Size(116, 51);
            this.btnEstadoSunat.TabIndex = 45;
            this.btnEstadoSunat.Text = "CONSULTAR ESTADO SUNAT";
            this.btnEstadoSunat.UseVisualStyleBackColor = false;
            this.btnEstadoSunat.Click += new System.EventHandler(this.btnEstadoSunat_Click);
            // 
            // btnGeneraXML
            // 
            this.btnGeneraXML.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGeneraXML.FlatAppearance.BorderSize = 0;
            this.btnGeneraXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneraXML.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGeneraXML.Location = new System.Drawing.Point(758, 496);
            this.btnGeneraXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneraXML.Name = "btnGeneraXML";
            this.btnGeneraXML.Size = new System.Drawing.Size(99, 51);
            this.btnGeneraXML.TabIndex = 46;
            this.btnGeneraXML.Text = "DESCARGAR XML";
            this.btnGeneraXML.UseVisualStyleBackColor = false;
            this.btnGeneraXML.Click += new System.EventHandler(this.btnGeneraXML_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(869, 603);
            this.Controls.Add(this.btnGeneraXML);
            this.Controls.Add(this.btnEstadoSunat);
            this.Controls.Add(this.txtCorrelativo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.txtTotalGravada);
            this.Controls.Add(this.label9);
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
        private TextBox txtEmail;
        private Label label13;
        private TextBox textBox2;
        private TextBox txtCorrelativo;
        private Button btnEstadoSunat;
        private Button btnGeneraXML;
    }
}