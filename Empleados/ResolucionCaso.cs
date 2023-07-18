using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class ResolucionCaso : Form
    {


         string orden = "SELECT NroCaso,Fecha,Legajo,Apellido,Nombre,Motivo,CodMotivo FROM sanciones ORDER BY NroCaso DESC LIMIT 1;";
         public int Legajo;
         public string Fecha,Nombre,Apellido,Motivo,NroCaso, CodMotivo;
        public ResolucionCaso()
        {
            InitializeComponent();
        }

        private void ResolucionCaso_Load(object sender, EventArgs e)
        {
            ManejoDatos md = new ManejoDatos();
            
            MySqlDataReader dr= md.buscarSancion(orden);
            dr.Read();
           
            txtNroCaso.Text = dr[0].ToString();
            labelFecha.Text = ((DateTime)dr[1]).ToString("dd/MM/yyyy");
            txtLegajo.Text = dr[2].ToString();
            txtApellido.Text = dr[3].ToString();
            txtNombre.Text = dr[4].ToString();
            txtMotivo.Text = dr[5].ToString();
            txtCodmotivo.Text = dr[6].ToString();
            

            }


        private void Print(Panel panel)
        {
            PrinterSettings ps = new PrinterSettings();

            panel2 = panel;
            getprintarea(panel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(imprimirReso_ImprimirPag);
            printPreviewDialog1.ShowDialog();
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel panel)
        {
            memoryimg = new Bitmap(panel2.Width, panel2.Height);
            panel.DrawToBitmap(memoryimg, new Rectangle(0, 0, panel.Width, panel.Height));

        }
        private void imprimirReso_ImprimirPag(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel2.Width / 2), this.panel2.Location.Y);

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pictureBox2, "Imprimir");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Print(this.panel2);
        }
    }
}
