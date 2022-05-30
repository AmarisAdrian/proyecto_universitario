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
    public partial class FrmPresentacion : Form
    {
        public FrmPresentacion()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            if (Barra.Value < 100)
            {
                Barra.Value = Barra.Value + 20;
                LblProgreso.Text = Convert.ToString(Barra.Value) + " % ";
                     
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                frm.Show();
            }
        }
        private void FrmPresentacion_Load(object sender, EventArgs e)
        {

        }
       
    }
}
