using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfrmFrontTest
{
    public partial class Form1 : Form
    {
        bool sideBarExpand = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                PbExpand.Visible = false;
                PbNotExpand.Visible = true;
            }
            else
            {
                PbNotExpand.Visible = false;
                PbExpand.Visible = true;
            }
            SideBarTimer.Start();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.MinimumSize.Width == sideBar.Width)
                {
                    sideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.MaximumSize.Width == sideBar.Width)
                {
                    sideBarExpand = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void PbNotExpand_Click(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                PbExpand.Visible = false;
                PbNotExpand.Visible = true;
            }
            else
            {
                PbNotExpand.Visible = false;
                PbExpand.Visible = true;
            }
            SideBarTimer.Start();
        }
    }
}
