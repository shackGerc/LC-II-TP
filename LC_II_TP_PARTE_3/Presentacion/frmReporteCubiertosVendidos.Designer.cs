namespace LC_II_TP_PARTE_3.Presentacion
{
    partial class frmReporteCubiertosVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCubiertosVendidos));
            this.rpvCompras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkNoVendidos = new System.Windows.Forms.CheckBox();
            this.checkDescuento = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numDescMax = new System.Windows.Forms.NumericUpDown();
            this.numDescMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkFechas = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDescMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDescMin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvCompras
            // 
            this.rpvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvCompras.LocalReport.ReportEmbeddedResource = "LC_II_TP_PARTE_3.Presentacion.Reportes.reporteCompras.rdlc";
            this.rpvCompras.Location = new System.Drawing.Point(12, 143);
            this.rpvCompras.Name = "rpvCompras";
            this.rpvCompras.ServerReport.BearerToken = null;
            this.rpvCompras.Size = new System.Drawing.Size(1070, 491);
            this.rpvCompras.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.checkNoVendidos);
            this.panel1.Controls.Add(this.checkDescuento);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.checkFechas);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 137);
            this.panel1.TabIndex = 2;
            // 
            // checkNoVendidos
            // 
            this.checkNoVendidos.AutoSize = true;
            this.checkNoVendidos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkNoVendidos.FlatAppearance.BorderSize = 0;
            this.checkNoVendidos.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNoVendidos.ForeColor = System.Drawing.Color.White;
            this.checkNoVendidos.Location = new System.Drawing.Point(127, 99);
            this.checkNoVendidos.Name = "checkNoVendidos";
            this.checkNoVendidos.Size = new System.Drawing.Size(157, 21);
            this.checkNoVendidos.TabIndex = 9;
            this.checkNoVendidos.Text = "Incluir nunca vendidos";
            this.checkNoVendidos.UseVisualStyleBackColor = true;
            // 
            // checkDescuento
            // 
            this.checkDescuento.AutoSize = true;
            this.checkDescuento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkDescuento.FlatAppearance.BorderSize = 0;
            this.checkDescuento.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDescuento.ForeColor = System.Drawing.Color.White;
            this.checkDescuento.Location = new System.Drawing.Point(127, 59);
            this.checkDescuento.Name = "checkDescuento";
            this.checkDescuento.Size = new System.Drawing.Size(207, 21);
            this.checkDescuento.TabIndex = 7;
            this.checkDescuento.Text = "Limitar por valor de descuento";
            this.checkDescuento.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numDescMax);
            this.panel3.Controls.Add(this.numDescMin);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(340, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 36);
            this.panel3.TabIndex = 8;
            // 
            // numDescMax
            // 
            this.numDescMax.Location = new System.Drawing.Point(416, 7);
            this.numDescMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDescMax.Name = "numDescMax";
            this.numDescMax.Size = new System.Drawing.Size(120, 20);
            this.numDescMax.TabIndex = 6;
            this.numDescMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDescMax.ValueChanged += new System.EventHandler(this.numDescMax_ValueChanged);
            // 
            // numDescMin
            // 
            this.numDescMin.Location = new System.Drawing.Point(141, 7);
            this.numDescMin.Name = "numDescMin";
            this.numDescMin.Size = new System.Drawing.Size(120, 20);
            this.numDescMin.TabIndex = 5;
            this.numDescMin.ValueChanged += new System.EventHandler(this.numDescMin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descuento Maximo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descuento Minimo:";
            // 
            // checkFechas
            // 
            this.checkFechas.AutoSize = true;
            this.checkFechas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkFechas.FlatAppearance.BorderSize = 0;
            this.checkFechas.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFechas.ForeColor = System.Drawing.Color.White;
            this.checkFechas.Location = new System.Drawing.Point(127, 17);
            this.checkFechas.Name = "checkFechas";
            this.checkFechas.Size = new System.Drawing.Size(253, 21);
            this.checkFechas.TabIndex = 5;
            this.checkFechas.Text = "Limitar por intervalo de fecha de venta";
            this.checkFechas.UseVisualStyleBackColor = true;
            this.checkFechas.CheckedChanged += new System.EventHandler(this.checkFechas_CheckedChanged);
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
            this.btnGenerar.Location = new System.Drawing.Point(12, 30);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 75);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpFechaFinal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpFechaInicial);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(386, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 36);
            this.panel2.TabIndex = 6;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(396, 8);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final:";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(93, 8);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 1;
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial:";
            // 
            // frmReporteCubiertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 646);
            this.Controls.Add(this.rpvCompras);
            this.Controls.Add(this.panel1);
            this.Name = "frmReporteCubiertos";
            this.Text = "frmReporteCubiertos";
            this.Load += new System.EventHandler(this.frmReporteCubiertos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDescMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDescMin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvCompras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkFechas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkNoVendidos;
        private System.Windows.Forms.CheckBox checkDescuento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numDescMax;
        private System.Windows.Forms.NumericUpDown numDescMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}