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
    public partial class FrmOperador : Form
    {
        public FrmOperador()
        {
            InitializeComponent();
        }
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        Negocio.ProcesosTecnicos Cargar = new Negocio.ProcesosTecnicos();
        Negocio.Usuario Usuario = new Negocio.Usuario();
        public int _Codverificar = 0;
        private void FrmOperador_Load(object sender, EventArgs e)
        {
            Combos();
            CodInterno();
            Asignar();
        }
        private void Asignar()
        {

            BtnEditar.Visible = true;
            BtnBuscar.Visible = true;
            CmbRol.Enabled = true;
            Cver.Visible = true;

        }
        private void Combos()
        {
            try
            {
                Cargar.CargarComboGenero(CmbGenero);
                CmbGenero.SelectedIndex = -1;
                Cargar.CargarComboEstado(CmbEstado);
                CmbEstado.SelectedIndex = -1;
                Cargar.CargarComborRolusuario(CmbRol);
                CmbRol.SelectedIndex = -1;
                Cargar.CargarComborDepartamento(CmbDepartamento);
                CmbDepartamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CodInterno()
        {
            try
            {
                if (Cargar.ConsultarUltimoCodInterno())
                {
                    TxtCodInterno.Text = Cargar._UltimoCodInterno;
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
        private void Consultar()
        {
            try
            {
                if (Usuario.ConsultarUsuario(TxtDocumento))
                {
                    TxtCodInterno.Text = Usuario._CodInterno;
                    int cont = Convert.ToInt32(TxtCodInterno.Text);
                    TxtCodInterno.Text = string.Format("{0:000000000}", cont);
                    TxtPassword.Text = Usuario._Password;
                    TxtNombres.Text = Usuario._Nombres;
                    TxtApellidos.Text = Usuario._Apellidos;
                    CmbGenero.SelectedValue = Usuario._Genero;
                    CmbRol.SelectedValue = Usuario._RolUsuario;
                    CmbEstado.SelectedValue = Usuario._Estadousuario;
                    TxtMovil.Text = Usuario._Movil;
                    TxtTelefono.Text = Usuario._Telefono;
                    TxtEmail.Text = Usuario._Email;
                    CmbDepartamento.SelectedValue = Usuario._Departamento;
                    TxtCiudad.Text = Usuario._Ciudad;
                    TxtDireccion.Text = Usuario._Direccion;
                    Habilitar();
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Habilitar()
        {
            if (TxtDocumento.Text == "" || TxtPassword.Text == "" || TxtNombres.Text == "" || CmbRol.SelectedIndex == -1 || CmbGenero.SelectedIndex == -1 || CmbEstado.SelectedIndex == 1 || CmbDepartamento.SelectedIndex == -1)
            {
                BtnEditar.Enabled = false;
            }
            else
            {
                BtnEditar.Enabled = true;
            }
        }
        private void TxtCodInterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtDocumento.Text == "")
            {
                MessageBox.Show("Para consultar digite el documento", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Consultar();
            }
        }
        private void Cver_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = !Cver.Checked;
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosPersonales, ErrorNumeric) && Validar.ValidarCombo(GbDatosPersonales, ErrorNumeric))
                {
                    if (Validar.ValidarEmail(Convert.ToString(TxtEmail.Text)))
                    {
                        if (Usuario.EditarUsuario(TxtCodInterno, TxtDocumento, TxtPassword, TxtNombres, TxtApellidos, CmbGenero, CmbRol, CmbEstado, TxtMovil, TxtTelefono, TxtEmail, CmbDepartamento, TxtCiudad, TxtDireccion))
                        {
                            MessageBox.Show("Datos de usuario actualizado correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Validar.LimpiarCampos(this, GbDatosPersonales);
                            ErrorNumeric.Clear();
                            Combos();
                            CodInterno();
                        }
                        else if (Usuario._CodigoError == -2146232060)
                        {
                            MessageBox.Show(Usuario._Mensaje, "El usuario ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Formato de email incorrecto", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (Validar.ValidarTextbox(GbDatosPersonales, ErrorNumeric) && Validar.ValidarCombo(GbDatosPersonales, ErrorNumeric))
                {
                    if (Validar.ValidarEmail(Convert.ToString(TxtEmail.Text)))
                    {
                        if (Usuario.GuardarUsuario(TxtCodInterno, TxtDocumento, TxtPassword, TxtNombres, TxtApellidos, CmbGenero, CmbRol, CmbEstado, TxtMovil, TxtTelefono, TxtEmail, CmbDepartamento, TxtCiudad, TxtDireccion))
                        {
                            MessageBox.Show("Sus datos han sido guardados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Validar.LimpiarCampos(this, GbDatosPersonales);
                            ErrorNumeric.Clear();
                            Combos();
                            CodInterno();
                        }
                        else if (Usuario._CodigoError == -2146232060)
                        {
                            MessageBox.Show(Usuario._Mensaje, "El usuario ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Formato de email incorrecto", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Validar.LimpiarCampos(this, GbDatosPersonales);
            ErrorNumeric.Clear();
            CodInterno();
        }
    }
}
