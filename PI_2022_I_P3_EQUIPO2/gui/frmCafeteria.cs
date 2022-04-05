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
    public partial class frmCafeteria : Form
    {
        public frmCafeteria()
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
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCafeteria frmAgregarCafeteria = new frmAgregarCafeteria();
            frmAgregarCafeteria.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarCafeteria frmEliminarCafeteria = new frmEliminarCafeteria();
            frmEliminarCafeteria.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarCafeteria frmActualizarCafeteria = new frmActualizarCafeteria();
            frmActualizarCafeteria.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCafeteria frmBuscarCafeteria = new frmBuscarCafeteria();
            frmBuscarCafeteria.Show();
        }
    }
}
