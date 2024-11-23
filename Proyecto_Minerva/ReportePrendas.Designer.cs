namespace CapaPresentacion
{
    partial class ReportePrendas
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
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.dgvPrendas = new System.Windows.Forms.DataGridView();
            this.gboxBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).BeginInit();
            this.gboxBusqueda.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSalir.Location = new System.Drawing.Point(595, 26);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 35);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvPrendas
            // 
            this.dgvPrendas.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvPrendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrendas.Location = new System.Drawing.Point(16, 88);
            this.dgvPrendas.Name = "dgvPrendas";
            this.dgvPrendas.RowHeadersWidth = 51;
            this.dgvPrendas.RowTemplate.Height = 25;
            this.dgvPrendas.Size = new System.Drawing.Size(637, 252);
            this.dgvPrendas.TabIndex = 27;
            this.dgvPrendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrendas_CellDoubleClick);
            // 
            // gboxBusqueda
            // 
            this.gboxBusqueda.BackColor = System.Drawing.Color.MintCream;
            this.gboxBusqueda.Controls.Add(this.txtBusqueda);
            this.gboxBusqueda.Controls.Add(this.btnLimpiar);
            this.gboxBusqueda.Controls.Add(this.cbBusqueda);
            this.gboxBusqueda.Controls.Add(this.label8);
            this.gboxBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gboxBusqueda.Location = new System.Drawing.Point(36, 12);
            this.gboxBusqueda.Name = "gboxBusqueda";
            this.gboxBusqueda.Size = new System.Drawing.Size(541, 64);
            this.gboxBusqueda.TabIndex = 26;
            this.gboxBusqueda.TabStop = false;
            this.gboxBusqueda.Text = "Buscar Prendas";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(286, 26);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(163, 22);
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
            this.btnLimpiar.Location = new System.Drawing.Point(478, 27);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(29, 20);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "Talla",
            "Categoria",
            "Descripcion"});
            this.cbBusqueda.Location = new System.Drawing.Point(95, 26);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(140, 25);
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
            // ReportePrendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(671, 357);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPrendas);
            this.Controls.Add(this.gboxBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ReportePrendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Prendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).EndInit();
            this.gboxBusqueda.ResumeLayout(false);
            this.gboxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private DataGridView dgvPrendas;
        private GroupBox gboxBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private ComboBox cbBusqueda;
        private Label label8;
    }
}