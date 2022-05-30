namespace Presentación
{
    partial class SeguimientoCliente
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbDetalleFactura = new System.Windows.Forms.GroupBox();
            this.DgDetalleFactura = new System.Windows.Forms.DataGridView();
            this.GbVentas = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalventas = new System.Windows.Forms.TextBox();
            this.TxtNumeroFactura = new System.Windows.Forms.TextBox();
            this.DgFactura = new System.Windows.Forms.DataGridView();
            this.GbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.DgDatos = new System.Windows.Forms.DataGridView();
            this.Gbdatos = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GbDetalleFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalleFactura)).BeginInit();
            this.GbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgFactura)).BeginInit();
            this.GbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).BeginInit();
            this.Gbdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbDetalleFactura
            // 
            this.GbDetalleFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbDetalleFactura.BackColor = System.Drawing.Color.Transparent;
            this.GbDetalleFactura.Controls.Add(this.DgDetalleFactura);
            this.GbDetalleFactura.Location = new System.Drawing.Point(12, 421);
            this.GbDetalleFactura.Name = "GbDetalleFactura";
            this.GbDetalleFactura.Size = new System.Drawing.Size(773, 143);
            this.GbDetalleFactura.TabIndex = 10;
            this.GbDetalleFactura.TabStop = false;
            this.GbDetalleFactura.Text = "Datos de ventas";
            // 
            // DgDetalleFactura
            // 
            this.DgDetalleFactura.AllowUserToAddRows = false;
            this.DgDetalleFactura.AllowUserToDeleteRows = false;
            this.DgDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetalleFactura.Location = new System.Drawing.Point(23, 20);
            this.DgDetalleFactura.Name = "DgDetalleFactura";
            this.DgDetalleFactura.ReadOnly = true;
            this.DgDetalleFactura.Size = new System.Drawing.Size(639, 103);
            this.DgDetalleFactura.TabIndex = 1;
            // 
            // GbVentas
            // 
            this.GbVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbVentas.BackColor = System.Drawing.Color.Transparent;
            this.GbVentas.Controls.Add(this.label5);
            this.GbVentas.Controls.Add(this.label4);
            this.GbVentas.Controls.Add(this.label2);
            this.GbVentas.Controls.Add(this.label1);
            this.GbVentas.Controls.Add(this.TxtTotalventas);
            this.GbVentas.Controls.Add(this.TxtNumeroFactura);
            this.GbVentas.Controls.Add(this.DgFactura);
            this.GbVentas.Location = new System.Drawing.Point(12, 272);
            this.GbVentas.Name = "GbVentas";
            this.GbVentas.Size = new System.Drawing.Size(773, 143);
            this.GbVentas.TabIndex = 9;
            this.GbVentas.TabStop = false;
            this.GbVentas.Text = "Datos de ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(736, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "N°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total en ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "facturas generadas";
            // 
            // TxtTotalventas
            // 
            this.TxtTotalventas.Enabled = false;
            this.TxtTotalventas.Location = new System.Drawing.Point(581, 103);
            this.TxtTotalventas.Name = "TxtTotalventas";
            this.TxtTotalventas.Size = new System.Drawing.Size(149, 20);
            this.TxtTotalventas.TabIndex = 3;
            // 
            // TxtNumeroFactura
            // 
            this.TxtNumeroFactura.Enabled = false;
            this.TxtNumeroFactura.Location = new System.Drawing.Point(581, 45);
            this.TxtNumeroFactura.Name = "TxtNumeroFactura";
            this.TxtNumeroFactura.Size = new System.Drawing.Size(149, 20);
            this.TxtNumeroFactura.TabIndex = 2;
            // 
            // DgFactura
            // 
            this.DgFactura.AllowUserToAddRows = false;
            this.DgFactura.AllowUserToDeleteRows = false;
            this.DgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgFactura.Location = new System.Drawing.Point(24, 20);
            this.DgFactura.Name = "DgFactura";
            this.DgFactura.ReadOnly = true;
            this.DgFactura.Size = new System.Drawing.Size(539, 103);
            this.DgFactura.TabIndex = 1;
            this.DgFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgFactura_CellDoubleClick_1);
            // 
            // GbDatosPersonales
            // 
            this.GbDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbDatosPersonales.BackColor = System.Drawing.Color.Transparent;
            this.GbDatosPersonales.Controls.Add(this.DgDatos);
            this.GbDatosPersonales.Location = new System.Drawing.Point(12, 107);
            this.GbDatosPersonales.Name = "GbDatosPersonales";
            this.GbDatosPersonales.Size = new System.Drawing.Size(773, 159);
            this.GbDatosPersonales.TabIndex = 8;
            this.GbDatosPersonales.TabStop = false;
            this.GbDatosPersonales.Text = "Datos personales";
            // 
            // DgDatos
            // 
            this.DgDatos.AllowUserToAddRows = false;
            this.DgDatos.AllowUserToDeleteRows = false;
            this.DgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDatos.Location = new System.Drawing.Point(24, 19);
            this.DgDatos.Name = "DgDatos";
            this.DgDatos.ReadOnly = true;
            this.DgDatos.Size = new System.Drawing.Size(726, 103);
            this.DgDatos.TabIndex = 0;
            // 
            // Gbdatos
            // 
            this.Gbdatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbdatos.BackColor = System.Drawing.Color.Transparent;
            this.Gbdatos.Controls.Add(this.BtnBuscar);
            this.Gbdatos.Controls.Add(this.TxtBuscar);
            this.Gbdatos.Controls.Add(this.label3);
            this.Gbdatos.Location = new System.Drawing.Point(12, 13);
            this.Gbdatos.Name = "Gbdatos";
            this.Gbdatos.Size = new System.Drawing.Size(773, 88);
            this.Gbdatos.TabIndex = 7;
            this.Gbdatos.TabStop = false;
            this.Gbdatos.Text = "Consultar";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(249, 34);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(65, 27);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(106, 38);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(137, 20);
            this.TxtBuscar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "No Documento";
            // 
            // SeguimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GbDetalleFactura);
            this.Controls.Add(this.GbVentas);
            this.Controls.Add(this.GbDatosPersonales);
            this.Controls.Add(this.Gbdatos);
            this.Name = "SeguimientoCliente";
            this.Size = new System.Drawing.Size(802, 572);
            this.Load += new System.EventHandler(this.SeguimientoCliente_Load);
            this.GbDetalleFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalleFactura)).EndInit();
            this.GbVentas.ResumeLayout(false);
            this.GbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgFactura)).EndInit();
            this.GbDatosPersonales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).EndInit();
            this.Gbdatos.ResumeLayout(false);
            this.Gbdatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDetalleFactura;
        private System.Windows.Forms.DataGridView DgDetalleFactura;
        private System.Windows.Forms.GroupBox GbVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalventas;
        private System.Windows.Forms.TextBox TxtNumeroFactura;
        private System.Windows.Forms.DataGridView DgFactura;
        private System.Windows.Forms.GroupBox GbDatosPersonales;
        private System.Windows.Forms.DataGridView DgDatos;
        private System.Windows.Forms.GroupBox Gbdatos;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label3;
    }
}
