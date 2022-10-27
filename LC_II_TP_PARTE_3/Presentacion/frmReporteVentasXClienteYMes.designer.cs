namespace LC_II_TP_PARTE_3.Presentacion
{
    partial class frmComprasXClienteYmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprasXClienteYmes));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTipoGeneracion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRBNS = new System.Windows.Forms.Panel();
            this.rbnPorCantVentas = new System.Windows.Forms.RadioButton();
            this.rbnPorCantSuministros = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.rpvVentasXClientesYMesTabla = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvVentasXClientesYMesGrafico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvVentasXClientesYMesGraficoSums = new Microsoft.Reporting.WinForms.ReportViewer();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRBNS.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(3, 9);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 36);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panelRBNS);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1115, 66);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 51);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTipoGeneracion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(119, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 51);
            this.panel2.TabIndex = 8;
            // 
            // cboTipoGeneracion
            // 
            this.cboTipoGeneracion.FormattingEnabled = true;
            this.cboTipoGeneracion.Location = new System.Drawing.Point(14, 27);
            this.cboTipoGeneracion.Name = "cboTipoGeneracion";
            this.cboTipoGeneracion.Size = new System.Drawing.Size(121, 21);
            this.cboTipoGeneracion.TabIndex = 7;
            this.cboTipoGeneracion.SelectedIndexChanged += new System.EventHandler(this.cboTipoGeneracion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Se va a generar:";
            // 
            // panelRBNS
            // 
            this.panelRBNS.Controls.Add(this.rbnPorCantVentas);
            this.panelRBNS.Controls.Add(this.rbnPorCantSuministros);
            this.panelRBNS.Location = new System.Drawing.Point(274, 3);
            this.panelRBNS.Name = "panelRBNS";
            this.panelRBNS.Size = new System.Drawing.Size(167, 63);
            this.panelRBNS.TabIndex = 11;
            this.panelRBNS.TabStop = true;
            this.panelRBNS.Visible = false;
            // 
            // rbnPorCantVentas
            // 
            this.rbnPorCantVentas.AutoSize = true;
            this.rbnPorCantVentas.ForeColor = System.Drawing.Color.White;
            this.rbnPorCantVentas.Location = new System.Drawing.Point(10, 12);
            this.rbnPorCantVentas.Name = "rbnPorCantVentas";
            this.rbnPorCantVentas.Size = new System.Drawing.Size(135, 17);
            this.rbnPorCantVentas.TabIndex = 9;
            this.rbnPorCantVentas.TabStop = true;
            this.rbnPorCantVentas.Text = "Por cantidad de ventas";
            this.rbnPorCantVentas.UseVisualStyleBackColor = true;
            // 
            // rbnPorCantSuministros
            // 
            this.rbnPorCantSuministros.AutoSize = true;
            this.rbnPorCantSuministros.ForeColor = System.Drawing.Color.White;
            this.rbnPorCantSuministros.Location = new System.Drawing.Point(10, 35);
            this.rbnPorCantSuministros.Name = "rbnPorCantSuministros";
            this.rbnPorCantSuministros.Size = new System.Drawing.Size(154, 17);
            this.rbnPorCantSuministros.TabIndex = 10;
            this.rbnPorCantSuministros.TabStop = true;
            this.rbnPorCantSuministros.Text = "Por cantidad de suministros";
            this.rbnPorCantSuministros.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtAnio);
            this.panel3.Location = new System.Drawing.Point(447, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 54);
            this.panel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Año";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(6, 27);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 12;
            this.txtAnio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rpvVentasXClientesYMesTabla
            // 
            this.rpvVentasXClientesYMesTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvVentasXClientesYMesTabla.LocalReport.ReportEmbeddedResource = "LC_II_TP_PARTE_3.Presentacion.Reportes.reporteVentasPorClienteYmesTabla.rdlc";
            this.rpvVentasXClientesYMesTabla.Location = new System.Drawing.Point(12, 72);
            this.rpvVentasXClientesYMesTabla.Name = "rpvVentasXClientesYMesTabla";
            this.rpvVentasXClientesYMesTabla.ServerReport.BearerToken = null;
            this.rpvVentasXClientesYMesTabla.Size = new System.Drawing.Size(1091, 441);
            this.rpvVentasXClientesYMesTabla.TabIndex = 3;
            this.rpvVentasXClientesYMesTabla.Visible = false;
            // 
            // rpvVentasXClientesYMesGrafico
            // 
            this.rpvVentasXClientesYMesGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvVentasXClientesYMesGrafico.LocalReport.ReportEmbeddedResource = "LC_II_TP_PARTE_3.Presentacion.Reportes.reporteVentasPorClienteYmesGrafico.rdlc";
            this.rpvVentasXClientesYMesGrafico.Location = new System.Drawing.Point(12, 72);
            this.rpvVentasXClientesYMesGrafico.Name = "rpvVentasXClientesYMesGrafico";
            this.rpvVentasXClientesYMesGrafico.ServerReport.BearerToken = null;
            this.rpvVentasXClientesYMesGrafico.Size = new System.Drawing.Size(1091, 441);
            this.rpvVentasXClientesYMesGrafico.TabIndex = 7;
            this.rpvVentasXClientesYMesGrafico.Visible = false;
            // 
            // rpvVentasXClientesYMesGraficoSums
            // 
            this.rpvVentasXClientesYMesGraficoSums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvVentasXClientesYMesGraficoSums.LocalReport.ReportEmbeddedResource = "LC_II_TP_PARTE_3.Presentacion.Reportes.reporteVentasPorClienteYmesGraficoSums.rdl" +
    "c";
            this.rpvVentasXClientesYMesGraficoSums.Location = new System.Drawing.Point(12, 72);
            this.rpvVentasXClientesYMesGraficoSums.Name = "rpvVentasXClientesYMesGraficoSums";
            this.rpvVentasXClientesYMesGraficoSums.ServerReport.BearerToken = null;
            this.rpvVentasXClientesYMesGraficoSums.Size = new System.Drawing.Size(1091, 441);
            this.rpvVentasXClientesYMesGraficoSums.TabIndex = 8;
            this.rpvVentasXClientesYMesGraficoSums.Visible = false;
            // 
            // frmComprasXClienteYmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 525);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rpvVentasXClientesYMesGrafico);
            this.Controls.Add(this.rpvVentasXClientesYMesTabla);
            this.Controls.Add(this.rpvVentasXClientesYMesGraficoSums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmComprasXClienteYmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas por clientes y mes";
            this.Load += new System.EventHandler(this.frmComprasXClienteYmes_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelRBNS.ResumeLayout(false);
            this.panelRBNS.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboTipoGeneracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRBNS;
        private System.Windows.Forms.RadioButton rbnPorCantVentas;
        private System.Windows.Forms.RadioButton rbnPorCantSuministros;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnio;
        private Microsoft.Reporting.WinForms.ReportViewer rpvVentasXClientesYMesTabla;
        private Microsoft.Reporting.WinForms.ReportViewer rpvVentasXClientesYMesGrafico;
        private Microsoft.Reporting.WinForms.ReportViewer rpvVentasXClientesYMesGraficoSums;
    }
}