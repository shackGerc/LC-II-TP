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
    public partial class frmReembolso : Form
    {
        public frmReembolso()
        {
            InitializeComponent();
        }

        private void frmReemboldo_Load(object sender, EventArgs e)
        {
            dtpFechaInicialReembolso.Value = DateTime.Now;
            dtpFechaFinalReembolso.Value = DateTime.Now;
            this.rpvReembolso.RefreshReport();
            this.rpvReembolso.RefreshReport();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Parametro> parametros = new List<Parametro>();
            if (ckbReembolso.Checked)
            {
                parametros.Add(new Parametro("@fecha1", dtpFechaInicialReembolso.Value));
                parametros.Add(new Parametro("@fecha2", dtpFechaFinalReembolso.Value));
            }
            else
            {
                parametros.Add(new Parametro("@fecha1", "1/1/2000 00:00:00"));
                parametros.Add(new Parametro("@fecha2", DateTime.Now));
            }
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaSQL("pa_reembolso_obrasocial", parametros);

            rpvReembolso.LocalReport.DataSources.Clear();
            rpvReembolso.LocalReport.SetParameters(new ReportParameter[] { new
            ReportParameter("FechaInicial", parametros[0].Valor.ToString()), 
                new ReportParameter("FechaFinal", parametros[1].Valor.ToString()) });

            rpvReembolso.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            rpvReembolso.RefreshReport();



        }

        private void dtpFechaInicialReembolso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ckbReembolso_CheckedChanged(object sender, EventArgs e)
        {
            activarFechas();
        }

        private void activarFechas()
        {
            dtpFechaInicialReembolso.Enabled = ckbReembolso.Checked;
            dtpFechaFinalReembolso.Enabled = ckbReembolso.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
