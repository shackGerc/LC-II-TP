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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LC_II_TP_PARTE_3.Presentacion
{
    public partial class frmReporteVentasVendedor : Form
    {
        public frmReporteVentasVendedor()
        {
            InitializeComponent();
        }

        private void frmReporteVentasVendedor_Load(object sender, EventArgs e)
        {
            dtpFechaInicial.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
            ActivarFechas();
        }
        private void ActivarFechas()
        {
            dtpFechaInicial.Enabled = checkFechas.Checked;
            dtpFechaFinal.Enabled = checkFechas.Checked;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();

            if (checkFechas.Checked)
            {
                parametros.Add(new Parametro("@fecha1", dtpFechaInicial.Value));
                parametros.Add(new Parametro("@fecha2", dtpFechaFinal.Value));
            }
            else
            {
                parametros.Add(new Parametro("@fecha1", "1/1/2000 00:00:00"));
                parametros.Add(new Parametro("@fecha2", DateTime.Now));
            }
            parametros.Add(new Parametro("@vendedor", tbxVendedor.Text));
            parametros.Add(new Parametro("@minimo", numVentasMinimas.Value));
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("pa_ventas_vendedor", parametros);

            rpvVentas.LocalReport.DataSources.Clear();
            rpvVentas.LocalReport.SetParameters(new ReportParameter[] { 
                new ReportParameter("FechaInicial", parametros[0].Valor.ToString()), 
                new ReportParameter("FechaFinal",   parametros[1].Valor.ToString()) });

            rpvVentas.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            rpvVentas.RefreshReport();
        }

        private void checkFechas_CheckedChanged(object sender, EventArgs e)
        {

            ActivarFechas();
        }
        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicial.Value >= dtpFechaFinal.Value.AddDays(-3))
            {
                dtpFechaInicial.Value = dtpFechaFinal.Value.AddDays(-3);
            }
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFinal.Value <= dtpFechaInicial.Value.AddDays(3))
            {
                dtpFechaFinal.Value = dtpFechaInicial.Value.AddDays(3);
            }
        }
    }
}
