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
    public partial class frmEmbarque : Form
    {
        public frmEmbarque()
        {
            InitializeComponent();
        }

        private void frmEmbarque_Load(object sender, EventArgs e)
        {

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
            frmAgregarEmbarque frmAgregarEmbarque = new frmAgregarEmbarque();
            frmAgregarEmbarque.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarEmbarque frmEliminarEmbarque = new frmEliminarEmbarque();
            frmEliminarEmbarque.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarEmbarque frmActualizarEmbarque = new frmActualizarEmbarque();
            frmActualizarEmbarque.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEmbarque frmBuscarEmbarque= new frmBuscarEmbarque();
            frmBuscarEmbarque.Show();
        }
    }
}
