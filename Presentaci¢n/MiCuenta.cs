using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Presentación
{
    public partial class MiCuenta : UserControl
    {
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        Negocio.ProcesosTecnicos Procesos = new Negocio.ProcesosTecnicos();
        Negocio.Usuario usuario = new Negocio.Usuario();
        Negocio.ProcesosTecnicos Cargar = new Negocio.ProcesosTecnicos();
        public string _Documento;
        public string _CodInterno;
        public string _EnviarCodInterno;
        public string _Hora;
        public string _EnviarHoraI;
      
        string Pass;
        public MiCuenta()
        {
            InitializeComponent();
        }

        private void MiCuenta_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Combos();
            Consultar();
            Sesiones();
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
        private void Consultar()
        {
            try
            {
                TxtDocumento.Text = _Documento;
                LblHoraI.Text = _Hora;          
                if (usuario.ConsultarUsuario(TxtDocumento))
                {
                        TxtCodInterno.Text = usuario._CodInterno;
                        int cont = Convert.ToInt32(TxtCodInterno.Text);
                        TxtCodInterno.Text = string.Format("{0:000000000}", cont);
                        Pass = usuario._Password;
                        TxtNombres.Text = usuario._Nombres;
                        TxtApellidos.Text = usuario._Apellidos;
                        CmbGenero.SelectedValue = usuario._Genero;
                        CmbRol.SelectedValue = usuario._RolUsuario;
                        CmbEstado.SelectedValue = usuario._Estadousuario;
                        TxtMovil.Text = usuario._Movil;
                        TxtTelefono.Text = usuario._Telefono;
                        TxtEmail.Text = usuario._Email;
                        CmbDepartamento.SelectedValue = usuario._Departamento;
                        TxtCiudad.Text = usuario._Ciudad;
                        TxtDireccion.Text = usuario._Direccion;               
                }
                else
                {
                    DialogResult result = MessageBox.Show("El documento se ha actualizado.Para visualizar esta pagina es necesario volver a iniciar sesion ¿Desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                        this.Visible = false;

                    }
                    else
                    {
                        this.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
        private void Cbhabilitar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cbhabilitar.Checked)
            {
                TxtDocumento.Enabled = true;
            }
            else
            {
                TxtDocumento.Enabled = false;
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatosPersonales, ErrorNumeric) && Validar.ValidarCombo(GbDatosPersonales, ErrorNumeric))
                {
                    if (Validar.ValidarEmail(Convert.ToString(TxtEmail.Text)))
                    {
                        if (usuario.EditarUsuario(TxtCodInterno, TxtDocumento, TxtPassNew, TxtNombres, TxtApellidos, CmbGenero, CmbRol, CmbEstado, TxtMovil, TxtTelefono, TxtEmail, CmbDepartamento, TxtCiudad, TxtDireccion))
                        {
                            MessageBox.Show("Sus datos han sido actualizado correctamente", "Validacion de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Validar.LimpiarCampos(this, GbDatosPersonales);
                            Validar.LimpiarCampos(this, GbContraseña);
                            ErrorNumeric.Clear();
                            Consultar();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error", "validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void BtnCambiarContraseña_Click_1(object sender, EventArgs e)
        {
            if (Validar.ValidarTextbox(GbContraseña, ErrorNumeric))
            {
                if (TxtPassOld.Text != Convert.ToString(Pass))
                {
                    MessageBox.Show("Las contraseña no concuerdan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPassOld.Clear();
                    TxtPassNew.Clear();
                }
                else if (TxtPassOld.Text == Convert.ToString(Pass))
                {
                    if (Validar.ValidarActualizarContraseña(_Documento, TxtPassNew))
                    {
                        MessageBox.Show("Se ha actualizado su contraseña exitosamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtPassOld.Clear();
                        TxtPassNew.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la contraseña");
                        TxtPassOld.Clear();
                        TxtPassNew.Clear();
                    }
                }
            }
        }
        private void Sesiones()
        {
            try
            {
                Procesos.ConsultarSesiones(DgUltimasSesiones, TxtCodInterno);
                this.DgUltimasSesiones.RowsDefaultCellStyle.BackColor = Color.Red;
                this.DgUltimasSesiones.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Validar.LimpiarCampos(this, GbDatosPersonales);
            Validar.LimpiarCampos(this, GbContraseña);
            ErrorNumeric.Clear();
        }      
        private void TxtDocumento_TextChanged_1(object sender, EventArgs e)
        {
            TxtPassNew.Text = TxtDocumento.Text;
        }
        private void TxtDocumento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtNombres_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetra(e);
        }
        private void TxtApellidos_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetra(e);
        }
        private void TxtMovil_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void TxtCiudad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtDireccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtPassOld_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
        private void TxtPassNew_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
        }
    }
}
