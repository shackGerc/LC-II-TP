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

namespace LC_II_TP_PARTE_3.Presentacion
{
    public partial class formSucursales : Form
    {
        public formSucursales()
        {
            InitializeComponent();
        }

        private void formSucursales_Load(object sender, EventArgs e)
        {

            this.rpvSucursales.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("SP_SUCURSALES_REEMBOLSOS", parametros);

            rpvSucursales.LocalReport.DataSources.Clear();

            rpvSucursales.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            rpvSucursales.RefreshReport();
        }
    }
}
