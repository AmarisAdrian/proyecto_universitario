using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class ProcesosTecnicos
    {
        public string _UltimoCodInterno { get; set; }
        public string _Iva { get; set; }
        public string _UltimoOrden { get; set; }
        public string _Documento { get; set; }
        public string _IdEstadoTicket { get; set; }
        public string _IdSoporteTicket { get; set; }
        public string _IdPrioridadTicket { get; set; }
        public string _Asunto { get; set; }
        public string _Descripcion { get; set; }
        public string _Fecha { get; set; }
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
        public void CargarComboGenero(ComboBox CmbGenero)
        {
            Negocio.CargarCombo Tipogenero = new Negocio.CargarCombo();
            Tipogenero.Cargar(CmbGenero, "SELECT ID ,NOMBRE FROM GENERO", "ID", "NOMBRE");
        }
        public void CargarComboEstado(ComboBox CmbEstado)
        {
            Negocio.CargarCombo Tipogenero = new Negocio.CargarCombo();
            Tipogenero.Cargar(CmbEstado, "SELECT ID ,NOMBRE FROM ESTADO_USUARIO", "ID", "NOMBRE");
        }
        public void CargarComborRolusuario(ComboBox CmbRolusuario)
        {
            Negocio.CargarCombo Tipogenero = new Negocio.CargarCombo();
            Tipogenero.Cargar(CmbRolusuario, "SELECT ID ,NOMBRE FROM ROL_USUARIO", "ID", "NOMBRE");
        }
        public void CargarComboProveedor(ComboBox CmbProveedor)
        {
            Negocio.CargarCombo Proveedor = new Negocio.CargarCombo();
            Proveedor.Cargar(CmbProveedor, "SELECT IDPROVEEDOR ,NOMBRE FROM PROVEEDOR", "IDPROVEEDOR", "NOMBRE");
        }
        public void CargarComboCategoria(ComboBox CmbCategoria)
        {
            Negocio.CargarCombo Categoria = new Negocio.CargarCombo();
            Categoria.Cargar(CmbCategoria, "SELECT ID ,NOMBRE FROM CATEGORIA_PRODUCTO", "ID", "NOMBRE");
        }
        public void CargarComboUnidad(ComboBox CmbUnidad)
        {
            Negocio.CargarCombo Unidad = new Negocio.CargarCombo();
            Unidad.Cargar(CmbUnidad, "SELECT ID ,NOMBRE FROM UNIDAD_PRODUCTO", "ID", "NOMBRE");
        }
        public void CargarComboMarca(ComboBox CmbMarca)
        {
            Negocio.CargarCombo Marca = new Negocio.CargarCombo();
            Marca.Cargar(CmbMarca, "SELECT ID ,NOMBRE FROM MARCA", "ID", "NOMBRE");
        }
        public void CargarComborDepartamento(ComboBox CmbDepartamento)
        {
            Negocio.CargarCombo Tipogenero = new Negocio.CargarCombo();
            Tipogenero.Cargar(CmbDepartamento, "SELECT ID ,NOMBRE FROM DEPARTAMENTOS", "ID", "NOMBRE");
        }
        public void CargarComboEstadoTicket(ComboBox CmbEstadoTicket)
        {
            Negocio.CargarCombo Tipogenero = new Negocio.CargarCombo();
            Tipogenero.Cargar(CmbEstadoTicket, "SELECT ID ,NOMBRE FROM ESTADOTICKET", "ID", "NOMBRE");
        }
        public void CargarComboSoporteTicket(ComboBox CmbSoporte)
        {
            Negocio.CargarCombo Tipogenero = new Negocio.CargarCombo();
            Tipogenero.Cargar(CmbSoporte, "SELECT ID ,NOMBRE FROM SOPORTETICKET", "ID", "NOMBRE");
        }
        public void CargarComboPrioridad(ComboBox CmbPrioridad)
        {
            Negocio.CargarCombo Tipogenero = new Negocio.CargarCombo();
            Tipogenero.Cargar(CmbPrioridad, "SELECT ID ,NOMBRE FROM PRIORIDADTICKET", "ID", "NOMBRE");
        }
        public void CargarComboClasificacion(ComboBox CmbClasificacion)
        {
            Negocio.CargarCombo Tipogenero = new Negocio.CargarCombo();
            Tipogenero.Cargar(CmbClasificacion, "SELECT ID ,NOMBRE FROM CLASIFICACIONTICKET", "ID", "NOMBRE");
        }
        public void ConsultarSesiones(DataGridView DgDetalles, TextBox TxtCodInterno)
        {
            CargarGrilla g = new CargarGrilla();
            DgDetalles.DataSource = null;
            g.Preparar("ULTIMASSESIONES'" + TxtCodInterno.Text + " '");
            g.Cargar(DgDetalles);
        }
        public void ConsultarTicketAbierto(DataGridView DgDetalles)
        {
            CargarGrilla g = new CargarGrilla();
            DgDetalles.DataSource = null;
            g.Preparar("BANDEJATICKET");
            g.Cargar(DgDetalles);
        }
        public void ConsultarTicket(DataGridView DgTicket, TextBox TxtDocumento)
        {
            CargarGrilla g = new CargarGrilla();
            DgTicket.DataSource = null;
            g.Preparar("TICKETS'" + TxtDocumento.Text + " '");
            g.Cargar(DgTicket);
        }
        public void VisualizarStock(DataGridView DgStock, TextBox TxtCantidad)
        {
            for (int i = 0; i < DgStock.Rows.Count; i++)
            {
                if (Convert.ToInt64(DgStock.Rows[i].Cells[9].Value.ToString()) <= Convert.ToInt64(TxtCantidad.Text))
                {
                    DgStock.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
                if (Convert.ToInt64(DgStock.Rows[i].Cells[9].Value.ToString()) >= Convert.ToInt64(TxtCantidad.Text))
                {
                    DgStock.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                }
            }
        }
        public void VisualizarTicket(DataGridView DgTicket)
        {
            for (int i = 0; i < DgTicket.Rows.Count; i++)
            {
                if (DgTicket.Rows[i].Cells[2].Value.ToString()=="ABIERTO")
                {
                    DgTicket.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                }
                if (DgTicket.Rows[i].Cells[2].Value.ToString()=="CERRADO")
                {
                    DgTicket.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }
        public bool ConsultarUltimoCodInterno()
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CODINTERNOUSUARIO", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoCodInterno = Convert.ToString(dr["CODINTERNO"]);
                    Consultar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool ConsultarCodInternoCliente()
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CODINTERNOCLIENTE", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoCodInterno = Convert.ToString(dr["CODINTERNO"]);
                    Consultar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool ConsultarCodInternoProveedor()
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CODINTERNOPROVEEDOR", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoCodInterno = Convert.ToString(dr["CODINTERNO"]);
                    Consultar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool ConsultarCodInternoProducto()
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CODINTERNOPRODUCTO", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoCodInterno = Convert.ToString(dr["CODINTERNO"]);
                    Consultar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool ConsultarCodInternoFactura()
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CODINTERNOFACTURA", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoCodInterno = Convert.ToString(dr["NOFACTURA"]);
                    Consultar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool ConsultarCodInternoIva()
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CONSULTARIVA", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _Iva = Convert.ToString(dr["IVA"]);
                    Consultar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool ConsultarOrdenTicket()
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("ULTIMAORDEN", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoOrden = Convert.ToString(dr["ORDEN"]);
                    Consultar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool GuardarOrden(TextBox TxtOrden, TextBox TxtDocumento, ComboBox CmbEstado, ComboBox CmbSoporte, ComboBox CmbPrioridad, ComboBox CmbClasificacion ,TextBox TxtAsunto, RichTextBox RMensaje, DateTime DtFecha)
        {
            bool Guardar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO TICKET (ORDEN,NODOCUMENTO,IDESTADOTICKET,IDSOPORTETICKET,IDPRIORIDADTICKET,IDCLASIFICACIONTICKET,ASUNTO,DESCRIPCION,FECHA)VALUES(@ORDEN,@NODOCUMENTO,@IDESTADOTICKET,@IDSOPORTETICKET,@IDPRIORIDADTICKET,@IDCLASIFICACIONTICKET,@ASUNTO,@DESCRIPCION,@FECHA) ", System.Data.CommandType.Text);
                bd.Asignarparametro("@ORDEN", SqlDbType.BigInt, TxtOrden.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocumento.Text);
                bd.Asignarparametro("@IDESTADOTICKET", SqlDbType.Int, CmbEstado.SelectedValue);
                bd.Asignarparametro("@IDSOPORTETICKET", SqlDbType.Int, CmbSoporte.SelectedValue);
                bd.Asignarparametro("@IDPRIORIDADTICKET", SqlDbType.Int, CmbPrioridad.SelectedValue);
                bd.Asignarparametro("@IDCLASIFICACIONTICKET", SqlDbType.Int, CmbClasificacion.SelectedValue);
                bd.Asignarparametro("@ASUNTO", SqlDbType.VarChar, TxtAsunto.Text);
                bd.Asignarparametro("@DESCRIPCION", SqlDbType.VarChar, RMensaje.Text);
                bd.Asignarparametro("@FECHA", SqlDbType.DateTime, DtFecha);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Guardar = true;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Guardar;
        }
        public bool ActualizarOrden(TextBox TxtOrden, ComboBox CmbEstado, ComboBox CmbSoporte, ComboBox CmbPrioridad)
        {
            bool Guardar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE TICKET SET [IDESTADOTICKET]=@IDESTADOTICKET,[IDSOPORTETICKET]=@IDSOPORTETICKET,[IDPRIORIDADTICKET]=@IDPRIORIDADTICKET WHERE [ORDEN]=@ORDEN", System.Data.CommandType.Text);
                bd.Asignarparametro("@ORDEN", SqlDbType.BigInt, TxtOrden.Text);
                bd.Asignarparametro("@IDESTADOTICKET", SqlDbType.BigInt, CmbEstado.SelectedValue);
                bd.Asignarparametro("@IDSOPORTETICKET", SqlDbType.BigInt, CmbSoporte.SelectedValue);
                bd.Asignarparametro("@IDPRIORIDADTICKET", SqlDbType.Int, CmbPrioridad.SelectedValue);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Guardar = true;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Guardar;
        }
        public bool ConsultarOrden(string TxtOrden)
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT * FROM TICKET WHERE ORDEN='" + TxtOrden + " '", CommandType.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoOrden = Convert.ToString(dr["ORDEN"]);
                    _Documento = Convert.ToString(dr["NODOCUMENTO"]);
                    _IdEstadoTicket = Convert.ToString(dr["IDESTADOTICKET"]);
                    _IdSoporteTicket = Convert.ToString(dr["IDSOPORTETICKET"]);
                    _IdPrioridadTicket = Convert.ToString(dr["IDPRIORIDADTICKET"]);
                    _Asunto = Convert.ToString(dr["ASUNTO"]);
                    _Descripcion = Convert.ToString(dr["DESCRIPCION"]);
                    _Fecha= Convert.ToString(dr["FECHA"]);
                    Consultar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
         }
    }
}
