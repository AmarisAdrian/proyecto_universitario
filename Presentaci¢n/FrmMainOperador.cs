using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FrmMainOperador : Form
    {
        public FrmMainOperador()
        {
            InitializeComponent();
        }
        Negocio.ProcesosTecnicos Procesos = new Negocio.ProcesosTecnicos();
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        Negocio.Usuario Usuario = new Negocio.Usuario();
        public string _Documento;
        public string _CodInterno;
        public string _EnviarCodInterno;
        public string _Hora;
        public string _Nombres;
        public string _Apellidos;
  
        private void FrmMainOperador_Load(object sender, EventArgs e)
        {
            
        }       
        private void AddFormInPanel(object Formulario)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            UserControl Frm = Formulario as UserControl;
            Frm.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(Frm);
            this.PanelPrincipal.Tag = Frm;
            Frm.Show();
        }
        private void BtnCuenta_Click(object sender, EventArgs e)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            MiCuenta Frm = new MiCuenta();
            Frm.Dock = DockStyle.Fill;
            Frm._Documento = _Documento;
            Frm._Hora = _Hora;
            this.PanelPrincipal.Controls.Add(Frm);
            this.PanelPrincipal.Tag = Frm;
            Frm.Show();
        }
        private void BtnEscritorio_Click(object sender, EventArgs e)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                FrmCerrarSesion frm = new FrmCerrarSesion();
                frm._EnviarCodInterno = _CodInterno;
                frm._EnviarHoraInicio = _Hora;
                frm._EnviarHoraFin = DateTime.Now.ToShortTimeString();
                this.Visible = false;
                frm.Visible = true;
            }
        }      
        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            FrmFactura Frm = new FrmFactura();
            Frm._NoDocumento = _Documento;
            Frm._Nombres = _Nombres;
            Frm._Apellidos = _Apellidos;
            Frm._HoraI = _Hora;
            this.Hide();
            Frm.Show();
        }
    }
}
