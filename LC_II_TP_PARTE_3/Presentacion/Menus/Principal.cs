using LC_II_TP_PARTE_3.Presentacion;
using LC_II_TP_PARTE_3.Presentacion.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LC_II_TP_PARTE_3
{
    public partial class frmPrincinpal : Form
    {
        bool sideBarExpandida;
        bool reportesMenuExpandido;
        public frmPrincinpal()
        {
            InitializeComponent();
        }

        private void SelectorBotones(bool selector)
        {
            this.btnSalir.Enabled =
                this.btnReportes.Enabled = selector;
        }

        private void frmPrincinpal_Load(object sender, EventArgs e)
        {
            sideBarExpandida = false;
            SelectorBotones(false);
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpandida)
            {
                flpSideBar.Width -= 10;

                if (flpSideBar.MinimumSize.Width == flpSideBar.Width)
                {
                    sideBarExpandida = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                flpSideBar.Width += 10;
                if(flpSideBar.MaximumSize.Width == flpSideBar.Width)
                {
                    sideBarExpandida = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void pbRetraerBarra_Click(object sender, EventArgs e)
        {
            pbRetraerBarra.Visible = false;
            pbExpandirBarra.Visible = true;
            SelectorBotones(false);
            if (reportesMenuExpandido)
            {
                ContenedorDeReportes.Height = ContenedorDeReportes.MinimumSize.Height;
                reportesMenuExpandido = false;

            }
            sideBarTimer.Start();
        }

        private void pbExpandirBarra_Click(object sender, EventArgs e)
        {
            pbRetraerBarra.Visible = true;
            pbExpandirBarra.Visible = false;
            SelectorBotones(true);
            sideBarTimer.Start();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            reportesTimer.Start();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que quiere salir de la aplicación?", "Salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void ReportesTimer_Tick(object sender, EventArgs e)
        {
            if (reportesMenuExpandido)
            {
                ContenedorDeReportes.Height -= 10;

                if(ContenedorDeReportes.MinimumSize.Height == ContenedorDeReportes.Height)
                {
                    reportesMenuExpandido = false;
                    reportesTimer.Stop();
                }
            }
            else
            {
                ContenedorDeReportes.Height += 10;
                if (ContenedorDeReportes.MaximumSize.Height == ContenedorDeReportes.Height)
                {
                    reportesMenuExpandido = true;
                    reportesTimer.Stop();
                }
            }
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            new frmVentasSubMenu().ShowDialog();
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            new frmComprasSubMenu().ShowDialog();
        }

        private void btnReporteRembolsos_Click(object sender, EventArgs e)
        {
            new frmRembolsosSubMenu().ShowDialog();
        }
    }
}