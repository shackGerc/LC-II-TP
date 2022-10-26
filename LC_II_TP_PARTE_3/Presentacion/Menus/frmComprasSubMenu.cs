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
    public partial class frmComprasSubMenu : Form
    {
        string[] reportes = { "Compras totales", "Productos más comprados"};
        public frmComprasSubMenu()
        {
            InitializeComponent();
        }

        private void frmComprasSubMenu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < reportes.Length; i++)
            {
                lstOpciones.Items.Add(reportes[i]);
            }
        }

        private void lstOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstOpciones.SelectedIndex;
            if (i!= -1)
            {
                switch (i)
                {
                    case 0:
                        new frmReporteCompras().ShowDialog();
                        lstOpciones.SelectedIndex = -1;
                        break;
                    case 1:
                        //Productos más comprados

                        lstOpciones.SelectedIndex = -1;
                        break;
                }
            }
        }
    }
}
