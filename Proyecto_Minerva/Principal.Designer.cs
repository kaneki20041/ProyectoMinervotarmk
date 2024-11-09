namespace Proyecto_Minerva
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.lblUser = new System.Windows.Forms.Label();
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnVenderPrendas = new FontAwesome.Sharp.IconButton();
            this.btnComprarPrendas = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.btnPrendas = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnMetodoPago = new FontAwesome.Sharp.IconButton();
            this.btnCarrito = new FontAwesome.Sharp.IconButton();
            this.btn_Facturacion = new FontAwesome.Sharp.IconButton();
            this.btnCategoria = new FontAwesome.Sharp.IconButton();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelCategoria = new System.Windows.Forms.Panel();
            this.panelPagoComp = new System.Windows.Forms.Panel();
            this.panelPagoVent = new System.Windows.Forms.Panel();
            this.panelPrenda = new System.Windows.Forms.Panel();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.panelMet = new System.Windows.Forms.Panel();
            this.panelProvee = new System.Windows.Forms.Panel();
            this.panelComprar = new System.Windows.Forms.Panel();
            this.panelVender = new System.Windows.Forms.Panel();
            this.panelconteiner = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.MenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 30;
            this.btnMinimizar.Location = new System.Drawing.Point(972, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 27);
            this.btnMinimizar.TabIndex = 17;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(1011, 11);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 27);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.lblUser.Location = new System.Drawing.Point(195, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(771, 18);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "lblNombreUsuario";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuLateral
            // 
            this.MenuLateral.BackColor = System.Drawing.Color.Khaki;
            this.MenuLateral.Controls.Add(this.panel2);
            this.MenuLateral.Controls.Add(this.iconButton1);
            this.MenuLateral.Controls.Add(this.btnInventario);
            this.MenuLateral.Controls.Add(this.panelInventario);
            this.MenuLateral.Controls.Add(this.btnUsuarios);
            this.MenuLateral.Controls.Add(this.btnVenderPrendas);
            this.MenuLateral.Controls.Add(this.btnComprarPrendas);
            this.MenuLateral.Controls.Add(this.btnCliente);
            this.MenuLateral.Controls.Add(this.btnPrendas);
            this.MenuLateral.Controls.Add(this.btnProveedores);
            this.MenuLateral.Controls.Add(this.btnMetodoPago);
            this.MenuLateral.Controls.Add(this.btnCarrito);
            this.MenuLateral.Controls.Add(this.btn_Facturacion);
            this.MenuLateral.Controls.Add(this.btnCategoria);
            this.MenuLateral.Controls.Add(this.panelUsuario);
            this.MenuLateral.Controls.Add(this.panelCategoria);
            this.MenuLateral.Controls.Add(this.panelPagoComp);
            this.MenuLateral.Controls.Add(this.panelPagoVent);
            this.MenuLateral.Controls.Add(this.panelPrenda);
            this.MenuLateral.Controls.Add(this.panelCliente);
            this.MenuLateral.Controls.Add(this.panelMet);
            this.MenuLateral.Controls.Add(this.panelProvee);
            this.MenuLateral.Controls.Add(this.panelComprar);
            this.MenuLateral.Controls.Add(this.panelVender);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(0, 47);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(181, 603);
            this.MenuLateral.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 32);
            this.panel2.TabIndex = 25;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.Location = new System.Drawing.Point(10, 418);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(171, 32);
            this.iconButton1.TabIndex = 26;
            this.iconButton1.Text = "Dashboard";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnInventario.IconColor = System.Drawing.Color.Black;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 25;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInventario.Location = new System.Drawing.Point(10, 380);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(171, 32);
            this.btnInventario.TabIndex = 25;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // panelInventario
            // 
            this.panelInventario.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelInventario.Location = new System.Drawing.Point(0, 380);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(9, 32);
            this.panelInventario.TabIndex = 24;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 30;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(10, 5);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(171, 32);
            this.btnUsuarios.TabIndex = 23;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnVenderPrendas
            // 
            this.btnVenderPrendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenderPrendas.FlatAppearance.BorderSize = 0;
            this.btnVenderPrendas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnVenderPrendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderPrendas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnVenderPrendas.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnVenderPrendas.IconColor = System.Drawing.Color.Black;
            this.btnVenderPrendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenderPrendas.IconSize = 28;
            this.btnVenderPrendas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVenderPrendas.Location = new System.Drawing.Point(10, 42);
            this.btnVenderPrendas.Name = "btnVenderPrendas";
            this.btnVenderPrendas.Size = new System.Drawing.Size(171, 32);
            this.btnVenderPrendas.TabIndex = 22;
            this.btnVenderPrendas.Text = "Vender Prendas";
            this.btnVenderPrendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenderPrendas.UseVisualStyleBackColor = true;
            this.btnVenderPrendas.Click += new System.EventHandler(this.btnVenderPrendas_Click);
            // 
            // btnComprarPrendas
            // 
            this.btnComprarPrendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprarPrendas.FlatAppearance.BorderSize = 0;
            this.btnComprarPrendas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnComprarPrendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprarPrendas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnComprarPrendas.IconChar = FontAwesome.Sharp.IconChar.Chain;
            this.btnComprarPrendas.IconColor = System.Drawing.Color.Black;
            this.btnComprarPrendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprarPrendas.IconSize = 28;
            this.btnComprarPrendas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnComprarPrendas.Location = new System.Drawing.Point(10, 80);
            this.btnComprarPrendas.Name = "btnComprarPrendas";
            this.btnComprarPrendas.Size = new System.Drawing.Size(171, 32);
            this.btnComprarPrendas.TabIndex = 21;
            this.btnComprarPrendas.Text = "Comprar Prendras";
            this.btnComprarPrendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprarPrendas.UseVisualStyleBackColor = true;
            this.btnComprarPrendas.Click += new System.EventHandler(this.btnComprarPrendas_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnCliente.IconColor = System.Drawing.Color.Black;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCliente.IconSize = 30;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCliente.Location = new System.Drawing.Point(10, 117);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(171, 32);
            this.btnCliente.TabIndex = 20;
            this.btnCliente.Text = "Registrar Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // btnPrendas
            // 
            this.btnPrendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrendas.FlatAppearance.BorderSize = 0;
            this.btnPrendas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrendas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnPrendas.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            this.btnPrendas.IconColor = System.Drawing.Color.Black;
            this.btnPrendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrendas.IconSize = 30;
            this.btnPrendas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrendas.Location = new System.Drawing.Point(10, 154);
            this.btnPrendas.Name = "btnPrendas";
            this.btnPrendas.Size = new System.Drawing.Size(171, 32);
            this.btnPrendas.TabIndex = 19;
            this.btnPrendas.Text = "Prendas";
            this.btnPrendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrendas.UseVisualStyleBackColor = true;
            this.btnPrendas.Click += new System.EventHandler(this.btnPrendas_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnProveedores.IconColor = System.Drawing.Color.Black;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 30;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProveedores.Location = new System.Drawing.Point(10, 193);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(171, 32);
            this.btnProveedores.TabIndex = 18;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnMetodoPago
            // 
            this.btnMetodoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnMetodoPago.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodoPago.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnMetodoPago.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnMetodoPago.IconColor = System.Drawing.Color.Black;
            this.btnMetodoPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMetodoPago.IconSize = 25;
            this.btnMetodoPago.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMetodoPago.Location = new System.Drawing.Point(10, 231);
            this.btnMetodoPago.Name = "btnMetodoPago";
            this.btnMetodoPago.Size = new System.Drawing.Size(171, 32);
            this.btnMetodoPago.TabIndex = 17;
            this.btnMetodoPago.Text = "Metodo Pago";
            this.btnMetodoPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMetodoPago.UseVisualStyleBackColor = true;
            this.btnMetodoPago.Click += new System.EventHandler(this.btnMetodoPago_Click);
            // 
            // btnCarrito
            // 
            this.btnCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarrito.FlatAppearance.BorderSize = 0;
            this.btnCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCarrito.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnCarrito.IconColor = System.Drawing.Color.Black;
            this.btnCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCarrito.IconSize = 25;
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.Location = new System.Drawing.Point(10, 268);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(171, 32);
            this.btnCarrito.TabIndex = 16;
            this.btnCarrito.Text = "Carrito";
            this.btnCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.btnSalidaMaterial_Click);
            // 
            // btn_Facturacion
            // 
            this.btn_Facturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Facturacion.FlatAppearance.BorderSize = 0;
            this.btn_Facturacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facturacion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_Facturacion.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.btn_Facturacion.IconColor = System.Drawing.Color.Black;
            this.btn_Facturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Facturacion.IconSize = 25;
            this.btn_Facturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Facturacion.Location = new System.Drawing.Point(10, 305);
            this.btn_Facturacion.Name = "btn_Facturacion";
            this.btn_Facturacion.Size = new System.Drawing.Size(171, 32);
            this.btn_Facturacion.TabIndex = 15;
            this.btn_Facturacion.Text = "Facturacion";
            this.btn_Facturacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Facturacion.UseVisualStyleBackColor = true;
            this.btn_Facturacion.Click += new System.EventHandler(this.btn_IngMaterial_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnCategoria.IconColor = System.Drawing.Color.Black;
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.IconSize = 25;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCategoria.Location = new System.Drawing.Point(10, 342);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(171, 32);
            this.btnCategoria.TabIndex = 14;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelUsuario.Location = new System.Drawing.Point(0, 5);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(9, 32);
            this.panelUsuario.TabIndex = 13;
            // 
            // panelCategoria
            // 
            this.panelCategoria.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelCategoria.Location = new System.Drawing.Point(0, 342);
            this.panelCategoria.Name = "panelCategoria";
            this.panelCategoria.Size = new System.Drawing.Size(9, 32);
            this.panelCategoria.TabIndex = 8;
            // 
            // panelPagoComp
            // 
            this.panelPagoComp.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelPagoComp.Location = new System.Drawing.Point(0, 305);
            this.panelPagoComp.Name = "panelPagoComp";
            this.panelPagoComp.Size = new System.Drawing.Size(9, 32);
            this.panelPagoComp.TabIndex = 7;
            // 
            // panelPagoVent
            // 
            this.panelPagoVent.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelPagoVent.Location = new System.Drawing.Point(0, 268);
            this.panelPagoVent.Name = "panelPagoVent";
            this.panelPagoVent.Size = new System.Drawing.Size(9, 32);
            this.panelPagoVent.TabIndex = 6;
            // 
            // panelPrenda
            // 
            this.panelPrenda.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelPrenda.Location = new System.Drawing.Point(0, 154);
            this.panelPrenda.Name = "panelPrenda";
            this.panelPrenda.Size = new System.Drawing.Size(9, 32);
            this.panelPrenda.TabIndex = 4;
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelCliente.Location = new System.Drawing.Point(0, 117);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(9, 32);
            this.panelCliente.TabIndex = 4;
            // 
            // panelMet
            // 
            this.panelMet.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMet.Location = new System.Drawing.Point(0, 231);
            this.panelMet.Name = "panelMet";
            this.panelMet.Size = new System.Drawing.Size(9, 32);
            this.panelMet.TabIndex = 4;
            // 
            // panelProvee
            // 
            this.panelProvee.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelProvee.Location = new System.Drawing.Point(0, 193);
            this.panelProvee.Name = "panelProvee";
            this.panelProvee.Size = new System.Drawing.Size(9, 32);
            this.panelProvee.TabIndex = 3;
            // 
            // panelComprar
            // 
            this.panelComprar.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelComprar.Location = new System.Drawing.Point(0, 80);
            this.panelComprar.Name = "panelComprar";
            this.panelComprar.Size = new System.Drawing.Size(9, 32);
            this.panelComprar.TabIndex = 2;
            // 
            // panelVender
            // 
            this.panelVender.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelVender.Location = new System.Drawing.Point(0, 42);
            this.panelVender.Name = "panelVender";
            this.panelVender.Size = new System.Drawing.Size(9, 32);
            this.panelVender.TabIndex = 1;
            // 
            // panelconteiner
            // 
            this.panelconteiner.BackColor = System.Drawing.Color.MintCream;
            this.panelconteiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelconteiner.Location = new System.Drawing.Point(181, 47);
            this.panelconteiner.Name = "panelconteiner";
            this.panelconteiner.Size = new System.Drawing.Size(869, 603);
            this.panelconteiner.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.panelconteiner);
            this.Controls.Add(this.MenuLateral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.MenuLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel MenuLateral;
        private Panel panelVender;
        private Panel panelProvee;
        private Panel panelComprar;
        private Panel panelMet;
        private Panel panelPrenda;
        private Panel panelCliente;
        private Panel panelPagoVent;
        private Panel panelPagoComp;
        private Panel panelCategoria;
        private Label lblUser;
        private Panel panelUsuario;
        private Panel panelconteiner;
        private FontAwesome.Sharp.IconButton btnCategoria;
        private FontAwesome.Sharp.IconButton btn_Facturacion;
        private FontAwesome.Sharp.IconButton btnCarrito;
        private FontAwesome.Sharp.IconButton btnMetodoPago;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnPrendas;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnComprarPrendas;
        private FontAwesome.Sharp.IconButton btnVenderPrendas;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnInventario;
        private Panel panelInventario;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}