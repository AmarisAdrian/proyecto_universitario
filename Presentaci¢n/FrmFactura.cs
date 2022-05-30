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
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }
        public string _NoDocumento;
        public string _Nombres;
        public string _Apellidos;
        public string _HoraI;
        string _Cantidad;
        string _Iva;
        string FechaActual = DateTime.Now.ToShortDateString();
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        Negocio.ProductoProveedor Productos = new Negocio.ProductoProveedor();
        Negocio.Facturacion Facturar = new Negocio.Facturacion();
        Negocio.ProcesosTecnicos Procesos = new Negocio.ProcesosTecnicos();
        Negocio.Usuario Usuario = new Negocio.Usuario();
        private void FrmFactura_Load(object sender, EventArgs e)
        {
            Asignar();
            AsignarIva();
            InHabilitarPantalla();
            
        }
        private void HabilitarPantalla()
        {
            GbDatosClientes.Enabled = true;
            GbDatosProductos.Enabled = true;
            GbImprimir.Enabled = true;
            GbAcciones.Enabled = true;
            CodInterno();
             
        }
        private void InHabilitarPantalla()
        {
            GbDatosClientes.Enabled = false;
            GbDatosProductos.Enabled = false;
            GbImprimir.Enabled = false;
            GbAcciones.Enabled = false;
        }
        private void Asignar()
        {
            try
            {
                LblDocumento.Text = _NoDocumento;
                LblNombres.Text = _Nombres;
                LblApellidos.Text = _Apellidos;
                LblFechaActual.Text = FechaActual;
                LblHoraI.Text = _HoraI;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        private void CodInterno()
        {
            try
            {
                if (Procesos.ConsultarCodInternoFactura())
                {
                    TxtNoFactura.Text = Procesos._UltimoCodInterno;
                    int cont = Convert.ToInt32(TxtNoFactura.Text);
                    cont = cont + 1;
                    TxtNoFactura.Text = string.Format("{0:000000000}", cont);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConsultarCliente()
        {
            try
            {
                if (Usuario.ConsultarCliente(TxtDocumento))
                {

                    TxtNombres.Text = Usuario._Nombres;
                    TxtApellidos.Text = Usuario._Apellidos;
                    TxtMovil.Text = Usuario._Movil;
                    TxtTelefono.Text = Usuario._Telefono;
                    TxtCiudad.Text= Usuario._Ciudad;
                    TxtDireccion.Text = Usuario._Direccion;

                }                
                else 
                {
                    DialogResult result = MessageBox.Show("El cliente no existe ¿Desea registrarlo?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        FrmCliente Frm = new FrmCliente();
                        Frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AsignarIva()
        {
            try
            {
                if (Procesos.ConsultarCodInternoIva())
                {
                    _Iva = Procesos._Iva;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtNoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TxtDocumento.Text == "")
                {
                    MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorNumeric.SetError(TxtDocumento, "Si desea consultar , digite en este campo el numero de identidad");
                }
                else
                {
                    ConsultarCliente();
                    ErrorNumeric.Clear();
                }
            }
        }
        private void TxtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (TxtReferencia.Text == "")
                    {
                        MessageBox.Show("Este campo no puede ir vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ErrorNumeric.SetError(TxtReferencia, "Este campo no puede ir vacio");
                        TxtReferencia.Clear();
                    }
                   else if (Productos.ConsultarProducto(TxtReferencia))
                    {
                        TxtCodInterno.Text = Productos._CodInterno;
                        int cont = Convert.ToInt32(TxtCodInterno.Text);
                        TxtCodInterno.Text = string.Format("{0:000000000}", cont);
                        Txtproducto.Text = Productos._Descripcion;
                        TxtIdMarca.Text = Productos._IdMarca;
                        TxtPrecio.Text = Productos._PrecioI;
                        TxtIva.Text = Productos._Iva;
                        TxtTotalProducto.Text = Productos._PrecioI;
                        _Cantidad = Productos._StockA;

                    }
                    else
                    {
                        MessageBox.Show("El producto no existe", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtReferencia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtReferencia.Text=="")
                {
                    Txtproducto.Clear();
                    TxtCantidad.Text = "1";
                    TxtDescuento.Text = "0";
                    TxtDescuento.Enabled = false;
                    CbDescuento.Checked = false;
                    TxtIdMarca.Clear();
                    TxtIva.Clear();
                    TxtCodInterno.Clear();
                    TxtPrecio.Clear();
                    TxtTotalProducto.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            double Total = 0;
            try
            {
                if (TxtReferencia.Text == "")
                {
                    TxtCantidad.Text = "1";
                }
                else if (TxtCantidad.Text == "" || TxtCantidad.Text == "0")
                {
                    TxtTotalProducto.Text = TxtPrecio.Text;
                }
                else if (Convert.ToInt32(TxtCantidad.Text) > Convert.ToInt32(_Cantidad))
                {
                    MessageBox.Show("la cantidad digitada es mayor que el stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCantidad.Text = "1";
                }
                else
                {
                    Total = Convert.ToDouble(TxtPrecio.Text) * Convert.ToDouble(TxtCantidad.Text);
                    TxtTotalProducto.Text = Convert.ToString(Total);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CbDescuento_CheckedChanged_1(object sender, EventArgs e)
        {
            double Total = 0;
            try
            {
                if (CbDescuento.Checked)
                {
                    TxtDescuento.Enabled = true;
                }
                else if (TxtReferencia.Text != "" || Txtproducto.Text != "")
                {
                    TxtDescuento.Enabled = false;
                    TxtDescuento.Text = "0";
                    Total = Convert.ToDouble(TxtPrecio.Text) * Convert.ToDouble(TxtCantidad.Text);
                    TxtTotalProducto.Text = Convert.ToString(Total);
                }
                else
                {
                    TxtDescuento.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxtDescuento_TextChanged_1(object sender, EventArgs e)
        {
            double Total = 0;
            try
            {
                if (TxtDescuento.Text == "")
                {
                    TxtDescuento.Text = "0";             
                }
                else if (TxtDescuento.Text =="" || TxtPrecio.Text=="")
                {
                    TxtDescuento.Text = "0";
                }
                else
                {
                    Total = Convert.ToDouble(TxtPrecio.Text) * Convert.ToDouble(TxtCantidad.Text);
                    TxtTotalProducto.Text = Convert.ToString(Total);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
        private void TxtDescuento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                double Descuento, Op, PrecioI, Preciof, Total = 0;
                if (TxtReferencia.Text == "")
                {
                    MessageBox.Show("verifique que no haya campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorNumeric.SetError(TxtReferencia, "Este campo no puede ir vacio");
                    TxtReferencia.Clear();
                    TxtDescuento.Enabled = false;
                    TxtDescuento.Text = "0";
                    CbDescuento.Checked = false;
                }
               else if (TxtDescuento.Text == "" || TxtDescuento.Text == "0")
                {
                    Total = Convert.ToDouble(TxtPrecio.Text) * Convert.ToDouble(TxtCantidad.Text);
                    TxtTotalProducto.Text = Convert.ToString(Total);
                }
                else
                {
                    Descuento = Convert.ToDouble(TxtDescuento.Text);
                    PrecioI = Convert.ToDouble(TxtTotalProducto.Text);
                    Op = Descuento / 100;
                    Preciof = Op * PrecioI;
                    Total = PrecioI - Preciof;
                    TxtTotalProducto.Text = Convert.ToString(Total);
                }
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            TextBox TxtIva = new TextBox();
            TxtIva.Text = _Iva;
            if (TxtDocumento.Text == "" || TxtReferencia.Text == "" || Txtproducto.Text == "" || TxtCantidad.Text == "")
            {
                MessageBox.Show("Hay campos Vacios", "Verificar Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else 
            {
                Facturar.TotalImprimirFactura(DgImprimir, TxtReferencia, Txtproducto, TxtCantidad, TxtPrecio, TxtTotal,TxtTotalProducto);
                Facturar.TotalFactura(DgImprimir, TxtIva, TxtTotal, TxtSubtotal);
                Facturar.FacturaRepetida(DgFactura,TxtNoFactura, TxtDocumento,Convert.ToString(Iva), TxtSubtotal, TxtTotal, DtFecha);
                Facturar.DetalleFactura(DgDetalleFactura, TxtNoFactura, TxtReferencia,TxtDescuento,TxtCantidad);
                
            }             
        }
        private void Calcular()
        {
            double SubTotal, Total, TotalMostrar;
            if (TxtTotalImprimir.Text == "")
            {
                Total = Convert.ToDouble(TxtTotalProducto.Text);
                SubTotal = Convert.ToDouble(Total) / Convert.ToDouble(_Iva) * 100;
                TxtSubImprimir.Text = Convert.ToString(SubTotal);
                TxtTotalImprimir.Text = Convert.ToString(Total);
            }
            else
            {
                Total = Convert.ToDouble(TxtTotalProducto.Text);
                TotalMostrar = Convert.ToDouble(Total) + Convert.ToDouble(TxtTotalImprimir.Text);
                SubTotal = Convert.ToDouble(TotalMostrar) / Convert.ToDouble(_Iva) * 100;
                TxtSubImprimir.Text = Convert.ToString(SubTotal); 
                TxtTotalImprimir.Text = Convert.ToString(TotalMostrar);
            }
        }
        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void EliminarFilasVacias()
        {
            DgDetalleFactura.AllowUserToAddRows = false;
            List<DataGridViewRow> rowsDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow fila in DgDetalleFactura.Rows)
            {
                bool hascontent = false;
                foreach (DataGridViewColumn col in DgDetalleFactura.Columns)
                {
                    if (Convert.ToString(fila.Cells[col.Index].Value) != "")
                    {
                        hascontent = true;
                        break;
                    }
                }
                if (!hascontent)
                {
                    rowsDelete.Add(fila);
                }
            }
            foreach (var item in rowsDelete)
            {
                DgDetalleFactura.Rows.Remove(item);
            }
        }
        private void BtnImprimir_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            EliminarFilasVacias();
            try
            {
                if (Convert.ToString(DgImprimir[i, 0].Value) == ""|| Convert.ToString(DgDetalleFactura[i, 0].Value) == ""|| Convert.ToString(DgFactura[i, 0].Value)=="")
                {
                    MessageBox.Show("Carro de compra vacio","Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Facturar.Guardarfactura(DgFactura) && (Facturar.GuardarDetallefactura(DgDetalleFactura)) &&(Facturar.GuardarControlFactura(TxtNoFactura,LblDocumento)))
                {
                    MessageBox.Show("IMPRIMIENDO ....", "Facturacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InHabilitarPantalla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No pudo guardarse la factura", "Facturacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No pudo guardarse la factura");
            }         
        }
        private void emitirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabilitarPantalla();
        }
        private void Limpiar()
        {          
            Validar.LimpiarCampos(this, GbDatosClientes);
            Validar.LimpiarCampos(this, GbDatosProductos);
            Validar.LimpiarCampos(this, GbDatosFinales);
            DgImprimir.Rows.Clear();
            DgFactura.Rows.Clear();
            DgDetalleFactura.Rows.Clear();           
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMainOperador frm = new FrmMainOperador();        
            frm._Documento = _NoDocumento;
            frm._Nombres = _Nombres;
            frm._Apellidos = _Apellidos;
            frm._Hora = _HoraI;
            this.Hide();
            frm.Show();         
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
