using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2022_I_P3_EQUIPO2.gui
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenu principal = new frmMenu();
            principal.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado frmAgregarEmpleado = new frmAgregarEmpleado();
            frmAgregarEmpleado.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarEmpleado frmEliminarEmpleado = new frmEliminarEmpleado();
            frmEliminarEmpleado.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarEmpleado frmActualizarEmpleado = new frmActualizarEmpleado();
            frmActualizarEmpleado.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado frmBuscarEmpleado= new frmBuscarEmpleado();
            frmBuscarEmpleado.Show();
        }
    }
}
