namespace Presentación
{
    partial class Stock
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
            this.GbProductos = new System.Windows.Forms.GroupBox();
            this.DgStock = new System.Windows.Forms.DataGridView();
            this.Añadir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbConsulta = new System.Windows.Forms.GroupBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.RbStockMinima = new System.Windows.Forms.RadioButton();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.RbBuscarTodo = new System.Windows.Forms.RadioButton();
            this.RbPersonalizada = new System.Windows.Forms.RadioButton();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgStock)).BeginInit();
            this.GbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbProductos
            // 
            this.GbProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbProductos.BackColor = System.Drawing.Color.Transparent;
            this.GbProductos.Controls.Add(this.DgStock);
            this.GbProductos.Location = new System.Drawing.Point(3, 120);
            this.GbProductos.Name = "GbProductos";
            this.GbProductos.Size = new System.Drawing.Size(1022, 196);
            this.GbProductos.TabIndex = 3;
            this.GbProductos.TabStop = false;
            this.GbProductos.Text = "Productos";
            // 
            // DgStock
            // 
            this.DgStock.AllowUserToAddRows = false;
            this.DgStock.AllowUserToDeleteRows = false;
            this.DgStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Añadir});
            this.DgStock.Location = new System.Drawing.Point(28, 29);
            this.DgStock.Name = "DgStock";
            this.DgStock.ReadOnly = true;
            this.DgStock.Size = new System.Drawing.Size(961, 150);
            this.DgStock.TabIndex = 0;
            this.DgStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgStock_CellContentClick);
            // 
            // Añadir
            // 
            this.Añadir.HeaderText = "Añadir";
            this.Añadir.Name = "Añadir";
            this.Añadir.ReadOnly = true;
            this.Añadir.Text = "Añadir";
            this.Añadir.ToolTipText = "Añadir";
            this.Añadir.UseColumnTextForButtonValue = true;
            // 
            // GbConsulta
            // 
            this.GbConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbConsulta.BackColor = System.Drawing.Color.Transparent;
            this.GbConsulta.Controls.Add(this.BtnActualizar);
            this.GbConsulta.Controls.Add(this.TxtCantidad);
            this.GbConsulta.Controls.Add(this.RbStockMinima);
            this.GbConsulta.Controls.Add(this.TxtBuscar);
            this.GbConsulta.Controls.Add(this.BtnBuscar);
            this.GbConsulta.Controls.Add(this.RbBuscarTodo);
            this.GbConsulta.Controls.Add(this.RbPersonalizada);
            this.GbConsulta.Location = new System.Drawing.Point(3, 13);
            this.GbConsulta.Name = "GbConsulta";
            this.GbConsulta.Size = new System.Drawing.Size(1022, 101);
            this.GbConsulta.TabIndex = 2;
            this.GbConsulta.TabStop = false;
            this.GbConsulta.Text = "Consulta";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Enabled = false;
            this.TxtCantidad.Location = new System.Drawing.Point(172, 62);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(132, 20);
            this.TxtCantidad.TabIndex = 3;
            this.TxtCantidad.Text = "20";
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress_1);
            // 
            // RbStockMinima
            // 
            this.RbStockMinima.AutoSize = true;
            this.RbStockMinima.Location = new System.Drawing.Point(16, 65);
            this.RbStockMinima.Name = "RbStockMinima";
            this.RbStockMinima.Size = new System.Drawing.Size(149, 17);
            this.RbStockMinima.TabIndex = 1;
            this.RbStockMinima.TabStop = true;
            this.RbStockMinima.Text = "Cantidad en stock minima ";
            this.RbStockMinima.UseVisualStyleBackColor = true;
            this.RbStockMinima.CheckedChanged += new System.EventHandler(this.RbStockMinima_CheckedChanged_1);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(172, 30);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(132, 20);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress_1);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(430, 27);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // RbBuscarTodo
            // 
            this.RbBuscarTodo.AutoSize = true;
            this.RbBuscarTodo.Location = new System.Drawing.Point(322, 31);
            this.RbBuscarTodo.Name = "RbBuscarTodo";
            this.RbBuscarTodo.Size = new System.Drawing.Size(82, 17);
            this.RbBuscarTodo.TabIndex = 4;
            this.RbBuscarTodo.TabStop = true;
            this.RbBuscarTodo.Text = "Buscar todo";
            this.RbBuscarTodo.UseVisualStyleBackColor = true;
            this.RbBuscarTodo.CheckedChanged += new System.EventHandler(this.RbBuscarTodo_CheckedChanged_1);
            // 
            // RbPersonalizada
            // 
            this.RbPersonalizada.AutoSize = true;
            this.RbPersonalizada.Location = new System.Drawing.Point(16, 31);
            this.RbPersonalizada.Name = "RbPersonalizada";
            this.RbPersonalizada.Size = new System.Drawing.Size(118, 17);
            this.RbPersonalizada.TabIndex = 0;
            this.RbPersonalizada.TabStop = true;
            this.RbPersonalizada.Text = "Busqueda producto";
            this.RbPersonalizada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbPersonalizada.UseVisualStyleBackColor = true;
            this.RbPersonalizada.CheckedChanged += new System.EventHandler(this.RbPersonalizada_CheckedChanged_1);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(430, 56);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GbProductos);
            this.Controls.Add(this.GbConsulta);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(1065, 346);
            this.Load += new System.EventHandler(this.Stock_Load);
            this.GbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgStock)).EndInit();
            this.GbConsulta.ResumeLayout(false);
            this.GbConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbProductos;
        private System.Windows.Forms.DataGridView DgStock;
        private System.Windows.Forms.GroupBox GbConsulta;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.RadioButton RbStockMinima;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.RadioButton RbBuscarTodo;
        private System.Windows.Forms.RadioButton RbPersonalizada;
        private System.Windows.Forms.DataGridViewButtonColumn Añadir;
        private System.Windows.Forms.Button BtnActualizar;
    }
}
