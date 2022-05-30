namespace Presentación
{
    partial class FrmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnSeguimientoCliente = new System.Windows.Forms.Button();
            this.BtnEscritorio = new System.Windows.Forms.Button();
            this.PanelIconos = new System.Windows.Forms.Panel();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnCuenta = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnOperador = new System.Windows.Forms.Button();
            this.BtnStock = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnFactura = new System.Windows.Forms.Button();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PanelOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelIconos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelOpciones.BackColor = System.Drawing.Color.DarkGray;
            this.PanelOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOpciones.Controls.Add(this.panel1);
            this.PanelOpciones.Controls.Add(this.PanelIconos);
            this.PanelOpciones.Location = new System.Drawing.Point(1, 1);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(1369, 66);
            this.PanelOpciones.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnSeguimientoCliente);
            this.panel1.Controls.Add(this.BtnEscritorio);
            this.panel1.Location = new System.Drawing.Point(1160, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 58);
            this.panel1.TabIndex = 11;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(131, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(65, 52);
            this.BtnSalir.TabIndex = 14;
            this.toolTip1.SetToolTip(this.BtnSalir, "Salir\r\n");
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnSeguimientoCliente
            // 
            this.BtnSeguimientoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeguimientoCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnSeguimientoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSeguimientoCliente.BackgroundImage")));
            this.BtnSeguimientoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeguimientoCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSeguimientoCliente.FlatAppearance.BorderSize = 0;
            this.BtnSeguimientoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeguimientoCliente.Location = new System.Drawing.Point(3, 6);
            this.BtnSeguimientoCliente.Name = "BtnSeguimientoCliente";
            this.BtnSeguimientoCliente.Size = new System.Drawing.Size(65, 49);
            this.BtnSeguimientoCliente.TabIndex = 12;
            this.toolTip1.SetToolTip(this.BtnSeguimientoCliente, "Seguimiento de clientes");
            this.BtnSeguimientoCliente.UseVisualStyleBackColor = false;
            this.BtnSeguimientoCliente.Click += new System.EventHandler(this.BtnSeguimientoCliente_Click);
            // 
            // BtnEscritorio
            // 
            this.BtnEscritorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEscritorio.BackColor = System.Drawing.Color.Transparent;
            this.BtnEscritorio.BackgroundImage = global::Presentación.Properties.Resources.Desktop;
            this.BtnEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEscritorio.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnEscritorio.FlatAppearance.BorderSize = 0;
            this.BtnEscritorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEscritorio.Location = new System.Drawing.Point(64, 5);
            this.BtnEscritorio.Name = "BtnEscritorio";
            this.BtnEscritorio.Size = new System.Drawing.Size(65, 49);
            this.BtnEscritorio.TabIndex = 13;
            this.BtnEscritorio.UseVisualStyleBackColor = false;
            this.BtnEscritorio.Click += new System.EventHandler(this.BtnEscritorio_Click);
            // 
            // PanelIconos
            // 
            this.PanelIconos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelIconos.Controls.Add(this.BtnInventario);
            this.PanelIconos.Controls.Add(this.BtnCuenta);
            this.PanelIconos.Controls.Add(this.BtnProductos);
            this.PanelIconos.Controls.Add(this.BtnOperador);
            this.PanelIconos.Controls.Add(this.BtnStock);
            this.PanelIconos.Controls.Add(this.BtnClientes);
            this.PanelIconos.Controls.Add(this.BtnFactura);
            this.PanelIconos.Controls.Add(this.BtnProveedor);
            this.PanelIconos.Location = new System.Drawing.Point(3, 5);
            this.PanelIconos.Name = "PanelIconos";
            this.PanelIconos.Size = new System.Drawing.Size(603, 56);
            this.PanelIconos.TabIndex = 1;
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInventario.BackgroundImage")));
            this.BtnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Location = new System.Drawing.Point(518, 2);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(65, 49);
            this.BtnInventario.TabIndex = 9;
            this.toolTip1.SetToolTip(this.BtnInventario, "Inventario y auditoria");
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnCuenta
            // 
            this.BtnCuenta.BackColor = System.Drawing.Color.Transparent;
            this.BtnCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCuenta.BackgroundImage")));
            this.BtnCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnCuenta.FlatAppearance.BorderSize = 0;
            this.BtnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuenta.Location = new System.Drawing.Point(21, 3);
            this.BtnCuenta.Name = "BtnCuenta";
            this.BtnCuenta.Size = new System.Drawing.Size(65, 49);
            this.BtnCuenta.TabIndex = 1;
            this.toolTip1.SetToolTip(this.BtnCuenta, "Mi cuenta");
            this.BtnCuenta.UseVisualStyleBackColor = false;
            this.BtnCuenta.Click += new System.EventHandler(this.BtnCuenta_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.Transparent;
            this.BtnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProductos.BackgroundImage")));
            this.BtnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Location = new System.Drawing.Point(92, 3);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(65, 49);
            this.BtnProductos.TabIndex = 2;
            this.toolTip1.SetToolTip(this.BtnProductos, "Gestion Productos");
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnOperador
            // 
            this.BtnOperador.BackColor = System.Drawing.Color.Transparent;
            this.BtnOperador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOperador.BackgroundImage")));
            this.BtnOperador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOperador.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnOperador.FlatAppearance.BorderSize = 0;
            this.BtnOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOperador.Location = new System.Drawing.Point(447, 3);
            this.BtnOperador.Name = "BtnOperador";
            this.BtnOperador.Size = new System.Drawing.Size(65, 49);
            this.BtnOperador.TabIndex = 7;
            this.toolTip1.SetToolTip(this.BtnOperador, "Gestion operadores");
            this.BtnOperador.UseVisualStyleBackColor = false;
            this.BtnOperador.Click += new System.EventHandler(this.BtnOperador_Click);
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.Transparent;
            this.BtnStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStock.BackgroundImage")));
            this.BtnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStock.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnStock.FlatAppearance.BorderSize = 0;
            this.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStock.Location = new System.Drawing.Point(163, 4);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(65, 49);
            this.BtnStock.TabIndex = 3;
            this.toolTip1.SetToolTip(this.BtnStock, "Stock productos");
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.Transparent;
            this.BtnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClientes.BackgroundImage")));
            this.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Location = new System.Drawing.Point(376, 3);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(65, 49);
            this.BtnClientes.TabIndex = 6;
            this.toolTip1.SetToolTip(this.BtnClientes, "Gestion clientes");
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnFactura
            // 
            this.BtnFactura.BackColor = System.Drawing.Color.Transparent;
            this.BtnFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFactura.BackgroundImage")));
            this.BtnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFactura.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnFactura.FlatAppearance.BorderSize = 0;
            this.BtnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFactura.Location = new System.Drawing.Point(234, 4);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(65, 49);
            this.BtnFactura.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BtnFactura, "Facturacion");
            this.BtnFactura.UseVisualStyleBackColor = false;
            this.BtnFactura.Click += new System.EventHandler(this.BtnFactura_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.BackColor = System.Drawing.Color.Transparent;
            this.BtnProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProveedor.BackgroundImage")));
            this.BtnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Location = new System.Drawing.Point(305, 3);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(65, 49);
            this.BtnProveedor.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnProveedor, "Gestion proveedores");
            this.BtnProveedor.UseVisualStyleBackColor = false;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.PanelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPrincipal.Location = new System.Drawing.Point(1, 66);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1369, 577);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 643);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelOpciones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.PanelOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelIconos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Panel PanelIconos;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnCuenta;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnOperador;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnFactura;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Button BtnEscritorio;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSeguimientoCliente;
        private System.Windows.Forms.Button BtnSalir;
    }
}