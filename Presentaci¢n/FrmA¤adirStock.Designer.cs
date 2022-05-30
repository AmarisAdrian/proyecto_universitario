namespace Presentación
{
    partial class FrmAñadirStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAñadirStock));
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtAbastecer = new System.Windows.Forms.TextBox();
            this.TxtStockActual = new System.Windows.Forms.TextBox();
            this.TxtStockInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.ErrorNumeric = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtResultante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatos
            // 
            this.GbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbDatos.Controls.Add(this.TxtResultante);
            this.GbDatos.Controls.Add(this.label5);
            this.GbDatos.Controls.Add(this.lblReferencia);
            this.GbDatos.Controls.Add(this.label4);
            this.GbDatos.Controls.Add(this.BtnSalir);
            this.GbDatos.Controls.Add(this.BtnActualizar);
            this.GbDatos.Controls.Add(this.TxtAbastecer);
            this.GbDatos.Controls.Add(this.TxtStockActual);
            this.GbDatos.Controls.Add(this.TxtStockInicial);
            this.GbDatos.Controls.Add(this.label3);
            this.GbDatos.Controls.Add(this.label2);
            this.GbDatos.Controls.Add(this.label1);
            this.GbDatos.Location = new System.Drawing.Point(13, 12);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(415, 297);
            this.GbDatos.TabIndex = 0;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(285, 234);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(64, 31);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(152, 234);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(124, 31);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.Text = "Abastecer Producto";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtAbastecer
            // 
            this.TxtAbastecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAbastecer.Location = new System.Drawing.Point(152, 145);
            this.TxtAbastecer.Name = "TxtAbastecer";
            this.TxtAbastecer.Size = new System.Drawing.Size(197, 26);
            this.TxtAbastecer.TabIndex = 5;
            this.TxtAbastecer.TextChanged += new System.EventHandler(this.TxtAbastecer_TextChanged);
            this.TxtAbastecer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAbastecer_KeyPress);
            // 
            // TxtStockActual
            // 
            this.TxtStockActual.Enabled = false;
            this.TxtStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockActual.Location = new System.Drawing.Point(152, 106);
            this.TxtStockActual.Name = "TxtStockActual";
            this.TxtStockActual.Size = new System.Drawing.Size(197, 26);
            this.TxtStockActual.TabIndex = 4;
            // 
            // TxtStockInicial
            // 
            this.TxtStockInicial.Enabled = false;
            this.TxtStockInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockInicial.Location = new System.Drawing.Point(152, 67);
            this.TxtStockInicial.Name = "TxtStockInicial";
            this.TxtStockInicial.Size = new System.Drawing.Size(197, 26);
            this.TxtStockInicial.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Abastecer stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "REFERENCIA";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblReferencia.Location = new System.Drawing.Point(153, 29);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(0, 21);
            this.lblReferencia.TabIndex = 9;
            // 
            // ErrorNumeric
            // 
            this.ErrorNumeric.ContainerControl = this;
            // 
            // TxtResultante
            // 
            this.TxtResultante.Enabled = false;
            this.TxtResultante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultante.Location = new System.Drawing.Point(152, 184);
            this.TxtResultante.Name = "TxtResultante";
            this.TxtResultante.Size = new System.Drawing.Size(197, 26);
            this.TxtResultante.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock resultante";
            // 
            // FrmAñadirStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 321);
            this.Controls.Add(this.GbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAñadirStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Stock";
            this.Load += new System.EventHandler(this.FrmAñadirStock_Load);
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtStockActual;
        private System.Windows.Forms.TextBox TxtStockInicial;
        private System.Windows.Forms.TextBox TxtAbastecer;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ErrorNumeric;
        private System.Windows.Forms.TextBox TxtResultante;
        private System.Windows.Forms.Label label5;
    }
}