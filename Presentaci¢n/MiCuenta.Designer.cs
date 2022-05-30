namespace Presentación
{
    partial class MiCuenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbConfiguracion = new System.Windows.Forms.GroupBox();
            this.GbSesiones = new System.Windows.Forms.GroupBox();
            this.DgUltimasSesiones = new System.Windows.Forms.DataGridView();
            this.GbAbrirSesiones = new System.Windows.Forms.GroupBox();
            this.BtnAbrirSesiones = new System.Windows.Forms.Button();
            this.GbActualizarDatos = new System.Windows.Forms.GroupBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.GbLimpiar = new System.Windows.Forms.GroupBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.GbContraseña = new System.Windows.Forms.GroupBox();
            this.BtnCambiarContraseña = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassOld = new System.Windows.Forms.TextBox();
            this.GbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.Cbhabilitar = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.LblHoraF = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.LblHoraI = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCodInterno = new System.Windows.Forms.TextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.CmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtMovil = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ErrorNumeric = new System.Windows.Forms.ErrorProvider(this.components);
            this.Ttip = new System.Windows.Forms.ToolTip(this.components);
            this.GbConfiguracion.SuspendLayout();
            this.GbSesiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgUltimasSesiones)).BeginInit();
            this.GbAbrirSesiones.SuspendLayout();
            this.GbActualizarDatos.SuspendLayout();
            this.GbLimpiar.SuspendLayout();
            this.GbContraseña.SuspendLayout();
            this.GbDatosPersonales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // GbConfiguracion
            // 
            this.GbConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.GbConfiguracion.Controls.Add(this.GbSesiones);
            this.GbConfiguracion.Controls.Add(this.GbAbrirSesiones);
            this.GbConfiguracion.Controls.Add(this.GbActualizarDatos);
            this.GbConfiguracion.Controls.Add(this.GbLimpiar);
            this.GbConfiguracion.Controls.Add(this.GbContraseña);
            this.GbConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbConfiguracion.ForeColor = System.Drawing.Color.Black;
            this.GbConfiguracion.Location = new System.Drawing.Point(3, 341);
            this.GbConfiguracion.Name = "GbConfiguracion";
            this.GbConfiguracion.Size = new System.Drawing.Size(1320, 307);
            this.GbConfiguracion.TabIndex = 23;
            this.GbConfiguracion.TabStop = false;
            // 
            // GbSesiones
            // 
            this.GbSesiones.BackColor = System.Drawing.Color.Transparent;
            this.GbSesiones.Controls.Add(this.DgUltimasSesiones);
            this.GbSesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSesiones.ForeColor = System.Drawing.Color.Black;
            this.GbSesiones.Location = new System.Drawing.Point(717, 25);
            this.GbSesiones.Name = "GbSesiones";
            this.GbSesiones.Size = new System.Drawing.Size(475, 225);
            this.GbSesiones.TabIndex = 24;
            this.GbSesiones.TabStop = false;
            this.GbSesiones.Text = "Historial de sesiones";
            // 
            // DgUltimasSesiones
            // 
            this.DgUltimasSesiones.AllowUserToAddRows = false;
            this.DgUltimasSesiones.AllowUserToDeleteRows = false;
            this.DgUltimasSesiones.AllowUserToResizeColumns = false;
            this.DgUltimasSesiones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgUltimasSesiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgUltimasSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgUltimasSesiones.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgUltimasSesiones.Location = new System.Drawing.Point(7, 21);
            this.DgUltimasSesiones.Name = "DgUltimasSesiones";
            this.DgUltimasSesiones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgUltimasSesiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgUltimasSesiones.Size = new System.Drawing.Size(448, 165);
            this.DgUltimasSesiones.TabIndex = 0;
            // 
            // GbAbrirSesiones
            // 
            this.GbAbrirSesiones.BackColor = System.Drawing.Color.Transparent;
            this.GbAbrirSesiones.Controls.Add(this.BtnAbrirSesiones);
            this.GbAbrirSesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbAbrirSesiones.ForeColor = System.Drawing.Color.Black;
            this.GbAbrirSesiones.Location = new System.Drawing.Point(711, 157);
            this.GbAbrirSesiones.Name = "GbAbrirSesiones";
            this.GbAbrirSesiones.Size = new System.Drawing.Size(246, 93);
            this.GbAbrirSesiones.TabIndex = 24;
            this.GbAbrirSesiones.TabStop = false;
            this.GbAbrirSesiones.Text = "Sesiones";
            // 
            // BtnAbrirSesiones
            // 
            this.BtnAbrirSesiones.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAbrirSesiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAbrirSesiones.ForeColor = System.Drawing.Color.White;
            this.BtnAbrirSesiones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAbrirSesiones.Location = new System.Drawing.Point(77, 27);
            this.BtnAbrirSesiones.Name = "BtnAbrirSesiones";
            this.BtnAbrirSesiones.Size = new System.Drawing.Size(138, 43);
            this.BtnAbrirSesiones.TabIndex = 26;
            this.BtnAbrirSesiones.Text = "Ultimas sesiones";
            this.BtnAbrirSesiones.UseVisualStyleBackColor = false;
            // 
            // GbActualizarDatos
            // 
            this.GbActualizarDatos.BackColor = System.Drawing.Color.Transparent;
            this.GbActualizarDatos.Controls.Add(this.BtnEditar);
            this.GbActualizarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbActualizarDatos.ForeColor = System.Drawing.Color.Black;
            this.GbActualizarDatos.Location = new System.Drawing.Point(445, 25);
            this.GbActualizarDatos.Name = "GbActualizarDatos";
            this.GbActualizarDatos.Size = new System.Drawing.Size(260, 126);
            this.GbActualizarDatos.TabIndex = 23;
            this.GbActualizarDatos.TabStop = false;
            this.GbActualizarDatos.Text = "Actualizar datos personales";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.Location = new System.Drawing.Point(52, 46);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 43);
            this.BtnEditar.TabIndex = 21;
            this.BtnEditar.Text = "Actualizar datos";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // GbLimpiar
            // 
            this.GbLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.GbLimpiar.Controls.Add(this.BtnLimpiar);
            this.GbLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbLimpiar.ForeColor = System.Drawing.Color.Black;
            this.GbLimpiar.Location = new System.Drawing.Point(445, 157);
            this.GbLimpiar.Name = "GbLimpiar";
            this.GbLimpiar.Size = new System.Drawing.Size(260, 93);
            this.GbLimpiar.TabIndex = 5;
            this.GbLimpiar.TabStop = false;
            this.GbLimpiar.Text = "Limpiar campos";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.Location = new System.Drawing.Point(80, 29);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(92, 43);
            this.BtnLimpiar.TabIndex = 22;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // GbContraseña
            // 
            this.GbContraseña.BackColor = System.Drawing.Color.Transparent;
            this.GbContraseña.Controls.Add(this.BtnCambiarContraseña);
            this.GbContraseña.Controls.Add(this.label3);
            this.GbContraseña.Controls.Add(this.TxtPassNew);
            this.GbContraseña.Controls.Add(this.label2);
            this.GbContraseña.Controls.Add(this.TxtPassOld);
            this.GbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbContraseña.ForeColor = System.Drawing.Color.Black;
            this.GbContraseña.Location = new System.Drawing.Point(15, 25);
            this.GbContraseña.Name = "GbContraseña";
            this.GbContraseña.Size = new System.Drawing.Size(424, 225);
            this.GbContraseña.TabIndex = 6;
            this.GbContraseña.TabStop = false;
            this.GbContraseña.Text = "Contraseña de acceso";
            // 
            // BtnCambiarContraseña
            // 
            this.BtnCambiarContraseña.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.BtnCambiarContraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCambiarContraseña.Location = new System.Drawing.Point(109, 142);
            this.BtnCambiarContraseña.Name = "BtnCambiarContraseña";
            this.BtnCambiarContraseña.Size = new System.Drawing.Size(147, 43);
            this.BtnCambiarContraseña.TabIndex = 20;
            this.BtnCambiarContraseña.Text = "Cambiar Contraseña";
            this.BtnCambiarContraseña.UseVisualStyleBackColor = false;
            this.BtnCambiarContraseña.Click += new System.EventHandler(this.BtnCambiarContraseña_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(232, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Contraseña Nueva";
            // 
            // TxtPassNew
            // 
            this.TxtPassNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassNew.Location = new System.Drawing.Point(207, 87);
            this.TxtPassNew.MaxLength = 15;
            this.TxtPassNew.Name = "TxtPassNew";
            this.TxtPassNew.PasswordChar = '*';
            this.TxtPassNew.Size = new System.Drawing.Size(176, 22);
            this.TxtPassNew.TabIndex = 19;
            this.TxtPassNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassNew_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Contraseña Antigua";
            // 
            // TxtPassOld
            // 
            this.TxtPassOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassOld.Location = new System.Drawing.Point(12, 87);
            this.TxtPassOld.MaxLength = 15;
            this.TxtPassOld.Name = "TxtPassOld";
            this.TxtPassOld.PasswordChar = '*';
            this.TxtPassOld.Size = new System.Drawing.Size(166, 22);
            this.TxtPassOld.TabIndex = 18;
            this.TxtPassOld.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassOld_KeyPress_1);
            // 
            // GbDatosPersonales
            // 
            this.GbDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbDatosPersonales.BackColor = System.Drawing.Color.Transparent;
            this.GbDatosPersonales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GbDatosPersonales.Controls.Add(this.Cbhabilitar);
            this.GbDatosPersonales.Controls.Add(this.label17);
            this.GbDatosPersonales.Controls.Add(this.groupBox1);
            this.GbDatosPersonales.Controls.Add(this.TxtCodInterno);
            this.GbDatosPersonales.Controls.Add(this.CmbEstado);
            this.GbDatosPersonales.Controls.Add(this.label1);
            this.GbDatosPersonales.Controls.Add(this.label6);
            this.GbDatosPersonales.Controls.Add(this.TxtApellidos);
            this.GbDatosPersonales.Controls.Add(this.label10);
            this.GbDatosPersonales.Controls.Add(this.CmbRol);
            this.GbDatosPersonales.Controls.Add(this.CmbGenero);
            this.GbDatosPersonales.Controls.Add(this.label8);
            this.GbDatosPersonales.Controls.Add(this.label7);
            this.GbDatosPersonales.Controls.Add(this.label9);
            this.GbDatosPersonales.Controls.Add(this.TxtDocumento);
            this.GbDatosPersonales.Controls.Add(this.TxtNombres);
            this.GbDatosPersonales.Controls.Add(this.TxtCiudad);
            this.GbDatosPersonales.Controls.Add(this.TxtDireccion);
            this.GbDatosPersonales.Controls.Add(this.label22);
            this.GbDatosPersonales.Controls.Add(this.TxtTelefono);
            this.GbDatosPersonales.Controls.Add(this.CmbDepartamento);
            this.GbDatosPersonales.Controls.Add(this.label12);
            this.GbDatosPersonales.Controls.Add(this.TxtEmail);
            this.GbDatosPersonales.Controls.Add(this.label13);
            this.GbDatosPersonales.Controls.Add(this.label14);
            this.GbDatosPersonales.Controls.Add(this.label15);
            this.GbDatosPersonales.Controls.Add(this.TxtMovil);
            this.GbDatosPersonales.Controls.Add(this.label21);
            this.GbDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbDatosPersonales.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDatosPersonales.ForeColor = System.Drawing.Color.SeaGreen;
            this.GbDatosPersonales.Location = new System.Drawing.Point(3, 3);
            this.GbDatosPersonales.Name = "GbDatosPersonales";
            this.GbDatosPersonales.Size = new System.Drawing.Size(1320, 332);
            this.GbDatosPersonales.TabIndex = 22;
            this.GbDatosPersonales.TabStop = false;
            this.GbDatosPersonales.Text = "Datos personales";
            // 
            // Cbhabilitar
            // 
            this.Cbhabilitar.AutoSize = true;
            this.Cbhabilitar.ForeColor = System.Drawing.Color.Black;
            this.Cbhabilitar.Location = new System.Drawing.Point(350, 95);
            this.Cbhabilitar.Name = "Cbhabilitar";
            this.Cbhabilitar.Size = new System.Drawing.Size(15, 14);
            this.Cbhabilitar.TabIndex = 3;
            this.Cbhabilitar.UseVisualStyleBackColor = true;
            this.Cbhabilitar.CheckedChanged += new System.EventHandler(this.Cbhabilitar_CheckedChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(41, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 17);
            this.label17.TabIndex = 38;
            this.label17.Text = "Codigo Interno";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.LblHoraF);
            this.groupBox1.Controls.Add(this.Lbl);
            this.groupBox1.Controls.Add(this.LblHoraI);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(717, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 302);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de sesiones";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DarkRed;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SeaGreen;
            this.label16.Location = new System.Drawing.Point(25, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Fecha Actual";
            // 
            // LblHoraF
            // 
            this.LblHoraF.AutoSize = true;
            this.LblHoraF.ForeColor = System.Drawing.Color.Maroon;
            this.LblHoraF.Location = new System.Drawing.Point(25, 187);
            this.LblHoraF.Name = "LblHoraF";
            this.LblHoraF.Size = new System.Drawing.Size(0, 16);
            this.LblHoraF.TabIndex = 3;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl.ForeColor = System.Drawing.Color.SeaGreen;
            this.Lbl.Location = new System.Drawing.Point(25, 139);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(261, 17);
            this.Lbl.TabIndex = 2;
            this.Lbl.Text = "Hora de finalizacion de sistema de logueo";
            // 
            // LblHoraI
            // 
            this.LblHoraI.AutoSize = true;
            this.LblHoraI.ForeColor = System.Drawing.Color.Maroon;
            this.LblHoraI.Location = new System.Drawing.Point(36, 104);
            this.LblHoraI.Name = "LblHoraI";
            this.LblHoraI.Size = new System.Drawing.Size(0, 16);
            this.LblHoraI.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(25, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hora de inicio de sistema de logueo";
            // 
            // TxtCodInterno
            // 
            this.TxtCodInterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodInterno.Enabled = false;
            this.TxtCodInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodInterno.Location = new System.Drawing.Point(147, 49);
            this.TxtCodInterno.MaxLength = 20;
            this.TxtCodInterno.Name = "TxtCodInterno";
            this.TxtCodInterno.Size = new System.Drawing.Size(197, 22);
            this.TxtCodInterno.TabIndex = 1;
            this.TxtCodInterno.Text = "000000000";
            // 
            // CmbEstado
            // 
            this.CmbEstado.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstado.ForeColor = System.Drawing.Color.White;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(147, 289);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(197, 24);
            this.CmbEstado.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "No Documento";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(147, 166);
            this.TxtApellidos.MaxLength = 45;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(197, 22);
            this.TxtApellidos.TabIndex = 5;
            this.TxtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidos_KeyPress_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(64, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Rol Usuario";
            // 
            // CmbRol
            // 
            this.CmbRol.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRol.Enabled = false;
            this.CmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRol.ForeColor = System.Drawing.Color.White;
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Location = new System.Drawing.Point(147, 247);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(197, 24);
            this.CmbRol.TabIndex = 7;
            // 
            // CmbGenero
            // 
            this.CmbGenero.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGenero.ForeColor = System.Drawing.Color.White;
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Location = new System.Drawing.Point(147, 205);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(197, 24);
            this.CmbGenero.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(78, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Apellidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(77, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(89, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Genero";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDocumento.Enabled = false;
            this.TxtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.Location = new System.Drawing.Point(147, 88);
            this.TxtDocumento.MaxLength = 20;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(197, 22);
            this.TxtDocumento.TabIndex = 2;
            this.TxtDocumento.TextChanged += new System.EventHandler(this.TxtDocumento_TextChanged_1);
            this.TxtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress_1);
            // 
            // TxtNombres
            // 
            this.TxtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(147, 127);
            this.TxtNombres.MaxLength = 45;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(197, 22);
            this.TxtNombres.TabIndex = 4;
            this.TxtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombres_KeyPress_1);
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.Location = new System.Drawing.Point(445, 216);
            this.TxtCiudad.MaxLength = 50;
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(234, 22);
            this.TxtCiudad.TabIndex = 13;
            this.TxtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCiudad_KeyPress_1);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(445, 258);
            this.TxtDireccion.MaxLength = 50;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(234, 22);
            this.TxtDireccion.TabIndex = 14;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress_1);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(376, 261);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 17);
            this.label22.TabIndex = 29;
            this.label22.Text = "Dirección";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(445, 87);
            this.TxtTelefono.MaxLength = 20;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(234, 22);
            this.TxtTelefono.TabIndex = 10;
            this.TxtTelefono.Text = "0";
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress_1);
            // 
            // CmbDepartamento
            // 
            this.CmbDepartamento.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDepartamento.ForeColor = System.Drawing.Color.White;
            this.CmbDepartamento.FormattingEnabled = true;
            this.CmbDepartamento.Location = new System.Drawing.Point(445, 171);
            this.CmbDepartamento.Name = "CmbDepartamento";
            this.CmbDepartamento.Size = new System.Drawing.Size(234, 24);
            this.CmbDepartamento.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(380, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Telefono";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(445, 129);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(234, 22);
            this.TxtEmail.TabIndex = 11;
            this.TxtEmail.Text = "Anonimo@anonimo.com";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(399, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(343, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Departamento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(389, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Ciudad";
            // 
            // TxtMovil
            // 
            this.TxtMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMovil.Location = new System.Drawing.Point(445, 45);
            this.TxtMovil.MaxLength = 20;
            this.TxtMovil.Name = "TxtMovil";
            this.TxtMovil.Size = new System.Drawing.Size(234, 22);
            this.TxtMovil.TabIndex = 9;
            this.TxtMovil.Text = "0";
            this.TxtMovil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMovil_KeyPress_1);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(398, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 17);
            this.label21.TabIndex = 24;
            this.label21.Text = "Movil";
            // 
            // ErrorNumeric
            // 
            this.ErrorNumeric.ContainerControl = this;
            // 
            // Ttip
            // 
            this.Ttip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Ttip.ToolTipTitle = "Informacion";
            // 
            // MiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GbConfiguracion);
            this.Controls.Add(this.GbDatosPersonales);
            this.Name = "MiCuenta";
            this.Size = new System.Drawing.Size(1345, 668);
            this.Load += new System.EventHandler(this.MiCuenta_Load);
            this.GbConfiguracion.ResumeLayout(false);
            this.GbSesiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgUltimasSesiones)).EndInit();
            this.GbAbrirSesiones.ResumeLayout(false);
            this.GbActualizarDatos.ResumeLayout(false);
            this.GbLimpiar.ResumeLayout(false);
            this.GbContraseña.ResumeLayout(false);
            this.GbContraseña.PerformLayout();
            this.GbDatosPersonales.ResumeLayout(false);
            this.GbDatosPersonales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbConfiguracion;
        private System.Windows.Forms.GroupBox GbSesiones;
        private System.Windows.Forms.DataGridView DgUltimasSesiones;
        private System.Windows.Forms.GroupBox GbAbrirSesiones;
        private System.Windows.Forms.Button BtnAbrirSesiones;
        private System.Windows.Forms.GroupBox GbActualizarDatos;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.GroupBox GbLimpiar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.GroupBox GbContraseña;
        private System.Windows.Forms.Button BtnCambiarContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassOld;
        private System.Windows.Forms.GroupBox GbDatosPersonales;
        private System.Windows.Forms.CheckBox Cbhabilitar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LblHoraF;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label LblHoraI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtCodInterno;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.ComboBox CmbGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.ComboBox CmbDepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtMovil;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ErrorProvider ErrorNumeric;
        private System.Windows.Forms.ToolTip Ttip;
    }
}
