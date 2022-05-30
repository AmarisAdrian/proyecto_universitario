using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        public string _NoDocumento;
        public string _ConsultarDocumento;
        public string _Hora;
        public string _EnviarHora;
        public string _CodInterno;
        public string _EnviarCodInterno;
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            Asignar();
        }
        private void Asignar()
        {
            try
            {
                _ConsultarDocumento = _NoDocumento;
                _EnviarHora = _Hora;
                _EnviarCodInterno = _CodInterno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            Frm._Documento = _NoDocumento;
            Frm._Hora = _Hora;
            this.PanelPrincipal.Controls.Add(Frm);
            this.PanelPrincipal.Tag = Frm;
            Frm.Show();
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
             AddFormInPanel(new Productos());
        }
        private void BtnStock_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Stock());          
        }
        private void BtnFactura_Click(object sender, EventArgs e)
        {
           
        }
        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Proveedor());
        }
        private void BtnClientes_Click(object sender, EventArgs e)
        {
           // AddFormInPanel(new Cliente());
        }
        private void BtnOperador_Click(object sender, EventArgs e)
        {
            FrmOperador frm = new FrmOperador();
            frm.Show();
        }
        private void BtnReporte_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnEscritorio_Click(object sender, EventArgs e)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
        }
        private void BtnInventario_Click(object sender, EventArgs e)
        {

        }
        private void BtnSeguimientoCliente_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new SeguimientoCliente());
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
     
    }
}
