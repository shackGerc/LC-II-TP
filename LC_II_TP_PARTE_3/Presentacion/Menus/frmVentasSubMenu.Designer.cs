﻿namespace LC_II_TP_PARTE_3.Presentacion.Menus
{
    partial class frmVentasSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasSubMenu));
            this.lstOpciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstOpciones
            // 
            this.lstOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.lstOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOpciones.ForeColor = System.Drawing.Color.White;
            this.lstOpciones.FormattingEnabled = true;
            this.lstOpciones.ItemHeight = 25;
            this.lstOpciones.Location = new System.Drawing.Point(40, 32);
            this.lstOpciones.Name = "lstOpciones";
            this.lstOpciones.Size = new System.Drawing.Size(526, 204);
            this.lstOpciones.TabIndex = 0;
            this.lstOpciones.SelectedIndexChanged += new System.EventHandler(this.lstOpciones_SelectedIndexChanged);
            // 
            // frmVentasSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(610, 268);
            this.Controls.Add(this.lstOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentasSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu ventas";
            this.Load += new System.EventHandler(this.frmVentasSubMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOpciones;
    }
}