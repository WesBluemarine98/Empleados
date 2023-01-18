namespace Empleados
{
    partial class frmCaso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSusp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReso = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbResolucion = new System.Windows.Forms.ComboBox();
            this.cbSancion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.txtLeg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImpresion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Legajo:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(95, 23);
            this.txtBusqueda.MaxLength = 12;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarEmpleado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Empleado";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(201, 23);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(75, 21);
            this.btnBuscarEmpleado.TabIndex = 3;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPuesto);
            this.groupBox2.Controls.Add(this.txtSector);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSusp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtReso);
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Controls.Add(this.dtFecha);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbResolucion);
            this.groupBox2.Controls.Add(this.cbSancion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtApe);
            this.groupBox2.Controls.Add(this.txtNomb);
            this.groupBox2.Controls.Add(this.txtLeg);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Empleado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtSusp
            // 
            this.txtSusp.Location = new System.Drawing.Point(161, 155);
            this.txtSusp.Name = "txtSusp";
            this.txtSusp.Size = new System.Drawing.Size(28, 20);
            this.txtSusp.TabIndex = 18;
            this.txtSusp.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad de dias suspendidos:";
            // 
            // txtReso
            // 
            this.txtReso.Location = new System.Drawing.Point(130, 131);
            this.txtReso.Name = "txtReso";
            this.txtReso.Size = new System.Drawing.Size(158, 20);
            this.txtReso.TabIndex = 16;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(172, 103);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(127, 20);
            this.txtMotivo.TabIndex = 15;
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy-MM-dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(49, 179);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(84, 20);
            this.dtFecha.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fecha:";
            // 
            // cbResolucion
            // 
            this.cbResolucion.FormattingEnabled = true;
            this.cbResolucion.Items.AddRange(new object[] {
            "1",
            "﻿﻿2 ",
            "﻿﻿3",
            "﻿﻿4 ",
            "﻿﻿5",
            "﻿﻿6",
            "﻿﻿7",
            "﻿﻿8 ",
            "﻿﻿9 ",
            "﻿﻿﻿10 ",
            "﻿﻿11﻿ ",
            "﻿﻿﻿12 ",
            "999"});
            this.cbResolucion.Location = new System.Drawing.Point(70, 130);
            this.cbResolucion.Name = "cbResolucion";
            this.cbResolucion.Size = new System.Drawing.Size(54, 21);
            this.cbResolucion.TabIndex = 9;
            this.cbResolucion.SelectedIndexChanged += new System.EventHandler(this.cbResolucion_SelectedIndexChanged);
            // 
            // cbSancion
            // 
            this.cbSancion.FormattingEnabled = true;
            this.cbSancion.Items.AddRange(new object[] {
            "1  ",
            "﻿﻿2  ",
            "﻿﻿3  ",
            "﻿﻿4  ",
            "﻿5  ",
            "﻿﻿6  ",
            "﻿﻿7 ",
            "﻿﻿8 ",
            "﻿﻿9  ",
            "﻿﻿﻿10  ",
            "﻿﻿11  ﻿",
            "﻿﻿﻿12  ",
            "﻿﻿13﻿  ",
            "﻿﻿﻿14  ",
            "﻿﻿﻿15  ",
            "﻿﻿﻿16  "});
            this.cbSancion.Location = new System.Drawing.Point(118, 103);
            this.cbSancion.Name = "cbSancion";
            this.cbSancion.Size = new System.Drawing.Size(48, 21);
            this.cbSancion.TabIndex = 8;
            this.cbSancion.SelectedIndexChanged += new System.EventHandler(this.cbSancion_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Resolucion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Motivo de la sancion:";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(58, 72);
            this.txtApe.MaxLength = 16;
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(100, 20);
            this.txtApe.TabIndex = 5;
            // 
            // txtNomb
            // 
            this.txtNomb.Location = new System.Drawing.Point(58, 46);
            this.txtNomb.MaxLength = 20;
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(100, 20);
            this.txtNomb.TabIndex = 4;
            // 
            // txtLeg
            // 
            this.txtLeg.Location = new System.Drawing.Point(58, 20);
            this.txtLeg.MaxLength = 12;
            this.txtLeg.Name = "txtLeg";
            this.txtLeg.Size = new System.Drawing.Size(100, 20);
            this.txtLeg.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Legajo:";
            // 
            // btnImpresion
            // 
            this.btnImpresion.Location = new System.Drawing.Point(174, 337);
            this.btnImpresion.Name = "btnImpresion";
            this.btnImpresion.Size = new System.Drawing.Size(99, 23);
            this.btnImpresion.TabIndex = 5;
            this.btnImpresion.Text = "Imprimir Caso";
            this.btnImpresion.UseVisualStyleBackColor = true;
            this.btnImpresion.Click += new System.EventHandler(this.btnImpresion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sector:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Puesto:";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(246, 45);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(144, 20);
            this.txtSector.TabIndex = 21;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(246, 71);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(142, 20);
            this.txtPuesto.TabIndex = 22;
            // 
            // frmCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.btnImpresion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCaso";
            this.Text = "Generador de Sancion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.TextBox txtLeg;
        private System.Windows.Forms.Button btnImpresion;
        private System.Windows.Forms.ComboBox cbSancion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbResolucion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReso;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtSusp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }
}