using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentación
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        Negocio.Validaciones Validar = new Negocio.Validaciones();

        private void FrmLogin_Load(object sender, EventArgs e)
        {
 
        }
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumero(e);
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarLetraYnumero(e);
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Ingresar();
            }
        }
        private void Ingresar()
        {
            try
            {
                if (Validar.ValidarTextbox(GbDatos, ErrorVacio))
                {
                    if (Validar.ValidarLogin(TxtUsuario, TxtPass))
                    {
                        if (Validar._RolUsuario == 1 && Validar._Estadousuario == 1)
                        {
                            FrmInicio frm = new FrmInicio();
                            frm._NoDocumento = Validar._NoDocumento;
                            frm._Hora = DateTime.Now.ToShortTimeString();
                            frm._CodInterno = Validar._CodInterno;
                            frm.Visible = true;
                            this.Visible = false;
                        }
                        else if (Validar._RolUsuario == 1 && Validar._Estadousuario == 2)
                        {
                            LblMensaje.Text = "El usuario esta bloqueado";
                        }
                        if (Validar._RolUsuario == 2 && Validar._Estadousuario == 1)
                        {
                            FrmMainOperador frm = new FrmMainOperador();
                            frm._Documento = Validar._NoDocumento;
                            frm._Nombres = Validar._Nombres;
                            frm._Apellidos = Validar._Apellidos;
                            frm._CodInterno = Validar._CodInterno;
                            frm._Hora = DateTime.Now.ToShortTimeString();
                            frm.Visible = true;
                            this.Visible = false;
                        }
                        else if (Validar._RolUsuario == 2 && Validar._Estadousuario == 2)
                        {
                            LblMensaje.Text = "El usuario esta bloqueado";
                        }
                    }
                    else if (Validar._NoDocumento != TxtUsuario.Text && Validar._Password != TxtPass.Text)
                    {
                        LblMensaje.Text = "El usuario o la contraseña son incorrectas";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsuario.Text==""|| TxtPass.Text=="")
            {
                TxtPass.Clear();
                LblMensaje.Text = "";
            }
        }
        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" || TxtPass.Text == "")
            {
                LblMensaje.Text = "";
            }
        }
    }
}
