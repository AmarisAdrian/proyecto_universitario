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
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
        }
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        Negocio.ProductoProveedor Prod = new Negocio.ProductoProveedor();
        Negocio.ProcesosTecnicos Procesos = new Negocio.ProcesosTecnicos();

        private void Stock_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            if (RbPersonalizada.Checked == true)
            {
                if (TxtBuscar.Text == "" || TxtCantidad.Text == "")
                {
                    MessageBox.Show("Hay campos vacios");
                }
                else
                {
                    Prod.ConsultarStock(DgStock, TxtBuscar);
                    Procesos.VisualizarStock(DgStock, TxtCantidad);
                }
            }
            else if (RbBuscarTodo.Checked)
            {
                Prod.ConsultarStock(DgStock);
                Procesos.VisualizarStock(DgStock, TxtCantidad);
            }
            else if (RbStockMinima.Checked)
            {
                Prod.ConsultarStock(DgStock);
                Procesos.VisualizarStock(DgStock, TxtCantidad);
            }
        }
        private void RbPersonalizada_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RbBuscarTodo.Checked == true)
            {
                TxtBuscar.Enabled = false;
                TxtCantidad.Enabled = false;
                TxtCantidad.Text = "20";
                TxtBuscar.Clear();
            }
            if (RbPersonalizada.Checked == true)
            {
                TxtBuscar.Enabled = true;
                TxtCantidad.Enabled = false;
                TxtCantidad.Text = "20";
            }
            if (RbStockMinima.Checked == true)
            {
                TxtBuscar.Enabled = false;
                TxtCantidad.Enabled = true;
            }
        }
        private void RbBuscarTodo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RbBuscarTodo.Checked == true)
            {
                TxtBuscar.Enabled = false;
                TxtCantidad.Enabled = false;
                TxtCantidad.Text = "20";
                TxtBuscar.Clear();
            }
        }
        private void RbStockMinima_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RbStockMinima.Checked == true)
            {
                TxtBuscar.Enabled = false;
                TxtCantidad.Enabled = true;
            }
        }
        private void TxtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void DgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Cod = Convert.ToString(this.DgStock.CurrentRow.Cells[1].Value);
            string StockInicial = Convert.ToString(this.DgStock.CurrentRow.Cells[8].Value);
            string StockActual = Convert.ToString(this.DgStock.CurrentRow.Cells[9].Value);
            FrmAñadirStock frm = new FrmAñadirStock();
            frm._CodInterno = Cod;
            frm._StockInicial = StockInicial;
            frm._StockActual = StockActual;
            frm.Show();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Prod.ConsultarStock(DgStock);
            Procesos.VisualizarStock(DgStock, TxtCantidad);
        }
    }
}
