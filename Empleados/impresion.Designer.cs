namespace Empleados
{
    partial class impresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(impresion));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCaso = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMotivo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelFecha2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.labellnfo = new System.Windows.Forms.Label();
            this.labeltxtMot = new System.Windows.Forms.Label();
            this.labeltxtRes = new System.Windows.Forms.Label();
            this.labelFecha3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pbLogoImp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoImp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.imprimirDocumento_ImprimirPagina);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "CASO DISCIPLINARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "FECHA";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(596, 124);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(13, 13);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° CASO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resolucion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "LEGAJO";
            // 
            // labelCaso
            // 
            this.labelCaso.AutoSize = true;
            this.labelCaso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaso.Location = new System.Drawing.Point(82, 151);
            this.labelCaso.Name = "labelCaso";
            this.labelCaso.Size = new System.Drawing.Size(15, 17);
            this.labelCaso.TabIndex = 7;
            this.labelCaso.Text = "?";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRes.Location = new System.Drawing.Point(88, 184);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(15, 17);
            this.labelRes.TabIndex = 8;
            this.labelRes.Text = "?";
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegajo.Location = new System.Drawing.Point(86, 213);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(15, 17);
            this.labelLegajo.TabIndex = 9;
            this.labelLegajo.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(783, 63);
            this.label10.TabIndex = 11;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(145, 212);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(15, 17);
            this.labelApellido.TabIndex = 12;
            this.labelApellido.Text = "?";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(209, 213);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(15, 17);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Detalle del Caso:";
            // 
            // labelMotivo
            // 
            this.labelMotivo.AutoSize = true;
            this.labelMotivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotivo.Location = new System.Drawing.Point(118, 330);
            this.labelMotivo.Name = "labelMotivo";
            this.labelMotivo.Size = new System.Drawing.Size(14, 16);
            this.labelMotivo.TabIndex = 15;
            this.labelMotivo.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Información Adicional:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 536);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "NOTIFICACIÓN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(313, 536);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "FECHA";
            // 
            // labelFecha2
            // 
            this.labelFecha2.AutoSize = true;
            this.labelFecha2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha2.Location = new System.Drawing.Point(313, 516);
            this.labelFecha2.Name = "labelFecha2";
            this.labelFecha2.Size = new System.Drawing.Size(14, 16);
            this.labelFecha2.TabIndex = 20;
            this.labelFecha2.Text = "?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(618, 536);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "FIRMA EMPRESA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 568);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(773, 40);
            this.label14.TabIndex = 22;
            this.label14.Text = "A continuación usted podrá realizar un descargo de lo acontecido, lo cual será ev" +
    "aluado a fin de tener \r\nuna resolución.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 608);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(780, 144);
            this.label15.TabIndex = 23;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 767);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "FIRMA DECLARANTE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(538, 767);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "FECHA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 816);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(724, 40);
            this.label17.TabIndex = 26;
            this.label17.Text = "Sanción aplicada\r\nAtento a lo expresado en el informe y considerando lo expuesto " +
    "por usted la empresa ha resuelto:\r\n";
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.Controls.Add(this.labellnfo);
            this.pnl1.Controls.Add(this.labeltxtMot);
            this.pnl1.Controls.Add(this.labeltxtRes);
            this.pnl1.Controls.Add(this.labelFecha3);
            this.pnl1.Controls.Add(this.label18);
            this.pnl1.Controls.Add(this.label17);
            this.pnl1.Controls.Add(this.label16);
            this.pnl1.Controls.Add(this.label9);
            this.pnl1.Controls.Add(this.label15);
            this.pnl1.Controls.Add(this.label14);
            this.pnl1.Controls.Add(this.label13);
            this.pnl1.Controls.Add(this.labelFecha2);
            this.pnl1.Controls.Add(this.label12);
            this.pnl1.Controls.Add(this.label11);
            this.pnl1.Controls.Add(this.label7);
            this.pnl1.Controls.Add(this.labelMotivo);
            this.pnl1.Controls.Add(this.label6);
            this.pnl1.Controls.Add(this.labelNombre);
            this.pnl1.Controls.Add(this.labelApellido);
            this.pnl1.Controls.Add(this.label10);
            this.pnl1.Controls.Add(this.labelLegajo);
            this.pnl1.Controls.Add(this.labelRes);
            this.pnl1.Controls.Add(this.labelCaso);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.labelFecha);
            this.pnl1.Controls.Add(this.label5);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.pbLogoImp);
            this.pnl1.Location = new System.Drawing.Point(1, 4);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(819, 999);
            this.pnl1.TabIndex = 0;
            this.pnl1.Click += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_Paint);
            // 
            // labellnfo
            // 
            this.labellnfo.AutoEllipsis = true;
            this.labellnfo.AutoSize = true;
            this.labellnfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellnfo.Location = new System.Drawing.Point(11, 385);
            this.labellnfo.Name = "labellnfo";
            this.labellnfo.Size = new System.Drawing.Size(18, 20);
            this.labellnfo.TabIndex = 31;
            this.labellnfo.Text = "?";
            // 
            // labeltxtMot
            // 
            this.labeltxtMot.AutoSize = true;
            this.labeltxtMot.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltxtMot.Location = new System.Drawing.Point(148, 330);
            this.labeltxtMot.Name = "labeltxtMot";
            this.labeltxtMot.Size = new System.Drawing.Size(15, 17);
            this.labeltxtMot.TabIndex = 30;
            this.labeltxtMot.Text = "?";
            // 
            // labeltxtRes
            // 
            this.labeltxtRes.AutoSize = true;
            this.labeltxtRes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltxtRes.Location = new System.Drawing.Point(117, 183);
            this.labeltxtRes.Name = "labeltxtRes";
            this.labeltxtRes.Size = new System.Drawing.Size(15, 17);
            this.labeltxtRes.TabIndex = 29;
            this.labeltxtRes.Text = "?";
            // 
            // labelFecha3
            // 
            this.labelFecha3.AutoSize = true;
            this.labelFecha3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha3.Location = new System.Drawing.Point(538, 745);
            this.labelFecha3.Name = "labelFecha3";
            this.labelFecha3.Size = new System.Drawing.Size(14, 16);
            this.labelFecha3.TabIndex = 28;
            this.labelFecha3.Text = "?";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 856);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(791, 120);
            this.label18.TabIndex = 27;
            this.label18.Text = resources.GetString("label18.Text");
            // 
            // pbLogoImp
            // 
            this.pbLogoImp.BackColor = System.Drawing.Color.White;
            this.pbLogoImp.Location = new System.Drawing.Point(14, 21);
            this.pbLogoImp.Name = "pbLogoImp";
            this.pbLogoImp.Size = new System.Drawing.Size(48, 48);
            this.pbLogoImp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogoImp.TabIndex = 0;
            this.pbLogoImp.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Empleados.Properties.Resources.icons8_imprimir_48;
            this.pictureBox1.Location = new System.Drawing.Point(753, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // impresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 1016);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl1);
            this.Name = "impresion";
            this.Text = "impresion";
            this.Load += new System.EventHandler(this.impresion_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoImp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCaso;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMotivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelFecha2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Label labelFecha3;
        private System.Windows.Forms.Label labeltxtMot;
        private System.Windows.Forms.Label labeltxtRes;
        private System.Windows.Forms.Label labellnfo;
        private System.Windows.Forms.PictureBox pbLogoImp;
    }
}