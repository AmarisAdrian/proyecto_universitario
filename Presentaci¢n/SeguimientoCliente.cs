using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class SeguimientoCliente : UserControl
    {
        public SeguimientoCliente()
        {
            InitializeComponent();
        }
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        Negocio.Auditoria Auditoria = new Negocio.Auditoria();
        Negocio.Facturacion Facturar = new Negocio.Facturacion();
        private void SeguimientoCliente_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            if (TxtBuscar.Text == "")
            {
                MessageBox.Show("Este campo no puede ir vacio", "Erro de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Auditoria.ConsultarFacturaCliente(DgFactura, TxtBuscar);
                    Auditoria.ConsultarDatosCliente(DgDatos, TxtBuscar);
                    Facturar.TotalFactura(DgFactura, TxtTotalventas);
                    TxtNumeroFactura.Text = this.DgFactura.Rows.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DgFactura_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string Numero = Convert.ToString(this.DgFactura.CurrentRow.Cells[0].Value);
            Auditoria.ConsultarDetalleFactura(DgDetalleFactura, Convert.ToString(Numero));
            this.DgDetalleFactura.RowsDefaultCellStyle.BackColor = Color.White;
            this.DgDetalleFactura.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow;
        }
    }
}
