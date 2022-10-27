using LC_II_TP_PARTE_3.AccesoDatos;
using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteSumiClient : Form
    {
        public frmReporteSumiClient()
        {
            InitializeComponent();
        }

        private void frmReporteSumiClient_Load(object sender, EventArgs e)
        {

            this.rpvSumiClient.RefreshReport();
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nombre_sum", txtSuministro.Text));
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("SP_SUMI_CLIENTES", parametros);

            rpvSumiClient.LocalReport.DataSources.Clear();

            rpvSumiClient.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            rpvSumiClient.RefreshReport();
        }
    }
}
