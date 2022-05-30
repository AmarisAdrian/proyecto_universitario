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
    public partial class FrmCerrarSesion : Form
    {
        public FrmCerrarSesion()
        {
            InitializeComponent();
        }
        public string _EnviarCodInterno;
        public string _EnviarHoraInicio;
        public string _EnviarHoraFin;
        string CodInterno, HoraI, Horaf;
        Negocio.Validaciones Validar = new Negocio.Validaciones();
        private void FrmCerrarSesion_Load(object sender, EventArgs e)
        {
            AsignarId();
            AsignarNuevoId();
            GuardarDatos();
        }
        private void AsignarId()
        {
            try
            {
                if (Validar.ValidarIdCierreSesion())
                {
      
                        LblRegistro.Text = Validar._UltimoIdControl;
                        int cont = Convert.ToInt32(LblRegistro.Text);
                        cont = cont + 1;
                        LblRegistro.Text = Convert.ToString(cont);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido el siguiente error");
            }
        }
        private void AsignarNuevoId()
        {
            try
            {
                CodInterno = _EnviarCodInterno;
                HoraI = _EnviarHoraInicio;
                Horaf = _EnviarHoraFin;
                DateTime horai = Convert.ToDateTime(HoraI);
                DateTime horaf = Convert.ToDateTime(Horaf);
                HoraI = horai.ToString("HH:mm");
                Horaf = horaf.ToString("HH:mm");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CargarBarra()
        {
            bool CargarBarra = false;
            int i = 0;
            PbCargarBarra.Maximum = 100;
            PbCargarBarra.Minimum = 0;
            PbCargarBarra.Value = 0;
            PbCargarBarra.Step = 1;
            for (i = PbCargarBarra.Minimum; i < PbCargarBarra.Maximum; i = i + PbCargarBarra.Step)
            {
                PbCargarBarra.PerformStep();
            }
            CargarBarra = true;
            return CargarBarra;
        }
        private void GuardarDatos()
        {
            FrmLogin frm = new FrmLogin();
            LblEstado.Text = "Estado:Guardando ....";
            try
            {
                if (CargarBarra())
                {

                    if (Validar.ValidarCierreSesion(LblRegistro, Convert.ToString(CodInterno), Convert.ToString(HoraI), Convert.ToString(Horaf), DtFecha.Value))
                    {
                        LblEstado.ForeColor = Color.Green;
                        LblEstado.Text = "Estado:Guardado";
                    }
                    else
                    {
                        LblEstado.ForeColor = Color.Red;
                        LblEstado.Text = "Estado: Error al guardar los datos";
                    }

                }
            }
            catch (Exception)
            {
                PbCargarBarra.BackColor = Color.Red;
                LblEstado.Text = "Estado: no se pudo guardar archivos" ;
            }
            this.Close();
            frm.Visible = true;
        }
    }
}
