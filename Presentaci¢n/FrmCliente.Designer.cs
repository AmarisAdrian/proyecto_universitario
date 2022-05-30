namespace Presentación
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtCodInterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtMovil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.ErrorNumeric = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).BeginInit();
            this.GbDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbGenero
            // 
            this.CmbGenero.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGenero.ForeColor = System.Drawing.Color.White;
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Location = new System.Drawing.Point(136, 159);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(234, 26);
            this.CmbGenero.TabIndex = 15;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(136, 124);
            this.TxtApellidos.MaxLength = 45;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(234, 24);
            this.TxtApellidos.TabIndex = 13;
            this.TxtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidos_KeyPress);
            // 
            // TxtNombres
            // 
            this.TxtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(136, 89);
            this.TxtNombres.MaxLength = 45;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(234, 24);
            this.TxtNombres.TabIndex = 11;
            this.TxtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombres_KeyPress);
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.Location = new System.Drawing.Point(136, 54);
            this.TxtDocumento.MaxLength = 20;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(234, 24);
            this.TxtDocumento.TabIndex = 9;
            this.TxtDocumento.TextChanged += new System.EventHandler(this.TxtDocumento_TextChanged);
            this.TxtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // TxtCodInterno
            // 
            this.TxtCodInterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodInterno.Enabled = false;
            this.TxtCodInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodInterno.Location = new System.Drawing.Point(136, 19);
            this.TxtCodInterno.Name = "TxtCodInterno";
            this.TxtCodInterno.Size = new System.Drawing.Size(234, 24);
            this.TxtCodInterno.TabIndex = 7;
            this.TxtCodInterno.Text = "000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(69, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "No Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo Interno";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(136, 301);
            this.TxtDireccion.MaxLength = 50;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(234, 24);
            this.TxtDireccion.TabIndex = 23;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.Location = new System.Drawing.Point(136, 266);
            this.TxtCiudad.MaxLength = 50;
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(234, 24);
            this.TxtCiudad.TabIndex = 21;
            this.TxtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCiudad_KeyPress);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(136, 231);
            this.TxtTelefono.MaxLength = 20;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(234, 24);
            this.TxtTelefono.TabIndex = 19;
            this.TxtTelefono.Text = "0";
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtMovil
            // 
            this.TxtMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMovil.Location = new System.Drawing.Point(136, 196);
            this.TxtMovil.MaxLength = 20;
            this.TxtMovil.Name = "TxtMovil";
            this.TxtMovil.Size = new System.Drawing.Size(234, 24);
            this.TxtMovil.TabIndex = 17;
            this.TxtMovil.Text = "0";
            this.TxtMovil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMovil_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(54, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(71, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(60, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(80, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Movil";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(55, 348);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 24;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Enabled = false;
            this.BtnEditar.Location = new System.Drawing.Point(215, 348);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 25;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(295, 348);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 26;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // ErrorNumeric
            // 
            this.ErrorNumeric.ContainerControl = this;
            // 
            // GbDatosPersonales
            // 
            this.GbDatosPersonales.Controls.Add(this.BtnBuscar);
            this.GbDatosPersonales.Controls.Add(this.TxtCodInterno);
            this.GbDatosPersonales.Controls.Add(this.BtnLimpiar);
            this.GbDatosPersonales.Controls.Add(this.label1);
            this.GbDatosPersonales.Controls.Add(this.BtnEditar);
            this.GbDatosPersonales.Controls.Add(this.label2);
            this.GbDatosPersonales.Controls.Add(this.BtnGuardar);
            this.GbDatosPersonales.Controls.Add(this.label3);
            this.GbDatosPersonales.Controls.Add(this.TxtDireccion);
            this.GbDatosPersonales.Controls.Add(this.label4);
            this.GbDatosPersonales.Controls.Add(this.TxtCiudad);
            this.GbDatosPersonales.Controls.Add(this.label5);
            this.GbDatosPersonales.Controls.Add(this.TxtTelefono);
            this.GbDatosPersonales.Controls.Add(this.TxtDocumento);
            this.GbDatosPersonales.Controls.Add(this.TxtMovil);
            this.GbDatosPersonales.Controls.Add(this.TxtNombres);
            this.GbDatosPersonales.Controls.Add(this.label9);
            this.GbDatosPersonales.Controls.Add(this.TxtApellidos);
            this.GbDatosPersonales.Controls.Add(this.label8);
            this.GbDatosPersonales.Controls.Add(this.CmbGenero);
            this.GbDatosPersonales.Controls.Add(this.label7);
            this.GbDatosPersonales.Controls.Add(this.label6);
            this.GbDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.GbDatosPersonales.Name = "GbDatosPersonales";
            this.GbDatosPersonales.Size = new System.Drawing.Size(411, 388);
            this.GbDatosPersonales.TabIndex = 27;
            this.GbDatosPersonales.TabStop = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(135, 348);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 27;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 413);
            this.Controls.Add(this.GbDatosPersonales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).EndInit();
            this.GbDatosPersonales.ResumeLayout(false);
            this.GbDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbGenero;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtCodInterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtMovil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ErrorProvider ErrorNumeric;
        private System.Windows.Forms.GroupBox GbDatosPersonales;
        private System.Windows.Forms.Button BtnBuscar;
    }
}