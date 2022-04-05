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
    public partial class frmMantenimiento : Form
    {
        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
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
            frmAgregarMantenimiento frmAgregarMantenimiento = new frmAgregarMantenimiento();
            frmAgregarMantenimiento.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarMantenimiento frmEliminarMantenimiento= new frmEliminarMantenimiento();
            frmEliminarMantenimiento.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarMantenimiento frmActualizarMantenimiento = new frmActualizarMantenimiento();
            frmActualizarMantenimiento.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarMantenimiento frmBuscarMantenimiento = new frmBuscarMantenimiento();
            frmBuscarMantenimiento.Show();
        }
    }
}
