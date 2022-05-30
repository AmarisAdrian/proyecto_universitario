using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;
using AccesoDatos;


namespace Negocio
{
    public class Validaciones
        
    {
        AccesoDatos.BaseDatos bd = new AccesoDatos.BaseDatos();
        public string _NoDocumento { get; set; }
        public string _Nombres { get; set; }
        public string _Apellidos { get; set; }
        public string _Password { get; set; }
        public int _RolUsuario { get; set; }
        public int _Estadousuario { get; set; }
        public string _UltimoIdControl { get; set; }
        public string _CodInterno{ get; set; }
        public void LimpiarCampos(Control control, GroupBox gb)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = -1;
                }
            }
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = -1;
                }
            }
        }
        public bool ValidarLetraYnumero(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return e.Handled;
        }
        public void SoloNumero(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                   if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                       if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void SoloLetra(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public bool ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }            
           }
            else
            {
                return false;
            }
        }
        public bool ValidarTextbox(GroupBox parent,ErrorProvider ErrorNumeric)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType().Equals(typeof(TextBox)))
                {
                    if (c.Text.Equals(string.Empty))
                    {
                        ErrorNumeric.SetError(c, "Este campo no puede ir vacio");
                        return false;
                    }
                }
                else
                {
                    ErrorNumeric.Clear();
                }
            }
            return true;
        }
        public bool ValidarCombo(GroupBox parent, ErrorProvider ErrorNumeric)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType().Equals(typeof(ComboBox)))
                {
                    if (c.Text.Equals(string.Empty))
                    {
                        ErrorNumeric.SetError(c, "Este campo no puede ir vacio");
                        return false;
                    }
                }
                else
                {
                    ErrorNumeric.Clear();
                }
            }
            return true;
        }
        public bool ValidarLogin(TextBox Txtcodigo, TextBox Txtpassword)
        {
            bool permitir = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("SELECT  CODINTERNO,NODOCUMENTO,NOMBRES,APELLIDOS,PASSWORD,IDESTADOUSUARIO,IDROLUSUARIO FROM USUARIO WHERE NODOCUMENTO='" + Txtcodigo.Text + " ' AND PASSWORD='" + Txtpassword.Text + "' ", CommandType.Text);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _CodInterno = Convert.ToString(dr["CODINTERNO"]);
                    _NoDocumento = Convert.ToString(dr["NODOCUMENTO"]);
                    _Nombres = Convert.ToString(dr["NOMBRES"]);
                    _Apellidos = Convert.ToString(dr["APELLIDOS"]);
                    _Password = Convert.ToString(dr["PASSWORD"]);
                    _RolUsuario = Convert.ToInt32(dr["IDROLUSUARIO"]);
                    _Estadousuario = Convert.ToInt32(dr["IDESTADOUSUARIO"]);
                     permitir = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return permitir;
        }
        public bool ValidarCierreSesion(Label LblRegistro,string CodInterno,string HoraI,string HoraF,DateTime DtFecha)
        {
            bool Inserto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("INSERT INTO AUDITORIALOGIN(ID,IDCODINTERNO,HORAINICIO,HORAFIN,FECHA)VALUES(@ID,@IDCODINTERNO,@HORAINICIO,@HORAFIN,@FECHA)", CommandType.Text);
                bd.Asignarparametro("@ID",SqlDbType.BigInt,LblRegistro.Text);
                bd.Asignarparametro("@IDCODINTERNO", SqlDbType.BigInt, CodInterno);
                bd.Asignarparametro("@HORAINICIO", SqlDbType.Time, HoraI);
                bd.Asignarparametro("@HORAFIN", SqlDbType.Time, HoraF);
                bd.Asignarparametro("@FECHA", SqlDbType.DateTime, DtFecha);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    Inserto = true;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally { bd.Desconectar(); }
            return Inserto;
        }
        public bool ValidarIdCierreSesion()
        {
            bool consulto = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CONTROLSESION", CommandType.StoredProcedure);
                SqlDataReader dr;
                dr = bd.EjecutarConsutaReader();
                if (dr.Read())
                {
                    _UltimoIdControl = Convert.ToString(dr["ID"]);
                    consulto = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return consulto;
          }
        public bool ValidarActualizarContraseña(string Documento, TextBox TxtConfirmar)
        {
            bool update = false;
            try
            {
                bd.Conectar();
                bd.CrearComando("CAMBIARPASSWORD", CommandType.StoredProcedure);
                bd.Asignarparametro("@NODOCUMENTO", SqlDbType.BigInt, Documento);
                bd.Asignarparametro("@PASSWORD", SqlDbType.VarChar, TxtConfirmar.Text);
                int reg = 0;
                reg = bd.Ejecutarcomando();
                if (reg > 0)
                {
                    update = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return update;
        }

    }
    }
