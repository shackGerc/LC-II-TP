namespace LC_II_TP_PARTE_3.Presentacion
{
    partial class frmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.labelFechaInicial = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.rpvVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelFechas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.panelFechas);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 66);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(130, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Limitar por intervalo de fecha:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.labelFechaFinal.Click += new System.EventHandler(this.label2_Click);
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
            this.labelFechaInicial.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(406, 8);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 2;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(105, 8);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 1;
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
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
            this.btnGenerar.Location = new System.Drawing.Point(12, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 36);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // rpvVentas
            // 
            this.rpvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvVentas.LocalReport.ReportEmbeddedResource = "LC_II_TP_PARTE_3.Presentacion.Reportes.reporteVentas.rdlc";
            this.rpvVentas.Location = new System.Drawing.Point(12, 72);
            this.rpvVentas.Name = "rpvVentas";
            this.rpvVentas.ServerReport.BearerToken = null;
            this.rpvVentas.Size = new System.Drawing.Size(1091, 441);
            this.rpvVentas.TabIndex = 1;
            // 
            // panelFechas
            // 
            this.panelFechas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFechas.Controls.Add(this.dtpFechaFinal);
            this.panelFechas.Controls.Add(this.labelFechaFinal);
            this.panelFechas.Controls.Add(this.dtpFechaInicial);
            this.panelFechas.Controls.Add(this.labelFechaInicial);
            this.panelFechas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelFechas.Location = new System.Drawing.Point(341, 15);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(618, 36);
            this.panelFechas.TabIndex = 2;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 525);
            this.Controls.Add(this.rpvVentas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.Label labelFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Button btnGenerar;
        private Microsoft.Reporting.WinForms.ReportViewer rpvVentas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelFechas;
    }
}