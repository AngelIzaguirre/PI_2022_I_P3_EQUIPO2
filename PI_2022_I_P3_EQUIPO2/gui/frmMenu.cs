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
            frmRegistrarEmpleado frmRegistrarEmpleado = new frmRegistrarEmpleado();
            frmRegistrarEmpleado.ShowDialog();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            frmRegistrarPersona frmRegistrarPersona = new frmRegistrarPersona();
            frmRegistrarPersona.ShowDialog();
        }

        private void btnBoleto_Click(object sender, EventArgs e)
        {
            frmRegistrarBoleto frmRegistrarBoleto = new frmRegistrarBoleto();
            frmRegistrarBoleto.ShowDialog();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            frmRegistrarMantenimiento frmRegistrarMantenimiento = new frmRegistrarMantenimiento();
            frmRegistrarMantenimiento.ShowDialog();
        }

        private void btnAerolinea_Click(object sender, EventArgs e)
        {
            frmRegistrarAerolinea frmRegistrarAerolinea = new frmRegistrarAerolinea();
            frmRegistrarAerolinea.ShowDialog();
        }

        private void btnSoporteTecnico_Click(object sender, EventArgs e)
        {
            frmRegistrarSoporteTecnico frmRegistrarSoporteTecnico = new frmRegistrarSoporteTecnico();
            frmRegistrarSoporteTecnico.ShowDialog();
        }

        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            frmRegistrarEquipaje frmRegistrarEquipaje = new frmRegistrarEquipaje();
            frmRegistrarEquipaje.ShowDialog();
        }

        private void btnEmbarque_Click(object sender, EventArgs e)
        {
            frmRegistrarEmbarque frmRegistrarEmbarque = new frmRegistrarEmbarque();
            frmRegistrarEmbarque.ShowDialog();
        }

        private void btnMigracion_Click(object sender, EventArgs e)
        {
            frmRegistrarMigracion frmRegistrarMigracion = new frmRegistrarMigracion();
            frmRegistrarMigracion.ShowDialog();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmRegistrarSeguridad frmRegistrarSeguridad = new frmRegistrarSeguridad();
            frmRegistrarSeguridad.ShowDialog();
        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            frmRegistrarCafeteria frmRegistrarCafeteria = new frmRegistrarCafeteria();
            frmRegistrarCafeteria.ShowDialog();
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            frmRegistrarLimpieza frmRegistrarLimpieza = new frmRegistrarLimpieza();
            frmRegistrarLimpieza.ShowDialog();
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
