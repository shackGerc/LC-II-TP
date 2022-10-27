namespace LC_II_TP_PARTE_3.Presentacion
{
    partial class frmReporteVentasVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentasVendedor));
            this.rpvVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkFechas = new System.Windows.Forms.CheckBox();
            this.panelFechas = new System.Windows.Forms.Panel();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.labelFechaInicial = new System.Windows.Forms.Label();
            this.numVentasMinimas = new System.Windows.Forms.NumericUpDown();
            this.tbxVendedor = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVentasMinimas)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvVentas
            // 
            this.rpvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvVentas.LocalReport.ReportEmbeddedResource = "LC_II_TP_PARTE_3.Presentacion.Reportes.reporteVentasVendedor.rdlc";
            this.rpvVentas.Location = new System.Drawing.Point(13, 115);
            this.rpvVentas.Name = "rpvVentas";
            this.rpvVentas.ServerReport.BearerToken = null;
            this.rpvVentas.Size = new System.Drawing.Size(1073, 484);
            this.rpvVentas.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkFechas);
            this.panel1.Controls.Add(this.panelFechas);
            this.panel1.Controls.Add(this.numVentasMinimas);
            this.panel1.Controls.Add(this.tbxVendedor);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 108);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(650, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ventas minimas efectuadas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vendedor:";
            // 
            // checkFechas
            // 
            this.checkFechas.AutoSize = true;
            this.checkFechas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkFechas.FlatAppearance.BorderSize = 0;
            this.checkFechas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFechas.ForeColor = System.Drawing.Color.White;
            this.checkFechas.Location = new System.Drawing.Point(142, 58);
            this.checkFechas.Name = "checkFechas";
            this.checkFechas.Size = new System.Drawing.Size(202, 21);
            this.checkFechas.TabIndex = 7;
            this.checkFechas.Text = "Limitar por intervalo de fecha:";
            this.checkFechas.UseVisualStyleBackColor = true;
            this.checkFechas.CheckedChanged += new System.EventHandler(this.checkFechas_CheckedChanged);
            // 
            // panelFechas
            // 
            this.panelFechas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFechas.Controls.Add(this.dtpFechaFinal);
            this.panelFechas.Controls.Add(this.labelFechaFinal);
            this.panelFechas.Controls.Add(this.dtpFechaInicial);
            this.panelFechas.Controls.Add(this.labelFechaInicial);
            this.panelFechas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelFechas.Location = new System.Drawing.Point(349, 50);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(618, 36);
            this.panelFechas.TabIndex = 6;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(406, 8);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 2;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.labelFechaFinal.ForeColor = System.Drawing.Color.White;
            this.labelFechaFinal.Location = new System.Drawing.Point(321, 10);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(80, 17);
            this.labelFechaFinal.TabIndex = 4;
            this.labelFechaFinal.Text = "Fecha Final:";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(105, 8);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 1;
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
            // 
            // labelFechaInicial
            // 
            this.labelFechaInicial.AutoSize = true;
            this.labelFechaInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.labelFechaInicial.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.labelFechaInicial.ForeColor = System.Drawing.Color.White;
            this.labelFechaInicial.Location = new System.Drawing.Point(13, 10);
            this.labelFechaInicial.Name = "labelFechaInicial";
            this.labelFechaInicial.Size = new System.Drawing.Size(87, 17);
            this.labelFechaInicial.TabIndex = 3;
            this.labelFechaInicial.Text = "Fecha Inicial:";
            // 
            // numVentasMinimas
            // 
            this.numVentasMinimas.Location = new System.Drawing.Point(836, 24);
            this.numVentasMinimas.Name = "numVentasMinimas";
            this.numVentasMinimas.Size = new System.Drawing.Size(120, 20);
            this.numVentasMinimas.TabIndex = 2;
            // 
            // tbxVendedor
            // 
            this.tbxVendedor.Location = new System.Drawing.Point(216, 24);
            this.tbxVendedor.Name = "tbxVendedor";
            this.tbxVendedor.Size = new System.Drawing.Size(428, 20);
            this.tbxVendedor.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(12, 36);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 36);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmReporteVentasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 611);
            this.Controls.Add(this.rpvVentas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteVentasVendedor";
            this.Text = "Reporte de Ventas por Vendedor";
            this.Load += new System.EventHandler(this.frmReporteVentasVendedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVentasMinimas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numVentasMinimas;
        private System.Windows.Forms.TextBox tbxVendedor;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkFechas;
        private System.Windows.Forms.Panel panelFechas;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label labelFechaInicial;
    }
}