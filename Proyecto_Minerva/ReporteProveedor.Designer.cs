namespace CapaPresentacion
{
    partial class ReporteProveedor
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
            this.gboxBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscarUsuario = new FontAwesome.Sharp.IconButton();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.gboxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxBusqueda
            // 
            this.gboxBusqueda.BackColor = System.Drawing.Color.MintCream;
            this.gboxBusqueda.Controls.Add(this.txtBusqueda);
            this.gboxBusqueda.Controls.Add(this.btnLimpiar);
            this.gboxBusqueda.Controls.Add(this.btnBuscarUsuario);
            this.gboxBusqueda.Controls.Add(this.cbBusqueda);
            this.gboxBusqueda.Controls.Add(this.label8);
            this.gboxBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gboxBusqueda.Location = new System.Drawing.Point(36, 12);
            this.gboxBusqueda.Name = "gboxBusqueda";
            this.gboxBusqueda.Size = new System.Drawing.Size(539, 65);
            this.gboxBusqueda.TabIndex = 23;
            this.gboxBusqueda.TabStop = false;
            this.gboxBusqueda.Text = "Buscar Proveedor";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(308, 29);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(168, 22);
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
            this.btnLimpiar.Location = new System.Drawing.Point(491, 26);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(29, 22);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarUsuario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarUsuario.IconSize = 15;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(249, 26);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(29, 25);
            this.btnBuscarUsuario.TabIndex = 14;
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "Telefono",
            "Razon Social",
            "RUC"});
            this.cbBusqueda.Location = new System.Drawing.Point(95, 26);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(148, 25);
            this.cbBusqueda.TabIndex = 14;
            this.cbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbBusqueda_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Buscar por:";
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(12, 90);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 25;
            this.dgvProveedor.Size = new System.Drawing.Size(647, 255);
            this.dgvProveedor.TabIndex = 24;
            this.dgvProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellDoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MintCream;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(595, 28);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 35);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ReporteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(671, 357);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.gboxBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Reporte Proveedor";
            this.gboxBusqueda.ResumeLayout(false);
            this.gboxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gboxBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscarUsuario;
        private ComboBox cbBusqueda;
        private Label label8;
        private DataGridView dgvProveedor;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}