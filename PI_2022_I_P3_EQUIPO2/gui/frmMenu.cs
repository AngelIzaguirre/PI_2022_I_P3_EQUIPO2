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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleado frmEmpleado = new frmEmpleado();
            frmEmpleado.Show();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            frmPersona frmPersona = new frmPersona();
            frmPersona.Show();
        }

        private void btnBoleto_Click(object sender, EventArgs e)
        {
            frmBoleto frmBoleto = new frmBoleto();
            frmBoleto.Show();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimiento frmMantenimiento = new frmMantenimiento();
            frmMantenimiento.Show();
        }

        private void btnAerolinea_Click(object sender, EventArgs e)
        {
            frmAerolinea frmAerolinea = new frmAerolinea();
            frmAerolinea.Show();
        }

        private void btnSoporteTecnico_Click(object sender, EventArgs e)
        {
            frmSoporteTecnico frmSoporteTecnico = new frmSoporteTecnico();
            frmSoporteTecnico.Show();
        }

        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            frmEquipaje frmEquipaje = new frmEquipaje();
            frmEquipaje.Show();
        }

        private void btnEmbarque_Click(object sender, EventArgs e)
        {
            frmEmbarque frmEmbarque = new frmEmbarque();
            frmEmbarque.Show();
        }

        private void btnMigracion_Click(object sender, EventArgs e)
        {
            frmMigracion frmMigracion = new frmMigracion();
            frmMigracion.Show();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmSeguridad frmSeguridad = new frmSeguridad();
            frmSeguridad.Show();
        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            frmCafeteria frmCafeteria = new frmCafeteria();
            frmCafeteria.Show();
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            frmLimpieza frmLimpieza = new frmLimpieza();
            frmLimpieza.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
