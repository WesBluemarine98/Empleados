using MySql.Data.MySqlClient;
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
        ManejoDatos mdt=new ManejoDatos();
        public frmCaso()
        {

            InitializeComponent();
        }

        private void bloquearCeldas(bool estado)
        {
            txtReso.Enabled= estado;
            txtMotivo.Enabled= estado;
            txtSusp.Enabled = estado;
            txtSector.Enabled= estado;
            txtPuesto.Enabled= estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MySqlDataReader dr=mdt.buscarEmpleado(txtBusqueda.Text);
            bloquearCeldas(false);
            if (dr.Read()) 
            {
                txtLeg.Text = dr[0].ToString();
                txtNomb.Text = dr[1].ToString();
                txtApe.Text = dr[2].ToString();
                txtSector.Text = dr[4].ToString();
                txtPuesto.Text = dr[5].ToString();


            }
            else
            {
                MessageBox.Show("Empleado no encontrado.", "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int contcaso = 12;
        private void btnImpresion_Click(object sender, EventArgs e)
        {
                
            impresion imp=new impresion();
            imp.sector= txtSector.Text;
            imp.puesto= txtPuesto.Text;
            imp.Nombre = txtNomb.Text;
            imp.Apellido= txtApe.Text;
            imp.Legajo=txtLeg.Text;
            imp.motivo = motivo;
            imp.resolucion = resolucion;
            imp.codmotivo = cbSancion.SelectedItem.ToString();
            imp.codresolucion=cbResolucion.SelectedItem.ToString();
            imp.nroCaso=contcaso.ToString();
            imp.Fecha = dtFecha.Value.ToString("yyyy/MM/dd");
            imp.cantSusp=txtSusp.Text;
            imp.ShowDialog();

        }

        string motivo;
        int indice = 0;
        private void cbSancion_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cbSancion.SelectedIndex;
            switch (indice)
            {
                case 0: motivo = "Ausencia sin justificación"; break;
                case 1: motivo = "Ausencia sin aviso ni justificación"; break;
                case 2: motivo = "Impuntualidad"; break;
                case 3: motivo = "Abandono de tareas"; break;
                case 4: motivo = "Actos de indisciplina"; break;
                case 5: motivo = "Indisciplina con superiores";break;
                case 6: motivo = "Incumplimiento de tareas"; break;
                case 7: motivo = "Negativa a realizar tareas"; break;
                case 8: motivo = "Incumplimiento de normas"; break;
                case 9: motivo = "Provocar riesgos de seguridad"; break;
                case 10: motivo = "Mala fe laboral"; break;
                case 11: motivo = "Falta de colab. y/o fidelidad"; break;
                case 12: motivo = "Robo o hurto de materiales"; break;
                case 13: motivo = "Negligencia en las tareas"; break;
                case 14: motivo = "Emite caso"; break;
                case 15: motivo = "Fallas en la producción"; break;
            }
            txtMotivo.Text = motivo.ToString();
        }

        string resolucion;
            int posicion = 0;
        
        private void cbResolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bloquearCeldas(false);

            posicion = cbResolucion.SelectedIndex;
            switch (posicion)
            {
                case 0: resolucion = "Llamado de atención"; break;
                case 1: resolucion = "Apercibimiento"; break;
                case 2: resolucion = "Suspensión";
                    if (cbResolucion.SelectedIndex ==2)
                    {
                        txtSusp.Enabled = true;
                    }
                    break;
                case 3: resolucion = "Suspensión condicionada";
                    if (cbResolucion.SelectedIndex ==3)
                    {
                        txtSusp.Enabled = true;
                    }
                    break;
                case 4: resolucion = "Intimación retomar tareas"; break;
                case 5: resolucion = "Despido con causa"; break;
                case 6: resolucion = "Despido sin causa"; break;
                case 7: resolucion = "Ext. Mutuo acuerdo"; break;
                case 8: resolucion = "Se acepta descargo"; break;
                case 9: resolucion = "Se anula Caso"; break;
                case 10: resolucion = "Menciones especiales"; break;
                case 11: resolucion = "Observaciones varias"; break;
                case 12: resolucion = "Emite caso"; break;
            }
            txtReso.Text = resolucion.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            bloquearCeldas(false);

        }
    }
}
