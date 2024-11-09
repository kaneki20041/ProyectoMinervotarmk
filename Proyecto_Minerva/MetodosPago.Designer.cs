namespace Proyecto_Minerva
{
    partial class MetodosPago
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbkEstMetPago = new System.Windows.Forms.CheckBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtMetpago = new System.Windows.Forms.TextBox();
            this.dgvMetPago = new System.Windows.Forms.DataGridView();
            this.btnCancelFpag = new System.Windows.Forms.Button();
            this.btnModFpag = new System.Windows.Forms.Button();
            this.btnAgreMpag = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetPago)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Metodo pago";
            // 
            // cbkEstMetPago
            // 
            this.cbkEstMetPago.AutoSize = true;
            this.cbkEstMetPago.Checked = true;
            this.cbkEstMetPago.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkEstMetPago.Location = new System.Drawing.Point(313, 105);
            this.cbkEstMetPago.Name = "cbkEstMetPago";
            this.cbkEstMetPago.Size = new System.Drawing.Size(67, 21);
            this.cbkEstMetPago.TabIndex = 41;
            this.cbkEstMetPago.Text = "Estado";
            this.cbkEstMetPago.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(290, 45);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(112, 22);
            this.txtid.TabIndex = 42;
            // 
            // txtMetpago
            // 
            this.txtMetpago.Location = new System.Drawing.Point(290, 70);
            this.txtMetpago.Name = "txtMetpago";
            this.txtMetpago.Size = new System.Drawing.Size(112, 22);
            this.txtMetpago.TabIndex = 43;
            // 
            // dgvMetPago
            // 
            this.dgvMetPago.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvMetPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMetPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetPago.Location = new System.Drawing.Point(124, 46);
            this.dgvMetPago.Name = "dgvMetPago";
            this.dgvMetPago.RowTemplate.Height = 25;
            this.dgvMetPago.Size = new System.Drawing.Size(471, 310);
            this.dgvMetPago.TabIndex = 44;
            // 
            // btnCancelFpag
            // 
            this.btnCancelFpag.BackColor = System.Drawing.Color.LightCyan;
            this.btnCancelFpag.FlatAppearance.BorderSize = 0;
            this.btnCancelFpag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFpag.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelFpag.Location = new System.Drawing.Point(543, 85);
            this.btnCancelFpag.Name = "btnCancelFpag";
            this.btnCancelFpag.Size = new System.Drawing.Size(100, 36);
            this.btnCancelFpag.TabIndex = 47;
            this.btnCancelFpag.Text = "Cancelar";
            this.btnCancelFpag.UseVisualStyleBackColor = false;
            this.btnCancelFpag.Click += new System.EventHandler(this.btnCancelFpag_Click);
            // 
            // btnModFpag
            // 
            this.btnModFpag.BackColor = System.Drawing.Color.LightCyan;
            this.btnModFpag.FlatAppearance.BorderSize = 0;
            this.btnModFpag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModFpag.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnModFpag.Location = new System.Drawing.Point(437, 85);
            this.btnModFpag.Name = "btnModFpag";
            this.btnModFpag.Size = new System.Drawing.Size(100, 34);
            this.btnModFpag.TabIndex = 46;
            this.btnModFpag.Text = "Modificar";
            this.btnModFpag.UseVisualStyleBackColor = false;
            this.btnModFpag.Click += new System.EventHandler(this.btnModFpag_Click);
            // 
            // btnAgreMpag
            // 
            this.btnAgreMpag.BackColor = System.Drawing.Color.LightCyan;
            this.btnAgreMpag.FlatAppearance.BorderSize = 0;
            this.btnAgreMpag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgreMpag.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAgreMpag.Location = new System.Drawing.Point(437, 45);
            this.btnAgreMpag.Name = "btnAgreMpag";
            this.btnAgreMpag.Size = new System.Drawing.Size(100, 34);
            this.btnAgreMpag.TabIndex = 45;
            this.btnAgreMpag.Text = "Agregar";
            this.btnAgreMpag.UseVisualStyleBackColor = false;
            this.btnAgreMpag.Click += new System.EventHandler(this.btnAgreMpag_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button4.Location = new System.Drawing.Point(636, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 48);
            this.button4.TabIndex = 50;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button5.Location = new System.Drawing.Point(636, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 48);
            this.button5.TabIndex = 49;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCyan;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button6.Location = new System.Drawing.Point(543, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 34);
            this.button6.TabIndex = 48;
            this.button6.Text = "Deshabilitar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEstado);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dgvMetPago);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox1.Location = new System.Drawing.Point(20, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 386);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodos de pago";
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.LightBlue;
            this.btnEstado.FlatAppearance.BorderSize = 0;
            this.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEstado.Location = new System.Drawing.Point(636, 228);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(86, 48);
            this.btnEstado.TabIndex = 51;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelFpag);
            this.groupBox2.Controls.Add(this.txtMetpago);
            this.groupBox2.Controls.Add(this.btnModFpag);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.cbkEstMetPago);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAgreMpag);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox2.Location = new System.Drawing.Point(20, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 157);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // Desc_Formpago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(869, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desc_Formpago";
            this.Text = "Motorizado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetPago)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label3;
        private Label label4;
        private CheckBox cbkEstMetPago;
        private TextBox txtid;
        private TextBox txtMetpago;
        private DataGridView dgvMetPago;
        private Button btnCancelFpag;
        private Button btnModFpag;
        private Button btnAgreMpag;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnEstado;
    }
}