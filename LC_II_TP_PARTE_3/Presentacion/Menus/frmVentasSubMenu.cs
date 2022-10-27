using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LC_II_TP_PARTE_3.Presentacion.Menus
{
    public partial class frmVentasSubMenu : Form
    {
        string[] reportes = { "Ventas totales", "Suministros cubiertos vendidos", "Ventas por vendedor", "Suministros por cliente",
        "Ventas por cliente", "Clientes con mas ventas sin más receta que con receta"};
        public frmVentasSubMenu()
        {
            InitializeComponent();
        }

        private void lstOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstOpciones.SelectedIndex;
            if( i!= -1)
            {
                switch (i)
                {
                    case 0:
                        new frmReporteVentas().ShowDialog();
                        lstOpciones.SelectedIndex = -1;
                        break;
                    case 1:
                        new frmReporteCubiertosVendidos().ShowDialog();
                        lstOpciones.SelectedIndex = -1;
                        break;
                    case 2:
                        new frmReporteVentasVendedor().ShowDialog();
                        lstOpciones.SelectedIndex = -1;
                        break;
                    case 3:
                        new frmReporteSumiClient().ShowDialog();
                        lstOpciones.SelectedIndex = -1;
                        break;
                    case 4:
                        new frmComprasXClienteYmes().ShowDialog();
                        lstOpciones.SelectedIndex = -1;
                        break;
                    case 5:
                        new frmreporteMasVentasSinRecetaQueCon().ShowDialog();
                        lstOpciones.SelectedIndex = -1;
                        break;
                }
            }

        }

        private void frmVentasSubMenu_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < reportes.Length; i++)
            {
                lstOpciones.Items.Add(reportes[i]);
            }
        }
    }
}
