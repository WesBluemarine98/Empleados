namespace Empleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCarga = new System.Windows.Forms.ToolStripMenuItem();
            this.sancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarCasoDisciplinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.dgvCasos = new System.Windows.Forms.DataGridView();
            this.BtnCarga = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmpleados,
            this.sancionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuEmpleados
            // 
            this.mnuEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCarga});
            this.mnuEmpleados.Name = "mnuEmpleados";
            this.mnuEmpleados.Size = new System.Drawing.Size(77, 20);
            this.mnuEmpleados.Text = "Empleados";
            // 
            // mnuCarga
            // 
            this.mnuCarga.Name = "mnuCarga";
            this.mnuCarga.Size = new System.Drawing.Size(142, 22);
            this.mnuCarga.Text = "Cargar Datos";
            this.mnuCarga.Click += new System.EventHandler(this.mnuCarga_Click);
            // 
            // sancionesToolStripMenuItem
            // 
            this.sancionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarCasoDisciplinarioToolStripMenuItem});
            this.sancionesToolStripMenuItem.Name = "sancionesToolStripMenuItem";
            this.sancionesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sancionesToolStripMenuItem.Text = "Sanciones";
            // 
            // generarCasoDisciplinarioToolStripMenuItem
            // 
            this.generarCasoDisciplinarioToolStripMenuItem.Name = "generarCasoDisciplinarioToolStripMenuItem";
            this.generarCasoDisciplinarioToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.generarCasoDisciplinarioToolStripMenuItem.Text = "Generar Caso Disciplinario";
            this.generarCasoDisciplinarioToolStripMenuItem.Click += new System.EventHandler(this.generarCasoDisciplinarioToolStripMenuItem_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.Location = new System.Drawing.Point(914, 27);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(159, 30);
            this.BtnExportar.TabIndex = 6;
            this.BtnExportar.Text = "Exportar datos";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // dgvCasos
            // 
            this.dgvCasos.AllowUserToAddRows = false;
            this.dgvCasos.AllowUserToDeleteRows = false;
            this.dgvCasos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasos.Location = new System.Drawing.Point(12, 63);
            this.dgvCasos.Name = "dgvCasos";
            this.dgvCasos.ReadOnly = true;
            this.dgvCasos.RowHeadersWidth = 45;
            this.dgvCasos.Size = new System.Drawing.Size(1061, 495);
            this.dgvCasos.TabIndex = 4;
            // 
            // BtnCarga
            // 
            this.BtnCarga.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarga.Location = new System.Drawing.Point(12, 27);
            this.BtnCarga.Name = "BtnCarga";
            this.BtnCarga.Size = new System.Drawing.Size(159, 28);
            this.BtnCarga.TabIndex = 5;
            this.BtnCarga.Text = "Cargar datos";
            this.BtnCarga.UseVisualStyleBackColor = false;
            this.BtnCarga.Click += new System.EventHandler(this.BtnCarga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1187, 583);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvCasos);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.BtnCarga);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestor";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpleados;
        private System.Windows.Forms.ToolStripMenuItem mnuCarga;
        private System.Windows.Forms.ToolStripMenuItem sancionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarCasoDisciplinarioToolStripMenuItem;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.DataGridView dgvCasos;
        private System.Windows.Forms.Button BtnCarga;
    }
}

