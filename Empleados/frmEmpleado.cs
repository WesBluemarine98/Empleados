using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Empleados
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }
        ManejoDatos mnd = new ManejoDatos();
        bool editando=false;

        private void limpiarCeldas()
        {
            txtLegajo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            cbSector.ResetText();
            cbPuesto.ResetText();
            cbSexo.ResetText();
            dgvEmpleados.DataSource = null;
        }

        private void habilitarCeldas(bool estado)
        {
            txtLegajo.Enabled= estado;
            txtNombre.Enabled= estado;
            txtApellido.Enabled= estado;
            cbPuesto.Enabled = estado;
            cbSector.Enabled = estado;
            cbSexo.Enabled=estado;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            string exito = "";
            string error = "";

            if (editando)
            {
                resultado=mnd.editarCuenta(txtLegajo.Text, txtNombre.Text, txtApellido.Text,cbSexo.Text,cbSector.Text,cbPuesto.Text);
                exito = "Empleado modificado";
                error = "No se pudo modificar al empleado";
            }
            else
            {

                resultado = mnd.agregarCuenta(txtLegajo.Text, txtNombre.Text, txtApellido.Text, cbSexo.Text, cbSector.Text, cbPuesto.Text);
                exito = "Cuenta agregada";
                error = "No se pudo agregar al empleado";
            }
                if (resultado > 0)
            {
                MessageBox.Show(exito, "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancelar.PerformClick();
            }
            else
            {
                MessageBox.Show(error, "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = mnd.buscar();
            editando=true;
            habilitarCeldas(true);
            txtLegajo.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLegajo.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            cbSexo.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            cbPuesto.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            cbSector.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            editando = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        int res=mnd.eliminarEmpleado(txtLegajo.Text);
        if (res > 0)
            {
                MessageBox.Show("Empleado eliminado.", "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar al Empleado.", "Modulo de empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            habilitarCeldas(false);
            limpiarCeldas();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            editando = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            editando = false;
            limpiarCeldas();
            habilitarCeldas(true);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;    
            btnEliminar.Enabled = false;

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled= false;
            btnCancelar.Enabled= false;
            btnEliminar.Enabled= false;
            habilitarCeldas(false);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCeldas();
            habilitarCeldas(false);
            btnGuardar.Enabled= false;
            btnCancelar.Enabled= false;
            btnEliminar.Enabled= false;
            editando = false;

        }
    }
}
