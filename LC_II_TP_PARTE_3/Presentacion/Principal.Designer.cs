namespace LC_II_TP_PARTE_3
{
    partial class frmPrincinpal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincinpal));
            this.flpSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbExpandirBarra = new System.Windows.Forms.PictureBox();
            this.pbRetraerBarra = new System.Windows.Forms.PictureBox();
            this.ContenedorDeReportes = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnReporteSuministros = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnReporteRembolsos = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReporteCompras = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReporteVentas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.reportesTimer = new System.Windows.Forms.Timer(this.components);
            this.flpSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandirBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetraerBarra)).BeginInit();
            this.ContenedorDeReportes.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // flpSideBar
            // 
            this.flpSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.flpSideBar.Controls.Add(this.panel1);
            this.flpSideBar.Controls.Add(this.ContenedorDeReportes);
            this.flpSideBar.Controls.Add(this.panel4);
            this.flpSideBar.Location = new System.Drawing.Point(-2, -3);
            this.flpSideBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpSideBar.MaximumSize = new System.Drawing.Size(153, 369);
            this.flpSideBar.MinimumSize = new System.Drawing.Size(54, 369);
            this.flpSideBar.Name = "flpSideBar";
            this.flpSideBar.Size = new System.Drawing.Size(153, 369);
            this.flpSideBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbExpandirBarra);
            this.panel1.Controls.Add(this.pbRetraerBarra);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 65);
            this.panel1.TabIndex = 2;
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(54, 13);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(50, 24);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(155, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 58);
            this.panel2.TabIndex = 3;
            // 
            // pbExpandirBarra
            // 
            this.pbExpandirBarra.Image = ((System.Drawing.Image)(resources.GetObject("pbExpandirBarra.Image")));
            this.pbExpandirBarra.Location = new System.Drawing.Point(8, 9);
            this.pbExpandirBarra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbExpandirBarra.Name = "pbExpandirBarra";
            this.pbExpandirBarra.Size = new System.Drawing.Size(32, 32);
            this.pbExpandirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExpandirBarra.TabIndex = 1;
            this.pbExpandirBarra.TabStop = false;
            this.pbExpandirBarra.Click += new System.EventHandler(this.pbExpandirBarra_Click);
            // 
            // pbRetraerBarra
            // 
            this.pbRetraerBarra.Image = ((System.Drawing.Image)(resources.GetObject("pbRetraerBarra.Image")));
            this.pbRetraerBarra.Location = new System.Drawing.Point(8, 9);
            this.pbRetraerBarra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRetraerBarra.Name = "pbRetraerBarra";
            this.pbRetraerBarra.Size = new System.Drawing.Size(32, 32);
            this.pbRetraerBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRetraerBarra.TabIndex = 0;
            this.pbRetraerBarra.TabStop = false;
            this.pbRetraerBarra.Click += new System.EventHandler(this.pbRetraerBarra_Click);
            // 
            // ContenedorDeReportes
            // 
            this.ContenedorDeReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.ContenedorDeReportes.Controls.Add(this.panel8);
            this.ContenedorDeReportes.Controls.Add(this.panel7);
            this.ContenedorDeReportes.Controls.Add(this.panel6);
            this.ContenedorDeReportes.Controls.Add(this.panel5);
            this.ContenedorDeReportes.Controls.Add(this.panel3);
            this.ContenedorDeReportes.Location = new System.Drawing.Point(3, 74);
            this.ContenedorDeReportes.MaximumSize = new System.Drawing.Size(149, 203);
            this.ContenedorDeReportes.MinimumSize = new System.Drawing.Size(150, 43);
            this.ContenedorDeReportes.Name = "ContenedorDeReportes";
            this.ContenedorDeReportes.Size = new System.Drawing.Size(150, 43);
            this.ContenedorDeReportes.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnReporteSuministros);
            this.panel8.Location = new System.Drawing.Point(0, 158);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(146, 30);
            this.panel8.TabIndex = 8;
            // 
            // btnReporteSuministros
            // 
            this.btnReporteSuministros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporteSuministros.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnReporteSuministros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteSuministros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteSuministros.ForeColor = System.Drawing.Color.White;
            this.btnReporteSuministros.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteSuministros.Image")));
            this.btnReporteSuministros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteSuministros.Location = new System.Drawing.Point(-26, -14);
            this.btnReporteSuministros.Name = "btnReporteSuministros";
            this.btnReporteSuministros.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnReporteSuministros.Size = new System.Drawing.Size(192, 58);
            this.btnReporteSuministros.TabIndex = 0;
            this.btnReporteSuministros.Text = "            Suministros";
            this.btnReporteSuministros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteSuministros.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnReporteRembolsos);
            this.panel7.Location = new System.Drawing.Point(0, 122);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(146, 30);
            this.panel7.TabIndex = 7;
            // 
            // btnReporteRembolsos
            // 
            this.btnReporteRembolsos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporteRembolsos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnReporteRembolsos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteRembolsos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteRembolsos.ForeColor = System.Drawing.Color.White;
            this.btnReporteRembolsos.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteRembolsos.Image")));
            this.btnReporteRembolsos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteRembolsos.Location = new System.Drawing.Point(-26, -14);
            this.btnReporteRembolsos.Name = "btnReporteRembolsos";
            this.btnReporteRembolsos.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnReporteRembolsos.Size = new System.Drawing.Size(192, 58);
            this.btnReporteRembolsos.TabIndex = 0;
            this.btnReporteRembolsos.Text = "            Rembolsos";
            this.btnReporteRembolsos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteRembolsos.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnReporteCompras);
            this.panel6.Location = new System.Drawing.Point(0, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(146, 30);
            this.panel6.TabIndex = 6;
            // 
            // btnReporteCompras
            // 
            this.btnReporteCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporteCompras.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnReporteCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCompras.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCompras.ForeColor = System.Drawing.Color.White;
            this.btnReporteCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteCompras.Image")));
            this.btnReporteCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteCompras.Location = new System.Drawing.Point(-26, -14);
            this.btnReporteCompras.Name = "btnReporteCompras";
            this.btnReporteCompras.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnReporteCompras.Size = new System.Drawing.Size(192, 58);
            this.btnReporteCompras.TabIndex = 0;
            this.btnReporteCompras.Text = "            Compras";
            this.btnReporteCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteCompras.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnReporteVentas);
            this.panel5.Location = new System.Drawing.Point(0, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 30);
            this.panel5.TabIndex = 5;
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporteVentas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteVentas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVentas.ForeColor = System.Drawing.Color.White;
            this.btnReporteVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteVentas.Image")));
            this.btnReporteVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteVentas.Location = new System.Drawing.Point(-26, -14);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnReporteVentas.Size = new System.Drawing.Size(192, 58);
            this.btnReporteVentas.TabIndex = 0;
            this.btnReporteVentas.Text = "            Ventas";
            this.btnReporteVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReportes);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 43);
            this.panel3.TabIndex = 4;
            // 
            // btnReportes
            // 
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(-26, -6);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(192, 58);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.Text = "            Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSalir);
            this.panel4.Location = new System.Drawing.Point(3, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 43);
            this.panel4.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(-26, -6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(192, 58);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "            Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbLogoPrincipal
            // 
            this.pbLogoPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoPrincipal.Image")));
            this.pbLogoPrincipal.Location = new System.Drawing.Point(228, 35);
            this.pbLogoPrincipal.Name = "pbLogoPrincipal";
            this.pbLogoPrincipal.Size = new System.Drawing.Size(300, 300);
            this.pbLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogoPrincipal.TabIndex = 1;
            this.pbLogoPrincipal.TabStop = false;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // reportesTimer
            // 
            this.reportesTimer.Interval = 10;
            this.reportesTimer.Tick += new System.EventHandler(this.ReportesTimer_Tick);
            // 
            // frmPrincinpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(602, 366);
            this.Controls.Add(this.pbLogoPrincipal);
            this.Controls.Add(this.flpSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincinpal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincinpal_Load);
            this.flpSideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandirBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetraerBarra)).EndInit();
            this.ContenedorDeReportes.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSideBar;
        private System.Windows.Forms.PictureBox pbLogoPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbRetraerBarra;
        private System.Windows.Forms.PictureBox pbExpandirBarra;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer reportesTimer;
        private System.Windows.Forms.Panel ContenedorDeReportes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnReporteVentas;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnReporteRembolsos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReporteCompras;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnReporteSuministros;
    }
}

