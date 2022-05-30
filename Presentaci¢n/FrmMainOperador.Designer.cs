namespace Presentación
{
    partial class FrmMainOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainOperador));
            this.ErrorNumeric = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.PanelSalir = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.BtnFacturacion = new System.Windows.Forms.Button();
            this.BtnCuenta = new System.Windows.Forms.Button();
            this.BtnSeguimientoOperador = new System.Windows.Forms.Button();
            this.BtnEscritorio = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).BeginInit();
            this.PanelOpciones.SuspendLayout();
            this.PanelSalir.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorNumeric
            // 
            this.ErrorNumeric.ContainerControl = this;
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelOpciones.BackColor = System.Drawing.Color.DarkGray;
            this.PanelOpciones.Controls.Add(this.PanelSalir);
            this.PanelOpciones.Controls.Add(this.PanelBotones);
            this.PanelOpciones.Location = new System.Drawing.Point(1, 0);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(1375, 67);
            this.PanelOpciones.TabIndex = 1;
            // 
            // PanelSalir
            // 
            this.PanelSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSalir.Controls.Add(this.BtnSalir);
            this.PanelSalir.Location = new System.Drawing.Point(1292, 3);
            this.PanelSalir.Name = "PanelSalir";
            this.PanelSalir.Size = new System.Drawing.Size(80, 61);
            this.PanelSalir.TabIndex = 15;
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
            this.BtnSalir.Location = new System.Drawing.Point(8, 5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(65, 52);
            this.BtnSalir.TabIndex = 6;
            this.toolTip1.SetToolTip(this.BtnSalir, "Mostrar panel principal(Blanco)");
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PanelBotones
            // 
            this.PanelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelBotones.Controls.Add(this.BtnFacturacion);
            this.PanelBotones.Controls.Add(this.BtnCuenta);
            this.PanelBotones.Controls.Add(this.BtnSeguimientoOperador);
            this.PanelBotones.Controls.Add(this.BtnEscritorio);
            this.PanelBotones.Location = new System.Drawing.Point(3, 3);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(309, 61);
            this.PanelBotones.TabIndex = 12;
            // 
            // BtnFacturacion
            // 
            this.BtnFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFacturacion.BackColor = System.Drawing.Color.Transparent;
            this.BtnFacturacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFacturacion.BackgroundImage")));
            this.BtnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFacturacion.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnFacturacion.FlatAppearance.BorderSize = 0;
            this.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturacion.Location = new System.Drawing.Point(144, 3);
            this.BtnFacturacion.Name = "BtnFacturacion";
            this.BtnFacturacion.Size = new System.Drawing.Size(65, 52);
            this.BtnFacturacion.TabIndex = 3;
            this.toolTip1.SetToolTip(this.BtnFacturacion, "Facturacion");
            this.BtnFacturacion.UseVisualStyleBackColor = false;
            this.BtnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // BtnCuenta
            // 
            this.BtnCuenta.BackColor = System.Drawing.Color.Transparent;
            this.BtnCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCuenta.BackgroundImage")));
            this.BtnCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnCuenta.FlatAppearance.BorderSize = 0;
            this.BtnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuenta.Location = new System.Drawing.Point(3, 7);
            this.BtnCuenta.Name = "BtnCuenta";
            this.BtnCuenta.Size = new System.Drawing.Size(65, 49);
            this.BtnCuenta.TabIndex = 1;
            this.toolTip1.SetToolTip(this.BtnCuenta, "Mi cuenta");
            this.BtnCuenta.UseVisualStyleBackColor = false;
            this.BtnCuenta.Click += new System.EventHandler(this.BtnCuenta_Click);
            // 
            // BtnSeguimientoOperador
            // 
            this.BtnSeguimientoOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeguimientoOperador.BackColor = System.Drawing.Color.Transparent;
            this.BtnSeguimientoOperador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSeguimientoOperador.BackgroundImage")));
            this.BtnSeguimientoOperador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeguimientoOperador.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSeguimientoOperador.FlatAppearance.BorderSize = 0;
            this.BtnSeguimientoOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeguimientoOperador.Location = new System.Drawing.Point(73, 6);
            this.BtnSeguimientoOperador.Name = "BtnSeguimientoOperador";
            this.BtnSeguimientoOperador.Size = new System.Drawing.Size(65, 52);
            this.BtnSeguimientoOperador.TabIndex = 2;
            this.toolTip1.SetToolTip(this.BtnSeguimientoOperador, "Seguimiento");
            this.BtnSeguimientoOperador.UseVisualStyleBackColor = false;
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
            this.BtnEscritorio.Location = new System.Drawing.Point(215, 3);
            this.BtnEscritorio.Name = "BtnEscritorio";
            this.BtnEscritorio.Size = new System.Drawing.Size(65, 52);
            this.BtnEscritorio.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BtnEscritorio, "Mostrar panel principal(Blanco)");
            this.BtnEscritorio.UseVisualStyleBackColor = false;
            this.BtnEscritorio.Click += new System.EventHandler(this.BtnEscritorio_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.PanelPrincipal.Location = new System.Drawing.Point(4, 73);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1372, 554);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // FrmMainOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 630);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainOperador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).EndInit();
            this.PanelOpciones.ResumeLayout(false);
            this.PanelSalir.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorNumeric;
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Button BtnSeguimientoOperador;
        private System.Windows.Forms.Button BtnEscritorio;
        private System.Windows.Forms.Button BtnCuenta;
        private System.Windows.Forms.Button BtnFacturacion;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel PanelSalir;
        private System.Windows.Forms.Button BtnSalir;
    }
}