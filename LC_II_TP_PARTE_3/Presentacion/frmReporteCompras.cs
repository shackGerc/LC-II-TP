using LC_II_TP_PARTE_3.AccesoDatos;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class frmReporteCompras : Form
    {
        public frmReporteCompras()
        {
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            dtpFechaInicial.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
            ActivarFechas();

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            if (checkBox1.Checked)
            {
                parametros.Add(new Parametro("@fecha1", dtpFechaInicial.Value));
                parametros.Add(new Parametro("@fecha2", dtpFechaFinal.Value));
            }
            else
            {
                parametros.Add(new Parametro("@fecha1", "1/1/2000 00:00:00"));
                parametros.Add(new Parametro("@fecha2", DateTime.Now));
            }
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("pa_consultar_compras", parametros);

            rpvCompras.LocalReport.DataSources.Clear();
            rpvCompras.LocalReport.SetParameters(new ReportParameter[] { new
            ReportParameter("FechaInicial", parametros[0].Valor.ToString()), new ReportParameter("FechaFinal",
            parametros[1].Valor.ToString()) });

            rpvCompras.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            rpvCompras.RefreshReport();
        }

        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFechaInicial.Value >= dtpFechaFinal.Value.AddDays(-3))
            {
                dtpFechaInicial.Value = dtpFechaFinal.Value.AddDays(-3);
            }
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFechaFinal.Value <= dtpFechaInicial.Value.AddDays(3))
            {
                dtpFechaFinal.Value = dtpFechaInicial.Value.AddDays(3);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ActivarFechas();
        }

        private void ActivarFechas()
        {
            dtpFechaInicial.Enabled = checkBox1.Checked;
            dtpFechaFinal.Enabled = checkBox1.Checked;
        }
    }
}
