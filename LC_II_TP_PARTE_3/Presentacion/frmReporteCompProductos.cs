using LC_II_TP_PARTE_3.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LC_II_TP_PARTE_3.Presentacion.Reportes
{
    public partial class frmReporteCompProductos : Form
    {
        public frmReporteCompProductos()
        {
            InitializeComponent();
        }

        private void frmReporteCompProductos_Load(object sender, EventArgs e)
        {

            this.rpvProducto.RefreshReport();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("pa_productos_fecha", parametros);
            rpvProducto.LocalReport.DataSources.Clear();
            rpvProducto.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            rpvProducto.RefreshReport();
        }
    }
}
