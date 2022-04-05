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
    public partial class frmSoporteTecnico : Form
    {
        public frmSoporteTecnico()
        {
            InitializeComponent();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenu Principal = new frmMenu();
            Principal.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarSoporteTecnico frmAgregarSoporteTecnico = new frmAgregarSoporteTecnico();
            frmAgregarSoporteTecnico.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarSoporteTecnico frmEliminarSoporteTecnico = new frmEliminarSoporteTecnico();
            frmEliminarSoporteTecnico.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarSoporteTecnico frmActualizarSoporteTecnico = new frmActualizarSoporteTecnico();
            frmActualizarSoporteTecnico.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarSoporteTecnico frmBuscarSoporteTecnico = new frmBuscarSoporteTecnico();
            frmBuscarSoporteTecnico.Show();
        }
    }
}
