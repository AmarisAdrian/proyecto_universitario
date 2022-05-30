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
    public partial class Proveedor : UserControl
    {
        public Proveedor()
        {
            InitializeComponent();
        }
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        Negocio.ProcesosTecnicos Cargar = new Negocio.ProcesosTecnicos();
        Negocio.ProductoProveedor Pro = new Negocio.ProductoProveedor();
        private void Proveedor_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Combos();
            CodInterno();
        }
        private void Combos()
        {
            try
            {
                Cargar.CargarComborDepartamento(CmbDepartamento);
                CmbDepartamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CodInterno()
        {
            try
            {
                if (Cargar.ConsultarCodInternoProveedor())
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
                if (Pro.ConsultarProveedor(TxtIdProveedor))
                {
                    TxtCodInterno.Text = Pro._CodInterno;
                    int cont = Convert.ToInt32(TxtCodInterno.Text);
                    TxtCodInterno.Text = string.Format("{0:000000000}", cont);
                    TxtNombre.Text = Pro._Nombre;
                    TxtDireccion.Text = Pro._Direccion;
                    TxtTelefono.Text = Pro._Telefono;
                    TxtEmail.Text = Pro._Email;
                    TxtRut.Text = Pro._rut;
                    TxtNombreContacto.Text = Pro._NombreContacto;
                    TxtTelContacto.Text = Pro._TelefonoContacto;
                    TxtEmailContacto.Text = Pro._EmailContacto;
                    CmbDepartamento.SelectedValue = Pro._Departamento;
                    TxtCiudad.Text = Pro._Ciudad;
                    RtNotas.Text = Pro._Notas;
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
        private void TxtIdProveedor_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            Validar.SoloNumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TxtIdProveedor.Text == "")
                {
                    MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorNumeric.SetError(TxtIdProveedor, "Si desea consultar , digite en este campo el numero de identidad");
                }
                else
                {
                    Consultar();
                    ErrorNumeric.Clear();
                }

            }
        }
        private void TxtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetra(e);
        }
        private void TxtDireccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtRut_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtNombreContacto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetra(e);
        }
        private void TxtTelContacto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtCiudad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void RtNotas_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtIdProveedor_TextChanged_1(object sender, EventArgs e)
        {
            if (TxtIdProveedor.Text == "")
            {
                Validar.LimpiarCampos(this, GbDatos);
                ErrorNumeric.Clear();
                Habilitar();
                RtNotas.Clear();
            }
            CodInterno();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtIdProveedor.Text == "")
            {
                MessageBox.Show(" Para consultar digite el documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorNumeric.SetError(TxtIdProveedor, "Si desea consultar , digite en este campo el numero de identidad");
            }
            else
            {
                Consultar();
                ErrorNumeric.Clear();
             
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Validar.LimpiarCampos(this, GbDatos);
            RtNotas.Clear();
            CodInterno();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatos, ErrorNumeric) && Validar.ValidarCombo(GbDatos, ErrorNumeric))
                {
                    if (Validar.ValidarEmail(Convert.ToString(TxtEmail.Text)))
                    {
                        if (Pro.InsertarProveedor(TxtCodInterno, TxtIdProveedor, TxtNombre, TxtDireccion, TxtTelefono, TxtEmail, TxtRut, TxtNombreContacto, TxtTelContacto, TxtEmailContacto, CmbDepartamento, TxtCiudad, RtNotas))
                        {
                            MessageBox.Show("Sus datos han sido guardados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Validar.LimpiarCampos(this, GbDatos);
                            ErrorNumeric.Clear();
                            RtNotas.Clear();
                            CodInterno();
                        }
                        else if (Pro._CodigoError == -2146232060)
                        {
                            MessageBox.Show(Pro._Mensaje, "El usuario ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatos, ErrorNumeric) && Validar.ValidarCombo(GbDatos, ErrorNumeric))
                {
                    if (Validar.ValidarEmail(Convert.ToString(TxtEmail.Text)))
                    {
                        if (Pro.EditarProveedor(TxtCodInterno, TxtIdProveedor, TxtNombre, TxtDireccion, TxtTelefono, TxtEmail, TxtRut, TxtNombreContacto, TxtTelContacto, TxtEmailContacto, CmbDepartamento, TxtCiudad, RtNotas))
                        {
                            MessageBox.Show("Sus datos han sido actualizados correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Validar.LimpiarCampos(this, GbDatos);
                            ErrorNumeric.Clear();
                            RtNotas.Clear();
                            CodInterno();
                        }
                        else if (Pro._CodigoError == -2146232060)
                        {
                            MessageBox.Show(Pro._Mensaje, "El usuario ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Habilitar()
        {
            if (TxtIdProveedor.Text==""||TxtNombre.Text==""||TxtTelefono.Text==""|| TxtNombreContacto.Text==""||TxtDireccion.Text=="" || CmbDepartamento.SelectedIndex==-1|| TxtCiudad.Text=="")
            {
                BtnEditar.Enabled = false;
            }
            else
            {
                BtnEditar.Enabled = true;
            }
        }

        private void GbDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
