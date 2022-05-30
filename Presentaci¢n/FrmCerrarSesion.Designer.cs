namespace Presentación
{
    partial class FrmCerrarSesion
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
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.PbCargarBarra = new System.Windows.Forms.ProgressBar();
            this.LblEstado = new System.Windows.Forms.Label();
            this.Crono = new System.Windows.Forms.Timer(this.components);
            this.LblRegistro = new System.Windows.Forms.Label();
            this.ConTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DtFecha
            // 
            this.DtFecha.Enabled = false;
            this.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFecha.Location = new System.Drawing.Point(23, 12);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(97, 20);
            this.DtFecha.TabIndex = 0;
            this.DtFecha.Visible = false;
            // 
            // PbCargarBarra
            // 
            this.PbCargarBarra.Location = new System.Drawing.Point(23, 52);
            this.PbCargarBarra.Name = "PbCargarBarra";
            this.PbCargarBarra.Size = new System.Drawing.Size(198, 23);
            this.PbCargarBarra.TabIndex = 1;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(20, 107);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(148, 18);
            this.LblEstado.TabIndex = 2;
            this.LblEstado.Text = "Estado: Verificando ..";
            // 
            // LblRegistro
            // 
            this.LblRegistro.AutoSize = true;
            this.LblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistro.Location = new System.Drawing.Point(20, 80);
            this.LblRegistro.Name = "LblRegistro";
            this.LblRegistro.Size = new System.Drawing.Size(0, 18);
            this.LblRegistro.TabIndex = 3;
            this.LblRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblRegistro.Visible = false;
            // 
            // ConTimer
            // 
            this.ConTimer.AutoSize = true;
            this.ConTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConTimer.Location = new System.Drawing.Point(227, 57);
            this.ConTimer.Name = "ConTimer";
            this.ConTimer.Size = new System.Drawing.Size(0, 18);
            this.ConTimer.TabIndex = 4;
            // 
            // FrmCerrarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.ConTimer);
            this.Controls.Add(this.LblRegistro);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.PbCargarBarra);
            this.Controls.Add(this.DtFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCerrarSesion";
            this.Text = "Cerrando sesion";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmCerrarSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.ProgressBar PbCargarBarra;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Timer Crono;
        private System.Windows.Forms.Label LblRegistro;
        private System.Windows.Forms.Label ConTimer;
    }
}