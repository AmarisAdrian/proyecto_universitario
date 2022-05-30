using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Sql;
using AccesoDatos;

namespace Negocio
{
    public class Facturacion
    {
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
        Negocio.ProcesosTecnicos Procesos = new Negocio.ProcesosTecnicos();
        string _Iva;
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
        public void FacturaRepetida(DataGridView DgFactura, TextBox TxtNoFactura, TextBox TxtDocumento, string Txtiva, TextBox TxtSubtotal, TextBox TxtTotal, DateTimePicker DtFecha)
        {
            AsignarIva();
            Txtiva = _Iva;
            int i = 0;
            bool permitir = false;
            while (DgFactura[0, i].Value != null)
            {
                if (Convert.ToString(DgFactura[0, i].Value) == Convert.ToString(TxtNoFactura.Text))
                {
                    DgFactura[3, i].Value = TxtSubtotal.Text;
                    DgFactura[4, i].Value = TxtTotal.Text;
                    permitir = true;
                }
                i++;
            }
            if (permitir == false)
            {
                DgFactura.Rows.Add(TxtNoFactura.Text, TxtDocumento.Text, Txtiva, TxtSubtotal.Text, TxtTotal.Text, DtFecha.Text);
            }
        }
        public void DetalleFactura(DataGridView DgDetallesFactura, TextBox TxtNoFactura, TextBox TxtReferencia,TextBox TxtDescuento, TextBox TxtCantidad)
        {
            int i = 0;
            double Cantidad = 0;
            bool permitir = false;
            while (DgDetallesFactura[0, i].Value != null)
            {
                if (Convert.ToString(DgDetallesFactura[1, i].Value) == Convert.ToString(TxtReferencia.Text))
                {
                    Cantidad = Convert.ToDouble(DgDetallesFactura[3, i].Value) + Convert.ToDouble(TxtCantidad.Text);
                    DgDetallesFactura[3, i].Value = Convert.ToString(Cantidad);
                    permitir = true;
                }
                i++;
            }
            if (permitir == false)
            {
                DgDetallesFactura.Rows.Add(TxtNoFactura.Text, TxtReferencia.Text,TxtDescuento.Text, TxtCantidad.Text);
            }
        }
        public void TotalImprimirFactura(DataGridView DgImprimir, TextBox TxtReferencia, TextBox TxtProducto, TextBox TxtCantidad, TextBox TxtPrecio, TextBox TxtTotal,TextBox TxtTotalProducto)
        {
            double Cantidad = 0;
            double total = 0;
            bool agregar = false;
            int i = 0;
            try
            { 
                    
                while (DgImprimir[0, i].Value != null)
                {
                    if (Convert.ToString(DgImprimir[0, i].Value) == Convert.ToString(TxtReferencia.Text))
                    {
                        Cantidad = Convert.ToDouble(DgImprimir[2, i].Value) + Convert.ToDouble(TxtCantidad.Text);
                        DgImprimir[2, i].Value = Convert.ToString(Cantidad);
                        total = Convert.ToDouble(TxtPrecio.Text) * Convert.ToDouble(Cantidad);
                        DgImprimir[4, i].Value = Convert.ToString(total);
                        agregar = true;
                    }
                    i++;
                }
                if (agregar == false)
                {

                    DgImprimir.Rows.Add(TxtReferencia.Text, TxtProducto.Text, TxtCantidad.Text, TxtPrecio.Text, TxtTotalProducto.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void TotalFactura(DataGridView DgImprimir, TextBox Txtiva, TextBox TxtTotalFactura, TextBox TxtSubtotalFactura)
        {
            AsignarIva();
            double total = 0;
            double subtotal = 0;
            double Iva = 0;
            Txtiva.Text = _Iva;
            foreach (DataGridViewRow row in DgImprimir.Rows)
            {
                total += Convert.ToDouble(row.Cells["Totalview"].Value);
            }
            Iva = double.Parse(Txtiva.Text) / 100;
            subtotal = total / Iva;
            TxtSubtotalFactura.Text = Convert.ToString(subtotal);
            TxtTotalFactura.Text = Convert.ToString(total);
        }
        public void TotalFactura(DataGridView DgFactura,TextBox TxtTotal)
        {
            double total = 0;
            foreach (DataGridViewRow row in DgFactura.Rows)
            {
                total += Convert.ToDouble(row.Cells["TOTALPAGAR"].Value);
            }
            TxtTotal.Text = Convert.ToString(total);
        }
        public bool Guardarfactura(DataGridView Dgfactura)
        {
            bool save = false;
            int i = 0;
            bd.Conectar();
            bd.CrearComando("INSERT INTO FACTURA (NOFACTURA,IDCLIENTE,IVA,SUBTOTAL,TOTALPAGAR,FECHA)VALUES(@NOFACTURA,@IDCLIENTE,@IVA,@SUBTOTAL,@TOTALPAGAR,@FECHA)", System.Data.CommandType.Text);
            bd.Asignarparametro("@NOFACTURA ", SqlDbType.VarChar, Dgfactura.Rows[i].Cells[0].Value.ToString());
            bd.Asignarparametro("@IDCLIENTE ", SqlDbType.BigInt, Dgfactura.Rows[i].Cells[1].Value.ToString());
            bd.Asignarparametro("@IVA ", SqlDbType.NVarChar, Dgfactura.Rows[i].Cells[2].Value.ToString());
            bd.Asignarparametro("@SUBTOTAL ", SqlDbType.Decimal, Dgfactura.Rows[i].Cells[3].Value.ToString());
            bd.Asignarparametro("@TOTALPAGAR ", SqlDbType.Decimal, Dgfactura.Rows[i].Cells[4].Value.ToString());
            bd.Asignarparametro("@FECHA ", SqlDbType.DateTime, Dgfactura.Rows[i].Cells[5].Value.ToString());
            int reg = 0;
            reg = bd.Ejecutarcomando();
            if (reg > 0)
            {
                save = true;
                i++;
            }
            else
            {
                save = false;
            }

            bd.Desconectar();
            return save;
        }
        public bool GuardarDetallefactura(DataGridView DgDetallesFactura)
        {
            bool guardar = false;
            int i = 0;
            try
            {
                foreach (DataGridViewRow Rows in DgDetallesFactura.Rows)
                {
                    bd.Conectar();
                    bd.CrearComando("INSERTARDETALLEFACTURA", CommandType.StoredProcedure);
                    bd.Asignarparametro("@NOFACTURA", SqlDbType.BigInt, DgDetallesFactura.Rows[i].Cells[0].Value.ToString());
                    bd.Asignarparametro("@IDPRODUCTO", SqlDbType.BigInt, DgDetallesFactura.Rows[i].Cells[1].Value.ToString());                 
                    bd.Asignarparametro("@DESCUENTO", SqlDbType.Int, DgDetallesFactura.Rows[i].Cells[2].Value.ToString());
                    bd.Asignarparametro("@CANTIDAD", SqlDbType.Int, DgDetallesFactura.Rows[i].Cells[3].Value.ToString());
                    int reg = 0;
                    reg = bd.Ejecutarcomando();
                    if (reg > 0)
                    {
                        guardar = true;
                        i++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                bd.Desconectar();
            }
            return guardar;
        }
        public bool GuardarControlFactura(TextBox Txtnofac, Label LblDocumento)
        {
            bool save = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO AUDITORIAFACTURA(NOFACTURA,NODOCUMENTO)VALUES(@NOFACTURA,@NODOCUMENTO)", CommandType.Text);
                bd.Asignarparametro("@NOFACTURA", SqlDbType.BigInt, Txtnofac.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, LblDocumento.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    save = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                bd.Desconectar();
            }
            return save;
        }

    }
}
