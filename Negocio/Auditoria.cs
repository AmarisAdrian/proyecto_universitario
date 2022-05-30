using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class Auditoria
    {
        public void ConsultarSesiones(DataGridView DgSesiones, TextBox TxtDocumento)
        {
            CargarGrilla g = new CargarGrilla();
            DgSesiones.DataSource = null;
            g.Preparar("CONSULTARLOGIN'" + TxtDocumento.Text + " '");
            g.Cargar(DgSesiones);
        }
        public void ConsultarFactura(DataGridView Dgfactura, TextBox TxtDocumento)
        {
            CargarGrilla g = new CargarGrilla();
            Dgfactura.DataSource = null;
            g.Preparar("CONSULTARFACTURA'" + TxtDocumento.Text + " '");
            g.Cargar(Dgfactura);
        }
        public void ConsultarDetalleFactura(DataGridView DgSesiones, string Nofactura)
        {
            CargarGrilla g = new CargarGrilla();
            DgSesiones.DataSource = null;
            g.Preparar("CONSULTARDETALLEFACTURA'" + Nofactura + " '");
            g.Cargar(DgSesiones);
        }
        public void ConsultarFacturaCliente(DataGridView DgDatos, TextBox TxtDocumento)
        {
            CargarGrilla g = new CargarGrilla();
            DgDatos.DataSource = null;
            g.Preparar("SELECT * FROM FACTURA WHERE IDCLIENTE='" + TxtDocumento.Text + " '");
            g.Cargar(DgDatos);
        }
        public void ConsultarDatosCliente(DataGridView DgDatos, TextBox TxtDocumento)
        {
            CargarGrilla g = new CargarGrilla();
            DgDatos.DataSource = null;
            g.Preparar("SELECT * FROM CLIENTE WHERE NODOCUMENTO='" + TxtDocumento.Text + " '");
            g.Cargar(DgDatos);
        }

    }
}
