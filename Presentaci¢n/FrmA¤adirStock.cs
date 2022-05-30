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
    public partial class FrmAñadirStock : Form
    {
        public FrmAñadirStock()
        {
            InitializeComponent();
        }
        Negocio.ProductoProveedor Pro = new Negocio.ProductoProveedor();
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        public string _CodInterno;
        public string _StockActual;
        public string _StockInicial;
        private void FrmAñadirStock_Load(object sender, EventArgs e)
        {
            lblReferencia.Text = _CodInterno;
            TxtStockActual.Text = _StockActual;
            TxtStockInicial.Text = _StockInicial;
        }
        private void TxtAbastecer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
           try
           {
                if (Validar.ValidarTextbox(GbDatos, ErrorNumeric))
                {
                    if (Pro.ActualizarStock(lblReferencia, TxtResultante))
                    {
                        MessageBox.Show("Se ha abastecido el producto", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatos);
                        ErrorNumeric.Clear();
                    }
                    else
                    {
                        MessageBox.Show(Pro._Mensaje, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TxtAbastecer_TextChanged(object sender, EventArgs e)
        {
            double Res = 0;
            if (TxtAbastecer.Text == "")
            {
                TxtResultante.Text = "0";
            }
            else {
                Res = Convert.ToDouble(TxtStockActual.Text) + Convert.ToDouble(TxtAbastecer.Text);
                TxtResultante.Text = Convert.ToString(Res);
            }
        }
    }
}
