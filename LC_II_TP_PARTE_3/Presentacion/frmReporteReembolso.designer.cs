namespace LC_II_TP_PARTE_3.Presentacion
{
    partial class frmReembolso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReembolso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbReembolso = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFechaFinalReembolso = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicialReembolso = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvReembolso = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet11 = new LC_II_TP_PARTE_3.Presentacion.Reportes.DataSet1();
            this.dataSet12 = new LC_II_TP_PARTE_3.Presentacion.Reportes.DataSet1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.ckbReembolso);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 63);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ckbReembolso
            // 
            this.ckbReembolso.AutoSize = true;
            this.ckbReembolso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ckbReembolso.FlatAppearance.BorderSize = 0;
            this.ckbReembolso.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbReembolso.ForeColor = System.Drawing.Color.White;
            this.ckbReembolso.Location = new System.Drawing.Point(118, 20);
            this.ckbReembolso.Name = "ckbReembolso";
            this.ckbReembolso.Size = new System.Drawing.Size(199, 21);
            this.ckbReembolso.TabIndex = 5;
            this.ckbReembolso.Text = "Limitar por intervalo de fecha";
            this.ckbReembolso.UseVisualStyleBackColor = true;
            this.ckbReembolso.CheckedChanged += new System.EventHandler(this.ckbReembolso_CheckedChanged);
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
            this.btnGenerar.Location = new System.Drawing.Point(12, 13);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 36);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpFechaFinalReembolso);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpFechaInicialReembolso);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(332, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 36);
            this.panel2.TabIndex = 6;
            // 
            // dtpFechaFinalReembolso
            // 
            this.dtpFechaFinalReembolso.Location = new System.Drawing.Point(396, 8);
            this.dtpFechaFinalReembolso.Name = "dtpFechaFinalReembolso";
            this.dtpFechaFinalReembolso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinalReembolso.TabIndex = 2;
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
            // dtpFechaInicialReembolso
            // 
            this.dtpFechaInicialReembolso.Location = new System.Drawing.Point(99, 7);
            this.dtpFechaInicialReembolso.Name = "dtpFechaInicialReembolso";
            this.dtpFechaInicialReembolso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicialReembolso.TabIndex = 1;
            this.dtpFechaInicialReembolso.ValueChanged += new System.EventHandler(this.dtpFechaInicialReembolso_ValueChanged);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rpvReembolso
            // 
            this.rpvReembolso.LocalReport.ReportEmbeddedResource = "LC_II_TP_PARTE_3.Presentacion.Reportes.reporteReembolso.rdlc";
            this.rpvReembolso.Location = new System.Drawing.Point(12, 69);
            this.rpvReembolso.Name = "rpvReembolso";
            this.rpvReembolso.ServerReport.BearerToken = null;
            this.rpvReembolso.Size = new System.Drawing.Size(1085, 444);
            this.rpvReembolso.TabIndex = 2;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReembolso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 525);
            this.Controls.Add(this.rpvReembolso);
            this.Controls.Add(this.panel1);
            this.Name = "frmReembolso";
            this.Text = "Reporte Reembolso";
            this.Load += new System.EventHandler(this.frmReemboldo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbReembolso;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalReembolso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicialReembolso;
        private System.Windows.Forms.Label label1;
        private Reportes.DataSet1 dataSet11;
        private Reportes.DataSet1 dataSet12;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReembolso;
    }
}