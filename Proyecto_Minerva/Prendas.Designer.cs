namespace CapaPresentacion
{
    partial class Prendas
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
            this.btnAgregarPre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrevioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnRemovPro = new System.Windows.Forms.Button();
            this.btnEditPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarPre
            // 
            this.btnAgregarPre.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarPre.FlatAppearance.BorderSize = 0;
            this.btnAgregarPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAgregarPre.Location = new System.Drawing.Point(716, 27);
            this.btnAgregarPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPre.Name = "btnAgregarPre";
            this.btnAgregarPre.Size = new System.Drawing.Size(104, 47);
            this.btnAgregarPre.TabIndex = 88;
            this.btnAgregarPre.Text = "Agregar";
            this.btnAgregarPre.UseVisualStyleBackColor = false;
            this.btnAgregarPre.Click += new System.EventHandler(this.btnAgregarPre_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(690, 356);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dgvPrendas_SelectionChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button1.Location = new System.Drawing.Point(716, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 47);
            this.button1.TabIndex = 85;
            this.button1.Text = "Deshabilitar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarPre);
            this.groupBox1.Controls.Add(this.cbxEstado);
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtPrevioVenta);
            this.groupBox1.Controls.Add(this.btnEditPro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 208);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de prenda";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Checked = true;
            this.cbxEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxEstado.Location = new System.Drawing.Point(187, 148);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(67, 21);
            this.cbxEstado.TabIndex = 87;
            this.cbxEstado.Text = "Estado";
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(530, 145);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(123, 22);
            this.txtPrecioCompra.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Precio Compra";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(116, 42);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(215, 22);
            this.txtDescripcion.TabIndex = 77;
            // 
            // txtPrevioVenta
            // 
            this.txtPrevioVenta.Location = new System.Drawing.Point(530, 112);
            this.txtPrevioVenta.Name = "txtPrevioVenta";
            this.txtPrevioVenta.Size = new System.Drawing.Size(123, 22);
            this.txtPrevioVenta.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Precio Venta";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(530, 42);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(123, 22);
            this.txtStock.TabIndex = 81;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button2.Location = new System.Drawing.Point(348, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 35);
            this.button2.TabIndex = 66;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 73;
            this.label13.Text = "Talla";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(482, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 80;
            this.label16.Text = "Stock";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "S",
            "M",
            "L",
            "XL"});
            this.comboBox3.Location = new System.Drawing.Point(530, 75);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(123, 25);
            this.comboBox3.TabIndex = 72;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 73);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 25);
            this.comboBox2.TabIndex = 71;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 109);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 25);
            this.comboBox1.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 69;
            this.label12.Text = "Colegio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 68;
            this.label11.Text = "Categoria";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button3.Location = new System.Drawing.Point(728, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 47);
            this.button3.TabIndex = 83;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnRemovPro
            // 
            this.BtnRemovPro.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnRemovPro.FlatAppearance.BorderSize = 0;
            this.BtnRemovPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemovPro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnRemovPro.Location = new System.Drawing.Point(728, 417);
            this.BtnRemovPro.Name = "BtnRemovPro";
            this.BtnRemovPro.Size = new System.Drawing.Size(104, 47);
            this.BtnRemovPro.TabIndex = 81;
            this.BtnRemovPro.Text = "Cancelar";
            this.BtnRemovPro.UseVisualStyleBackColor = false;
            this.BtnRemovPro.Click += new System.EventHandler(this.BtnRemovPro_Click);
            // 
            // btnEditPro
            // 
            this.btnEditPro.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEditPro.FlatAppearance.BorderSize = 0;
            this.btnEditPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEditPro.Location = new System.Drawing.Point(716, 81);
            this.btnEditPro.Name = "btnEditPro";
            this.btnEditPro.Size = new System.Drawing.Size(104, 47);
            this.btnEditPro.TabIndex = 80;
            this.btnEditPro.Text = "Modificar";
            this.btnEditPro.UseVisualStyleBackColor = false;
            this.btnEditPro.Click += new System.EventHandler(this.btnEditPro_Click);
            // 
            // Prendas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(869, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnRemovPro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prendas1";
            this.Text = "Prendas1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAgregarPre;
        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox1;
        private CheckBox cbxEstado;
        private TextBox txtPrecioCompra;
        private Label label6;
        private TextBox txtDescripcion;
        private TextBox txtPrevioVenta;
        private Label label4;
        private Label label8;
        private TextBox txtStock;
        private Label label13;
        private Label label16;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private Button button2;
        private Button button3;
        private Button BtnRemovPro;
        private Button btnEditPro;
    }
}