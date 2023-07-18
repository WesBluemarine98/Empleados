using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        private void mnuCarga_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.MdiParent = this;
            empleado.Show();
            dgvCasos.SendToBack();
            BtnCarga.SendToBack();
            BtnExportar.SendToBack();

        }

        private void generarCasoDisciplinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaso caso = new frmCaso();
            caso.MdiParent = this;
            caso.Show();
            dgvCasos.SendToBack();
            BtnCarga.SendToBack();
            BtnExportar.SendToBack();
        }

        ManejoDatos mnd = new ManejoDatos();

        private void BtnCarga_Click(object sender, EventArgs e)
        {
            dgvCasos.DataSource = mnd.listarcasos();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
           
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage();

          
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Datos");

            
            for (int i = 0; i < dgvCasos.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = dgvCasos.Columns[i].HeaderText;
            }

            
            for (int i = 0; i < dgvCasos.Rows.Count; i++)
            {
                for (int j = 0; j < dgvCasos.Columns.Count; j++)
                {
                    if (dgvCasos.Rows[i].Cells[j].Value is DateTime fecha)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = fecha.ToString("yyyy-MM-dd");

                    }
                    else
                    {

                        worksheet.Cells[i + 2, j + 1].Value = dgvCasos.Rows[i].Cells[j].Value;
                    }
                }
            }

           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo Excel";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog.FileName, excelPackage.GetAsByteArray());
                    MessageBox.Show("Datos exportados a Excel correctamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo Excel: " + ex.Message, "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
    
}
