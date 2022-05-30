namespace Presentación
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.GbMensajes = new System.Windows.Forms.GroupBox();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.ErrorVacio = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelImagen = new System.Windows.Forms.Panel();
            this.ImagenLogin = new System.Windows.Forms.PictureBox();
            this.GbDatos.SuspendLayout();
            this.GbMensajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorVacio)).BeginInit();
            this.PanelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.GhostWhite;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(142, 35);
            this.TxtUsuario.MaxLength = 25;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(215, 29);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.GhostWhite;
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(142, 76);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(215, 29);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIngresar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.Black;
            this.BtnIngresar.Location = new System.Drawing.Point(142, 125);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(108, 37);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.Location = new System.Drawing.Point(256, 125);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(101, 37);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GbDatos
            // 
            this.GbDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GbDatos.BackColor = System.Drawing.Color.Transparent;
            this.GbDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GbDatos.Controls.Add(this.TxtUsuario);
            this.GbDatos.Controls.Add(this.TxtPass);
            this.GbDatos.Controls.Add(this.BtnSalir);
            this.GbDatos.Controls.Add(this.BtnIngresar);
            this.GbDatos.Controls.Add(this.label1);
            this.GbDatos.Controls.Add(this.label2);
            this.GbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDatos.ForeColor = System.Drawing.Color.Black;
            this.GbDatos.Location = new System.Drawing.Point(24, 26);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(376, 186);
            this.GbDatos.TabIndex = 8;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos de acceso";
            // 
            // GbMensajes
            // 
            this.GbMensajes.BackColor = System.Drawing.Color.Transparent;
            this.GbMensajes.Controls.Add(this.LblMensaje);
            this.GbMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMensajes.ForeColor = System.Drawing.Color.Black;
            this.GbMensajes.Location = new System.Drawing.Point(24, 218);
            this.GbMensajes.Name = "GbMensajes";
            this.GbMensajes.Size = new System.Drawing.Size(376, 83);
            this.GbMensajes.TabIndex = 8;
            this.GbMensajes.TabStop = false;
            this.GbMensajes.Text = "Mensaje";
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.Color.Maroon;
            this.LblMensaje.Location = new System.Drawing.Point(6, 26);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(0, 20);
            this.LblMensaje.TabIndex = 0;
            // 
            // ErrorVacio
            // 
            this.ErrorVacio.ContainerControl = this;
            // 
            // PanelImagen
            // 
            this.PanelImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelImagen.BackColor = System.Drawing.Color.DodgerBlue;
            this.PanelImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelImagen.Controls.Add(this.ImagenLogin);
            this.PanelImagen.Location = new System.Drawing.Point(408, -4);
            this.PanelImagen.Name = "PanelImagen";
            this.PanelImagen.Size = new System.Drawing.Size(321, 331);
            this.PanelImagen.TabIndex = 10;
            // 
            // ImagenLogin
            // 
            this.ImagenLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagenLogin.Image = ((System.Drawing.Image)(resources.GetObject("ImagenLogin.Image")));
            this.ImagenLogin.Location = new System.Drawing.Point(15, 39);
            this.ImagenLogin.Name = "ImagenLogin";
            this.ImagenLogin.Size = new System.Drawing.Size(290, 265);
            this.ImagenLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenLogin.TabIndex = 0;
            this.ImagenLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 323);
            this.Controls.Add(this.PanelImagen);
            this.Controls.Add(this.GbMensajes);
            this.Controls.Add(this.GbDatos);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.GbMensajes.ResumeLayout(false);
            this.GbMensajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorVacio)).EndInit();
            this.PanelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.GroupBox GbMensajes;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.ErrorProvider ErrorVacio;
        private System.Windows.Forms.Panel PanelImagen;
        private System.Windows.Forms.PictureBox ImagenLogin;
    }
}