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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSusp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReso = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbResolucion = new System.Windows.Forms.ComboBox();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.txtLeg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImpresion = new System.Windows.Forms.Button();
            this.btnResoimpr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
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
            this.txtBusqueda.MaxLength = 99999999;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.groupBox2.Controls.Add(this.PbLogo);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtInfo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSusp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtReso);
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Controls.Add(this.dtFecha);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbResolucion);
            this.groupBox2.Controls.Add(this.cbMotivo);
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
            this.groupBox2.Size = new System.Drawing.Size(546, 343);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Empleado";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 223);
            this.txtInfo.MaxLength = 1500;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(522, 114);
            this.txtInfo.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Información Adicional:";
            // 
            // txtSusp
            // 
            this.txtSusp.Location = new System.Drawing.Point(161, 155);
            this.txtSusp.MaxLength = 365;
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
            this.txtReso.Location = new System.Drawing.Point(224, 130);
            this.txtReso.MaxLength = 35;
            this.txtReso.Name = "txtReso";
            this.txtReso.Size = new System.Drawing.Size(27, 20);
            this.txtReso.TabIndex = 16;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(305, 104);
            this.txtMotivo.MaxLength = 35;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(19, 20);
            this.txtMotivo.TabIndex = 15;
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy-MM-dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(51, 177);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(84, 20);
            this.dtFecha.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fecha:";
            // 
            // cbResolucion
            // 
            this.cbResolucion.FormattingEnabled = true;
            this.cbResolucion.Items.AddRange(new object[] {
            "Llamado de atención ",
            "﻿﻿Apercibimiento",
            "﻿﻿Suspensión",
            "﻿﻿Suspensión condicionada",
            "﻿﻿Intimación retomar tareas",
            "﻿﻿Despido con causa",
            "﻿﻿Despido sin causa",
            "﻿﻿Ext. Mutuo acuerdo",
            "﻿﻿Se acepta acuerdo",
            "﻿﻿﻿Se anula caso",
            "﻿﻿Menciones especiales",
            "﻿﻿﻿Observaciones varias",
            "Emite caso"});
            this.cbResolucion.Location = new System.Drawing.Point(70, 130);
            this.cbResolucion.Name = "cbResolucion";
            this.cbResolucion.Size = new System.Drawing.Size(147, 21);
            this.cbResolucion.TabIndex = 9;
            this.cbResolucion.SelectedIndexChanged += new System.EventHandler(this.cbResolucion_SelectedIndexChanged);
            // 
            // cbMotivo
            // 
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Items.AddRange(new object[] {
            "Ausencia sin justificación",
            "Ausencia sin aviso ni justificación",
            "Impuntualidad",
            "Abandono de tareas",
            "Actos de indisciplina",
            "Indisciplina con superiores",
            "Incumplimiento de tareas",
            "Negativa a realizar tareas",
            "Incumplimiento de normas",
            "Provocar riesgos de seguridad",
            "Mala fe laboral",
            "Falta de colab. y/o fidelidad",
            "Robo o hurto de materiales",
            "Negligencia en las tareas",
            "Emite caso",
            "Fallas en la producción"});
            this.cbMotivo.Location = new System.Drawing.Point(118, 103);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(181, 21);
            this.cbMotivo.TabIndex = 8;
            this.cbMotivo.SelectedIndexChanged += new System.EventHandler(this.cbSancion_SelectedIndexChanged);
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
            this.btnImpresion.Location = new System.Drawing.Point(165, 428);
            this.btnImpresion.Name = "btnImpresion";
            this.btnImpresion.Size = new System.Drawing.Size(99, 23);
            this.btnImpresion.TabIndex = 5;
            this.btnImpresion.Text = "Imprimir Caso";
            this.btnImpresion.UseVisualStyleBackColor = true;
            this.btnImpresion.Click += new System.EventHandler(this.btnImpresion_Click);
            // 
            // btnResoimpr
            // 
            this.btnResoimpr.Location = new System.Drawing.Point(282, 428);
            this.btnResoimpr.Name = "btnResoimpr";
            this.btnResoimpr.Size = new System.Drawing.Size(113, 23);
            this.btnResoimpr.TabIndex = 6;
            this.btnResoimpr.Text = "Imprimir resolucion";
            this.btnResoimpr.UseVisualStyleBackColor = true;
            this.btnResoimpr.Click += new System.EventHandler(this.btnResoimpr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Logo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PbLogo
            // 
            this.PbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbLogo.Location = new System.Drawing.Point(330, 17);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(130, 98);
            this.PbLogo.TabIndex = 22;
            this.PbLogo.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 471);
            this.Controls.Add(this.btnResoimpr);
            this.Controls.Add(this.btnImpresion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCaso";
            this.Text = "Generador de Sancion";
            this.Load += new System.EventHandler(this.frmCaso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
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
        private System.Windows.Forms.ComboBox cbMotivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbResolucion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReso;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtSusp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResoimpr;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}