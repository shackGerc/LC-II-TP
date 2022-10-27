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
    public partial class frmComprasXClienteYmes : Form
    {
        public frmComprasXClienteYmes()
        {
            InitializeComponent();
        }

        private void frmComprasXClienteYmes_Load(object sender, EventArgs e)
        {
            string[] tipoSalida = { "Tabla", "Grafico" };
            cboTipoGeneracion.DataSource = tipoSalida;

            txtAnio.Text = Convert.ToString(DateTime.Now.Year);

            rpvVentasXClientesYMesTabla.Visible =
                rpvVentasXClientesYMesGrafico.Visible =
                rpvVentasXClientesYMesGraficoSums.Visible = false;
        }

        private void cboTipoGeneracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoGeneracion.SelectedIndex == 1)
                panelRBNS.Visible = true;
            else
                panelRBNS.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Control de datos ingresados como año, solo se permiten numeros
            int i = txtAnio.Text.Length;
            if (i != 0)
                if (char.IsControl(txtAnio.Text[i-1]) || char.IsSymbol(txtAnio.Text[i-1]) ||
                    char.IsLetter(txtAnio.Text[i-1]) ||
                    char.IsPunctuation(txtAnio.Text[i-1]))
                    {
                        txtAnio.Text = txtAnio.Text.Remove(i-1);
                    }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            rpvVentasXClientesYMesTabla.Visible =
             rpvVentasXClientesYMesGrafico.Visible =
                rpvVentasXClientesYMesGraficoSums.Visible = false;

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@anio", int.Parse(txtAnio.Text)));
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("pa_consutar_ventas_x_cliente_x_mes",
                parametros);

            if (cboTipoGeneracion.SelectedIndex == 0)
            {
                rpvVentasXClientesYMesTabla.Visible = true;

                rpvVentasXClientesYMesTabla.LocalReport.DataSources.Clear();
                rpvVentasXClientesYMesTabla.LocalReport.SetParameters(new ReportParameter[] {new ReportParameter("Anio",
                    parametros[0].Valor.ToString())});

                rpvVentasXClientesYMesTabla.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                rpvVentasXClientesYMesTabla.RefreshReport();
            }
            else
            {
                if (rbnPorCantVentas.Checked)
                {
                    rpvVentasXClientesYMesGrafico.Visible = true;

                    rpvVentasXClientesYMesGrafico.LocalReport.DataSources.Clear();
                    rpvVentasXClientesYMesGrafico.LocalReport.SetParameters(new ReportParameter[] {new ReportParameter("Anio",
                     parametros[0].Valor.ToString())});

                    rpvVentasXClientesYMesGrafico.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                    rpvVentasXClientesYMesGrafico.RefreshReport();
                }
                else
                {
                    rpvVentasXClientesYMesGraficoSums.Visible = true;

                    rpvVentasXClientesYMesGraficoSums.LocalReport.DataSources.Clear();
                    rpvVentasXClientesYMesGraficoSums.LocalReport.SetParameters(new ReportParameter[] {new ReportParameter("Anio",
                    parametros[0].Valor.ToString())});

                    rpvVentasXClientesYMesGraficoSums.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                    rpvVentasXClientesYMesGraficoSums.RefreshReport();
                }
            }
        }
    }
}
