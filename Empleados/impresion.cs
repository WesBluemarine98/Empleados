using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class impresion : Form
    {
        public string Fecha,Legajo,Nombre,Apellido,Resolucion,Motivo, nroCaso,sector, puesto, codmotivo, motivo, codresolucion, resolucion, cantSusp;
        public impresion()
        {
            InitializeComponent();
            
  
        }
        ManejoDatos mdd = new ManejoDatos();
        frmCaso caso = new frmCaso();
 
        private void contador(object sender, EventArgs e)
        {
            
            //mdd.sumarcaso
        }

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
            
            labelFecha.Text = Fecha;
            labelFecha2.Text=Fecha;
            labelFecha3.Text = Fecha;
            labelCaso.Text = nroCaso;
            labelLegajo.Text = Legajo;
            labelApellido.Text = Apellido;
            labelCantsusp.Text = cantSusp;
            labelSector.Text = sector;
            labelPuesto.Text = puesto;
            labelNombre.Text = Nombre; 
            labelMotivo.Text = codmotivo;
            labeltxtMot.Text = motivo;
            labelRes.Text = codresolucion;
            labeltxtRes.Text = resolucion;
            int resultado = 0;
            string exito = "Se ha cargado la sancion.";
            string error = "No se pudo cargar la sancion.";
            resultado = mdd.cargarSancion(labelLegajo.Text,labelApellido.Text,labelNombre.Text,labelSector.Text,labelPuesto.Text,labelMotivo.Text,labeltxtMot.Text,labelRes.Text,labeltxtRes.Text,labelCantsusp.Text,labelFecha.Text);
            if (resultado > 0)
            {
                MessageBox.Show(exito, "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
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
            toolTip1.SetToolTip(pictureBox1, "Print");
        }
    }
}
