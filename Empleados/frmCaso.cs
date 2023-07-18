using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class frmCaso : Form

    {
        public int leg,cantsusp, resultado = 0;
        string Fecha,sector, puesto;
        ManejoDatos mdt=new ManejoDatos();
        public frmCaso()
        {
            InitializeComponent();
        }

        private void habilitarCeldas(bool estado)
        {
            txtReso.Enabled= false;
            txtMotivo.Enabled= false;
            txtSusp.Enabled = false;
            txtLeg.Enabled = false;
            txtNomb.Enabled = false;
            txtApe.Enabled = false;
            cbMotivo.Enabled = estado;
            cbResolucion.Enabled = estado;
            dtFecha.Enabled = estado;
        }

        private void validarcampo()
        {
         
            var vr = !string.IsNullOrEmpty(txtBusqueda.Text);
            btnBuscarEmpleado.Enabled = vr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           MySqlDataReader dr=mdt.buscarEmpleado(txtBusqueda.Text);
            if (dr.Read()) 
            {
                habilitarCeldas(true);
                txtLeg.Text = dr[0].ToString();
                txtNomb.Text = dr[1].ToString();
                txtApe.Text = dr[2].ToString();


            }
            else
            {
                MessageBox.Show("Empleado no encontrado.", "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        ManejoDatos mdd= new ManejoDatos();
        private void btnImpresion_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = mdt.buscarEmpleado(txtBusqueda.Text);
            dr.Read();
            sector = dr[4].ToString();
            puesto = dr[5].ToString();
            string exito = "Se ha cargado la sancion.";
            string error = "No se pudo cargar la sancion.";
            cantsusp = Convert.ToInt32(txtSusp.Text);
            Fecha= dtFecha.Value.ToString("yyyy/MM/dd");
            leg = Convert.ToInt32(txtLeg.Text);
            resultado = mdd.cargarSancion(leg, txtApe.Text, txtNomb.Text, sector, puesto, cbMotivo.SelectedIndex+1, motivo, cbResolucion.SelectedIndex+1, resolucion, cantsusp, Fecha);
            if (resultado > 0)
            {
                MessageBox.Show(exito, "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            impresion imp = new impresion();
            imp.Legajo= Convert.ToInt32(txtLeg.Text);
            imp.informacion=txtInfo.Text;
            imp.Fecha = dtFecha.Value.ToString("yyyy/MM/dd");
            imp.img = PbLogo.Image;
            limpiartodo();
            imp.ShowDialog();

        }

        private void limpiartodo()
        {
            txtBusqueda.Clear();
            txtLeg.Clear();
            txtNomb.Clear();
            txtApe.Clear();
            cbMotivo.ResetText();
            txtMotivo.Clear();
            cbResolucion.ResetText();
            txtReso.Clear();
            txtInfo.Clear();
          

        }

        string motivo;
        int indice = 0;
        private void cbSancion_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cbMotivo.SelectedIndex;
            switch (indice)
            {
                case 0: motivo = "1";break;
                case 1: motivo = "2";break;
                case 2: motivo = "3";break;
                case 3: motivo = "4";break;
                case 4: motivo = "5";break;
                case 5: motivo = "6";break;
                case 6: motivo = "7";break;
                case 7: motivo = "8";break;
                case 8: motivo = "9";break;
                case 9: motivo = "10";break;
                case 10: motivo = "11"; break;
                case 11: motivo = "12";break;
                case 12: motivo = "13";break;
                case 13: motivo = "14";break;
                case 14: motivo = "15";break;
                case 15: motivo = "16"; break;
            }
            txtMotivo.Text = motivo.ToString();
            motivo=cbMotivo.SelectedItem.ToString();
        }

        string resolucion;

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            validarcampo();
        }

        private void frmCaso_Load(object sender, EventArgs e)
        {
            btnBuscarEmpleado.Enabled = false;
        }

        private void CargarLogo()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Seleccionar imagen";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string imagenPath = openFileDialog.FileName;
                    PbLogo.Image = Image.FromFile(imagenPath);
                    PbLogo.SizeMode = PictureBoxSizeMode.AutoSize;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen.\n"+ ex.ToString(),"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarLogo();
        }

        int posicion = 0;
        private void cbResolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            posicion = cbResolucion.SelectedIndex;
            switch (posicion)
            {
                case 0: resolucion = "1"; break;
                case 1: resolucion = "2"; break;
                case 2: resolucion = "3";
                    if (cbResolucion.SelectedIndex ==2)
                    {
                        txtSusp.Enabled = true;
                    }
                    break;
                case 3: resolucion = "4";
                    if (cbResolucion.SelectedIndex ==3)
                    {
                        txtSusp.Enabled = true;
                    }
                    break;
                case 4: resolucion = "5"; break;
                case 5: resolucion = "6"; break;
                case 6: resolucion = "7"; break;
                case 7: resolucion = "8"; break;
                case 8: resolucion = "9"; break;
                case 9: resolucion = "10"; break;
                case 10: resolucion = "11"; break;
                case 11: resolucion = "12"; break;
                case 12: resolucion = "999"; break;
            }
            txtReso.Text = resolucion.ToString();
            resolucion=cbResolucion.SelectedItem.ToString();

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            habilitarCeldas(false);
        }
        private void btnResoimpr_Click(object sender, EventArgs e)
        {
            ResolucionCaso res= new ResolucionCaso();
            res.ShowDialog();
        }
    }
}
