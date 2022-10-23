using LC_II_TP_PARTE_3.AccesoDatos;
using LC_II_TP_PARTE_3.Presentacion.Reportes;
using LC_II_TP_PARTE_3.Presentacion.Reportes.DataSet1TableAdapters;
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
            DateTime fecha1,fecha2;
            if (checkBox1.Checked)
            {
                fecha1 = dtpFechaInicial.Value;
                fecha2 = dtpFechaFinal.Value;
            }
            else
            {
                fecha1 = DateTime.Parse("1/1/2000 00:00:00");
                fecha2 = DateTime.Now;
            }
            rpvVentas.LocalReport.SetParameters(new ReportParameter[] { new
            ReportParameter("FechaInicial", fecha1.ToString()), new ReportParameter("FechaFinal",
            fecha2.ToString()) });
            pa_consultar_comprasTableAdapter.Fill(dataSet1.pa_consultar_compras, fecha1, fecha2);

            rpvVentas.RefreshReport();
        }

        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFechaInicial.Value >= dtpFechaFinal.Value.AddDays(-30))
            {
                dtpFechaInicial.Value = dtpFechaFinal.Value.AddDays(-30);
            }
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFechaFinal.Value <= dtpFechaInicial.Value.AddDays(30))
            {
                dtpFechaFinal.Value = dtpFechaInicial.Value.AddDays(30);
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
