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
    public partial class impresion : Form
    {
        public string Fecha,Nombre,Apellido,Resolucion,Motivo,sector, puesto, motivo,resolucion,nroCaso,informacion;
        public int Legajo, codmotivo, codresolucion, cantSusp;
        public Image img= null;
        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        public impresion()
        {
            InitializeComponent();
            
  
        }
        ManejoDatos mdd = new ManejoDatos();
        //frmCaso caso = new frmCaso();


        private void Print(Panel panel1)
        {
            PrinterSettings ps= new PrinterSettings();

            pnl1 = panel1;
            getprintarea(panel1);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(imprimirDocumento_ImprimirPagina); 
            printPreviewDialog1.ShowDialog();
        }
        private void getprintarea(Panel panel1)
        {
            memoryimg= new Bitmap(pnl1.Width, pnl1.Height);
            panel1.DrawToBitmap(memoryimg,new Rectangle(0, 0,panel1.Width,panel1.Height));

        }
        private Bitmap memoryimg;
       
        private void impresion_Load(object sender, EventArgs e)
        {
            MySqlDataReader drt = mdd.buscarCaso(Legajo.ToString());
            drt.Read();

            labelLegajo.Text = drt[0].ToString();
            labelNombre.Text = drt[1].ToString();
            labelApellido.Text = drt[2].ToString();
            labelCaso.Text = drt[5].ToString();
            labelMotivo.Text = drt[6].ToString();
            labeltxtMot.Text = drt[7].ToString();
            labelRes.Text = drt[8].ToString();
            labeltxtRes.Text = drt[9].ToString();
            labelFecha.Text = Fecha;
            labelFecha2.Text=Fecha;
            labelFecha3.Text = Fecha;
            labellnfo.Text=informacion.ToString();
            pbLogoImp.Image = img;

        }

        private void cargandoDatos(object sender,EventArgs e)
        {
        }
        private void imprimirDocumento_ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.pnl1.Width / 2), this.pnl1.Location.Y);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Print(this.pnl1);
            


        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Imprimir");
        }
    }
}
