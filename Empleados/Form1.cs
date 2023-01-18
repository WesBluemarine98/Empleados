using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuEmpleado_Click(object sender, EventArgs e)
        {
        }

        private void mnuCarga_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.MdiParent = this;
            empleado.Show();

        }

        private void generarCasoDisciplinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaso caso = new frmCaso();
            caso.MdiParent = this;
            caso.Show();
            /*
            frmEmpleado empleado = new frmEmpleado();
            empleado.MdiParent = this;
            empleado.Show();
            */
        }
    }
}
