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
    public partial class frmreporteMasVentasSinRecetaQueCon : Form
    {
        public frmreporteMasVentasSinRecetaQueCon()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            if (txtAnio.Text != "")
            {
                parametros.Add(new Parametro("mes", cboMeses.SelectedIndex+1));
                parametros.Add(new Parametro("anio", int.Parse(txtAnio.Text)));

                DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("pa_consultar_clientes_mas_sin_receta_que_con", parametros);

                rtvResultado.LocalReport.DataSources.Clear();
                rtvResultado.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("Mes", parametros[0].Valor.ToString()),
                new ReportParameter("Anio",   parametros[1].Valor.ToString()) });

                rtvResultado.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                rtvResultado.RefreshReport();

            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN AÑO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmreporteMasVentasSinRecetaQueCon_Load(object sender, EventArgs e)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            cboMeses.DataSource = meses;
            cboMeses.SelectedIndex = DateTime.Now.Month -1;

            txtAnio.Text = Convert.ToString(DateTime.Now.Year);
        }
    }
}
