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
    public partial class frmReporteCubiertosVendidos : Form
    {
        public frmReporteCubiertosVendidos()
        {
            InitializeComponent();
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
            if (checkDescuento.Checked)
            {
                parametros.Add(new Parametro("@descuento1", numDescMin.Value));
                parametros.Add(new Parametro("@descuento2", numDescMax.Value));
            }
            else
            {
                parametros.Add(new Parametro("@descuento1", 0));
                parametros.Add(new Parametro("@descuento2", 100));
            }
            if (checkNoVendidos.Checked)
            {
                parametros.Add(new Parametro("@no_vendidos", 1));
            }
            else
            {
                parametros.Add(new Parametro("@no_vendidos", 0));
            }
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("pa_consultar_cubiertos_vendidos", parametros);

            rpvCompras.LocalReport.DataSources.Clear();
            rpvCompras.LocalReport.SetParameters(new ReportParameter[] { 
                new ReportParameter("FechaInicial", parametros[0].Valor.ToString()), 
                new ReportParameter("FechaFinal", parametros[1].Valor.ToString()),
                new ReportParameter("DescuentoMinimo", parametros[2].Valor.ToString()),
                new ReportParameter("DescuentoMaximo", parametros[3].Valor.ToString()),
                new ReportParameter("NoVendidos", ((int)parametros[4].Valor==1)? "Si":"No")
            });

            rpvCompras.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            rpvCompras.RefreshReport();
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
                MessageBox.Show("asasdasdasd");
            }
        }

        private void frmReporteCubiertos_Load(object sender, EventArgs e)
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

        private void numDescMin_ValueChanged(object sender, EventArgs e)
        {

            if (numDescMin.Value >= numDescMax.Value)
            {
                numDescMin.Value = numDescMax.Value-1;
            }
        }

        private void numDescMax_ValueChanged(object sender, EventArgs e)
        {
            if (numDescMax.Value <= numDescMin.Value)
            {
                numDescMax.Value = numDescMin.Value + 1;
            }
        }

        private void checkFechas_CheckedChanged(object sender, EventArgs e)
        {
            ActivarFechas();
        }

        private void checkNoVendidos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkDescuento_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
