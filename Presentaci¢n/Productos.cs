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
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
        }
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        Negocio.ProductoProveedor Prod = new Negocio.ProductoProveedor();
        Negocio.ProcesosTecnicos Procesos = new Negocio.ProcesosTecnicos();
        private void Productos_Load(object sender, EventArgs e)
        {
            Combos();
            this.Dock = DockStyle.Fill;
            CodInterno();
        }
        private void CodInterno()
        {
            try
            {
                if (Procesos.ConsultarCodInternoProducto())
                {
                    TxtCodInterno.Text = Procesos._UltimoCodInterno;
                    int cont = Convert.ToInt32(TxtCodInterno.Text);
                    cont = cont + 1;
                    TxtCodInterno.Text = string.Format("{0:000000000}", cont);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Combos()
        {
            try
            {
                Procesos.CargarComboProveedor(CmbProveedor);
                CmbProveedor.SelectedIndex = -1;
                Procesos.CargarComboCategoria(CmbCategoria);
                CmbCategoria.SelectedIndex = -1;
                Procesos.CargarComboUnidad(CmbUnidad);
                CmbUnidad.SelectedIndex = -1;
                Procesos.CargarComboMarca(CmbMarca);
                CmbMarca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void ConsultarMarca()
        {
            try
            {
                if (Prod.ConsultarMarca(TxtIdMarca))
                {
                    TxtNombreMarca.Text = Prod._Nombre;
                    HabilitarMarca();
                }
                else
                {
                    MessageBox.Show("La marca no existe", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConsultarCategoria()
        {
            try
            {
                if (Prod.Consultarcategoria(TxtIdCategoria))
                {
                    TxtNombreCategoria.Text = Prod._Nombre;
                    HabilitarCategoria();
                }
                else
                {
                    MessageBox.Show("La categoria no existe", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConsultarUnidad()
        {
            try
            {
                if (Prod.ConsultarUnidadProducto(TxtIdUnidad))
                {
                    TxtNombreUnidad.Text = Prod._Nombre;
                    HabilitarUnidad();
                }
                else
                {
                    MessageBox.Show("La unidad no existe", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConsultarProducto()
        {
            try
            {
                if (Prod.ConsultarProducto(TxtIdProducto))
                {
                    TxtCodInterno.Text = Prod._CodInterno;
                    int cont = Convert.ToInt32(TxtCodInterno.Text);
                    TxtCodInterno.Text = string.Format("{0:000000000}", cont);
                    CmbProveedor.SelectedValue = Prod._IdProveedor;
                    CmbCategoria.SelectedValue = Prod._IdCategoria;
                    CmbUnidad.SelectedValue = Prod._IdUnidadProducto;
                    CmbMarca.SelectedValue = Prod._IdMarca;
                    RtDescripcion.Text = Prod._Descripcion;
                    TxtStockInicial.Text = Prod._StockI;
                    TxtStockInicial.Enabled = false;
                    txtStockActual.Enabled = false;
                    txtStockActual.Text = Prod._StockA;
                    TxtPrecioUnitario.Text = Prod._PrecioU;
                    TxtIva.Text = Prod._Iva;
                    TxtPrecioIva.Text = Prod._PrecioI;
                    HabilitarProducto();
                }
                else
                {
                    MessageBox.Show("El producto no existe", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HabilitarProducto()
        {
            if (Validar.ValidarTextbox(GbDatosProductos, ErrorNumeric) && Validar.ValidarCombo(GbDatosProductos, ErrorNumeric))
            {
                BtnEditarProducto.Enabled = true;
            }
            else
            {
                BtnEditarProducto.Enabled = false;
            }
        }
        private void HabilitarUnidad()
        {
            if (Validar.ValidarTextbox(GbDatosUnidades, ErrorNumeric))
            {
                BtnEditarUnidad.Enabled = true;
            }
            else
            {
                BtnEditarUnidad.Enabled = false;
            }
        }
        private void HabilitarMarca()
        {
            if (Validar.ValidarTextbox(GbDatosMarca, ErrorNumeric))
            {
                BtnEditarMarca.Enabled = true;
            }
            else
            {
                BtnEditarMarca.Enabled = false;
            }
        }
        private void HabilitarCategoria()
        {
            if (Validar.ValidarTextbox(GbDatosCategoria, ErrorNumeric))
            {
                BtnEditarCategoria.Enabled = true;
            }
            else
            {
                BtnEditarCategoria.Enabled = false;
            }
        }
        private void TxtCodInterno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtStockInicial_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void txtStockActual_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtPrecioUnitario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosProductos, ErrorNumeric) && Validar.ValidarCombo(GbDatosProductos, ErrorNumeric))
                {
                    if (Prod.InsertarProducto(TxtCodInterno, TxtIdProducto,CmbProveedor, CmbCategoria, CmbUnidad, CmbMarca, RtDescripcion, TxtStockInicial, txtStockActual, TxtPrecioUnitario, TxtIva, TxtPrecioIva))
                    {
                        MessageBox.Show("Sus datos han sido guardados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatosProductos);
                        ErrorNumeric.Clear();
                        CodInterno();
                        RtDescripcion.Clear();
                    }
                    else if (Prod._CodigoError == -2146232060)
                    {
                        MessageBox.Show("El producto con esa referencia se encuentra registrado","El producto ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }  
                else
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ha ocurrido el siguiente error:");
            }
        }
        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosProductos, ErrorNumeric) && Validar.ValidarCombo(GbDatosProductos, ErrorNumeric))
                {
                    if (Prod.EditarProducto(TxtCodInterno, TxtIdProducto, CmbProveedor, CmbCategoria, CmbUnidad, CmbMarca, RtDescripcion, TxtStockInicial, txtStockActual, TxtPrecioUnitario, TxtIva, TxtPrecioIva))
                    {
                        MessageBox.Show("Sus datos han sido guardados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatosProductos);
                        ErrorNumeric.Clear();
                        CodInterno();
                        RtDescripcion.Clear();
                    }
                    else if (Prod._CodigoError == -2146232060)
                    {
                        MessageBox.Show(Prod._Mensaje, "El Id del producto ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error:");
            }
        }
        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
            
                if (TxtIdProducto.Text == "")
                {

                    MessageBox.Show("Este campo no puede ir vacio");
                }
                else
                {
                    ConsultarProducto();
                }
              
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error:");
            }

        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Validar.LimpiarCampos(this,GbDatosProductos);
            RtDescripcion.Clear();
            CodInterno();
        }
        private void BtnGuardarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosCategoria, ErrorNumeric))
                {
                    if (Prod.InsertarCategoria(TxtIdCategoria, TxtNombreCategoria))
                    {

                        MessageBox.Show("Sus datos han sido guardados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatosCategoria);
                        ErrorNumeric.Clear();
                        Combos();
                    }
                    else if (Prod._CodigoError == -2146232060)
                    {
                        MessageBox.Show(Prod._Mensaje, "La categoria ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error:");
            }
        }
        private void BtnEditarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                    if (Validar.ValidarTextbox(GbDatosCategoria, ErrorNumeric))
                    {
                        if (Prod.EditarCategoria(TxtIdCategoria, TxtNombreCategoria))
                        {

                            MessageBox.Show("Sus datos han sido editados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Validar.LimpiarCampos(this, GbDatosCategoria);
                            ErrorNumeric.Clear();
                             Combos();
                        }
                        else if (Prod._CodigoError == -2146232060)
                        {
                            MessageBox.Show(Prod._Mensaje, "La categoria ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error:");
            }
        }
        private void BtnGuardarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosMarca, ErrorNumeric))
                {
                    if (Prod.InsertarMarca(TxtIdMarca, TxtNombreMarca))
                    {

                        MessageBox.Show("Sus datos han sido guardado correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatosMarca);
                        ErrorNumeric.Clear();
                        Combos();
                    }
                    else if (Prod._CodigoError == -2146232060)
                    {
                        MessageBox.Show(Prod._Mensaje, "La marca ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error:");
            }
        }
        private void BtnEditarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosMarca, ErrorNumeric))
                {
                    if (Prod.EditarMarca(TxtIdMarca, TxtNombreMarca))
                    {

                        MessageBox.Show("Sus datos han sido editados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatosMarca);
                        ErrorNumeric.Clear();
                        Combos();
                    }
                    else if (Prod._CodigoError == -2146232060)
                    {
                        MessageBox.Show(Prod._Mensaje, "La marca ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error:");
            }
        }
        private void BtnInsertarUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosUnidades, ErrorNumeric))
                {
                    if (Prod.InsertarUnidad(TxtIdUnidad, TxtNombreUnidad))
                    {

                        MessageBox.Show("Sus datos han sido guardado correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatosUnidades);
                        ErrorNumeric.Clear();
                        Combos();
                    }
                    else if (Prod._CodigoError == -2146232060)
                    {
                        MessageBox.Show(Prod._Mensaje, "La unidad ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error:");
            }
        }
        private void BtnEditarUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosUnidades, ErrorNumeric))
                {
                    if (Prod.EditarUnidadProducto(TxtIdUnidad, TxtNombreUnidad))
                    {

                        MessageBox.Show("Sus datos han sido editados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatosUnidades);
                        ErrorNumeric.Clear();
                        Combos();
                    }
                    else if (Prod._CodigoError == -2146232060)
                    {
                        MessageBox.Show(Prod._Mensaje, "La unidad ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error:");
            }

        }
        private void TxtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            double Subtotal,Total, Iva = 0;
            if (TxtPrecioUnitario.Text == "")
            {
                TxtPrecioIva.Clear();
                TxtIva.Text = "19";
            }
            else
            {
                    TxtIva.Text = "19";
                    Subtotal = Convert.ToDouble(TxtPrecioUnitario.Text);
                    Iva = Convert.ToDouble(TxtIva.Text) + 100;
                    Total = Subtotal * Iva / 100;
                    TxtPrecioIva.Text = Convert.ToString(Total);
            }
        }
        private void CbActivar_CheckedChanged(object sender, EventArgs e)
        {
            double Subtotal, Total, Iva = 0;
            if (CbActivar.Checked)
            {
                TxtIva.Enabled = true;
            }
            else
            {
                TxtIva.Enabled = false;
                TxtIva.Text = "19";
                if (TxtPrecioUnitario.Text=="")
                {
                    TxtIva.Enabled = false;
                    TxtIva.Text = "19";
                }
                else
                {
                    Subtotal = Convert.ToDouble(TxtPrecioUnitario.Text);
                    Iva = Convert.ToDouble(TxtIva.Text) + 100;
                    Total = Subtotal * Iva / 100;
                    TxtPrecioIva.Text = Convert.ToString(Total);
                }
            }
        }
        private void TxtIva_TextChanged(object sender, EventArgs e)
        {
            double Subtotal, Total, Iva = 0;
            if (TxtIva.Text=="")
            {
                TxtPrecioIva.Clear();
            }
            else if(TxtPrecioUnitario.Text != "")
            {
                Subtotal = Convert.ToDouble(TxtPrecioUnitario.Text);
                Iva = Convert.ToDouble(TxtIva.Text) + 100;
                Total = Subtotal * Iva / 100;
                TxtPrecioIva.Text = Convert.ToString(Total);
            }
        }
        private void TxtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
            double Subtotal, Total, Iva = 0;
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Subtotal = Convert.ToDouble(TxtPrecioUnitario.Text);
                Iva = Convert.ToDouble(TxtIva.Text) + 100;
                Total = Subtotal * Iva / 100;
                TxtPrecioIva.Text = Convert.ToString(Total);
            }
        }      
        private void TxtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ConsultarProducto();
            }
        }
        private void RtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (TxtIdProducto.Text == "")
            {
                Validar.LimpiarCampos(this, GbDatosProductos);
                RtDescripcion.Clear();
                HabilitarProducto();
                CodInterno();
            }
        }
        private void TxtIdUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TxtIdUnidad.Text == "")
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ConsultarUnidad();
                }               
            }          
        }
        private void TxtIdCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if(TxtIdCategoria.Text=="")
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ConsultarCategoria();
                }              
            }        
        }
        private void TxtIdMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TxtIdMarca.Text == "")
                {
                    MessageBox.Show("Campos vacios", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ConsultarMarca();
                }              
            }          
        }
        private void TxtNombreUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtNombreCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtIdUnidad_TextChanged(object sender, EventArgs e)
        {
            if (TxtIdUnidad.Text=="")
            {
                TxtNombreUnidad.Clear();
                HabilitarUnidad();
            }
        }
        private void TxtIdCategoria_TextChanged(object sender, EventArgs e)
        {
            if (TxtIdCategoria.Text == "")
            {
                TxtNombreCategoria.Clear();
                HabilitarCategoria();
            }
        }
        private void TxtIdMarca_TextChanged(object sender, EventArgs e)
        {
            if (TxtIdMarca.Text == "")
            {
                TxtNombreMarca.Clear();
                HabilitarMarca();
            }
        }
       
    }
}

