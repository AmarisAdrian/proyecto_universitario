using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
   public class ProductoProveedor
    {
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
        public string _CodInterno { get; set; }
        public string _Id { get; set; }
        public string _Nombre { get; set; }
        public string _Direccion { get; set; }
        public string _Telefono { get; set; }
        public string _Email { get; set; }
        public string _rut { get; set; }
        public string _NombreContacto { get; set; }
        public string _TelefonoContacto { get; set; }
        public string _EmailContacto { get; set; }
        public string _Departamento { get; set; }
        public string _Ciudad { get; set; }
        public string _Notas { get; set; }
        public string _Id_Producto { get; set; }
        public string _IdProveedor { get; set; }
        public string _IdCategoria{ get; set; }
        public string _IdUnidadProducto{ get; set; }
        public string _IdMarca { get; set; }
        public string _Descripcion { get; set; }
        public string _StockI  { get; set; }
        public string _StockA  { get; set; }
        public string _Iva { get; set; }
        public string _PrecioU { get; set; }
        public string _PrecioI { get; set; }
        public string _Mensaje { get; set; }
        public int _CodigoError { get; set; }

        public void ConsultarStock(DataGridView DgStock, TextBox TxtIdProducto)
        {
            CargarGrilla g = new CargarGrilla();
            DgStock.DataSource = null;
            g.Preparar("CONSULTARSTOCKID'" + TxtIdProducto.Text + " '");
            g.Cargar(DgStock);
        }
        public void ConsultarStock(DataGridView DgStock)
        {
            CargarGrilla g = new CargarGrilla();
            DgStock.DataSource = null;
            g.Preparar("CONSULTARSTOCKPRODUCTO");
            g.Cargar(DgStock);
        }
        public bool InsertarProveedor(TextBox TxtCodInterno, TextBox TxtIdProveedor, TextBox TxtNombre, TextBox TxtDireccion, TextBox TxtTelefono, TextBox TxtEmail, TextBox TxtRut, TextBox TxtNombreContacto, TextBox TxtTelContacto, TextBox TxtEmailContacto,ComboBox CmbDepartamento, TextBox TxtCiudad,RichTextBox RtNotas)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO PROVEEDOR(CODINTERNO,IDPROVEEDOR,NOMBRE,DIRECCION,TELEFONO,EMAIL,RUT,NOMBRECONTACTO,TELEFONOCONTACTO,EMAILCONTACTO,IDDEPARTAMENTO,CIUDAD,NOTAS)VALUES(@CODINTERNO,@IDPROVEEDOR,@NOMBRE,@DIRECCION,@TELEFONO,@EMAIL,@RUT,@NOMBRECONTACTO,@TELEFONOCONTACTO,@EMAILCONTACTO,@IDDEPARTAMENTO,@CIUDAD,@NOTAS)", CommandType.Text);
                bd.Asignarparametro("@CODINTERNO", SqlDbType.BigInt, TxtCodInterno.Text);
                bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.BigInt, TxtIdProveedor.Text);
                bd.Asignarparametro("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);
                bd.Asignarparametro("@DIRECCION", SqlDbType.VarChar, TxtDireccion.Text);
                bd.Asignarparametro("@TELEFONO", SqlDbType.BigInt,TxtTelefono.Text);
                bd.Asignarparametro("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
                bd.Asignarparametro("@RUT", SqlDbType.BigInt,TxtRut.Text);
                bd.Asignarparametro("@NOMBRECONTACTO", SqlDbType.VarChar, TxtNombreContacto.Text);
                bd.Asignarparametro("@TELEFONOCONTACTO", SqlDbType.BigInt,TxtTelContacto.Text);
                bd.Asignarparametro("@EMAILCONTACTO", SqlDbType.VarChar, TxtEmailContacto.Text);
                bd.Asignarparametro("@IDDEPARTAMENTO", SqlDbType.Int,CmbDepartamento.SelectedValue);
                bd.Asignarparametro("@CIUDAD", SqlDbType.VarChar, TxtCiudad.Text);
                bd.Asignarparametro("@NOTAS", SqlDbType.VarChar, RtNotas.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool EditarProveedor(TextBox TxtCodInterno, TextBox TxtIdProveedor, TextBox TxtNombre, TextBox TxtDireccion, TextBox TxtTelefono, TextBox TxtEmail, TextBox TxtRut, TextBox TxtNombreContacto, TextBox TxtTelContacto, TextBox TxtEmailContacto, ComboBox CmbDepartamento, TextBox TxtCiudad, RichTextBox RtNotas)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE PROVEEDOR SET [IDPROVEEDOR]=@IDPROVEEDOR,[NOMBRE]=@NOMBRE,[DIRECCION]=@DIRECCION,[TELEFONO]=@TELEFONO,[EMAIL]=@EMAIL,[RUT]=@RUT,[NOMBRECONTACTO]=@NOMBRECONTACTO,[TELEFONOCONTACTO]=@TELEFONOCONTACTO,[EMAILCONTACTO]=@EMAILCONTACTO,[IDDEPARTAMENTO]=@IDDEPARTAMENTO,[CIUDAD]=@CIUDAD,[NOTAS]=@NOTAS WHERE [CODINTERNO]=@CODINTERNO", CommandType.Text);
                bd.Asignarparametro("@CODINTERNO", SqlDbType.BigInt, TxtCodInterno.Text);
                bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.BigInt, TxtIdProveedor.Text);
                bd.Asignarparametro("@NOMBRE", SqlDbType.VarChar, TxtNombre.Text);
                bd.Asignarparametro("@DIRECCION", SqlDbType.VarChar, TxtDireccion.Text);
                bd.Asignarparametro("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.Asignarparametro("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
                bd.Asignarparametro("@RUT", SqlDbType.BigInt, TxtRut.Text);
                bd.Asignarparametro("@NOMBRECONTACTO", SqlDbType.VarChar, TxtNombreContacto.Text);
                bd.Asignarparametro("@TELEFONOCONTACTO", SqlDbType.BigInt, TxtTelContacto.Text);
                bd.Asignarparametro("@EMAILCONTACTO", SqlDbType.VarChar, TxtEmailContacto.Text);
                bd.Asignarparametro("@IDDEPARTAMENTO", SqlDbType.Int, CmbDepartamento.SelectedValue);
                bd.Asignarparametro("@CIUDAD", SqlDbType.VarChar, TxtCiudad.Text);
                bd.Asignarparametro("@NOTAS", SqlDbType.VarChar, RtNotas.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
      
        public bool ConsultarProveedor(TextBox TxtIdProveedor)
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT CODINTERNO,IDPROVEEDOR,NOMBRE,DIRECCION,TELEFONO,EMAIL,RUT,NOMBRECONTACTO,TELEFONOCONTACTO,EMAILCONTACTO,IDDEPARTAMENTO,CIUDAD,NOTAS FROM PROVEEDOR WHERE IDPROVEEDOR='" + TxtIdProveedor.Text + " '", CommandType.Text);
                bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.BigInt, TxtIdProveedor.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _CodInterno = Convert.ToString(dr["CODINTERNO"]);
                    _Id = Convert.ToString(dr["IDPROVEEDOR"]);
                    _Nombre = Convert.ToString(dr["NOMBRE"]);
                    _Direccion = Convert.ToString(dr["DIRECCION"]);
                    _Telefono = Convert.ToString(dr["TELEFONO"]);
                    _Email = Convert.ToString(dr["EMAIL"]);
                    _rut = Convert.ToString(dr["RUT"]);
                    _NombreContacto = Convert.ToString(dr["NOMBRECONTACTO"]);
                    _TelefonoContacto = Convert.ToString(dr["TELEFONOCONTACTO"]);
                    _EmailContacto = Convert.ToString(dr["EMAILCONTACTO"]);
                    _Departamento = Convert.ToString(dr["IDDEPARTAMENTO"]);
                    _Ciudad = Convert.ToString(dr["CIUDAD"]);
                    _Notas = Convert.ToString(dr["NOTAS"]);
                    Consultar = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool InsertarMarca(TextBox TxtIdMarca,TextBox TxtNombreMarca)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO MARCA(ID,NOMBRE)VALUES(@ID,@NOMBRE)", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.BigInt, TxtIdMarca.Text);
                bd.Asignarparametro("@NOMBRE", SqlDbType.VarChar, TxtNombreMarca.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool EditarMarca(TextBox TxtIdMarca, TextBox TxtNombreMarca)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE MARCA SET [ID]=@ID,[NOMBRE]=@NOMBRE WHERE [ID]=@ID", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.BigInt, TxtIdMarca.Text);
                bd.Asignarparametro("@NOMBRE", SqlDbType.VarChar, TxtNombreMarca.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool ConsultarMarca(TextBox TxtIdMarca)
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT NOMBRE FROM MARCA WHERE ID='" + TxtIdMarca.Text + " '", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.Int, TxtIdMarca.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _Nombre = Convert.ToString(dr["NOMBRE"]);
                    Consultar = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool InsertarCategoria(TextBox TxtIdcategoria, TextBox TxtNombreCategoria)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO CATEGORIA_PRODUCTO(ID,NOMBRE)VALUES(@ID,@NOMBRE)", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.BigInt, TxtIdcategoria.Text);
                bd.Asignarparametro("@NOMBRE", SqlDbType.VarChar, TxtNombreCategoria.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool EditarCategoria(TextBox TxtIdcategoria, TextBox TxtNombreCategoria)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE CATEGORIA_PRODUCTO SET [ID]=@ID,[NOMBRE]=@NOMBRE WHERE [ID]=@ID", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.BigInt, TxtIdcategoria.Text);
                bd.Asignarparametro("@NOMBRE", SqlDbType.VarChar, TxtNombreCategoria.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool Consultarcategoria(TextBox TxtIdcategoria)
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT NOMBRE FROM CATEGORIA_PRODUCTO WHERE ID='" + TxtIdcategoria.Text + " '", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.Int, TxtIdcategoria.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _Nombre = Convert.ToString(dr["NOMBRE"]);
                    Consultar = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool InsertarUnidad(TextBox TxtIdUnidad, TextBox TxtNombreUnidad)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO UNIDAD_PRODUCTO(ID,NOMBRE)VALUES(@ID,@NOMBRE)", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.BigInt, TxtIdUnidad.Text);
                bd.Asignarparametro("@NOMBRE", SqlDbType.VarChar, TxtNombreUnidad.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool EditarUnidadProducto(TextBox TxtIdUnidad, TextBox TxtNombreUnidad)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE UNIDAD_PRODUCTO SET [ID]=@ID,[NOMBRE]=@NOMBRE WHERE [ID]=@ID", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.BigInt, TxtIdUnidad.Text);
                bd.Asignarparametro("@NOMBRE", SqlDbType.VarChar, TxtNombreUnidad.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool ConsultarUnidadProducto(TextBox txtIdUnidad)
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT NOMBRE FROM UNIDAD_PRODUCTO WHERE ID='" + txtIdUnidad.Text + " '", CommandType.Text);
                bd.Asignarparametro("@ID", SqlDbType.Int, txtIdUnidad.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _Nombre = Convert.ToString(dr["NOMBRE"]);
                    Consultar = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool InsertarProducto(TextBox TxtCodInterno, TextBox TxtIdProducto, ComboBox CmbProveedor, ComboBox CmbCategoria, ComboBox CmbUnidad, ComboBox Cmbmarca, RichTextBox RtDescripcion, TextBox TxtStockInicial, TextBox TxtStockActual, TextBox TxtPrecioUnitario, TextBox TxtIva, TextBox TxtPrecioIva)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO PRODUCTO(CODINTERNO,IDPRODUCTO,IDPROVEEDOR,IDCATEGORIA,IDUNIDADPRODUCTO,IDMARCA,DESCRIPCION,STOCKINICIAL,STOCKACTUAL,PRECIOUNITARIO,IVA,PRECIOIVA)VALUES(@CODINTERNO,@IDPRODUCTO,@IDPROVEEDOR,@IDCATEGORIA,@IDUNIDADPRODUCTO,@IDMARCA,@DESCRIPCION,@STOCKINICIAL,@STOCKACTUAL,@PRECIOUNITARIO,@IVA,@PRECIOIVA)", CommandType.Text);
                bd.Asignarparametro("@CODINTERNO", SqlDbType.BigInt, TxtCodInterno.Text);
                bd.Asignarparametro("@IDPRODUCTO", SqlDbType.BigInt, TxtIdProducto.Text);
                bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.Int, CmbProveedor.SelectedValue);
                bd.Asignarparametro("@IDCATEGORIA", SqlDbType.Int, CmbCategoria.SelectedValue);
                bd.Asignarparametro("@IDUNIDADPRODUCTO", SqlDbType.Int, CmbUnidad.SelectedValue);
                bd.Asignarparametro("@IDMARCA", SqlDbType.Int, Cmbmarca.SelectedValue);
                bd.Asignarparametro("@DESCRIPCION", SqlDbType.VarChar, RtDescripcion.Text);
                bd.Asignarparametro("@STOCKINICIAL", SqlDbType.Int, TxtStockInicial.Text);
                bd.Asignarparametro("@STOCKACTUAL", SqlDbType.Int, TxtStockActual.Text);
                bd.Asignarparametro("@PRECIOUNITARIO", SqlDbType.Decimal, TxtPrecioUnitario.Text);
                bd.Asignarparametro("@IVA", SqlDbType.Int, TxtIva.Text);
                bd.Asignarparametro("@PRECIOIVA", SqlDbType.Decimal, TxtPrecioIva.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool EditarProducto(TextBox TxtCodInterno, TextBox TxtIdProducto, ComboBox CmbProveedor, ComboBox CmbCategoria, ComboBox CmbUnidad, ComboBox Cmbmarca, RichTextBox RtDescripcion, TextBox TxtStockInicial, TextBox TxtStockActual,TextBox TxtPrecioUnitario, TextBox TxtIva, TextBox TxtPrecioIva)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE PRODUCTO SET [IDPRODUCTO]=@IDPRODUCTO,[IDPROVEEDOR]=@IDPROVEEDOR,[IDCATEGORIA]=@IDCATEGORIA,[IDUNIDADPRODUCTO]=@IDUNIDADPRODUCTO,[IDMARCA]=@IDMARCA,[DESCRIPCION]=@DESCRIPCION,[STOCKINICIAL]=@STOCKINICIAL,[STOCKACTUAL]=@STOCKACTUAL,[PRECIOUNITARIO]=@PRECIOUNITARIO,[IVA]=@IVA,[PRECIOIVA]=@PRECIOIVA WHERE [CODINTERNO]=@CODINTERNO", CommandType.Text);
                bd.Asignarparametro("@CODINTERNO", SqlDbType.BigInt, TxtCodInterno.Text);
                bd.Asignarparametro("@IDPRODUCTO", SqlDbType.BigInt, TxtIdProducto.Text);
                bd.Asignarparametro("@IDPROVEEDOR", SqlDbType.Int, CmbProveedor.SelectedValue);
                bd.Asignarparametro("@IDCATEGORIA", SqlDbType.Int, CmbCategoria.SelectedValue);
                bd.Asignarparametro("@IDUNIDADPRODUCTO", SqlDbType.Int, CmbUnidad.SelectedValue);
                bd.Asignarparametro("@IDMARCA", SqlDbType.Int, Cmbmarca.SelectedValue);
                bd.Asignarparametro("@DESCRIPCION", SqlDbType.VarChar, RtDescripcion.Text);
                bd.Asignarparametro("@STOCKINICIAL", SqlDbType.Int, TxtStockInicial.Text);
                bd.Asignarparametro("@STOCKACTUAL", SqlDbType.Int, TxtStockActual.Text);
                bd.Asignarparametro("@PRECIOUNITARIO", SqlDbType.Decimal, TxtPrecioUnitario.Text);
                bd.Asignarparametro("@IVA", SqlDbType.Int, TxtIva.Text);
                bd.Asignarparametro("@PRECIOIVA", SqlDbType.Decimal, TxtPrecioIva.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool ConsultarProducto(TextBox TxtIdProducto)
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT CODINTERNO,IDPRODUCTO,IDPROVEEDOR,IDCATEGORIA,IDUNIDADPRODUCTO,IDMARCA,DESCRIPCION,STOCKINICIAL,STOCKACTUAL,PRECIOUNITARIO,IVA,PRECIOIVA FROM PRODUCTO WHERE IDPRODUCTO='" + TxtIdProducto.Text + " '", CommandType.Text);
                bd.Asignarparametro("@IDPRODUCTO", SqlDbType.BigInt, TxtIdProducto.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _CodInterno = Convert.ToString(dr["CODINTERNO"]);
                    _Id_Producto = Convert.ToString(dr["IDPRODUCTO"]);
                    _IdProveedor = Convert.ToString(dr["IDPROVEEDOR"]);
                    _IdCategoria = Convert.ToString(dr["IDCATEGORIA"]);
                    _IdUnidadProducto = Convert.ToString(dr["IDUNIDADPRODUCTO"]);
                    _IdMarca = Convert.ToString(dr["IDMARCA"]);
                    _Descripcion = Convert.ToString(dr["DESCRIPCION"]);
                    _StockI = Convert.ToString(dr["STOCKINICIAL"]);
                    _StockA = Convert.ToString(dr["STOCKACTUAL"]);
                    _PrecioU = Convert.ToString(dr["PRECIOUNITARIO"]);
                    _Iva = Convert.ToString(dr["IVA"]);
                    _PrecioI = Convert.ToString(dr["PRECIOIVA"]);
                    Consultar = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Consultar;
        }
        public bool ActualizarStock(Label TxtCodInterno, TextBox TxtStock)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE PRODUCTO SET [STOCKACTUAL]=@STOCKACTUAL WHERE [CODINTERNO]=@CODINTERNO", CommandType.Text);
                bd.Asignarparametro("@CODINTERNO", SqlDbType.BigInt, TxtCodInterno.Text);
                bd.Asignarparametro("@STOCKACTUAL", SqlDbType.BigInt, TxtStock.Text);
                int Reg = 0;
                Reg = bd.Ejecutarcomando();
                if (Reg > 0)
                {
                    Inserto = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
    }
}
