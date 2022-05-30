using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using AccesoDatos;

namespace Negocio
{
   public class Usuario
    {
        
        public string _CodInterno { get; set; }
        public string _NoDocumento{ get; set; }
        public string _Password   { get; set; }
        public string _Nombres    { get; set; }
        public string _Apellidos  { get; set; }
        public string _Genero     { get; set; }
        public string _RolUsuario { get; set; }
        public string _Estadousuario { get; set; }
        public string _Movil      { get; set; }
        public string _Telefono   { get; set; }
        public string _Email      { get; set; }
        public string _Departamento { get; set; }
        public string _Ciudad     { get; set; }
        public string _Direccion  { get; set; }
        public string _Mensaje { get; set; }
        public int _CodigoError { get; set; }

        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
        public bool GuardarUsuario(TextBox TxtCodInterno,TextBox TxtDocumento, TextBox TxtPassword, TextBox TxtNombres, TextBox TxtApellidos, ComboBox CmbGenero, ComboBox CmbRol, ComboBox CmbEstadoUsuario, TextBox TxtMovil, TextBox TxtTelefono, TextBox TxtEmail, ComboBox CmbDepartamento, TextBox TxtCiudad, TextBox TxtDireccion)
        {
            bool Guardar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO USUARIO (CODINTERNO,NODOCUMENTO,PASSWORD,NOMBRES,APELLIDOS,IDGENERO,IDROLUSUARIO,IDESTADOUSUARIO,MOVIL,TELEFONO,EMAIL,IDDEPARTAMENTO,CIUDAD,DIRECCION)VALUES(@CODINTERNO,@NODOCUMENTO,@PASSWORD,@NOMBRES,@APELLIDOS,@IDGENERO,@IDROLUSUARIO,@IDESTADOUSUARIO,@MOVIL,@TELEFONO,@EMAIL,@IDDEPARTAMENTO,@CIUDAD,@DIRECCION) ", System.Data.CommandType.Text);
                bd.Asignarparametro("@CODINTERNO", SqlDbType.BigInt, TxtCodInterno.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocumento.Text);
                bd.Asignarparametro("@PASSWORD", SqlDbType.VarChar, TxtPassword.Text);
                bd.Asignarparametro("@NOMBRES", SqlDbType.VarChar, TxtNombres.Text);
                bd.Asignarparametro("@APELLIDOS", SqlDbType.VarChar, TxtApellidos.Text);
                bd.Asignarparametro("@IDGENERO", SqlDbType.Int, CmbGenero.SelectedValue);
                bd.Asignarparametro("@IDROLUSUARIO", SqlDbType.Int, CmbRol.SelectedValue);
                bd.Asignarparametro("@IDESTADOUSUARIO", SqlDbType.Int, CmbEstadoUsuario.SelectedValue);
                bd.Asignarparametro("@MOVIL", SqlDbType.BigInt, TxtMovil.Text);
                bd.Asignarparametro("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.Asignarparametro("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
                bd.Asignarparametro("@IDDEPARTAMENTO", SqlDbType.Int, CmbDepartamento.SelectedValue);
                bd.Asignarparametro("@CIUDAD", SqlDbType.VarChar, TxtCiudad.Text);
                bd.Asignarparametro("@DIRECCION", SqlDbType.VarChar, TxtDireccion.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Guardar = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }
               
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Guardar;
        }
        public bool EditarUsuario(TextBox TxtCodInterno,TextBox TxtDocumento,TextBox TxtPassword,TextBox TxtNombres,TextBox TxtApellidos,ComboBox CmbGenero,ComboBox CmbRol,ComboBox CmbEstadoUsuario,TextBox TxtMovil,TextBox TxtTelefono,TextBox TxtEmail,ComboBox CmbDepartamento,TextBox TxtCiudad,TextBox TxtDireccion)
        {
            bool Update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE USUARIO SET  [NODOCUMENTO]=@NODOCUMENTO,[PASSWORD]=@PASSWORD,[NOMBRES]=@NOMBRES,[APELLIDOS]=@APELLIDOS,[IDGENERO]=@IDGENERO,[IDROLUSUARIO]=@IDROLUSUARIO,[IDESTADOUSUARIO]=@IDESTADOUSUARIO,[MOVIL]=@MOVIL,[TELEFONO]=@TELEFONO,[EMAIL]=@EMAIL ,[IDDEPARTAMENTO]=@IDDEPARTAMENTO,[CIUDAD]=@CIUDAD,[DIRECCION]=@DIRECCION WHERE [CODINTERNO]=@CODINTERNO", System.Data.CommandType.Text);
                bd.Asignarparametro("@CODINTERNO", SqlDbType.BigInt, TxtCodInterno.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocumento.Text);
                bd.Asignarparametro("@PASSWORD", SqlDbType.VarChar, TxtPassword.Text);
                bd.Asignarparametro("@NOMBRES", SqlDbType.VarChar, TxtNombres.Text);
                bd.Asignarparametro("@APELLIDOS", SqlDbType.VarChar, TxtApellidos.Text);
                bd.Asignarparametro("@IDGENERO", SqlDbType.Int, CmbGenero.SelectedValue);
                bd.Asignarparametro("@IDROLUSUARIO", SqlDbType.Int, CmbRol.SelectedValue);
                bd.Asignarparametro("@IDESTADOUSUARIO", SqlDbType.Int, CmbEstadoUsuario.SelectedValue);
                bd.Asignarparametro("@MOVIL", SqlDbType.BigInt, TxtMovil.Text);
                bd.Asignarparametro("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.Asignarparametro("@EMAIL", SqlDbType.VarChar, TxtEmail.Text);
                bd.Asignarparametro("@IDDEPARTAMENTO", SqlDbType.Int, CmbDepartamento.SelectedValue);
                bd.Asignarparametro("@CIUDAD", SqlDbType.VarChar, TxtCiudad.Text);
                bd.Asignarparametro("@DIRECCION", SqlDbType.VarChar, TxtDireccion.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Update = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally {    bd.Desconectar();    }
            return Update;
        }
        public bool ConsultarUsuario(TextBox TxtDocumento)
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT CODINTERNO,NODOCUMENTO,PASSWORD,NOMBRES,APELLIDOS,IDGENERO,IDROLUSUARIO,IDESTADOUSUARIO,MOVIL,TELEFONO,EMAIL,IDDEPARTAMENTO,CIUDAD,DIRECCION FROM USUARIO WHERE NODOCUMENTO='" + TxtDocumento.Text + " '", CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocumento.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _CodInterno = Convert.ToString(dr["CODINTERNO"]);
                    _NoDocumento = Convert.ToString(dr["NODOCUMENTO"]);
                    _Password = Convert.ToString(dr["PASSWORD"]);
                    _Nombres = Convert.ToString(dr["NOMBRES"]);
                    _Apellidos = Convert.ToString(dr["APELLIDOS"]);
                    _Genero = Convert.ToString(dr["IDGENERO"]);
                    _RolUsuario = Convert.ToString(dr["IDROLUSUARIO"]);
                    _Estadousuario = Convert.ToString(dr["IDESTADOUSUARIO"]);
                    _Movil = Convert.ToString(dr["MOVIL"]);
                    _Telefono = Convert.ToString(dr["TELEFONO"]);
                    _Email = Convert.ToString(dr["EMAIL"]);
                    _Departamento = Convert.ToString(dr["IDDEPARTAMENTO"]);
                    _Ciudad = Convert.ToString(dr["CIUDAD"]);
                    _Direccion = Convert.ToString(dr["DIRECCION"]);
                    Consultar = true;
                }
                else
                {
                    Consultar = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {  bd.Desconectar(); }
            return Consultar;
        }
        public bool GuardarCliente(TextBox TxtCodInterno, TextBox TxtDocumento,TextBox TxtNombres, TextBox TxtApellidos, ComboBox CmbGenero, TextBox TxtMovil, TextBox TxtTelefono, TextBox TxtCiudad, TextBox TxtDireccion)
        {
            bool Guardar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO CLIENTE (CODINTERNO,NODOCUMENTO,NOMBRES,APELLIDOS,IDGENERO,MOVIL,TELEFONO,CIUDAD,DIRECCION)VALUES(@CODINTERNO,@NODOCUMENTO,@NOMBRES,@APELLIDOS,@IDGENERO,@MOVIL,@TELEFONO,@CIUDAD,@DIRECCION) ", System.Data.CommandType.Text);
                bd.Asignarparametro("@CODINTERNO", SqlDbType.BigInt, TxtCodInterno.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocumento.Text);
                bd.Asignarparametro("@NOMBRES", SqlDbType.VarChar, TxtNombres.Text);
                bd.Asignarparametro("@APELLIDOS", SqlDbType.VarChar, TxtApellidos.Text);
                bd.Asignarparametro("@IDGENERO", SqlDbType.Int, CmbGenero.SelectedValue);
                bd.Asignarparametro("@MOVIL", SqlDbType.BigInt, TxtMovil.Text);
                bd.Asignarparametro("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.Asignarparametro("@CIUDAD", SqlDbType.VarChar, TxtCiudad.Text);
                bd.Asignarparametro("@DIRECCION", SqlDbType.VarChar, TxtDireccion.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Guardar = true;
                }
                else
                {
                    _Mensaje = BaseDatos.MsgBdError;
                    _CodigoError = BaseDatos.CodeBdError;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Guardar;
        }
        public bool EditarCliente(TextBox TxtCodInterno, TextBox TxtDocumento, TextBox TxtNombres, TextBox TxtApellidos, ComboBox CmbGenero, TextBox TxtMovil, TextBox TxtTelefono, TextBox TxtCiudad, TextBox TxtDireccion)
        {
            bool Update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("UPDATE CLIENTE SET [NODOCUMENTO]=@NODOCUMENTO,[NOMBRES]=@NOMBRES,[APELLIDOS]=@APELLIDOS,[IDGENERO]=@IDGENERO,[MOVIL]=@MOVIL,[TELEFONO]=@TELEFONO,[CIUDAD]=@CIUDAD,[DIRECCION]=@DIRECCION WHERE [CODINTERNO]=@CODINTERNO ", System.Data.CommandType.Text);
                bd.Asignarparametro("@CODINTERNO", SqlDbType.BigInt, TxtCodInterno.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocumento.Text);
                bd.Asignarparametro("@NOMBRES", SqlDbType.VarChar, TxtNombres.Text);
                bd.Asignarparametro("@APELLIDOS", SqlDbType.VarChar, TxtApellidos.Text);
                bd.Asignarparametro("@IDGENERO", SqlDbType.Int, CmbGenero.SelectedValue);
                bd.Asignarparametro("@MOVIL", SqlDbType.BigInt, TxtMovil.Text);
                bd.Asignarparametro("@TELEFONO", SqlDbType.BigInt, TxtTelefono.Text);
                bd.Asignarparametro("@CIUDAD", SqlDbType.VarChar, TxtCiudad.Text);
                bd.Asignarparametro("@DIRECCION", SqlDbType.VarChar, TxtDireccion.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Update = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Update;
        }
        public bool ConsultarCliente(TextBox TxtDocumento)
        {
            bool Consultar = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT CODINTERNO,NODOCUMENTO,NOMBRES,APELLIDOS,IDGENERO,IDGENERO,MOVIL,TELEFONO,CIUDAD,DIRECCION FROM CLIENTE WHERE NODOCUMENTO='" + TxtDocumento.Text + " '", CommandType.Text);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, TxtDocumento.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _CodInterno = Convert.ToString(dr["CODINTERNO"]);
                    _NoDocumento = Convert.ToString(dr["NODOCUMENTO"]);
                    _Nombres = Convert.ToString(dr["NOMBRES"]);
                    _Apellidos = Convert.ToString(dr["APELLIDOS"]);
                    _Genero = Convert.ToString(dr["IDGENERO"]);
                    _Movil = Convert.ToString(dr["MOVIL"]);
                    _Telefono = Convert.ToString(dr["TELEFONO"]);
                    _Ciudad = Convert.ToString(dr["CIUDAD"]);
                    _Direccion = Convert.ToString(dr["DIRECCION"]); ;
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
    }
}
