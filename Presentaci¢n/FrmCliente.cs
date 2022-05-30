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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        Negocio.ProcesosTecnicos Cargar = new Negocio.ProcesosTecnicos();
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        Negocio.Usuario Usuario = new Negocio.Usuario();
        private void CodInterno()
        {
            try
            {
                if (Cargar.ConsultarCodInternoCliente())
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
        private void Combos()
        {
            try
            {
                Cargar.CargarComboGenero(CmbGenero);
                CmbGenero.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Consultar()
        {
            try
            {
                if (TxtDocumento.Text == "")
                {
                    MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorNumeric.SetError(TxtDocumento, "Si desea consultar , digite en este campo el numero de identidad");
                }
                else if (Usuario.ConsultarCliente(TxtDocumento))
                {
                    TxtCodInterno.Text = Usuario._CodInterno;
                    int cont = Convert.ToInt32(TxtCodInterno.Text);
                    TxtCodInterno.Text = string.Format("{0:000000000}", cont);
                    TxtNombres.Text = Usuario._Nombres;
                    TxtApellidos.Text = Usuario._Apellidos;
                    CmbGenero.SelectedValue = Usuario._Genero;
                    TxtMovil.Text = Usuario._Movil;
                    TxtTelefono.Text = Usuario._Telefono;
                    TxtCiudad.Text = Usuario._Ciudad;
                    TxtDireccion.Text = Usuario._Direccion;
                    habilitar();

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
        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (Validar.ValidarTextbox(GbDatosPersonales, ErrorNumeric) && Validar.ValidarCombo(GbDatosPersonales, ErrorNumeric))
                {
                    if (Usuario.GuardarCliente(TxtCodInterno, TxtDocumento, TxtNombres, TxtApellidos, CmbGenero, TxtMovil, TxtTelefono, TxtCiudad, TxtDireccion))
                    {
                        MessageBox.Show("Sus datos han sido guardados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatosPersonales);
                        ErrorNumeric.Clear();
                        CodInterno();
                    }
                    else if (Usuario._CodigoError == -2146232060)
                    {
                        MessageBox.Show(Usuario._Mensaje, "El cliente ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosPersonales, ErrorNumeric) && Validar.ValidarCombo(GbDatosPersonales, ErrorNumeric))
                {
                    if (Usuario.EditarCliente(TxtCodInterno, TxtDocumento, TxtNombres, TxtApellidos, CmbGenero, TxtMovil, TxtTelefono, TxtCiudad, TxtDireccion))
                    {
                        MessageBox.Show("Sus datos han sido guardados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Validar.LimpiarCampos(this, GbDatosPersonales);
                        ErrorNumeric.Clear();
                        CodInterno();
                    }
                    else if (Usuario._CodigoError == -2146232060)
                    {
                        MessageBox.Show(Usuario._Mensaje, "El cliente ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Combos();
            CodInterno();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Validar.LimpiarCampos(this, GbDatosPersonales);
            ErrorNumeric.Clear();
            CodInterno();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtDocumento.Text == "")
            {
                MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorNumeric.SetError(TxtDocumento, "Si desea consultar , digite en este campo el numero de identidad");
            }
            else
            {
                Consultar();
                ErrorNumeric.Clear();
            }
        }

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetra(e);
        }
        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetra(e);
        }
        private void TxtMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }

        private void TxtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (TxtDocumento.Text == "")
            {
                Validar.LimpiarCampos(this, GbDatosPersonales);
                ErrorNumeric.Clear();
                CodInterno();
                habilitar();
            }
        }
        private void habilitar()
        {
            if (TxtDocumento.Text == "" || TxtNombres.Text == "" || CmbGenero.SelectedIndex == -1)
            {
                BtnEditar.Enabled = false;
            }
            else
            {
                BtnEditar.Enabled = true;
            }
        }
    }
}
